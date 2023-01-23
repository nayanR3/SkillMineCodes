namespace BasicForm
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCalSal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblHra = new System.Windows.Forms.Label();
            this.lblDa = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtBasicSal = new System.Windows.Forms.TextBox();
            this.txtHra = new System.Windows.Forms.TextBox();
            this.txtDa = new System.Windows.Forms.TextBox();
            this.txtPf = new System.Windows.Forms.TextBox();
            this.lblPf = new System.Windows.Forms.Label();
            this.txtTotalSal = new System.Windows.Forms.TextBox();
            this.lblTotalSal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(209, 389);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 46);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCalSal
            // 
            this.btnCalSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalSal.Location = new System.Drawing.Point(260, 299);
            this.btnCalSal.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalSal.Name = "btnCalSal";
            this.btnCalSal.Size = new System.Drawing.Size(196, 49);
            this.btnCalSal.TabIndex = 1;
            this.btnCalSal.Text = "calculate Salary";
            this.btnCalSal.UseVisualStyleBackColor = true;
            this.btnCalSal.Click += new System.EventHandler(this.btnCalSal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(356, 389);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(206, 37);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(82, 17);
            this.lblEmpName.TabIndex = 3;
            this.lblEmpName.Text = "emp name";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.Location = new System.Drawing.Point(206, 69);
            this.lblEmpId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(56, 17);
            this.lblEmpId.TabIndex = 4;
            this.lblEmpId.Text = "emp id";
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasic.Location = new System.Drawing.Point(206, 96);
            this.lblBasic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(95, 17);
            this.lblBasic.TabIndex = 5;
            this.lblBasic.Text = "basic salary";
            // 
            // lblHra
            // 
            this.lblHra.AutoSize = true;
            this.lblHra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHra.Location = new System.Drawing.Point(206, 127);
            this.lblHra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHra.Name = "lblHra";
            this.lblHra.Size = new System.Drawing.Size(40, 17);
            this.lblHra.TabIndex = 6;
            this.lblHra.Text = "HRA";
            // 
            // lblDa
            // 
            this.lblDa.AutoSize = true;
            this.lblDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDa.Location = new System.Drawing.Point(206, 162);
            this.lblDa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDa.Name = "lblDa";
            this.lblDa.Size = new System.Drawing.Size(29, 17);
            this.lblDa.TabIndex = 7;
            this.lblDa.Text = "DA";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(396, 34);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(132, 23);
            this.txtEmpName.TabIndex = 8;
            this.txtEmpName.TextChanged += new System.EventHandler(this.txtEmpName_TextChanged);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(396, 65);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(132, 23);
            this.txtEmpId.TabIndex = 9;
            // 
            // txtBasicSal
            // 
            this.txtBasicSal.Location = new System.Drawing.Point(396, 96);
            this.txtBasicSal.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasicSal.Name = "txtBasicSal";
            this.txtBasicSal.Size = new System.Drawing.Size(132, 23);
            this.txtBasicSal.TabIndex = 10;
            // 
            // txtHra
            // 
            this.txtHra.Enabled = false;
            this.txtHra.Location = new System.Drawing.Point(396, 127);
            this.txtHra.Margin = new System.Windows.Forms.Padding(4);
            this.txtHra.Name = "txtHra";
            this.txtHra.Size = new System.Drawing.Size(132, 23);
            this.txtHra.TabIndex = 11;
            // 
            // txtDa
            // 
            this.txtDa.Enabled = false;
            this.txtDa.Location = new System.Drawing.Point(396, 158);
            this.txtDa.Margin = new System.Windows.Forms.Padding(4);
            this.txtDa.Name = "txtDa";
            this.txtDa.Size = new System.Drawing.Size(132, 23);
            this.txtDa.TabIndex = 12;
            // 
            // txtPf
            // 
            this.txtPf.Enabled = false;
            this.txtPf.Location = new System.Drawing.Point(396, 189);
            this.txtPf.Margin = new System.Windows.Forms.Padding(4);
            this.txtPf.Name = "txtPf";
            this.txtPf.Size = new System.Drawing.Size(132, 23);
            this.txtPf.TabIndex = 14;
            // 
            // lblPf
            // 
            this.lblPf.AutoSize = true;
            this.lblPf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPf.Location = new System.Drawing.Point(206, 193);
            this.lblPf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPf.Name = "lblPf";
            this.lblPf.Size = new System.Drawing.Size(27, 17);
            this.lblPf.TabIndex = 13;
            this.lblPf.Text = "PF";
            // 
            // txtTotalSal
            // 
            this.txtTotalSal.Enabled = false;
            this.txtTotalSal.Location = new System.Drawing.Point(396, 220);
            this.txtTotalSal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSal.Name = "txtTotalSal";
            this.txtTotalSal.Size = new System.Drawing.Size(132, 23);
            this.txtTotalSal.TabIndex = 16;
            // 
            // lblTotalSal
            // 
            this.lblTotalSal.AutoSize = true;
            this.lblTotalSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSal.Location = new System.Drawing.Point(206, 224);
            this.lblTotalSal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSal.Name = "lblTotalSal";
            this.lblTotalSal.Size = new System.Drawing.Size(96, 17);
            this.lblTotalSal.TabIndex = 15;
            this.lblTotalSal.Text = "Total Salary";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtTotalSal);
            this.Controls.Add(this.lblTotalSal);
            this.Controls.Add(this.txtPf);
            this.Controls.Add(this.lblPf);
            this.Controls.Add(this.txtDa);
            this.Controls.Add(this.txtHra);
            this.Controls.Add(this.txtBasicSal);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblDa);
            this.Controls.Add(this.lblHra);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalSal);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCalSal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblHra;
        private System.Windows.Forms.Label lblDa;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtBasicSal;
        private System.Windows.Forms.TextBox txtHra;
        private System.Windows.Forms.TextBox txtDa;
        private System.Windows.Forms.TextBox txtPf;
        private System.Windows.Forms.Label lblPf;
        private System.Windows.Forms.TextBox txtTotalSal;
        private System.Windows.Forms.Label lblTotalSal;
    }
}