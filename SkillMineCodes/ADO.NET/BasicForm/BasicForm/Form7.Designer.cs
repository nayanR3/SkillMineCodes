namespace BasicForm
{
    partial class Form7
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
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.txtEmpSal = new System.Windows.Forms.TextBox();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblEmpSal = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(455, 182);
            this.btnBinaryRead.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(150, 50);
            this.btnBinaryRead.TabIndex = 39;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(272, 182);
            this.btnBinaryWrite.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(150, 50);
            this.btnBinaryWrite.TabIndex = 38;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(455, 371);
            this.btnJSONRead.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(150, 50);
            this.btnJSONRead.TabIndex = 37;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(455, 309);
            this.btnSOAPRead.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(150, 50);
            this.btnSOAPRead.TabIndex = 36;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(272, 371);
            this.btnJSONWrite.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(150, 50);
            this.btnJSONWrite.TabIndex = 35;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(272, 309);
            this.btnSOAPWrite.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(150, 50);
            this.btnSOAPWrite.TabIndex = 34;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // txtEmpSal
            // 
            this.txtEmpSal.Location = new System.Drawing.Point(442, 120);
            this.txtEmpSal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtEmpSal.Name = "txtEmpSal";
            this.txtEmpSal.Size = new System.Drawing.Size(141, 21);
            this.txtEmpSal.TabIndex = 33;
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(283, 90);
            this.lblEmpId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(86, 15);
            this.lblEmpId.TabIndex = 32;
            this.lblEmpId.Text = "Employee Id";
            this.lblEmpId.Click += new System.EventHandler(this.lblEmpId_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(442, 87);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(141, 21);
            this.txtEmpId.TabIndex = 31;
            // 
            // lblEmpSal
            // 
            this.lblEmpSal.AutoSize = true;
            this.lblEmpSal.Location = new System.Drawing.Point(279, 120);
            this.lblEmpSal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEmpSal.Name = "lblEmpSal";
            this.lblEmpSal.Size = new System.Drawing.Size(114, 15);
            this.lblEmpSal.TabIndex = 30;
            this.lblEmpSal.Text = "Employee Salary";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(442, 50);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(141, 21);
            this.txtEmpName.TabIndex = 29;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(283, 53);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(112, 15);
            this.lblEmpName.TabIndex = 28;
            this.lblEmpName.Text = "Employee Name";
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(455, 247);
            this.btnXmlRead.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(150, 50);
            this.btnXmlRead.TabIndex = 41;
            this.btnXmlRead.Text = "XML Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(272, 247);
            this.btnXmlWrite.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(150, 50);
            this.btnXmlWrite.TabIndex = 40;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 519);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.txtEmpSal);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblEmpSal);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnJSONRead;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.TextBox txtEmpSal;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblEmpSal;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnXmlWrite;
    }
}