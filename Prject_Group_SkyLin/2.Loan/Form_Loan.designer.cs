namespace H_0920_Loan
{
    partial class Form_Loan
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
            this.but_clear = new System.Windows.Forms.Button();
            this.But_CALC_Go = new System.Windows.Forms.Button();
            this.Txt_APR = new System.Windows.Forms.TextBox();
            this.Txt_period = new System.Windows.Forms.TextBox();
            this.txt_loanMoney = new System.Windows.Forms.TextBox();
            this.lab_APR = new System.Windows.Forms.Label();
            this.lab_period = new System.Windows.Forms.Label();
            this.lab_loanMoney = new System.Windows.Forms.Label();
            this.lab_interset = new System.Windows.Forms.Label();
            this.txt_interset = new System.Windows.Forms.TextBox();
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_table = new System.Windows.Forms.Label();
            this.ricTxt_Table = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // but_clear
            // 
            this.but_clear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_clear.Location = new System.Drawing.Point(185, 273);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(100, 50);
            this.but_clear.TabIndex = 9;
            this.but_clear.Text = "清除";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // But_CALC_Go
            // 
            this.But_CALC_Go.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.But_CALC_Go.Location = new System.Drawing.Point(43, 273);
            this.But_CALC_Go.Name = "But_CALC_Go";
            this.But_CALC_Go.Size = new System.Drawing.Size(100, 50);
            this.But_CALC_Go.TabIndex = 10;
            this.But_CALC_Go.Text = "計算";
            this.But_CALC_Go.UseVisualStyleBackColor = true;
            this.But_CALC_Go.Click += new System.EventHandler(this.But_CALC_Go_Click);
            // 
            // Txt_APR
            // 
            this.Txt_APR.Location = new System.Drawing.Point(185, 143);
            this.Txt_APR.Name = "Txt_APR";
            this.Txt_APR.Size = new System.Drawing.Size(100, 22);
            this.Txt_APR.TabIndex = 6;
            // 
            // Txt_period
            // 
            this.Txt_period.Location = new System.Drawing.Point(185, 101);
            this.Txt_period.Name = "Txt_period";
            this.Txt_period.Size = new System.Drawing.Size(100, 22);
            this.Txt_period.TabIndex = 7;
            // 
            // txt_loanMoney
            // 
            this.txt_loanMoney.Location = new System.Drawing.Point(185, 61);
            this.txt_loanMoney.Name = "txt_loanMoney";
            this.txt_loanMoney.Size = new System.Drawing.Size(100, 22);
            this.txt_loanMoney.TabIndex = 8;
            // 
            // lab_APR
            // 
            this.lab_APR.AutoSize = true;
            this.lab_APR.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_APR.Location = new System.Drawing.Point(39, 143);
            this.lab_APR.Name = "lab_APR";
            this.lab_APR.Size = new System.Drawing.Size(84, 24);
            this.lab_APR.TabIndex = 3;
            this.lab_APR.Text = "年利率%";
            // 
            // lab_period
            // 
            this.lab_period.AutoSize = true;
            this.lab_period.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_period.Location = new System.Drawing.Point(39, 101);
            this.lab_period.Name = "lab_period";
            this.lab_period.Size = new System.Drawing.Size(119, 24);
            this.lab_period.TabIndex = 4;
            this.lab_period.Text = "貸款期數(月)";
            // 
            // lab_loanMoney
            // 
            this.lab_loanMoney.AutoSize = true;
            this.lab_loanMoney.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_loanMoney.Location = new System.Drawing.Point(39, 60);
            this.lab_loanMoney.Name = "lab_loanMoney";
            this.lab_loanMoney.Size = new System.Drawing.Size(86, 24);
            this.lab_loanMoney.TabIndex = 5;
            this.lab_loanMoney.Text = "貸款金額";
            // 
            // lab_interset
            // 
            this.lab_interset.AutoSize = true;
            this.lab_interset.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_interset.Location = new System.Drawing.Point(39, 183);
            this.lab_interset.Name = "lab_interset";
            this.lab_interset.Size = new System.Drawing.Size(86, 24);
            this.lab_interset.TabIndex = 3;
            this.lab_interset.Text = "全部利息";
            // 
            // txt_interset
            // 
            this.txt_interset.Location = new System.Drawing.Point(185, 183);
            this.txt_interset.Name = "txt_interset";
            this.txt_interset.Size = new System.Drawing.Size(100, 22);
            this.txt_interset.TabIndex = 6;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_title.Location = new System.Drawing.Point(39, 19);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(162, 24);
            this.lab_title.TabIndex = 5;
            this.lab_title.Text = "本金平均攤還計算";
            // 
            // lab_table
            // 
            this.lab_table.AutoSize = true;
            this.lab_table.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_table.Location = new System.Drawing.Point(39, 220);
            this.lab_table.Name = "lab_table";
            this.lab_table.Size = new System.Drawing.Size(186, 24);
            this.lab_table.TabIndex = 3;
            this.lab_table.Text = "每期應繳金額 見右表";
            // 
            // ricTxt_Table
            // 
            this.ricTxt_Table.Location = new System.Drawing.Point(300, 61);
            this.ricTxt_Table.Name = "ricTxt_Table";
            this.ricTxt_Table.Size = new System.Drawing.Size(314, 262);
            this.ricTxt_Table.TabIndex = 11;
            this.ricTxt_Table.Text = "";
            // 
            // Form_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.ricTxt_Table);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.But_CALC_Go);
            this.Controls.Add(this.txt_interset);
            this.Controls.Add(this.Txt_APR);
            this.Controls.Add(this.Txt_period);
            this.Controls.Add(this.lab_table);
            this.Controls.Add(this.lab_interset);
            this.Controls.Add(this.txt_loanMoney);
            this.Controls.Add(this.lab_APR);
            this.Controls.Add(this.lab_period);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.lab_loanMoney);
            this.Name = "Form_Loan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Loan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button But_CALC_Go;
        private System.Windows.Forms.TextBox Txt_APR;
        private System.Windows.Forms.TextBox Txt_period;
        private System.Windows.Forms.TextBox txt_loanMoney;
        private System.Windows.Forms.Label lab_APR;
        private System.Windows.Forms.Label lab_period;
        private System.Windows.Forms.Label lab_loanMoney;
        private System.Windows.Forms.Label lab_interset;
        private System.Windows.Forms.TextBox txt_interset;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_table;
        private System.Windows.Forms.RichTextBox ricTxt_Table;
    }
}

