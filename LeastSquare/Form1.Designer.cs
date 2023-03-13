
namespace LeastSquare
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.picdraw = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picdraw)).BeginInit();
            this.SuspendLayout();
            // 
            // picdraw
            // 
            this.picdraw.BackColor = System.Drawing.Color.White;
            this.picdraw.Location = new System.Drawing.Point(35, 12);
            this.picdraw.Name = "picdraw";
            this.picdraw.Size = new System.Drawing.Size(500, 500);
            this.picdraw.TabIndex = 0;
            this.picdraw.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(597, 38);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(153, 89);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.picdraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picdraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picdraw;
        private System.Windows.Forms.Button btn1;
    }
}

