﻿namespace CShapeWinFormHomwork01
{
    partial class FrmHomework3
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
            this.lbHead = new System.Windows.Forms.Label();
            this.tbAmountPeople = new System.Windows.Forms.TextBox();
            this.lbAmoutPeople = new System.Windows.Forms.Label();
            this.tbAmountMoney = new System.Windows.Forms.TextBox();
            this.lbAmountMoney = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.lbDivideby = new System.Windows.Forms.Label();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.lbBaht = new System.Windows.Forms.Label();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbHead.ForeColor = System.Drawing.Color.Blue;
            this.lbHead.Location = new System.Drawing.Point(131, 22);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(335, 31);
            this.lbHead.TabIndex = 1;
            this.lbHead.Text = "โปรแกรม American Share";
            // 
            // tbAmountPeople
            // 
            this.tbAmountPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAmountPeople.Location = new System.Drawing.Point(256, 109);
            this.tbAmountPeople.Name = "tbAmountPeople";
            this.tbAmountPeople.Size = new System.Drawing.Size(186, 20);
            this.tbAmountPeople.TabIndex = 7;
            this.tbAmountPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmountPeople_KeyPress);
            // 
            // lbAmoutPeople
            // 
            this.lbAmoutPeople.AutoSize = true;
            this.lbAmoutPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAmoutPeople.Location = new System.Drawing.Point(138, 110);
            this.lbAmoutPeople.Name = "lbAmoutPeople";
            this.lbAmoutPeople.Size = new System.Drawing.Size(104, 15);
            this.lbAmoutPeople.TabIndex = 6;
            this.lbAmoutPeople.Text = "จำนวนคนที่จะหาร";
            // 
            // tbAmountMoney
            // 
            this.tbAmountMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAmountMoney.Location = new System.Drawing.Point(256, 71);
            this.tbAmountMoney.Name = "tbAmountMoney";
            this.tbAmountMoney.Size = new System.Drawing.Size(186, 20);
            this.tbAmountMoney.TabIndex = 5;
            this.tbAmountMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmountMoney_KeyPress);
            // 
            // lbAmountMoney
            // 
            this.lbAmountMoney.AutoSize = true;
            this.lbAmountMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAmountMoney.Location = new System.Drawing.Point(134, 71);
            this.lbAmountMoney.Name = "lbAmountMoney";
            this.lbAmountMoney.Size = new System.Drawing.Size(108, 15);
            this.lbAmountMoney.TabIndex = 4;
            this.lbAmountMoney.Text = "จำนวนเงินที่จะหาร";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btClose.Image = global::CShapeWinFormHomwork01.Properties.Resources.exit3;
            this.btClose.Location = new System.Drawing.Point(305, 158);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(82, 78);
            this.btClose.TabIndex = 10;
            this.btClose.Text = "ปิดหน้าจอ";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCal.Image = global::CShapeWinFormHomwork01.Properties.Resources.calculator2;
            this.btCal.Location = new System.Drawing.Point(184, 158);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(82, 78);
            this.btCal.TabIndex = 8;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // lbDivideby
            // 
            this.lbDivideby.AutoSize = true;
            this.lbDivideby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbDivideby.Location = new System.Drawing.Point(92, 295);
            this.lbDivideby.Name = "lbDivideby";
            this.lbDivideby.Size = new System.Drawing.Size(58, 15);
            this.lbDivideby.TabIndex = 11;
            this.lbDivideby.Text = "หารคนละ";
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbShowResult.ForeColor = System.Drawing.Color.Red;
            this.lbShowResult.Location = new System.Drawing.Point(195, 270);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(192, 58);
            this.lbShowResult.TabIndex = 12;
            this.lbShowResult.Text = "XX.XX";
            this.lbShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBaht
            // 
            this.lbBaht.AutoSize = true;
            this.lbBaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbBaht.Location = new System.Drawing.Point(444, 295);
            this.lbBaht.Name = "lbBaht";
            this.lbBaht.Size = new System.Drawing.Size(29, 15);
            this.lbBaht.TabIndex = 13;
            this.lbBaht.Text = "บาท";
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(488, 410);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(28, 23);
            this.bt2.TabIndex = 30;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(454, 410);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(28, 23);
            this.bt1.TabIndex = 29;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt3
            // 
            this.bt3.Enabled = false;
            this.bt3.Location = new System.Drawing.Point(522, 410);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(28, 23);
            this.bt3.TabIndex = 28;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(556, 410);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(28, 23);
            this.bt4.TabIndex = 27;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // FrmHomework3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 445);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.lbBaht);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.lbDivideby);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.tbAmountPeople);
            this.Controls.Add(this.lbAmoutPeople);
            this.Controls.Add(this.tbAmountMoney);
            this.Controls.Add(this.lbAmountMoney);
            this.Controls.Add(this.lbHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmHomework3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมการบัาน3";
            this.Load += new System.EventHandler(this.FrmHomework3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.TextBox tbAmountPeople;
        private System.Windows.Forms.Label lbAmoutPeople;
        private System.Windows.Forms.TextBox tbAmountMoney;
        private System.Windows.Forms.Label lbAmountMoney;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Label lbDivideby;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.Label lbBaht;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
    }
}