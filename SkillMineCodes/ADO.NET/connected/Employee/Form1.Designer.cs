namespace empProject
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
            this.lbled = new System.Windows.Forms.Label();
            this.lblea = new System.Windows.Forms.Label();
            this.lblen = new System.Windows.Forms.Label();
            this.lblei = new System.Windows.Forms.Label();
            this.txtED = new System.Windows.Forms.TextBox();
            this.txtEA = new System.Windows.Forms.TextBox();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.txtEI = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbles = new System.Windows.Forms.Label();
            this.txtES = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(178, 482);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 35);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSA
            // 
            this.btnSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSA.Location = new System.Drawing.Point(541, 387);
            this.btnSA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSA.Name = "btnSA";
            this.btnSA.Size = new System.Drawing.Size(101, 37);
            this.btnSA.TabIndex = 31;
            this.btnSA.Text = "SHOW ALL";
            this.btnSA.UseVisualStyleBackColor = true;
            this.btnSA.Click += new System.EventHandler(this.btnSA_Click);
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(444, 434);
            this.GridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(329, 131);
            this.GridView1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 50);
            this.label1.TabIndex = 29;
            this.label1.Text = "Employee Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbled
            // 
            this.lbled.AutoSize = true;
            this.lbled.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbled.Location = new System.Drawing.Point(243, 253);
            this.lbled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbled.Name = "lbled";
            this.lbled.Size = new System.Drawing.Size(97, 22);
            this.lbled.TabIndex = 28;
            this.lbled.Text = "Emp Dept";
            // 
            // lblea
            // 
            this.lblea.AutoSize = true;
            this.lblea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblea.Location = new System.Drawing.Point(244, 218);
            this.lblea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblea.Name = "lblea";
            this.lblea.Size = new System.Drawing.Size(90, 22);
            this.lblea.TabIndex = 27;
            this.lblea.Text = "Emp Age";
            // 
            // lblen
            // 
            this.lblen.AutoSize = true;
            this.lblen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblen.Location = new System.Drawing.Point(244, 180);
            this.lblen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblen.Name = "lblen";
            this.lblen.Size = new System.Drawing.Size(106, 22);
            this.lblen.TabIndex = 26;
            this.lblen.Text = "Emp Name";
            // 
            // lblei
            // 
            this.lblei.AutoSize = true;
            this.lblei.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblei.Location = new System.Drawing.Point(244, 144);
            this.lblei.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblei.Name = "lblei";
            this.lblei.Size = new System.Drawing.Size(71, 22);
            this.lblei.TabIndex = 25;
            this.lblei.Text = "Emp Id";
            // 
            // txtED
            // 
            this.txtED.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtED.Location = new System.Drawing.Point(473, 250);
            this.txtED.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtED.Name = "txtED";
            this.txtED.Size = new System.Drawing.Size(116, 27);
            this.txtED.TabIndex = 24;
            // 
            // txtEA
            // 
            this.txtEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEA.Location = new System.Drawing.Point(473, 213);
            this.txtEA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEA.Name = "txtEA";
            this.txtEA.Size = new System.Drawing.Size(116, 27);
            this.txtEA.TabIndex = 23;
            // 
            // txtEN
            // 
            this.txtEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEN.Location = new System.Drawing.Point(473, 175);
            this.txtEN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(116, 27);
            this.txtEN.TabIndex = 22;
            // 
            // txtEI
            // 
            this.txtEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEI.Location = new System.Drawing.Point(473, 141);
            this.txtEI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEI.Name = "txtEI";
            this.txtEI.Size = new System.Drawing.Size(116, 27);
            this.txtEI.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(297, 434);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 38);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(178, 434);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 38);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(297, 387);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 38);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(178, 387);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 38);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbles
            // 
            this.lbles.AutoSize = true;
            this.lbles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbles.Location = new System.Drawing.Point(244, 297);
            this.lbles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbles.Name = "lbles";
            this.lbles.Size = new System.Drawing.Size(112, 22);
            this.lbles.TabIndex = 34;
            this.lbles.Text = "Emp Salary";
            // 
            // txtES
            // 
            this.txtES.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtES.Location = new System.Drawing.Point(474, 294);
            this.txtES.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtES.Name = "txtES";
            this.txtES.Size = new System.Drawing.Size(116, 27);
            this.txtES.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 553);
            this.Controls.Add(this.lbles);
            this.Controls.Add(this.txtES);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSA);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbled);
            this.Controls.Add(this.lblea);
            this.Controls.Add(this.lblen);
            this.Controls.Add(this.lblei);
            this.Controls.Add(this.txtED);
            this.Controls.Add(this.txtEA);
            this.Controls.Add(this.txtEN);
            this.Controls.Add(this.txtEI);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
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
        private System.Windows.Forms.Label lbled;
        private System.Windows.Forms.Label lblea;
        private System.Windows.Forms.Label lblen;
        private System.Windows.Forms.Label lblei;
        private System.Windows.Forms.TextBox txtED;
        private System.Windows.Forms.TextBox txtEA;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.TextBox txtEI;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbles;
        private System.Windows.Forms.TextBox txtES;
    }
}

