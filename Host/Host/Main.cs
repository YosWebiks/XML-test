using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Host
{
    public partial class Main : Form
    {
        // מחרוזת חיבור למסד הנתונים
        string ConnectionString = "server=DANIEL\\SQLEXPRESS;initial catalog=shabat; user id=sa;password=1234; TrustServerCertificate=Yes";

        // אובייקט החיבור למסד הנתונים
        SqlConnection Connection;

        public Main()
        {
            InitializeComponent();
            // הצגת כל הקטגוריות עם אתחול ללא פרמטר שם
            ShowAllCategories();
        }

        // פונקציה שמתחברת למסד הנתונים
        private bool Connect()
        {
            try
            {
                // יצירת אובייקט החיבור והתחברות למסד הנתונים
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                // הצגת הודעת שגיאה אם החיבור נכשל
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // פונקציה שמציגה את כל הקטגוריות
        private void ShowAllCategories(string name = "")
        {
            // שאילתת בחירה מהקטגוריות לפי שם
            string select = "SELECT name FROM categories WHERE name like '%'+@name+'%'";
            if (Connect())
            {
                // יצירת אובייקט פקודה והוספת פרמטרים
                SqlCommand command = new SqlCommand(select, Connection);
                command.Parameters.AddWithValue("@name", name);

                // ביצוע השאילתה וקריאת התוצאות
                SqlDataReader reader = command.ExecuteReader();
                lstCategory.Items.Clear();

                // בדיקה אם קיימות שורות בטבלה
                if (reader.HasRows)
                {
                    // ריצה על כל השורות במבנה טבלאי
                    while (reader.Read())
                    {
                        // הוספת כל שם קטגוריה לרשימה
                        string categoryName = reader[0].ToString();

                        lstCategory.Items.Add(categoryName);
                    }
                }

                // סגירת החיבור למסד הנתונים
                Connection.Close();
            }
        }

        // אירוע לחיצה על כפתור הוספת קטגוריה
        private void btnEnterCategory_Click(object sender, EventArgs e)
        {
            // שאילתת הוספה אם שם הקטגוריה אינו ריק ואם הקטגוריה לא קיימת כבר
            //string insert = "IF (@name_category != '')\r\n\tBEGIN\r\n\tIF NOT EXISTS(SELECT name FROM Categories WHERE name=@name_category)\r\n\t\tBEGIN\r\n\t\t\t INSERT INTO Categories values(@name_category)\r\n\t\tEND\r\n\tEND";

            string insert = @"
                IF (@name_category != '')
                BEGIN
                    IF NOT EXISTS (SELECT name FROM Categories WHERE name = @name_category)
                    BEGIN
                        INSERT INTO Categories (name) VALUES (@name_category)
                    END
                END";



            if (Connect())
            {
                // יצירת אובייקט פקודה והוספת פרמטרים
                SqlCommand command = new SqlCommand(insert, Connection);
                command.Parameters.AddWithValue("@name_category", txtCategory.Text);

                // ביצוע הפקודה והחזרת מספר השורות שהושפעו
                int updateRows = command.ExecuteNonQuery();

                // סגירת החיבור למסד הנתונים
                Connection.Close();

                // אם נוספה קטגוריה חדשה, הצגת כל הקטגוריות
                if (updateRows > 0) ShowAllCategories("");

                // ניקוי תיבת הטקסט
                txtCategory.Text = string.Empty;
            }
        }

        // אירוע שינוי טקסט בתיבת הטקסט של הקטגוריה
        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            // הצגת כל הקטגוריות עם השם שנמצא בתיבת הטקסט
            ShowAllCategories(txtCategory.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
