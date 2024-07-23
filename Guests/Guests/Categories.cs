using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Guests
{
    public partial class Categories : Form
    {
        // משתנה לשמירת הפניה לחלון הראשי
        Main Parent;

        // רשימה סטטית של קטגוריות
        //static List<Categories> GetCategories;

        // אינדקס הקטגוריה הנוכחית
        readonly int CurrIndex;

        // בנאי המקבל את החלון הראשי, שם הקטגוריה, שם האורח ואינדקס הקטגוריה
        public Categories(Main parent, string categoryName, string guestName, int _CurrIndex)
        {
            InitializeComponent();
            Parent = parent;
            lblCategoryName.Text = categoryName;
            lblGuestName.Text = guestName;
            CurrIndex = _CurrIndex;
            ShowAllChoice();
            ShowGuestChoice();
        }

        // מאפיין להגדרת רשימת הקטגוריות
        //public List<Categories> SetCategories
        //{
        //    set { GetCategories = value; }
        //}

        // פונקציה להצגת כל המאכלים בקטגוריה
        private void ShowAllChoice()
        {
            // שאילתה להצגת כל המאכלים בקטגוריה
            string select = "SELECT food.name AS 'שם מאכל' FROM food " +
                            "INNER JOIN Categories ON Food.Category_ID=Categories.ID " +
                            "INNER JOIN Guests ON Food.Guest_ID = Guests.ID " +
                            "WHERE Categories.name=@categoryName";

            // שימוש ב-SqlDataAdapter לביצוע השאילתה
            using (SqlDataAdapter adapter = new SqlDataAdapter(select, Parent.ConnectionString))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@categoryName", lblCategoryName.Text);

                // יצירת טבלת נתונים
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // הצגת הנתונים ב-DataGridView
                dgvAllChoice.DataSource = dt;
            }
        }

        // פונקציה להצגת המאכלים שבחר האורח בקטגוריה
        private void ShowGuestChoice()
        {
            // שאילתה להצגת המאכלים שבחר האורח בקטגוריה
            string select = "SELECT Food.name AS 'שם מאכל' FROM Food " +
                            "INNER JOIN Categories ON Food.Category_ID=Categories.ID " +
                            "INNER JOIN Guests ON Food.Guest_ID = Guests.ID " +
                            "WHERE Categories.name=@categoryName AND Guests.name=@guestName";

            // שימוש ב-SqlDataAdapter לביצוע השאילתה

            SqlDataAdapter adapter = new SqlDataAdapter(select, Parent.ConnectionString);

            adapter.SelectCommand.Parameters.AddWithValue("@categoryName", lblCategoryName.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@guestName", lblGuestName.Text);

            // יצירת טבלת נתונים
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // הצגת הנתונים ב-DataGridView
            dgvGuestChoice.DataSource = dt;

        }

        // פונקציה לחזרה לקטגוריה הקודמת
        private void btBack_Click(object sender, EventArgs e)
        {
            // הסתרת הטופס הנוכחי
            this.Visible = false;
            // אם יש עוד קטגוריות ברשימה, תציג את הטופס הקודם
            if (CurrIndex > 0)
            {
                Parent.CategoryList[CurrIndex - 1].Visible = true;
            }
        }

        // פונקציה למעבר לקטגוריה הבאה
        private void btForward_Click(object sender, EventArgs e)
        {
            // הסתרת הטופס הנוכחי
            this.Visible = false;
            // אם יש עוד קטגוריות ברשימה, תציג את הטופס הבא
            if (CurrIndex < Parent.CategoryList.Count() - 1)
            {
                Parent.CategoryList[CurrIndex + 1].Visible = true;
            }
        }

        // פונקציה להוספת מאכל לקטגוריה
        private void InsertFood(string food)
        {
            if (string.IsNullOrEmpty(food))
            {
                return;
            }

            // שאילתה להוספת מאכל לקטגוריה
            string insert = @"INSERT INTO food (Guest_ID, Category_ID, name) 
                              VALUES ((SELECT ID FROM guests WHERE name=@guestName), 
                                      (SELECT ID FROM categories WHERE name=@categoryName), 
                                      @food)";


            if (Parent.Connect())
            {
                // שימוש ב-SqlCommand לביצוע השאילתה
                using (SqlCommand command = new SqlCommand(insert, Parent.Connection))
                {
                    command.Parameters.AddWithValue("@guestName", lblGuestName.Text);
                    command.Parameters.AddWithValue("@categoryName", lblCategoryName.Text);
                    command.Parameters.AddWithValue("@food", food);

                    command.ExecuteNonQuery();
                }

                Parent.Disconnect();
                ShowAllChoice();
                ShowGuestChoice();
            }
        }

        // פונקציה להצגת הפאנל להוספת מאכל
        private void btAddFood_Click(object sender, EventArgs e)
        {
            pAddFood.Visible = true;
        }

        // פונקציה להוספת מאכל מהפאנל
        private void btOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddFood.Text))
            {
                return;
            }

            InsertFood(txtAddFood.Text);
            pAddFood.Visible = false;
        }

        // פונקציה להוספת מאכל בלחיצה כפולה על תא ב-DataGridView
        private void dgvAllChoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InsertFood(dgvAllChoice[0, e.RowIndex].Value.ToString());
        }

        private void dgvAllChoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
