namespace Project
{
    partial class UserControlBlank
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
            this.IBdays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IBdays
            // 
            this.IBdays.AutoSize = true;
            this.IBdays.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IBdays.Location = new System.Drawing.Point(3, 9);
            this.IBdays.Name = "IBdays";
            this.IBdays.Size = new System.Drawing.Size(23, 16);
            this.IBdays.TabIndex = 0;
            this.IBdays.Text = "00";
            // 
            // UserControlBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IBdays);
            this.Name = "UserControlBlank";
            this.Size = new System.Drawing.Size(74, 80);
            this.Load += new System.EventHandler(this.UserControlBlank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label IBdays;
    }
}
