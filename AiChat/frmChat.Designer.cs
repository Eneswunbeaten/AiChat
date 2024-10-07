namespace AiChat
{
    partial class frmChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            txtPrompt = new RichTextBox();
            txtGpt = new RichTextBox();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            btnSend = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            btnCopyCode = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtPrompt
            // 
            resources.ApplyResources(txtPrompt, "txtPrompt");
            txtPrompt.BorderStyle = BorderStyle.FixedSingle;
            txtPrompt.Name = "txtPrompt";
            txtPrompt.KeyDown += txtPrompt_KeyDown;
            // 
            // txtGpt
            // 
            resources.ApplyResources(txtGpt, "txtGpt");
            txtGpt.BorderStyle = BorderStyle.FixedSingle;
            txtGpt.Name = "txtGpt";
            txtGpt.ReadOnly = true;
            // 
            // pictureEdit1
            // 
            resources.ApplyResources(pictureEdit1, "pictureEdit1");
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = (Font)resources.GetObject("labelControl1.Appearance.Font");
            labelControl1.Appearance.Options.UseFont = true;
            resources.ApplyResources(labelControl1, "labelControl1");
            labelControl1.Name = "labelControl1";
            // 
            // btnSend
            // 
            resources.ApplyResources(btnSend, "btnSend");
            btnSend.Appearance.Font = (Font)resources.GetObject("btnSend.Appearance.Font");
            btnSend.Appearance.Options.UseFont = true;
            btnSend.Appearance.Options.UseImage = true;
            btnSend.Cursor = Cursors.Hand;
            btnSend.ImageOptions.Image = (Image)resources.GetObject("btnSend.ImageOptions.Image");
            btnSend.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnSend.Name = "btnSend";
            btnSend.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnSend.Click += btnSend_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.BackColor = (Color)resources.GetObject("labelControl2.Appearance.BackColor");
            labelControl2.Appearance.Font = (Font)resources.GetObject("labelControl2.Appearance.Font");
            labelControl2.Appearance.ForeColor = (Color)resources.GetObject("labelControl2.Appearance.ForeColor");
            labelControl2.Appearance.Options.UseBackColor = true;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(labelControl2, "labelControl2");
            labelControl2.Name = "labelControl2";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.BackColor = (Color)resources.GetObject("labelControl3.Appearance.BackColor");
            labelControl3.Appearance.Font = (Font)resources.GetObject("labelControl3.Appearance.Font");
            labelControl3.Appearance.ForeColor = (Color)resources.GetObject("labelControl3.Appearance.ForeColor");
            labelControl3.Appearance.Options.UseBackColor = true;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(labelControl3, "labelControl3");
            labelControl3.Name = "labelControl3";
            // 
            // btnCopyCode
            // 
            resources.ApplyResources(btnCopyCode, "btnCopyCode");
            btnCopyCode.Appearance.Font = (Font)resources.GetObject("simpleButton1.Appearance.Font");
            btnCopyCode.Appearance.Options.UseFont = true;
            btnCopyCode.Appearance.Options.UseImage = true;
            btnCopyCode.Cursor = Cursors.Hand;
            btnCopyCode.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            btnCopyCode.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnCopyCode.Name = "btnCopyCode";
            btnCopyCode.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            // 
            // frmChat
            // 
            Appearance.BackColor = (Color)resources.GetObject("frmChat.Appearance.BackColor");
            Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCopyCode);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(btnSend);
            Controls.Add(labelControl1);
            Controls.Add(pictureEdit1);
            Controls.Add(txtGpt);
            Controls.Add(txtPrompt);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Image = (Image)resources.GetObject("frmChat.IconOptions.Image");
            Name = "frmChat";
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtPrompt;
        private RichTextBox txtGpt;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCopyCode;
    }
}