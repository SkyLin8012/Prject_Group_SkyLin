namespace Prject_Group_SkyLin
{
    partial class Form_Meun_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Meun_UI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_show_Hello = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.btn_Loan = new System.Windows.Forms.Button();
            this.btn_POS = new System.Windows.Forms.Button();
            this.btn_Student_Struce = new System.Windows.Forms.Button();
            this.btn_StudentGrade_list = new System.Windows.Forms.Button();
            this.btn_MyClac = new System.Windows.Forms.Button();
            this.btn_ForDoWhile = new System.Windows.Forms.Button();
            this.btn_XOGame = new System.Windows.Forms.Button();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.btn_Alarm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.label_title);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 729);
            this.splitContainer1.SplitterDistance = 104;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Gold;
            this.splitContainer2.Panel1.Controls.Add(this.btn_Alarm);
            this.splitContainer2.Panel1.Controls.Add(this.btn_Guess);
            this.splitContainer2.Panel1.Controls.Add(this.btn_XOGame);
            this.splitContainer2.Panel1.Controls.Add(this.btn_ForDoWhile);
            this.splitContainer2.Panel1.Controls.Add(this.btn_MyClac);
            this.splitContainer2.Panel1.Controls.Add(this.btn_StudentGrade_list);
            this.splitContainer2.Panel1.Controls.Add(this.btn_Student_Struce);
            this.splitContainer2.Panel1.Controls.Add(this.btn_POS);
            this.splitContainer2.Panel1.Controls.Add(this.btn_Loan);
            this.splitContainer2.Panel1.Controls.Add(this.btn_show_Hello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Gold;
            this.splitContainer2.Size = new System.Drawing.Size(1008, 621);
            this.splitContainer2.SplitterDistance = 169;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_show_Hello
            // 
            this.btn_show_Hello.Location = new System.Drawing.Point(12, 16);
            this.btn_show_Hello.Name = "btn_show_Hello";
            this.btn_show_Hello.Size = new System.Drawing.Size(144, 23);
            this.btn_show_Hello.TabIndex = 0;
            this.btn_show_Hello.Text = "H0919_Hello";
            this.btn_show_Hello.UseVisualStyleBackColor = true;
            this.btn_show_Hello.Click += new System.EventHandler(this.btn_show_Hello_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_title.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_title.Location = new System.Drawing.Point(69, 31);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(97, 24);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "C# 小品集";
            // 
            // btn_Loan
            // 
            this.btn_Loan.Location = new System.Drawing.Point(12, 45);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(144, 23);
            this.btn_Loan.TabIndex = 0;
            this.btn_Loan.Text = "0920_Loan";
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // btn_POS
            // 
            this.btn_POS.Location = new System.Drawing.Point(12, 74);
            this.btn_POS.Name = "btn_POS";
            this.btn_POS.Size = new System.Drawing.Size(144, 23);
            this.btn_POS.TabIndex = 0;
            this.btn_POS.Text = "0921_POS";
            this.btn_POS.UseVisualStyleBackColor = true;
            this.btn_POS.Click += new System.EventHandler(this.btn_POS_Click);
            // 
            // btn_Student_Struce
            // 
            this.btn_Student_Struce.Location = new System.Drawing.Point(12, 103);
            this.btn_Student_Struce.Name = "btn_Student_Struce";
            this.btn_Student_Struce.Size = new System.Drawing.Size(144, 23);
            this.btn_Student_Struce.TabIndex = 0;
            this.btn_Student_Struce.Text = "0922_StudentForm_Struct";
            this.btn_Student_Struce.UseVisualStyleBackColor = true;
            this.btn_Student_Struce.Click += new System.EventHandler(this.btn_Student_Struce_Click);
            // 
            // btn_StudentGrade_list
            // 
            this.btn_StudentGrade_list.Location = new System.Drawing.Point(12, 132);
            this.btn_StudentGrade_list.Name = "btn_StudentGrade_list";
            this.btn_StudentGrade_list.Size = new System.Drawing.Size(144, 23);
            this.btn_StudentGrade_list.TabIndex = 0;
            this.btn_StudentGrade_list.Text = "0923_StudentGrade_List";
            this.btn_StudentGrade_list.UseVisualStyleBackColor = true;
            this.btn_StudentGrade_list.Click += new System.EventHandler(this.btn_StudentGrade_list_Click);
            // 
            // btn_MyClac
            // 
            this.btn_MyClac.Location = new System.Drawing.Point(12, 161);
            this.btn_MyClac.Name = "btn_MyClac";
            this.btn_MyClac.Size = new System.Drawing.Size(144, 23);
            this.btn_MyClac.TabIndex = 0;
            this.btn_MyClac.Text = "0927_MyClac";
            this.btn_MyClac.UseVisualStyleBackColor = true;
            this.btn_MyClac.Click += new System.EventHandler(this.btn_MyClac_Click);
            // 
            // btn_ForDoWhile
            // 
            this.btn_ForDoWhile.Location = new System.Drawing.Point(12, 190);
            this.btn_ForDoWhile.Name = "btn_ForDoWhile";
            this.btn_ForDoWhile.Size = new System.Drawing.Size(144, 23);
            this.btn_ForDoWhile.TabIndex = 0;
            this.btn_ForDoWhile.Text = "0926_ForDoWhile";
            this.btn_ForDoWhile.UseVisualStyleBackColor = true;
            this.btn_ForDoWhile.Click += new System.EventHandler(this.btn_ForDoWhile_Click);
            // 
            // btn_XOGame
            // 
            this.btn_XOGame.Location = new System.Drawing.Point(12, 219);
            this.btn_XOGame.Name = "btn_XOGame";
            this.btn_XOGame.Size = new System.Drawing.Size(144, 23);
            this.btn_XOGame.TabIndex = 0;
            this.btn_XOGame.Text = "0924_XOGame";
            this.btn_XOGame.UseVisualStyleBackColor = true;
            this.btn_XOGame.Click += new System.EventHandler(this.btn_XOGame_Click);
            // 
            // btn_Guess
            // 
            this.btn_Guess.Location = new System.Drawing.Point(12, 248);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(144, 23);
            this.btn_Guess.TabIndex = 0;
            this.btn_Guess.Text = "0926_Guess";
            this.btn_Guess.UseVisualStyleBackColor = true;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // btn_Alarm
            // 
            this.btn_Alarm.Location = new System.Drawing.Point(12, 277);
            this.btn_Alarm.Name = "btn_Alarm";
            this.btn_Alarm.Size = new System.Drawing.Size(144, 23);
            this.btn_Alarm.TabIndex = 0;
            this.btn_Alarm.Text = "0926_Alarm";
            this.btn_Alarm.UseVisualStyleBackColor = true;
            this.btn_Alarm.Click += new System.EventHandler(this.btn_Alarm_Click);
            // 
            // Form_Meun_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_Meun_UI";
            this.Text = "Menu UI";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_show_Hello;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.Button btn_POS;
        private System.Windows.Forms.Button btn_Student_Struce;
        private System.Windows.Forms.Button btn_StudentGrade_list;
        private System.Windows.Forms.Button btn_MyClac;
        private System.Windows.Forms.Button btn_ForDoWhile;
        private System.Windows.Forms.Button btn_XOGame;
        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.Button btn_Alarm;
    }
}

