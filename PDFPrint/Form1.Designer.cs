namespace PDFPrint
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
            this.lblName = new System.Windows.Forms.Label();
            this.FieldName = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.btnPdfPrt = new System.Windows.Forms.Button();
            this.btnFdName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(202, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name : ";
            // 
            // FieldName
            // 
            this.FieldName.Location = new System.Drawing.Point(26, 87);
            this.FieldName.Multiline = true;
            this.FieldName.Name = "FieldName";
            this.FieldName.Size = new System.Drawing.Size(159, 259);
            this.FieldName.TabIndex = 5;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(266, 87);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(165, 21);
            this.FileName.TabIndex = 6;
            // 
            // btnPdfPrt
            // 
            this.btnPdfPrt.Location = new System.Drawing.Point(333, 114);
            this.btnPdfPrt.Name = "btnPdfPrt";
            this.btnPdfPrt.Size = new System.Drawing.Size(98, 23);
            this.btnPdfPrt.TabIndex = 7;
            this.btnPdfPrt.Text = "PC에저장";
            this.btnPdfPrt.UseVisualStyleBackColor = true;
            this.btnPdfPrt.Click += new System.EventHandler(this.btnPdfPrt_Click);
            // 
            // btnFdName
            // 
            this.btnFdName.Location = new System.Drawing.Point(89, 352);
            this.btnFdName.Name = "btnFdName";
            this.btnFdName.Size = new System.Drawing.Size(96, 23);
            this.btnFdName.TabIndex = 8;
            this.btnFdName.Text = "조회";
            this.btnFdName.UseVisualStyleBackColor = true;
            this.btnFdName.Click += new System.EventHandler(this.btnFdName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 427);
            this.Controls.Add(this.btnFdName);
            this.Controls.Add(this.btnPdfPrt);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.FieldName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox FieldName;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button btnPdfPrt;
        private System.Windows.Forms.Button btnFdName;
    }
}

