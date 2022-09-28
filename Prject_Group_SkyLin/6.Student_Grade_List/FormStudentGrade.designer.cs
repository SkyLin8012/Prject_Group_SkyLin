namespace H0923_StudentsGrade_List
{
    partial class Form_StudentsGrade
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
            this.btn_InsetGrade = new System.Windows.Forms.Button();
            this.btn_AddGrade = new System.Windows.Forms.Button();
            this.txt_MathValue = new System.Windows.Forms.TextBox();
            this.lab_Math = new System.Windows.Forms.Label();
            this.txt_EngValue = new System.Windows.Forms.TextBox();
            this.lab_English = new System.Windows.Forms.Label();
            this.txt_ChiValue = new System.Windows.Forms.TextBox();
            this.lab_Chines = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.richTxt_BigMoniter = new System.Windows.Forms.RichTextBox();
            this.richtxt_show_Analysisscorce = new System.Windows.Forms.RichTextBox();
            this.richTxt_ShowScore = new System.Windows.Forms.RichTextBox();
            this.btn_RemoveGrade = new System.Windows.Forms.Button();
            this.btn_ClearGrade = new System.Windows.Forms.Button();
            this.btn_Analisys_Score = new System.Windows.Forms.Button();
            this.txt_Low = new System.Windows.Forms.TextBox();
            this.txt_top = new System.Windows.Forms.TextBox();
            this.lab_search_title = new System.Windows.Forms.Label();
            this.lab_search_icon01 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.Panel_stu_val = new System.Windows.Forms.Panel();
            this.Panel_stu_val.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_InsetGrade
            // 
            this.btn_InsetGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_InsetGrade.Location = new System.Drawing.Point(35, 238);
            this.btn_InsetGrade.Name = "btn_InsetGrade";
            this.btn_InsetGrade.Size = new System.Drawing.Size(120, 32);
            this.btn_InsetGrade.TabIndex = 13;
            this.btn_InsetGrade.Text = "插入儲存資料";
            this.btn_InsetGrade.UseVisualStyleBackColor = true;
            this.btn_InsetGrade.Click += new System.EventHandler(this.btn_InsetGrade_Click);
            // 
            // btn_AddGrade
            // 
            this.btn_AddGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddGrade.Location = new System.Drawing.Point(35, 200);
            this.btn_AddGrade.Name = "btn_AddGrade";
            this.btn_AddGrade.Size = new System.Drawing.Size(120, 32);
            this.btn_AddGrade.TabIndex = 14;
            this.btn_AddGrade.Text = "加入學生資料";
            this.btn_AddGrade.UseVisualStyleBackColor = true;
            this.btn_AddGrade.Click += new System.EventHandler(this.btn_AddGrade_Click);
            // 
            // txt_MathValue
            // 
            this.txt_MathValue.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_MathValue.Location = new System.Drawing.Point(0, 134);
            this.txt_MathValue.Name = "txt_MathValue";
            this.txt_MathValue.Size = new System.Drawing.Size(85, 30);
            this.txt_MathValue.TabIndex = 8;
            // 
            // lab_Math
            // 
            this.lab_Math.AutoSize = true;
            this.lab_Math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Math.Location = new System.Drawing.Point(12, 152);
            this.lab_Math.Name = "lab_Math";
            this.lab_Math.Size = new System.Drawing.Size(52, 24);
            this.lab_Math.TabIndex = 4;
            this.lab_Math.Text = "數學:";
            // 
            // txt_EngValue
            // 
            this.txt_EngValue.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_EngValue.Location = new System.Drawing.Point(0, 89);
            this.txt_EngValue.Name = "txt_EngValue";
            this.txt_EngValue.Size = new System.Drawing.Size(85, 30);
            this.txt_EngValue.TabIndex = 9;
            // 
            // lab_English
            // 
            this.lab_English.AutoSize = true;
            this.lab_English.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_English.Location = new System.Drawing.Point(12, 107);
            this.lab_English.Name = "lab_English";
            this.lab_English.Size = new System.Drawing.Size(52, 24);
            this.lab_English.TabIndex = 5;
            this.lab_English.Text = "英文:";
            // 
            // txt_ChiValue
            // 
            this.txt_ChiValue.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ChiValue.Location = new System.Drawing.Point(0, 46);
            this.txt_ChiValue.Name = "txt_ChiValue";
            this.txt_ChiValue.Size = new System.Drawing.Size(85, 30);
            this.txt_ChiValue.TabIndex = 10;
            // 
            // lab_Chines
            // 
            this.lab_Chines.AutoSize = true;
            this.lab_Chines.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Chines.Location = new System.Drawing.Point(12, 64);
            this.lab_Chines.Name = "lab_Chines";
            this.lab_Chines.Size = new System.Drawing.Size(52, 24);
            this.lab_Chines.TabIndex = 6;
            this.lab_Chines.Text = "國文:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(0, 1);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(85, 30);
            this.txt_Name.TabIndex = 11;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Name.Location = new System.Drawing.Point(12, 18);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(52, 24);
            this.lab_Name.TabIndex = 7;
            this.lab_Name.Text = "姓名:";
            // 
            // richTxt_BigMoniter
            // 
            this.richTxt_BigMoniter.BackColor = System.Drawing.Color.Gainsboro;
            this.richTxt_BigMoniter.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTxt_BigMoniter.Location = new System.Drawing.Point(176, 18);
            this.richTxt_BigMoniter.Name = "richTxt_BigMoniter";
            this.richTxt_BigMoniter.ReadOnly = true;
            this.richTxt_BigMoniter.Size = new System.Drawing.Size(431, 329);
            this.richTxt_BigMoniter.TabIndex = 0;
            this.richTxt_BigMoniter.Text = "  姓名   國文  英文  數學    總分   平均   最低    最高";
            // 
            // richtxt_show_Analysisscorce
            // 
            this.richtxt_show_Analysisscorce.BackColor = System.Drawing.Color.Gainsboro;
            this.richtxt_show_Analysisscorce.Location = new System.Drawing.Point(176, 353);
            this.richtxt_show_Analysisscorce.Name = "richtxt_show_Analysisscorce";
            this.richtxt_show_Analysisscorce.ReadOnly = true;
            this.richtxt_show_Analysisscorce.Size = new System.Drawing.Size(431, 82);
            this.richtxt_show_Analysisscorce.TabIndex = 0;
            this.richtxt_show_Analysisscorce.Text = "";
            // 
            // richTxt_ShowScore
            // 
            this.richTxt_ShowScore.BackColor = System.Drawing.Color.Gainsboro;
            this.richTxt_ShowScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxt_ShowScore.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTxt_ShowScore.ForeColor = System.Drawing.Color.Black;
            this.richTxt_ShowScore.Location = new System.Drawing.Point(191, 42);
            this.richTxt_ShowScore.Name = "richTxt_ShowScore";
            this.richTxt_ShowScore.ReadOnly = true;
            this.richTxt_ShowScore.Size = new System.Drawing.Size(401, 292);
            this.richTxt_ShowScore.TabIndex = 15;
            this.richTxt_ShowScore.Text = "";
            // 
            // btn_RemoveGrade
            // 
            this.btn_RemoveGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_RemoveGrade.Location = new System.Drawing.Point(35, 276);
            this.btn_RemoveGrade.Name = "btn_RemoveGrade";
            this.btn_RemoveGrade.Size = new System.Drawing.Size(120, 32);
            this.btn_RemoveGrade.TabIndex = 13;
            this.btn_RemoveGrade.Text = "移除儲存資料";
            this.btn_RemoveGrade.UseVisualStyleBackColor = true;
            this.btn_RemoveGrade.Click += new System.EventHandler(this.btn_RemoveGrade_Click);
            // 
            // btn_ClearGrade
            // 
            this.btn_ClearGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ClearGrade.Location = new System.Drawing.Point(35, 315);
            this.btn_ClearGrade.Name = "btn_ClearGrade";
            this.btn_ClearGrade.Size = new System.Drawing.Size(120, 32);
            this.btn_ClearGrade.TabIndex = 13;
            this.btn_ClearGrade.Text = "清除所有資料";
            this.btn_ClearGrade.UseVisualStyleBackColor = true;
            this.btn_ClearGrade.Click += new System.EventHandler(this.btn_ClearGrade_Click);
            // 
            // btn_Analisys_Score
            // 
            this.btn_Analisys_Score.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Analisys_Score.Location = new System.Drawing.Point(487, 441);
            this.btn_Analisys_Score.Name = "btn_Analisys_Score";
            this.btn_Analisys_Score.Size = new System.Drawing.Size(120, 40);
            this.btn_Analisys_Score.TabIndex = 13;
            this.btn_Analisys_Score.Text = "各科統計";
            this.btn_Analisys_Score.UseVisualStyleBackColor = true;
            this.btn_Analisys_Score.Click += new System.EventHandler(this.btn_Analisys_Score_Click);
            // 
            // txt_Low
            // 
            this.txt_Low.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Low.Location = new System.Drawing.Point(17, 389);
            this.txt_Low.Name = "txt_Low";
            this.txt_Low.Size = new System.Drawing.Size(54, 30);
            this.txt_Low.TabIndex = 8;
            // 
            // txt_top
            // 
            this.txt_top.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_top.Location = new System.Drawing.Point(102, 389);
            this.txt_top.Name = "txt_top";
            this.txt_top.Size = new System.Drawing.Size(54, 30);
            this.txt_top.TabIndex = 8;
            // 
            // lab_search_title
            // 
            this.lab_search_title.AutoSize = true;
            this.lab_search_title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_search_title.Location = new System.Drawing.Point(19, 353);
            this.lab_search_title.Name = "lab_search_title";
            this.lab_search_title.Size = new System.Drawing.Size(137, 20);
            this.lab_search_title.TabIndex = 4;
            this.lab_search_title.Text = "搜尋國文成績範圍";
            // 
            // lab_search_icon01
            // 
            this.lab_search_icon01.AutoSize = true;
            this.lab_search_icon01.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_search_icon01.Location = new System.Drawing.Point(77, 389);
            this.lab_search_icon01.Name = "lab_search_icon01";
            this.lab_search_icon01.Size = new System.Drawing.Size(18, 24);
            this.lab_search_icon01.TabIndex = 4;
            this.lab_search_icon01.Text = "-";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search.Location = new System.Drawing.Point(36, 441);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(120, 40);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.Text = "搜尋資料";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Panel_stu_val
            // 
            this.Panel_stu_val.Controls.Add(this.txt_Name);
            this.Panel_stu_val.Controls.Add(this.txt_ChiValue);
            this.Panel_stu_val.Controls.Add(this.txt_EngValue);
            this.Panel_stu_val.Controls.Add(this.txt_MathValue);
            this.Panel_stu_val.Location = new System.Drawing.Point(67, 18);
            this.Panel_stu_val.Name = "Panel_stu_val";
            this.Panel_stu_val.Size = new System.Drawing.Size(103, 170);
            this.Panel_stu_val.TabIndex = 16;
            // 
            // Form_StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 490);
            this.Controls.Add(this.Panel_stu_val);
            this.Controls.Add(this.richTxt_ShowScore);
            this.Controls.Add(this.richtxt_show_Analysisscorce);
            this.Controls.Add(this.richTxt_BigMoniter);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Analisys_Score);
            this.Controls.Add(this.btn_ClearGrade);
            this.Controls.Add(this.btn_RemoveGrade);
            this.Controls.Add(this.btn_InsetGrade);
            this.Controls.Add(this.btn_AddGrade);
            this.Controls.Add(this.txt_top);
            this.Controls.Add(this.txt_Low);
            this.Controls.Add(this.lab_search_icon01);
            this.Controls.Add(this.lab_search_title);
            this.Controls.Add(this.lab_Math);
            this.Controls.Add(this.lab_English);
            this.Controls.Add(this.lab_Chines);
            this.Controls.Add(this.lab_Name);
            this.Name = "Form_StudentsGrade";
            this.Text = "StudentsGrade";
            this.Panel_stu_val.ResumeLayout(false);
            this.Panel_stu_val.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InsetGrade;
        private System.Windows.Forms.Button btn_AddGrade;
        private System.Windows.Forms.TextBox txt_MathValue;
        private System.Windows.Forms.Label lab_Math;
        private System.Windows.Forms.TextBox txt_EngValue;
        private System.Windows.Forms.Label lab_English;
        private System.Windows.Forms.TextBox txt_ChiValue;
        private System.Windows.Forms.Label lab_Chines;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.RichTextBox richTxt_BigMoniter;
        private System.Windows.Forms.RichTextBox richtxt_show_Analysisscorce;
        private System.Windows.Forms.RichTextBox richTxt_ShowScore;
        private System.Windows.Forms.Button btn_RemoveGrade;
        private System.Windows.Forms.Button btn_ClearGrade;
        private System.Windows.Forms.Button btn_Analisys_Score;
        private System.Windows.Forms.TextBox txt_Low;
        private System.Windows.Forms.TextBox txt_top;
        private System.Windows.Forms.Label lab_search_title;
        private System.Windows.Forms.Label lab_search_icon01;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel Panel_stu_val;
    }
}

