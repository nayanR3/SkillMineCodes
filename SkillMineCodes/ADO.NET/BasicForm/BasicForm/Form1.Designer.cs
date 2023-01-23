namespace BasicForm
{
    partial class Form1
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
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_age = new System.Windows.Forms.Label();
            this.Txt_Age = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Clear.Location = new System.Drawing.Point(300, 217);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(100, 50);
            this.Btn_Clear.TabIndex = 0;
            this.Btn_Clear.Text = "clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Submit.Location = new System.Drawing.Point(194, 217);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(100, 50);
            this.Btn_Submit.TabIndex = 1;
            this.Btn_Submit.Text = "submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_Name.Location = new System.Drawing.Point(319, 117);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(100, 23);
            this.Txt_Name.TabIndex = 3;
            this.Txt_Name.TextChanged += new System.EventHandler(this.Txt_Name_TextChanged_1);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Name.Location = new System.Drawing.Point(179, 117);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Name.TabIndex = 6;
            this.Lbl_Name.Text = "Enter Name";
            // 
            // Lbl_age
            // 
            this.Lbl_age.AutoSize = true;
            this.Lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_age.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_age.Location = new System.Drawing.Point(179, 153);
            this.Lbl_age.Name = "Lbl_age";
            this.Lbl_age.Size = new System.Drawing.Size(80, 17);
            this.Lbl_age.TabIndex = 5;
            this.Lbl_age.Text = "Enter Age";
            // 
            // Txt_Age
            // 
            this.Txt_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Age.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_Age.Location = new System.Drawing.Point(319, 153);
            this.Txt_Age.Name = "Txt_Age";
            this.Txt_Age.Size = new System.Drawing.Size(100, 23);
            this.Txt_Age.TabIndex = 8;
            this.Txt_Age.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 353);
            this.Controls.Add(this.Txt_Age);
            this.Controls.Add(this.Lbl_age);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Btn_Clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_age;
        private System.Windows.Forms.TextBox Txt_Age;
    }
}

