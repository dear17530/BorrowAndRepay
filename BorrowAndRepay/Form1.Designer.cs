namespace BorrowAndRepay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.myNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.friendNameInput = new System.Windows.Forms.TextBox();
            this.checkName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.myMoneyLabel = new System.Windows.Forms.Label();
            this.friendMoneyLabel = new System.Windows.Forms.Label();
            this.friendNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.repayBtn = new System.Windows.Forms.Button();
            this.friendRepayBtn = new System.Windows.Forms.Button();
            this.friendBorrowBtn = new System.Windows.Forms.Button();
            this.myLiabilityLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.friendLiabilityLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.borrowAmount = new System.Windows.Forms.NumericUpDown();
            this.repayAmount = new System.Windows.Forms.NumericUpDown();
            this.friendBorrowAmount = new System.Windows.Forms.NumericUpDown();
            this.friendRepayAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.borrowAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repayAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendBorrowAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendRepayAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "我的名字:";
            // 
            // myNameInput
            // 
            this.myNameInput.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNameInput.Location = new System.Drawing.Point(233, 27);
            this.myNameInput.Name = "myNameInput";
            this.myNameInput.Size = new System.Drawing.Size(103, 41);
            this.myNameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "朋友的名字:";
            // 
            // friendNameInput
            // 
            this.friendNameInput.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendNameInput.Location = new System.Drawing.Point(233, 97);
            this.friendNameInput.Name = "friendNameInput";
            this.friendNameInput.Size = new System.Drawing.Size(103, 41);
            this.friendNameInput.TabIndex = 3;
            // 
            // checkName
            // 
            this.checkName.Font = new System.Drawing.Font("新細明體", 14F);
            this.checkName.Location = new System.Drawing.Point(393, 27);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(250, 111);
            this.checkName.TabIndex = 4;
            this.checkName.Text = "確定";
            this.checkName.UseVisualStyleBackColor = true;
            this.checkName.Click += new System.EventHandler(this.checkName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(42, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的名字:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(42, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "我的$$:";
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNameLabel.Location = new System.Drawing.Point(228, 183);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(69, 28);
            this.myNameLabel.TabIndex = 7;
            this.myNameLabel.Text = "OOO";
            // 
            // myMoneyLabel
            // 
            this.myMoneyLabel.AutoSize = true;
            this.myMoneyLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myMoneyLabel.Location = new System.Drawing.Point(228, 240);
            this.myMoneyLabel.Name = "myMoneyLabel";
            this.myMoneyLabel.Size = new System.Drawing.Size(64, 28);
            this.myMoneyLabel.TabIndex = 8;
            this.myMoneyLabel.Text = "1000";
            // 
            // friendMoneyLabel
            // 
            this.friendMoneyLabel.AutoSize = true;
            this.friendMoneyLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendMoneyLabel.Location = new System.Drawing.Point(574, 243);
            this.friendMoneyLabel.Name = "friendMoneyLabel";
            this.friendMoneyLabel.Size = new System.Drawing.Size(77, 28);
            this.friendMoneyLabel.TabIndex = 12;
            this.friendMoneyLabel.Text = "20000";
            // 
            // friendNameLabel
            // 
            this.friendNameLabel.AutoSize = true;
            this.friendNameLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendNameLabel.Location = new System.Drawing.Point(574, 186);
            this.friendNameLabel.Name = "friendNameLabel";
            this.friendNameLabel.Size = new System.Drawing.Size(69, 28);
            this.friendNameLabel.TabIndex = 11;
            this.friendNameLabel.Text = "XXX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(388, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "朋友的$$:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(388, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 28);
            this.label10.TabIndex = 9;
            this.label10.Text = "朋友的名字:";
            // 
            // borrowBtn
            // 
            this.borrowBtn.Enabled = false;
            this.borrowBtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.borrowBtn.Location = new System.Drawing.Point(47, 365);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(412, 50);
            this.borrowBtn.TabIndex = 13;
            this.borrowBtn.Text = "跟 XXX 借 1000 $";
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // repayBtn
            // 
            this.repayBtn.Enabled = false;
            this.repayBtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.repayBtn.Location = new System.Drawing.Point(47, 426);
            this.repayBtn.Name = "repayBtn";
            this.repayBtn.Size = new System.Drawing.Size(412, 50);
            this.repayBtn.TabIndex = 14;
            this.repayBtn.Text = "還給 XXX 1000 $";
            this.repayBtn.UseVisualStyleBackColor = true;
            this.repayBtn.Click += new System.EventHandler(this.repayBtn_Click);
            // 
            // friendRepayBtn
            // 
            this.friendRepayBtn.Enabled = false;
            this.friendRepayBtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.friendRepayBtn.Location = new System.Drawing.Point(478, 426);
            this.friendRepayBtn.Name = "friendRepayBtn";
            this.friendRepayBtn.Size = new System.Drawing.Size(412, 50);
            this.friendRepayBtn.TabIndex = 16;
            this.friendRepayBtn.Text = "還給 OOO 1000 $";
            this.friendRepayBtn.UseVisualStyleBackColor = true;
            this.friendRepayBtn.Click += new System.EventHandler(this.friendRepayBtn_Click);
            // 
            // friendBorrowBtn
            // 
            this.friendBorrowBtn.Enabled = false;
            this.friendBorrowBtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.friendBorrowBtn.Location = new System.Drawing.Point(478, 365);
            this.friendBorrowBtn.Name = "friendBorrowBtn";
            this.friendBorrowBtn.Size = new System.Drawing.Size(412, 50);
            this.friendBorrowBtn.TabIndex = 15;
            this.friendBorrowBtn.Text = "跟 OOO 借 1000 $";
            this.friendBorrowBtn.UseVisualStyleBackColor = true;
            this.friendBorrowBtn.Click += new System.EventHandler(this.friendBorrowBtn_Click);
            // 
            // myLiabilityLabel
            // 
            this.myLiabilityLabel.AutoSize = true;
            this.myLiabilityLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myLiabilityLabel.Location = new System.Drawing.Point(228, 298);
            this.myLiabilityLabel.Name = "myLiabilityLabel";
            this.myLiabilityLabel.Size = new System.Drawing.Size(25, 28);
            this.myLiabilityLabel.TabIndex = 18;
            this.myLiabilityLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(42, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "目前一共借了:";
            // 
            // friendLiabilityLabel
            // 
            this.friendLiabilityLabel.AutoSize = true;
            this.friendLiabilityLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendLiabilityLabel.Location = new System.Drawing.Point(574, 298);
            this.friendLiabilityLabel.Name = "friendLiabilityLabel";
            this.friendLiabilityLabel.Size = new System.Drawing.Size(25, 28);
            this.friendLiabilityLabel.TabIndex = 20;
            this.friendLiabilityLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(388, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "目前一共借了:";
            // 
            // borrowAmount
            // 
            this.borrowAmount.Enabled = false;
            this.borrowAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.borrowAmount.Location = new System.Drawing.Point(283, 376);
            this.borrowAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.borrowAmount.Name = "borrowAmount";
            this.borrowAmount.Size = new System.Drawing.Size(119, 29);
            this.borrowAmount.TabIndex = 21;
            this.borrowAmount.Tag = "";
            this.borrowAmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.borrowAmount.ValueChanged += new System.EventHandler(this.borrowAmount_ValueChanged);
            // 
            // repayAmount
            // 
            this.repayAmount.Enabled = false;
            this.repayAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.repayAmount.Location = new System.Drawing.Point(282, 437);
            this.repayAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.repayAmount.Name = "repayAmount";
            this.repayAmount.Size = new System.Drawing.Size(119, 29);
            this.repayAmount.TabIndex = 22;
            this.repayAmount.Tag = "";
            this.repayAmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.repayAmount.ValueChanged += new System.EventHandler(this.repayAmount_ValueChanged);
            // 
            // friendBorrowAmount
            // 
            this.friendBorrowAmount.Enabled = false;
            this.friendBorrowAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.friendBorrowAmount.Location = new System.Drawing.Point(713, 376);
            this.friendBorrowAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.friendBorrowAmount.Name = "friendBorrowAmount";
            this.friendBorrowAmount.Size = new System.Drawing.Size(119, 29);
            this.friendBorrowAmount.TabIndex = 23;
            this.friendBorrowAmount.Tag = "";
            this.friendBorrowAmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.friendBorrowAmount.ValueChanged += new System.EventHandler(this.friendBorrowAmount_ValueChanged);
            // 
            // friendRepayAmount
            // 
            this.friendRepayAmount.Enabled = false;
            this.friendRepayAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.friendRepayAmount.Location = new System.Drawing.Point(713, 437);
            this.friendRepayAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.friendRepayAmount.Name = "friendRepayAmount";
            this.friendRepayAmount.Size = new System.Drawing.Size(119, 29);
            this.friendRepayAmount.TabIndex = 24;
            this.friendRepayAmount.Tag = "";
            this.friendRepayAmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.friendRepayAmount.ValueChanged += new System.EventHandler(this.friendRepayAmount_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 524);
            this.Controls.Add(this.friendRepayAmount);
            this.Controls.Add(this.friendBorrowAmount);
            this.Controls.Add(this.repayAmount);
            this.Controls.Add(this.borrowAmount);
            this.Controls.Add(this.friendLiabilityLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.myLiabilityLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.friendRepayBtn);
            this.Controls.Add(this.friendBorrowBtn);
            this.Controls.Add(this.repayBtn);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.friendMoneyLabel);
            this.Controls.Add(this.friendNameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.myMoneyLabel);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkName);
            this.Controls.Add(this.friendNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myNameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "借錢還錢程式";
            ((System.ComponentModel.ISupportInitialize)(this.borrowAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repayAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendBorrowAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendRepayAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox friendNameInput;
        private System.Windows.Forms.Button checkName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label myMoneyLabel;
        private System.Windows.Forms.Label friendMoneyLabel;
        private System.Windows.Forms.Label friendNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Button repayBtn;
        private System.Windows.Forms.Button friendRepayBtn;
        private System.Windows.Forms.Button friendBorrowBtn;
        private System.Windows.Forms.Label myLiabilityLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label friendLiabilityLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown borrowAmount;
        private System.Windows.Forms.NumericUpDown repayAmount;
        private System.Windows.Forms.NumericUpDown friendBorrowAmount;
        private System.Windows.Forms.NumericUpDown friendRepayAmount;
    }
}

