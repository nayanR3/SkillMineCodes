namespace bookP
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
            this.lblG = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtPB = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSA = new System.Windows.Forms.Button();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.lblP = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.txtAN = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(198, 238);
            this.lblG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(72, 22);
            this.lblG.TabIndex = 75;
            this.lblG.Text = "Edition";
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(408, 233);
            this.txtE.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(135, 27);
            this.txtE.TabIndex = 74;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(198, 199);
            this.lblA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(109, 22);
            this.lblA.TabIndex = 73;
            this.lblA.Text = "Publication";
            // 
            // txtPB
            // 
            this.txtPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPB.Location = new System.Drawing.Point(408, 199);
            this.txtPB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPB.Name = "txtPB";
            this.txtPB.Size = new System.Drawing.Size(135, 27);
            this.txtPB.TabIndex = 72;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(85, 415);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 35);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSA
            // 
            this.btnSA.Location = new System.Drawing.Point(542, 321);
            this.btnSA.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSA.Name = "btnSA";
            this.btnSA.Size = new System.Drawing.Size(118, 37);
            this.btnSA.TabIndex = 70;
            this.btnSA.Text = "SHOW ALL";
            this.btnSA.UseVisualStyleBackColor = true;
            this.btnSA.Click += new System.EventHandler(this.btnSA_Click);
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(395, 367);
            this.GridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(527, 123);
            this.GridView1.TabIndex = 69;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(198, 171);
            this.lblP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(126, 22);
            this.lblP.TabIndex = 68;
            this.lblP.Text = "Author Name";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(198, 130);
            this.lblS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(56, 22);
            this.lblS.TabIndex = 67;
            this.lblS.Text = "Price";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(198, 84);
            this.lblN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(112, 22);
            this.lblN.TabIndex = 66;
            this.lblN.Text = "Book Name";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(198, 48);
            this.lblR.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(77, 22);
            this.lblR.TabIndex = 65;
            this.lblR.Text = "Book Id";
            // 
            // txtAN
            // 
            this.txtAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAN.Location = new System.Drawing.Point(408, 166);
            this.txtAN.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtAN.Name = "txtAN";
            this.txtAN.Size = new System.Drawing.Size(135, 27);
            this.txtAN.TabIndex = 64;
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(408, 125);
            this.txtP.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(135, 27);
            this.txtP.TabIndex = 63;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(408, 79);
            this.txtN.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(135, 27);
            this.txtN.TabIndex = 62;
            // 
            // txtI
            // 
            this.txtI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtI.Location = new System.Drawing.Point(408, 45);
            this.txtI.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(135, 27);
            this.txtI.TabIndex = 61;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(224, 367);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 38);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(85, 367);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 38);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(224, 320);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 38);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(85, 320);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 38);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 532);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtPB);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSA);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtAN);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtPB;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSA;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtAN;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}

