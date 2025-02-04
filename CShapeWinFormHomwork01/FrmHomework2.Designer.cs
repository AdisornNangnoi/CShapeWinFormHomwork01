namespace CShapeWinFormHomwork01
{
    partial class FrmHomework2
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
            this.gbStuData = new System.Windows.Forms.GroupBox();
            this.lbTest = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.Label();
            this.lbMidterm = new System.Windows.Forms.Label();
            this.tbCollect = new System.Windows.Forms.TextBox();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.tbMidterm = new System.Windows.Forms.TextBox();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.lbFullname = new System.Windows.Forms.Label();
            this.tbStuID = new System.Windows.Forms.TextBox();
            this.lbIdStu = new System.Windows.Forms.Label();
            this.lbIdStu2 = new System.Windows.Forms.Label();
            this.lbFullname2 = new System.Windows.Forms.Label();
            this.lbPointTotal = new System.Windows.Forms.Label();
            this.lbShowID = new System.Windows.Forms.Label();
            this.lbShowFullname = new System.Windows.Forms.Label();
            this.lbShowPoint = new System.Windows.Forms.Label();
            this.lbHead = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.lbShowGrade = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.gbStuData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStuData
            // 
            this.gbStuData.Controls.Add(this.lbTest);
            this.gbStuData.Controls.Add(this.lbFinal);
            this.gbStuData.Controls.Add(this.lbMidterm);
            this.gbStuData.Controls.Add(this.tbCollect);
            this.gbStuData.Controls.Add(this.tbFinal);
            this.gbStuData.Controls.Add(this.tbMidterm);
            this.gbStuData.Controls.Add(this.tbFullname);
            this.gbStuData.Controls.Add(this.lbFullname);
            this.gbStuData.Controls.Add(this.tbStuID);
            this.gbStuData.Controls.Add(this.lbIdStu);
            this.gbStuData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbStuData.Location = new System.Drawing.Point(46, 47);
            this.gbStuData.Name = "gbStuData";
            this.gbStuData.Size = new System.Drawing.Size(408, 241);
            this.gbStuData.TabIndex = 0;
            this.gbStuData.TabStop = false;
            this.gbStuData.Text = "ข้อมูลนักศึกษา";
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(67, 193);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(70, 15);
            this.lbTest.TabIndex = 9;
            this.lbTest.Text = "คะแนนเก็บ";
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Location = new System.Drawing.Point(38, 159);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(99, 15);
            this.lbFinal.TabIndex = 8;
            this.lbFinal.Text = "คะแนนปลายภาค";
            // 
            // lbMidterm
            // 
            this.lbMidterm.AutoSize = true;
            this.lbMidterm.Location = new System.Drawing.Point(40, 117);
            this.lbMidterm.Name = "lbMidterm";
            this.lbMidterm.Size = new System.Drawing.Size(97, 15);
            this.lbMidterm.TabIndex = 7;
            this.lbMidterm.Text = "คะแนนกลางภาค";
            // 
            // tbCollect
            // 
            this.tbCollect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCollect.Location = new System.Drawing.Point(153, 191);
            this.tbCollect.MaxLength = 2;
            this.tbCollect.Name = "tbCollect";
            this.tbCollect.Size = new System.Drawing.Size(186, 21);
            this.tbCollect.TabIndex = 6;
            this.tbCollect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCollect_KeyPress);
            // 
            // tbFinal
            // 
            this.tbFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFinal.Location = new System.Drawing.Point(153, 153);
            this.tbFinal.MaxLength = 2;
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(186, 21);
            this.tbFinal.TabIndex = 5;
            this.tbFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFinal_KeyPress);
            // 
            // tbMidterm
            // 
            this.tbMidterm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMidterm.Location = new System.Drawing.Point(153, 115);
            this.tbMidterm.MaxLength = 2;
            this.tbMidterm.Name = "tbMidterm";
            this.tbMidterm.Size = new System.Drawing.Size(186, 21);
            this.tbMidterm.TabIndex = 4;
            this.tbMidterm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMidterm_KeyPress);
            // 
            // tbFullname
            // 
            this.tbFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullname.Location = new System.Drawing.Point(153, 77);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(186, 21);
            this.tbFullname.TabIndex = 3;
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(88, 79);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(49, 15);
            this.lbFullname.TabIndex = 2;
            this.lbFullname.Text = "ชื่อ-สกุล";
            // 
            // tbStuID
            // 
            this.tbStuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStuID.Location = new System.Drawing.Point(153, 39);
            this.tbStuID.MaxLength = 13;
            this.tbStuID.Name = "tbStuID";
            this.tbStuID.Size = new System.Drawing.Size(186, 21);
            this.tbStuID.TabIndex = 1;
            this.tbStuID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStuID_KeyPress);
            // 
            // lbIdStu
            // 
            this.lbIdStu.AutoSize = true;
            this.lbIdStu.Location = new System.Drawing.Point(59, 41);
            this.lbIdStu.Name = "lbIdStu";
            this.lbIdStu.Size = new System.Drawing.Size(78, 15);
            this.lbIdStu.TabIndex = 0;
            this.lbIdStu.Text = "รหัสนักศึกษา";
            // 
            // lbIdStu2
            // 
            this.lbIdStu2.AutoSize = true;
            this.lbIdStu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbIdStu2.Location = new System.Drawing.Point(78, 413);
            this.lbIdStu2.Name = "lbIdStu2";
            this.lbIdStu2.Size = new System.Drawing.Size(78, 15);
            this.lbIdStu2.TabIndex = 4;
            this.lbIdStu2.Text = "รหัสนักศึกษา";
            // 
            // lbFullname2
            // 
            this.lbFullname2.AutoSize = true;
            this.lbFullname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbFullname2.Location = new System.Drawing.Point(107, 444);
            this.lbFullname2.Name = "lbFullname2";
            this.lbFullname2.Size = new System.Drawing.Size(49, 15);
            this.lbFullname2.TabIndex = 5;
            this.lbFullname2.Text = "ชื่อ-สกุล";
            // 
            // lbPointTotal
            // 
            this.lbPointTotal.AutoSize = true;
            this.lbPointTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbPointTotal.Location = new System.Drawing.Point(85, 483);
            this.lbPointTotal.Name = "lbPointTotal";
            this.lbPointTotal.Size = new System.Drawing.Size(70, 15);
            this.lbPointTotal.TabIndex = 6;
            this.lbPointTotal.Text = "คะแนนรวม";
            // 
            // lbShowID
            // 
            this.lbShowID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbShowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbShowID.ForeColor = System.Drawing.Color.Green;
            this.lbShowID.Location = new System.Drawing.Point(196, 413);
            this.lbShowID.Name = "lbShowID";
            this.lbShowID.Size = new System.Drawing.Size(219, 23);
            this.lbShowID.TabIndex = 9;
            this.lbShowID.Text = "XXXXXXXX";
            this.lbShowID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbShowFullname
            // 
            this.lbShowFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbShowFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbShowFullname.ForeColor = System.Drawing.Color.Green;
            this.lbShowFullname.Location = new System.Drawing.Point(196, 444);
            this.lbShowFullname.Name = "lbShowFullname";
            this.lbShowFullname.Size = new System.Drawing.Size(219, 23);
            this.lbShowFullname.TabIndex = 10;
            this.lbShowFullname.Text = "XXXXXXXX";
            this.lbShowFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbShowPoint
            // 
            this.lbShowPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbShowPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbShowPoint.ForeColor = System.Drawing.Color.Green;
            this.lbShowPoint.Location = new System.Drawing.Point(196, 475);
            this.lbShowPoint.Name = "lbShowPoint";
            this.lbShowPoint.Size = new System.Drawing.Size(219, 23);
            this.lbShowPoint.TabIndex = 11;
            this.lbShowPoint.Text = "XXXXXXXX";
            this.lbShowPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbHead.ForeColor = System.Drawing.Color.Blue;
            this.lbHead.Location = new System.Drawing.Point(137, 9);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(248, 31);
            this.lbHead.TabIndex = 14;
            this.lbHead.Text = "โปรแกรมผลการเรียน";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btClose.Image = global::CShapeWinFormHomwork01.Properties.Resources.exit3;
            this.btClose.Location = new System.Drawing.Point(346, 312);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(82, 78);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "ปิดหน้าจอ";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCancel.Image = global::CShapeWinFormHomwork01.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(213, 312);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(82, 78);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCal.Image = global::CShapeWinFormHomwork01.Properties.Resources.calculator2;
            this.btCal.Location = new System.Drawing.Point(80, 312);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(82, 78);
            this.btCal.TabIndex = 1;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // lbShowGrade
            // 
            this.lbShowGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbShowGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbShowGrade.ForeColor = System.Drawing.Color.Green;
            this.lbShowGrade.Location = new System.Drawing.Point(196, 510);
            this.lbShowGrade.Name = "lbShowGrade";
            this.lbShowGrade.Size = new System.Drawing.Size(219, 23);
            this.lbShowGrade.TabIndex = 16;
            this.lbShowGrade.Text = "XXXXXXXX";
            this.lbShowGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbGrade.Location = new System.Drawing.Point(115, 514);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(36, 15);
            this.lbGrade.TabIndex = 15;
            this.lbGrade.Text = "เกรด";
            // 
            // bt2
            // 
            this.bt2.Enabled = false;
            this.bt2.Location = new System.Drawing.Point(427, 567);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(28, 23);
            this.bt2.TabIndex = 30;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(393, 567);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(28, 23);
            this.bt1.TabIndex = 29;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(461, 567);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(28, 23);
            this.bt3.TabIndex = 28;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(495, 567);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(28, 23);
            this.bt4.TabIndex = 27;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // FrmHomework2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 602);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.lbShowGrade);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.lbHead);
            this.Controls.Add(this.lbShowPoint);
            this.Controls.Add(this.lbShowFullname);
            this.Controls.Add(this.lbShowID);
            this.Controls.Add(this.lbPointTotal);
            this.Controls.Add(this.lbFullname2);
            this.Controls.Add(this.lbIdStu2);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.gbStuData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmHomework2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมการบัาน2";
            this.Load += new System.EventHandler(this.FrmHomework2_Load);
            this.gbStuData.ResumeLayout(false);
            this.gbStuData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStuData;
        private System.Windows.Forms.TextBox tbStuID;
        private System.Windows.Forms.Label lbIdStu;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbMidterm;
        private System.Windows.Forms.TextBox tbCollect;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.TextBox tbMidterm;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbIdStu2;
        private System.Windows.Forms.Label lbFullname2;
        private System.Windows.Forms.Label lbPointTotal;
        private System.Windows.Forms.Label lbShowID;
        private System.Windows.Forms.Label lbShowFullname;
        private System.Windows.Forms.Label lbShowPoint;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Label lbShowGrade;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
    }
}