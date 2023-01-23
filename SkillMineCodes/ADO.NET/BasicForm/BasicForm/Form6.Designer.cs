namespace BasicForm
{
    partial class Form6
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
            this.txtEmpSal = new System.Windows.Forms.TextBox();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblEmpSal = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmpSal
            // 
            this.txtEmpSal.Location = new System.Drawing.Point(222, 158);
            this.txtEmpSal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmpSal.Name = "txtEmpSal";
            this.txtEmpSal.Size = new System.Drawing.Size(174, 21);
            this.txtEmpSal.TabIndex = 21;
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(52, 116);
            this.lblEmpId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(86, 15);
            this.lblEmpId.TabIndex = 20;
            this.lblEmpId.Text = "Employee Id";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(222, 116);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(174, 21);
            this.txtEmpId.TabIndex = 19;
            // 
            // lblEmpSal
            // 
            this.lblEmpSal.AutoSize = true;
            this.lblEmpSal.Location = new System.Drawing.Point(48, 158);
            this.lblEmpSal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpSal.Name = "lblEmpSal";
            this.lblEmpSal.Size = new System.Drawing.Size(114, 15);
            this.lblEmpSal.TabIndex = 18;
            this.lblEmpSal.Text = "Employee Salary";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(222, 72);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(174, 21);
            this.txtEmpName.TabIndex = 17;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(48, 72);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(112, 15);
            this.lblEmpName.TabIndex = 16;
            this.lblEmpName.Text = "Employee Name";
            this.lblEmpName.Click += new System.EventHandler(this.lblEmpName_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(641, 171);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(153, 51);
            this.btnDeleteFile.TabIndex = 25;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Location = new System.Drawing.Point(641, 110);
            this.btnDeleteFolder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(153, 51);
            this.btnDeleteFolder.TabIndex = 24;
            this.btnDeleteFolder.Text = "Delete Folder";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(478, 171);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(153, 51);
            this.btnCreateFile.TabIndex = 23;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(478, 110);
            this.btnCreateFolder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(153, 51);
            this.btnCreateFolder.TabIndex = 22;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(250, 238);
            this.btnBinaryRead.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(146, 46);
            this.btnBinaryRead.TabIndex = 27;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(53, 238);
            this.btnBinaryWrite.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(146, 46);
            this.btnBinaryWrite.TabIndex = 26;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnDeleteFolder);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.txtEmpSal);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblEmpSal);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpSal;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblEmpSal;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnDeleteFolder;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnBinaryWrite;
    }
}