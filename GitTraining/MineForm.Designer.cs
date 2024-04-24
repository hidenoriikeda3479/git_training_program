
namespace WindowsFormsApp1
{
    partial class MineForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAge = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnRemarks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "名前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "備考";
            // 
            // btnAge
            // 
            this.btnAge.Location = new System.Drawing.Point(209, 30);
            this.btnAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(100, 29);
            this.btnAge.TabIndex = 6;
            this.btnAge.Text = "年齢算出";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "年齢";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(121, 36);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(40, 15);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "XX歳";
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnName.Location = new System.Drawing.Point(209, 71);
            this.btnName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(100, 29);
            this.btnName.TabIndex = 7;
            this.btnName.Text = "名前編集";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(121, 78);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "XX　XX";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.BackColor = System.Drawing.Color.White;
            this.lblRemarks.Location = new System.Drawing.Point(61, 181);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(358, 60);
            this.lblRemarks.TabIndex = 8;
            this.lblRemarks.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\nXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r" +
    "\nXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\nXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" +
    "X\r\n";
            // 
            // btnRemarks
            // 
            this.btnRemarks.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRemarks.Location = new System.Drawing.Point(124, 141);
            this.btnRemarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemarks.Name = "btnRemarks";
            this.btnRemarks.Size = new System.Drawing.Size(100, 29);
            this.btnRemarks.TabIndex = 7;
            this.btnRemarks.Text = "備考編集";
            this.btnRemarks.UseVisualStyleBackColor = false;
            this.btnRemarks.Click += new System.EventHandler(this.btnRemarks_Click);
            // 
            // MineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 275);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRemarks);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MineForm";
            this.Text = "メイン";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnRemarks;
    }
}

