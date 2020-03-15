namespace AssociationInput {
    partial class KeyChangerMain {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyChangerMain));
            this.cNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.cAppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cAppMenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.cAppMenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.cAppMenuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cAppMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cMode = new System.Windows.Forms.ToolStripMenuItem();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cHiragana = new System.Windows.Forms.ToolStripMenuItem();
            this.cKatakana = new System.Windows.Forms.ToolStripMenuItem();
            this.cHanKatakana = new System.Windows.Forms.ToolStripMenuItem();
            this.cNum = new System.Windows.Forms.ToolStripMenuItem();
            this.cAppMenu.SuspendLayout();
            // 
            // cNotify
            // 
            this.cNotify.ContextMenuStrip = this.cAppMenu;
            this.cNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("cNotify.Icon")));
            this.cNotify.Text = "notifyIcon1";
            this.cNotify.Visible = true;
            // 
            // cAppMenu
            // 
            this.cAppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMode,
            this.separator3,
            this.cAppMenuStart,
            this.cAppMenuStop,
            this.separator1,
            this.cAppMenuReset,
            this.separator2,
            this.cAppMenuExit});
            this.cAppMenu.Name = "cAppMenu";
            this.cAppMenu.Size = new System.Drawing.Size(124, 132);
            // 
            // cAppMenuStart
            // 
            this.cAppMenuStart.Name = "cAppMenuStart";
            this.cAppMenuStart.Size = new System.Drawing.Size(123, 22);
            this.cAppMenuStart.Text = "Start";
            // 
            // cAppMenuStop
            // 
            this.cAppMenuStop.Name = "cAppMenuStop";
            this.cAppMenuStop.Size = new System.Drawing.Size(123, 22);
            this.cAppMenuStop.Text = "Stop";
            // 
            // cAppMenuReset
            // 
            this.cAppMenuReset.Name = "cAppMenuReset";
            this.cAppMenuReset.Size = new System.Drawing.Size(123, 22);
            this.cAppMenuReset.Text = "Reset";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(120, 6);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(120, 6);
            // 
            // cAppMenuExit
            // 
            this.cAppMenuExit.Name = "cAppMenuExit";
            this.cAppMenuExit.Size = new System.Drawing.Size(123, 22);
            this.cAppMenuExit.Text = "Exit";
            // 
            // cMode
            // 
            this.cMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHiragana,
            this.cKatakana,
            this.cHanKatakana,
            this.cNum});
            this.cMode.Name = "cMode";
            this.cMode.Size = new System.Drawing.Size(123, 22);
            this.cMode.Text = "入力モード";
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(120, 6);
            // 
            // cHiragana
            // 
            this.cHiragana.Checked = true;
            this.cHiragana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cHiragana.Name = "cHiragana";
            this.cHiragana.Size = new System.Drawing.Size(134, 22);
            this.cHiragana.Text = "ひらがな";
            // 
            // cKatakana
            // 
            this.cKatakana.Name = "cKatakana";
            this.cKatakana.Size = new System.Drawing.Size(134, 22);
            this.cKatakana.Text = "カタカナ";
            // 
            // cHanKatakana
            // 
            this.cHanKatakana.Name = "cHanKatakana";
            this.cHanKatakana.Size = new System.Drawing.Size(134, 22);
            this.cHanKatakana.Text = "半角カタカナ";
            // 
            // cNum
            // 
            this.cNum.Name = "cNum";
            this.cNum.Size = new System.Drawing.Size(134, 22);
            this.cNum.Text = "全角数値";
            this.cAppMenu.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon cNotify;
        private System.Windows.Forms.ContextMenuStrip cAppMenu;
        private System.Windows.Forms.ToolStripMenuItem cAppMenuStart;
        private System.Windows.Forms.ToolStripMenuItem cAppMenuStop;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripMenuItem cAppMenuReset;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripMenuItem cAppMenuExit;
        private System.Windows.Forms.ToolStripMenuItem cMode;
        private System.Windows.Forms.ToolStripMenuItem cHiragana;
        private System.Windows.Forms.ToolStripMenuItem cKatakana;
        private System.Windows.Forms.ToolStripMenuItem cHanKatakana;
        private System.Windows.Forms.ToolStripMenuItem cNum;
        private System.Windows.Forms.ToolStripSeparator separator3;
    }
}
