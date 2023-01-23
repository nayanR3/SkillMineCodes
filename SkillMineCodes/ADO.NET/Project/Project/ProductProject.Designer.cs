namespace Project
{
    partial class ProductProject
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPI = new System.Windows.Forms.TextBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.lblPI = new System.Windows.Forms.Label();
            this.lblPN = new System.Windows.Forms.Label();
            this.lblPP = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.btnSA = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(296, 327);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(415, 327);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(296, 374);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(415, 374);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPI
            // 
            this.txtPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPI.Location = new System.Drawing.Point(573, 109);
            this.txtPI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPI.Name = "txtPI";
            this.txtPI.Size = new System.Drawing.Size(116, 27);
            this.txtPI.TabIndex = 5;
            this.txtPI.TextChanged += new System.EventHandler(this.txtPI_TextChanged);
            // 
            // txtPN
            // 
            this.txtPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPN.Location = new System.Drawing.Point(573, 143);
            this.txtPN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(116, 27);
            this.txtPN.TabIndex = 6;
            // 
            // txtPP
            // 
            this.txtPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPP.Location = new System.Drawing.Point(573, 181);
            this.txtPP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(116, 27);
            this.txtPP.TabIndex = 7;
            // 
            // txtCN
            // 
            this.txtCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCN.Location = new System.Drawing.Point(573, 218);
            this.txtCN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(116, 27);
            this.txtCN.TabIndex = 8;
            // 
            // lblPI
            // 
            this.lblPI.AutoSize = true;
            this.lblPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPI.Location = new System.Drawing.Point(344, 112);
            this.lblPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPI.Name = "lblPI";
            this.lblPI.Size = new System.Drawing.Size(101, 22);
            this.lblPI.TabIndex = 9;
            this.lblPI.Text = "Product Id";
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPN.Location = new System.Drawing.Point(344, 148);
            this.lblPN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(136, 22);
            this.lblPN.TabIndex = 10;
            this.lblPN.Text = "Product Name";
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPP.Location = new System.Drawing.Point(344, 186);
            this.lblPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(131, 22);
            this.lblPP.TabIndex = 11;
            this.lblPP.Text = "Product Price";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCN.Location = new System.Drawing.Point(343, 221);
            this.lblCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(150, 22);
            this.lblCN.TabIndex = 12;
            this.lblCN.Text = "Company Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "PRODUCT ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(562, 374);
            this.GridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(329, 118);
            this.GridView1.TabIndex = 14;
            // 
            // btnSA
            // 
            this.btnSA.Location = new System.Drawing.Point(688, 328);
            this.btnSA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSA.Name = "btnSA";
            this.btnSA.Size = new System.Drawing.Size(101, 37);
            this.btnSA.TabIndex = 15;
            this.btnSA.Text = "SHOW ALL";
            this.btnSA.UseVisualStyleBackColor = true;
            this.btnSA.Click += new System.EventHandler(this.btnSA_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(296, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 35);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ProductProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 504);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSA);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.lblPP);
            this.Controls.Add(this.lblPN);
            this.Controls.Add(this.lblPI);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.txtPP);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.txtPI);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductProject";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPI;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.TextBox txtPP;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Label lblPI;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.Label lblPP;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Button btnSA;
        private System.Windows.Forms.Button btnClear;
    }
}

