namespace H_0922_Student_StrucForm
{
    partial class StudentForm
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
            this.lab_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_Chines = new System.Windows.Forms.Label();
            this.txt_ChiValue = new System.Windows.Forms.TextBox();
            this.lab_English = new System.Windows.Forms.Label();
            this.txt_EngValue = new System.Windows.Forms.TextBox();
            this.lab_Math = new System.Windows.Forms.Label();
            this.txt_MathValue = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_show_Save = new System.Windows.Forms.Button();
            this.groB_Score = new System.Windows.Forms.GroupBox();
            this.richtxt_show_Analysisscorce = new System.Windows.Forms.RichTextBox();
            this.richtxt_scorManu = new System.Windows.Forms.RichTextBox();
            this.btn_Analysis_scorce = new System.Windows.Forms.Button();
            this.groB_Score.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Name.Location = new System.Drawing.Point(51, 45);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(59, 27);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Text = "姓名:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(109, 43);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(131, 33);
            this.txt_Name.TabIndex = 1;
            // 
            // lab_Chines
            // 
            this.lab_Chines.AutoSize = true;
            this.lab_Chines.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Chines.Location = new System.Drawing.Point(51, 96);
            this.lab_Chines.Name = "lab_Chines";
            this.lab_Chines.Size = new System.Drawing.Size(59, 27);
            this.lab_Chines.TabIndex = 0;
            this.lab_Chines.Text = "國文:";
            // 
            // txt_ChiValue
            // 
            this.txt_ChiValue.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ChiValue.Location = new System.Drawing.Point(109, 94);
            this.txt_ChiValue.Name = "txt_ChiValue";
            this.txt_ChiValue.Size = new System.Drawing.Size(131, 33);
            this.txt_ChiValue.TabIndex = 1;
            // 
            // lab_English
            // 
            this.lab_English.AutoSize = true;
            this.lab_English.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_English.Location = new System.Drawing.Point(51, 149);
            this.lab_English.Name = "lab_English";
            this.lab_English.Size = new System.Drawing.Size(59, 27);
            this.lab_English.TabIndex = 0;
            this.lab_English.Text = "英文:";
            // 
            // txt_EngValue
            // 
            this.txt_EngValue.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_EngValue.Location = new System.Drawing.Point(109, 147);
            this.txt_EngValue.Name = "txt_EngValue";
            this.txt_EngValue.Size = new System.Drawing.Size(131, 33);
            this.txt_EngValue.TabIndex = 1;
            // 
            // lab_Math
            // 
            this.lab_Math.AutoSize = true;
            this.lab_Math.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Math.Location = new System.Drawing.Point(51, 201);
            this.lab_Math.Name = "lab_Math";
            this.lab_Math.Size = new System.Drawing.Size(59, 27);
            this.lab_Math.TabIndex = 0;
            this.lab_Math.Text = "數學:";
            // 
            // txt_MathValue
            // 
            this.txt_MathValue.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_MathValue.Location = new System.Drawing.Point(109, 199);
            this.txt_MathValue.Name = "txt_MathValue";
            this.txt_MathValue.Size = new System.Drawing.Size(131, 33);
            this.txt_MathValue.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(59, 280);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 40);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_show_Save
            // 
            this.btn_show_Save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_show_Save.Location = new System.Drawing.Point(185, 280);
            this.btn_show_Save.Name = "btn_show_Save";
            this.btn_show_Save.Size = new System.Drawing.Size(120, 40);
            this.btn_show_Save.TabIndex = 2;
            this.btn_show_Save.Text = "顯示儲存內容";
            this.btn_show_Save.UseVisualStyleBackColor = true;
            this.btn_show_Save.Click += new System.EventHandler(this.btn_show_Save_Click);
            // 
            // groB_Score
            // 
            this.groB_Score.Controls.Add(this.richtxt_show_Analysisscorce);
            this.groB_Score.Controls.Add(this.richtxt_scorManu);
            this.groB_Score.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groB_Score.Location = new System.Drawing.Point(311, 22);
            this.groB_Score.Name = "groB_Score";
            this.groB_Score.Size = new System.Drawing.Size(271, 313);
            this.groB_Score.TabIndex = 3;
            this.groB_Score.TabStop = false;
            this.groB_Score.Text = "成績";
            // 
            // richtxt_show_Analysisscorce
            // 
            this.richtxt_show_Analysisscorce.BackColor = System.Drawing.Color.Gainsboro;
            this.richtxt_show_Analysisscorce.Location = new System.Drawing.Point(6, 198);
            this.richtxt_show_Analysisscorce.Name = "richtxt_show_Analysisscorce";
            this.richtxt_show_Analysisscorce.ReadOnly = true;
            this.richtxt_show_Analysisscorce.Size = new System.Drawing.Size(250, 109);
            this.richtxt_show_Analysisscorce.TabIndex = 0;
            this.richtxt_show_Analysisscorce.Text = "";
            // 
            // richtxt_scorManu
            // 
            this.richtxt_scorManu.BackColor = System.Drawing.Color.Gainsboro;
            this.richtxt_scorManu.Location = new System.Drawing.Point(6, 32);
            this.richtxt_scorManu.Name = "richtxt_scorManu";
            this.richtxt_scorManu.ReadOnly = true;
            this.richtxt_scorManu.Size = new System.Drawing.Size(250, 161);
            this.richtxt_scorManu.TabIndex = 0;
            this.richtxt_scorManu.Text = "";
            // 
            // btn_Analysis_scorce
            // 
            this.btn_Analysis_scorce.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Analysis_scorce.Location = new System.Drawing.Point(375, 341);
            this.btn_Analysis_scorce.Name = "btn_Analysis_scorce";
            this.btn_Analysis_scorce.Size = new System.Drawing.Size(192, 40);
            this.btn_Analysis_scorce.TabIndex = 2;
            this.btn_Analysis_scorce.Text = "最高分/最低分科目";
            this.btn_Analysis_scorce.UseVisualStyleBackColor = true;
            this.btn_Analysis_scorce.Click += new System.EventHandler(this.btn_Analysis_scorce_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 401);
            this.Controls.Add(this.groB_Score);
            this.Controls.Add(this.btn_Analysis_scorce);
            this.Controls.Add(this.btn_show_Save);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_MathValue);
            this.Controls.Add(this.lab_Math);
            this.Controls.Add(this.txt_EngValue);
            this.Controls.Add(this.lab_English);
            this.Controls.Add(this.txt_ChiValue);
            this.Controls.Add(this.lab_Chines);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lab_Name);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.groB_Score.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_Chines;
        private System.Windows.Forms.TextBox txt_ChiValue;
        private System.Windows.Forms.Label lab_English;
        private System.Windows.Forms.TextBox txt_EngValue;
        private System.Windows.Forms.Label lab_Math;
        private System.Windows.Forms.TextBox txt_MathValue;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_show_Save;
        private System.Windows.Forms.GroupBox groB_Score;
        private System.Windows.Forms.Button btn_Analysis_scorce;
        private System.Windows.Forms.RichTextBox richtxt_show_Analysisscorce;
        private System.Windows.Forms.RichTextBox richtxt_scorManu;
    }
}

