namespace mamestagram_patcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shortcutPath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblConnectServer = new System.Windows.Forms.Label();
            this.cbSavePath = new System.Windows.Forms.CheckBox();
            this.connectServer = new System.Windows.Forms.TextBox();
            this.cbAddress = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shortcutPath
            // 
            this.shortcutPath.BackColor = System.Drawing.Color.Black;
            this.shortcutPath.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.shortcutPath.ForeColor = System.Drawing.SystemColors.Menu;
            this.shortcutPath.Location = new System.Drawing.Point(12, 64);
            this.shortcutPath.Name = "shortcutPath";
            this.shortcutPath.ReadOnly = true;
            this.shortcutPath.Size = new System.Drawing.Size(182, 23);
            this.shortcutPath.TabIndex = 0;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblFilePath.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFilePath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFilePath.Location = new System.Drawing.Point(12, 38);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(173, 12);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "osu!のファイルパスを指定してください";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(145, 96);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(49, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "指定";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblConnectServer
            // 
            this.lblConnectServer.AutoSize = true;
            this.lblConnectServer.BackColor = System.Drawing.Color.Transparent;
            this.lblConnectServer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblConnectServer.Location = new System.Drawing.Point(10, 137);
            this.lblConnectServer.Name = "lblConnectServer";
            this.lblConnectServer.Size = new System.Drawing.Size(97, 12);
            this.lblConnectServer.TabIndex = 3;
            this.lblConnectServer.Text = "接続したいサーバー";
            // 
            // cbSavePath
            // 
            this.cbSavePath.AutoSize = true;
            this.cbSavePath.BackColor = System.Drawing.Color.Transparent;
            this.cbSavePath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbSavePath.Location = new System.Drawing.Point(12, 100);
            this.cbSavePath.Name = "cbSavePath";
            this.cbSavePath.Size = new System.Drawing.Size(95, 16);
            this.cbSavePath.TabIndex = 4;
            this.cbSavePath.Text = "パスを保存する";
            this.cbSavePath.UseVisualStyleBackColor = false;
            // 
            // connectServer
            // 
            this.connectServer.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.connectServer.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.connectServer.ForeColor = System.Drawing.SystemColors.Info;
            this.connectServer.Location = new System.Drawing.Point(12, 164);
            this.connectServer.Name = "connectServer";
            this.connectServer.Size = new System.Drawing.Size(182, 23);
            this.connectServer.TabIndex = 5;
            // 
            // cbAddress
            // 
            this.cbAddress.AutoSize = true;
            this.cbAddress.BackColor = System.Drawing.Color.Transparent;
            this.cbAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbAddress.Location = new System.Drawing.Point(12, 204);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(116, 16);
            this.cbAddress.TabIndex = 6;
            this.cbAddress.Text = "サーバーを保存する";
            this.cbAddress.UseVisualStyleBackColor = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(43, 236);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 35);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "接続!";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(211, 283);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbAddress);
            this.Controls.Add(this.connectServer);
            this.Controls.Add(this.cbSavePath);
            this.Controls.Add(this.lblConnectServer);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.shortcutPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "osu! Patcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shortcutPath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblConnectServer;
        private System.Windows.Forms.CheckBox cbSavePath;
        private System.Windows.Forms.TextBox connectServer;
        private System.Windows.Forms.CheckBox cbAddress;
        private System.Windows.Forms.Button btnConnect;
    }
}

