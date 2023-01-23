namespace studentProject
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSA = new System.Windows.Forms.Button();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblG = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(188, 501);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 35);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSA
            // 
            this.btnSA.Location = new System.Drawing.Point(645, 407);
            this.btnSA.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSA.Name = "btnSA";
            this.btnSA.Size = new System.Drawing.Size(118, 37);
            this.btnSA.TabIndex = 31;
            this.btnSA.Text = "SHOW ALL";
            this.btnSA.UseVisualStyleBackColor = true;
            this.btnSA.Click += new System.EventHandler(this.btnSA_Click);
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(498, 453);
            this.GridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(527, 123);
            this.GridView1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 50);
            this.label1.TabIndex = 29;
            this.label1.Text = "STUDENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(244, 245);
            this.lblP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(112, 22);
            this.lblP.TabIndex = 28;
            this.lblP.Text = "Percentage";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(244, 208);
            this.lblS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(73, 22);
            this.lblS.TabIndex = 27;
            this.lblS.Text = "Stream";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(244, 170);
            this.lblN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(61, 22);
            this.lblN.TabIndex = 26;
            this.lblN.Text = "Name";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(244, 134);
            this.lblR.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(76, 22);
            this.lblR.TabIndex = 25;
            this.lblR.Text = "Roll No";
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(511, 240);
            this.txtP.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(135, 27);
            this.txtP.TabIndex = 24;
            // 
            // txtS
            // 
            this.txtS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS.Location = new System.Drawing.Point(511, 203);
            this.txtS.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(135, 27);
            this.txtS.TabIndex = 23;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(511, 165);
            this.txtN.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(135, 27);
            this.txtN.TabIndex = 22;
            // 
            // txtR
            // 
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR.Location = new System.Drawing.Point(511, 131);
            this.txtR.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(135, 27);
            this.txtR.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(327, 453);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 38);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(188, 453);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 38);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(327, 406);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 38);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(188, 406);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 38);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(249, 285);
            this.lblA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(45, 22);
            this.lblA.TabIndex = 34;
            this.lblA.Text = "Age";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(511, 285);
            this.txtA.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(135, 27);
            this.txtA.TabIndex = 33;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(244, 324);
            this.lblG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(76, 22);
            this.lblG.TabIndex = 36;
            this.lblG.Text = "Gender";
            // 
            // txtG
            // 
            this.txtG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG.Location = new System.Drawing.Point(511, 319);
            this.txtG.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(135, 27);
            this.txtG.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 621);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSA);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSA;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TextBox txtG;
    }
}

