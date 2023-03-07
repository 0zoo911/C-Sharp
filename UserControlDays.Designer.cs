namespace Project
{
    partial class UserControlDays
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            Ibdays = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Ibdays
            // 
            Ibdays.AutoSize = true;
            Ibdays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Ibdays.Location = new System.Drawing.Point(3, 11);
            Ibdays.Name = "Ibdays";
            Ibdays.Size = new System.Drawing.Size(28, 21);
            Ibdays.TabIndex = 0;
            Ibdays.Text = "00";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Khaki;
            Controls.Add(Ibdays);
            Name = "UserControlDays";
            Size = new System.Drawing.Size(74, 80);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Ibdays;
    }
}
