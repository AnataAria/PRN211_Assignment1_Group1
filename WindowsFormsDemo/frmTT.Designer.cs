
namespace ProjectManagementWinApp_NguyenQuangVinh
{
    partial class frmTT
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lvData = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            btnThem = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            txtCartoonCode = new System.Windows.Forms.TextBox();
            txtCartoonName = new System.Windows.Forms.TextBox();
            txtActors = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            txtProducer = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtReleaseDate = new System.Windows.Forms.DateTimePicker();
            cbCartoonType = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            txtDirector = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            rtbShortDescription = new System.Windows.Forms.RichTextBox();
            label10 = new System.Windows.Forms.Label();
            btnLoad = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 26);
            label1.TabIndex = 0;
            label1.Text = "Cartoon Code";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 131);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(129, 26);
            label2.TabIndex = 1;
            label2.Text = "Cartoon Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 183);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 26);
            label3.TabIndex = 1;
            label3.Text = "Actors";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(410, 83);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(114, 26);
            label4.TabIndex = 2;
            label4.Text = "Launch Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(410, 128);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 26);
            label5.TabIndex = 3;
            label5.Text = "Producer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(410, 186);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 26);
            label6.TabIndex = 4;
            label6.Text = "Country";
            // 
            // lvData
            // 
            lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader7, columnHeader8, columnHeader3, columnHeader9, columnHeader6, columnHeader5 });
            lvData.FullRowSelect = true;
            lvData.GridLines = true;
            lvData.Location = new System.Drawing.Point(8, 565);
            lvData.Name = "lvData";
            lvData.Size = new System.Drawing.Size(1371, 400);
            lvData.TabIndex = 5;
            lvData.UseCompatibleStateImageBehavior = false;
            lvData.View = System.Windows.Forms.View.Details;
            lvData.ItemSelectionChanged += lvData_ItemSelectionChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cartoon Code";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cartoon Name";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Launch Date";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Type";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Short Description";
            columnHeader8.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Actors";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 140;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Director";
            columnHeader9.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Country";
            columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader6.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Producer";
            columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader5.Width = 200;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(1406, 565);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(112, 34);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Location = new System.Drawing.Point(1406, 614);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(112, 34);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(1406, 664);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(112, 34);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(1406, 722);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(112, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCartoonCode
            // 
            txtCartoonCode.Enabled = false;
            txtCartoonCode.Location = new System.Drawing.Point(168, 80);
            txtCartoonCode.Name = "txtCartoonCode";
            txtCartoonCode.Size = new System.Drawing.Size(224, 33);
            txtCartoonCode.TabIndex = 1;
            // 
            // txtCartoonName
            // 
            txtCartoonName.Enabled = false;
            txtCartoonName.Location = new System.Drawing.Point(168, 131);
            txtCartoonName.Name = "txtCartoonName";
            txtCartoonName.Size = new System.Drawing.Size(224, 33);
            txtCartoonName.TabIndex = 3;
            // 
            // txtActors
            // 
            txtActors.Enabled = false;
            txtActors.Location = new System.Drawing.Point(168, 183);
            txtActors.Name = "txtActors";
            txtActors.Size = new System.Drawing.Size(224, 33);
            txtActors.TabIndex = 5;
            // 
            // txtCountry
            // 
            txtCountry.Enabled = false;
            txtCountry.Location = new System.Drawing.Point(544, 183);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(278, 33);
            txtCountry.TabIndex = 6;
            // 
            // txtProducer
            // 
            txtProducer.Enabled = false;
            txtProducer.Location = new System.Drawing.Point(544, 128);
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new System.Drawing.Size(278, 33);
            txtProducer.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.Highlight;
            label7.Location = new System.Drawing.Point(10, 12);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(659, 57);
            label7.TabIndex = 9;
            label7.Text = "CARTOON MANAGMENT SYSTEM";
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new System.Drawing.Point(544, 78);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new System.Drawing.Size(309, 33);
            txtReleaseDate.TabIndex = 10;
            // 
            // cbCartoonType
            // 
            cbCartoonType.FormattingEnabled = true;
            cbCartoonType.Location = new System.Drawing.Point(168, 231);
            cbCartoonType.Name = "cbCartoonType";
            cbCartoonType.Size = new System.Drawing.Size(129, 34);
            cbCartoonType.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(11, 231);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(52, 26);
            label8.TabIndex = 12;
            label8.Text = "Type";
            // 
            // txtDirector
            // 
            txtDirector.Enabled = false;
            txtDirector.Location = new System.Drawing.Point(544, 232);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new System.Drawing.Size(278, 33);
            txtDirector.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(410, 232);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(75, 26);
            label9.TabIndex = 13;
            label9.Text = "Director";
            // 
            // rtbShortDescription
            // 
            rtbShortDescription.Location = new System.Drawing.Point(12, 330);
            rtbShortDescription.Name = "rtbShortDescription";
            rtbShortDescription.Size = new System.Drawing.Size(810, 182);
            rtbShortDescription.TabIndex = 15;
            rtbShortDescription.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(12, 286);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(150, 26);
            label10.TabIndex = 16;
            label10.Text = "Short Description";
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(1406, 779);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(112, 34);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmTT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1576, 1012);
            Controls.Add(btnLoad);
            Controls.Add(label10);
            Controls.Add(rtbShortDescription);
            Controls.Add(txtDirector);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cbCartoonType);
            Controls.Add(txtReleaseDate);
            Controls.Add(label7);
            Controls.Add(txtCountry);
            Controls.Add(txtActors);
            Controls.Add(txtProducer);
            Controls.Add(txtCartoonName);
            Controls.Add(txtCartoonCode);
            Controls.Add(btnExit);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(lvData);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "frmTT";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmTT";
            FormClosing += frmTT_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCartoonCode;
        private System.Windows.Forms.TextBox txtCartoonName;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtReleaseDate;
        private System.Windows.Forms.ComboBox cbCartoonType;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbShortDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoad;
    }
}