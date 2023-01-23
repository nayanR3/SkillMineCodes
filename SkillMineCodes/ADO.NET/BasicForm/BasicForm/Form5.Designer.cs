namespace BasicForm
{
    partial class Form5
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
            this.txtDId = new System.Windows.Forms.TextBox();
            this.lblDId = new System.Windows.Forms.Label();
            this.txtDLoc = new System.Windows.Forms.TextBox();
            this.lblDLoc = new System.Windows.Forms.Label();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.lblDName = new System.Windows.Forms.Label();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDId
            // 
            this.txtDId.BackColor = System.Drawing.SystemColors.Control;
            this.txtDId.Location = new System.Drawing.Point(440, 141);
            this.txtDId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDId.Name = "txtDId";
            this.txtDId.Size = new System.Drawing.Size(196, 23);
            this.txtDId.TabIndex = 21;
            // 
            // lblDId
            // 
            this.lblDId.AutoSize = true;
            this.lblDId.BackColor = System.Drawing.SystemColors.Control;
            this.lblDId.Location = new System.Drawing.Point(281, 141);
            this.lblDId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDId.Name = "lblDId";
            this.lblDId.Size = new System.Drawing.Size(65, 17);
            this.lblDId.TabIndex = 20;
            this.lblDId.Text = "Dept. Id";
            // 
            // txtDLoc
            // 
            this.txtDLoc.BackColor = System.Drawing.SystemColors.Control;
            this.txtDLoc.Location = new System.Drawing.Point(440, 176);
            this.txtDLoc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDLoc.Name = "txtDLoc";
            this.txtDLoc.Size = new System.Drawing.Size(196, 23);
            this.txtDLoc.TabIndex = 19;
            this.txtDLoc.TextChanged += new System.EventHandler(this.txtEmpSal_TextChanged);
            // 
            // lblDLoc
            // 
            this.lblDLoc.AutoSize = true;
            this.lblDLoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblDLoc.Location = new System.Drawing.Point(281, 176);
            this.lblDLoc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDLoc.Name = "lblDLoc";
            this.lblDLoc.Size = new System.Drawing.Size(70, 17);
            this.lblDLoc.TabIndex = 18;
            this.lblDLoc.Text = "Location";
            // 
            // txtDName
            // 
            this.txtDName.BackColor = System.Drawing.SystemColors.Control;
            this.txtDName.Location = new System.Drawing.Point(440, 107);
            this.txtDName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(196, 23);
            this.txtDName.TabIndex = 17;
            // 
            // lblDName
            // 
            this.lblDName.AutoSize = true;
            this.lblDName.BackColor = System.Drawing.SystemColors.Control;
            this.lblDName.Location = new System.Drawing.Point(281, 107);
            this.lblDName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(93, 17);
            this.lblDName.TabIndex = 16;
            this.lblDName.Text = "Dept. Name";
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.BackColor = System.Drawing.SystemColors.Control;
            this.btnBinaryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaryRead.Location = new System.Drawing.Point(492, 263);
            this.btnBinaryRead.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(165, 49);
            this.btnBinaryRead.TabIndex = 23;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = false;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.BackColor = System.Drawing.SystemColors.Control;
            this.btnBinaryWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaryWrite.Location = new System.Drawing.Point(271, 263);
            this.btnBinaryWrite.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(165, 49);
            this.btnBinaryWrite.TabIndex = 22;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = false;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtDId);
            this.Controls.Add(this.lblDId);
            this.Controls.Add(this.txtDLoc);
            this.Controls.Add(this.lblDLoc);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.lblDName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDId;
        private System.Windows.Forms.Label lblDId;
        private System.Windows.Forms.TextBox txtDLoc;
        private System.Windows.Forms.Label lblDLoc;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnBinaryWrite;
    }
}