namespace H_GuessNumber
{
    partial class Form_Manue
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
            this.btn_Guess = new System.Windows.Forms.Button();
            this.lab_GuessInfo = new System.Windows.Forms.Label();
            this.btn_Answer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Guess
            // 
            this.btn_Guess.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guess.Location = new System.Drawing.Point(65, 189);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(100, 60);
            this.btn_Guess.TabIndex = 0;
            this.btn_Guess.Text = "Guess";
            this.btn_Guess.UseVisualStyleBackColor = true;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // lab_GuessInfo
            // 
            this.lab_GuessInfo.AutoSize = true;
            this.lab_GuessInfo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_GuessInfo.Location = new System.Drawing.Point(10, 121);
            this.lab_GuessInfo.Name = "lab_GuessInfo";
            this.lab_GuessInfo.Size = new System.Drawing.Size(422, 24);
            this.lab_GuessInfo.TabIndex = 1;
            this.lab_GuessInfo.Text = "Pleas Select A Number Between 1 to 100!";
            // 
            // btn_Answer
            // 
            this.btn_Answer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Answer.Location = new System.Drawing.Point(204, 189);
            this.btn_Answer.Name = "btn_Answer";
            this.btn_Answer.Size = new System.Drawing.Size(178, 60);
            this.btn_Answer.TabIndex = 0;
            this.btn_Answer.Text = "Show Answer";
            this.btn_Answer.UseVisualStyleBackColor = true;
            this.btn_Answer.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // Form_Manue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 311);
            this.Controls.Add(this.lab_GuessInfo);
            this.Controls.Add(this.btn_Answer);
            this.Controls.Add(this.btn_Guess);
            this.Name = "Form_Manue";
            this.Text = "Form Guess Number";
            this.Load += new System.EventHandler(this.Form_Manue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.Button btn_Answer;
        public System.Windows.Forms.Label lab_GuessInfo;
    }
}

