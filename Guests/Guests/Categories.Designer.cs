namespace Guests
{
    partial class Categories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.dgvAllChoice = new System.Windows.Forms.DataGridView();
            this.dgvGuestChoice = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btAddFood = new System.Windows.Forms.Button();
            this.pAddFood = new System.Windows.Forms.Panel();
            this.txtAddFood = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestChoice)).BeginInit();
            this.pAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCategoryName.Location = new System.Drawing.Point(188, 61);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(123, 29);
            this.lblCategoryName.TabIndex = 5;
            this.lblCategoryName.Text = "שם קטגוריה";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGuestName.Location = new System.Drawing.Point(483, 61);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(108, 29);
            this.lblGuestName.TabIndex = 5;
            this.lblGuestName.Text = "שם האורח";
            // 
            // dgvAllChoice
            // 
            this.dgvAllChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllChoice.Location = new System.Drawing.Point(188, 140);
            this.dgvAllChoice.Name = "dgvAllChoice";
            this.dgvAllChoice.RowHeadersWidth = 51;
            this.dgvAllChoice.RowTemplate.Height = 24;
            this.dgvAllChoice.Size = new System.Drawing.Size(435, 164);
            this.dgvAllChoice.TabIndex = 6;
            this.dgvAllChoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllChoice_CellContentClick);
            this.dgvAllChoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllChoice_CellDoubleClick);
            // 
            // dgvGuestChoice
            // 
            this.dgvGuestChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestChoice.Location = new System.Drawing.Point(188, 436);
            this.dgvGuestChoice.Name = "dgvGuestChoice";
            this.dgvGuestChoice.RowHeadersWidth = 51;
            this.dgvGuestChoice.RowTemplate.Height = 24;
            this.dgvGuestChoice.Size = new System.Drawing.Size(435, 164);
            this.dgvGuestChoice.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(483, 673);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 59);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<<<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(154, 673);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(164, 59);
            this.btnForward.TabIndex = 7;
            this.btnForward.Text = ">>>>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btAddFood
            // 
            this.btAddFood.Location = new System.Drawing.Point(491, 358);
            this.btAddFood.Name = "btAddFood";
            this.btAddFood.Size = new System.Drawing.Size(93, 31);
            this.btAddFood.TabIndex = 8;
            this.btAddFood.Text = "הוסף מאכל";
            this.btAddFood.UseVisualStyleBackColor = true;
            this.btAddFood.Click += new System.EventHandler(this.btAddFood_Click);
            // 
            // pAddFood
            // 
            this.pAddFood.Controls.Add(this.txtAddFood);
            this.pAddFood.Controls.Add(this.btnOK);
            this.pAddFood.Location = new System.Drawing.Point(226, 328);
            this.pAddFood.Name = "pAddFood";
            this.pAddFood.Size = new System.Drawing.Size(259, 92);
            this.pAddFood.TabIndex = 9;
            this.pAddFood.Visible = false;
            // 
            // txtAddFood
            // 
            this.txtAddFood.Location = new System.Drawing.Point(126, 34);
            this.txtAddFood.Name = "txtAddFood";
            this.txtAddFood.Size = new System.Drawing.Size(114, 22);
            this.txtAddFood.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(16, 31);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 31);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "אישור";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 536);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 10;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 786);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pAddFood);
            this.Controls.Add(this.btAddFood);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvGuestChoice);
            this.Controls.Add(this.dgvAllChoice);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblCategoryName);
            this.Name = "Categories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestChoice)).EndInit();
            this.pAddFood.ResumeLayout(false);
            this.pAddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.DataGridView dgvAllChoice;
        private System.Windows.Forms.DataGridView dgvGuestChoice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btAddFood;
        private System.Windows.Forms.Panel pAddFood;
        private System.Windows.Forms.TextBox txtAddFood;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}