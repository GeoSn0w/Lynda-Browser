namespace Lynda_Browser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UIActivePageElement = new Gecko.GeckoWebBrowser();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.goForward = new System.Windows.Forms.PictureBox();
            this.refreshPageButton = new System.Windows.Forms.PictureBox();
            this.polyMo = new System.Windows.Forms.PictureBox();
            this.PageTabLoader = new System.Windows.Forms.CustomTabControl();
            this.currentPage = new System.Windows.Forms.TabPage();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.iTalk_HeaderLabel3 = new iTalk.iTalk_HeaderLabel();
            this.iTalk_HeaderLabel2 = new iTalk.iTalk_HeaderLabel();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.lyndaLogo = new System.Windows.Forms.PictureBox();
            this.SaveDoc = new iTalk.iTalk_Button_1();
            this.exit = new iTalk.iTalk_Button_1();
            this.creditsBtn = new iTalk.iTalk_Button_1();
            this.viewSource = new iTalk.iTalk_Button_1();
            this.AppControl = new iTalk.iTalk_ControlBox();
            this.addr_bar = new iTalk.iTalk_TextBox_Small();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyMo)).BeginInit();
            this.PageTabLoader.SuspendLayout();
            this.currentPage.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyndaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // UIActivePageElement
            // 
            this.UIActivePageElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIActivePageElement.FrameEventsPropagateToMainWindow = false;
            this.UIActivePageElement.Location = new System.Drawing.Point(3, 3);
            this.UIActivePageElement.Name = "UIActivePageElement";
            this.UIActivePageElement.Size = new System.Drawing.Size(1488, 733);
            this.UIActivePageElement.TabIndex = 0;
            this.UIActivePageElement.UseHttpActivityObserver = false;
            this.UIActivePageElement.DomContentChanged += new System.EventHandler<Gecko.DomEventArgs>(this.UIActivePageElement_DomContentChanged);
            // 
            // backbutton
            // 
            this.backbutton.Image = global::Lynda_Browser.Properties.Resources.back;
            this.backbutton.Location = new System.Drawing.Point(3, 6);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(35, 30);
            this.backbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbutton.TabIndex = 2;
            this.backbutton.TabStop = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // goForward
            // 
            this.goForward.Image = global::Lynda_Browser.Properties.Resources.next;
            this.goForward.Location = new System.Drawing.Point(44, 6);
            this.goForward.Name = "goForward";
            this.goForward.Size = new System.Drawing.Size(35, 30);
            this.goForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goForward.TabIndex = 3;
            this.goForward.TabStop = false;
            this.goForward.Click += new System.EventHandler(this.goForward_Click);
            // 
            // refreshPageButton
            // 
            this.refreshPageButton.Image = global::Lynda_Browser.Properties.Resources.reload;
            this.refreshPageButton.Location = new System.Drawing.Point(84, 6);
            this.refreshPageButton.Name = "refreshPageButton";
            this.refreshPageButton.Size = new System.Drawing.Size(40, 30);
            this.refreshPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshPageButton.TabIndex = 4;
            this.refreshPageButton.TabStop = false;
            this.refreshPageButton.Click += new System.EventHandler(this.refreshPageButton_Click);
            // 
            // polyMo
            // 
            this.polyMo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.polyMo.Image = global::Lynda_Browser.Properties.Resources.menu1;
            this.polyMo.Location = new System.Drawing.Point(1368, 7);
            this.polyMo.Name = "polyMo";
            this.polyMo.Size = new System.Drawing.Size(31, 30);
            this.polyMo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.polyMo.TabIndex = 5;
            this.polyMo.TabStop = false;
            this.polyMo.Click += new System.EventHandler(this.polyMo_Click);
            // 
            // PageTabLoader
            // 
            this.PageTabLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageTabLoader.Controls.Add(this.currentPage);
            this.PageTabLoader.DisplayStyle = System.Windows.Forms.TabStyle.Angled;
            // 
            // 
            // 
            this.PageTabLoader.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.PageTabLoader.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.PageTabLoader.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.PageTabLoader.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.PageTabLoader.DisplayStyleProvider.FocusTrack = false;
            this.PageTabLoader.DisplayStyleProvider.HotTrack = true;
            this.PageTabLoader.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PageTabLoader.DisplayStyleProvider.Opacity = 1F;
            this.PageTabLoader.DisplayStyleProvider.Overlap = 7;
            this.PageTabLoader.DisplayStyleProvider.Padding = new System.Drawing.Point(10, 3);
            this.PageTabLoader.DisplayStyleProvider.Radius = 10;
            this.PageTabLoader.DisplayStyleProvider.ShowTabCloser = false;
            this.PageTabLoader.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.PageTabLoader.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.PageTabLoader.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.PageTabLoader.HotTrack = true;
            this.PageTabLoader.Location = new System.Drawing.Point(0, 42);
            this.PageTabLoader.Name = "PageTabLoader";
            this.PageTabLoader.SelectedIndex = 0;
            this.PageTabLoader.Size = new System.Drawing.Size(1502, 766);
            this.PageTabLoader.TabIndex = 6;
            // 
            // currentPage
            // 
            this.currentPage.Controls.Add(this.UIActivePageElement);
            this.currentPage.Location = new System.Drawing.Point(4, 23);
            this.currentPage.Name = "currentPage";
            this.currentPage.Padding = new System.Windows.Forms.Padding(3);
            this.currentPage.Size = new System.Drawing.Size(1494, 739);
            this.currentPage.TabIndex = 0;
            this.currentPage.Text = "No - Page - Yet";
            this.currentPage.UseVisualStyleBackColor = true;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.Controls.Add(this.iTalk_HeaderLabel3);
            this.menuPanel.Controls.Add(this.iTalk_HeaderLabel2);
            this.menuPanel.Controls.Add(this.iTalk_HeaderLabel1);
            this.menuPanel.Controls.Add(this.lyndaLogo);
            this.menuPanel.Controls.Add(this.SaveDoc);
            this.menuPanel.Controls.Add(this.exit);
            this.menuPanel.Controls.Add(this.creditsBtn);
            this.menuPanel.Controls.Add(this.viewSource);
            this.menuPanel.Location = new System.Drawing.Point(1226, 42);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(276, 384);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.Visible = false;
            // 
            // iTalk_HeaderLabel3
            // 
            this.iTalk_HeaderLabel3.AutoSize = true;
            this.iTalk_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel3.ForeColor = System.Drawing.Color.Silver;
            this.iTalk_HeaderLabel3.Location = new System.Drawing.Point(3, 358);
            this.iTalk_HeaderLabel3.Name = "iTalk_HeaderLabel3";
            this.iTalk_HeaderLabel3.Size = new System.Drawing.Size(245, 21);
            this.iTalk_HeaderLabel3.TabIndex = 11;
            this.iTalk_HeaderLabel3.Text = "Example by: GeoSn0w (@FCE365)";
            // 
            // iTalk_HeaderLabel2
            // 
            this.iTalk_HeaderLabel2.AutoSize = true;
            this.iTalk_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel2.ForeColor = System.Drawing.Color.Silver;
            this.iTalk_HeaderLabel2.Location = new System.Drawing.Point(3, 339);
            this.iTalk_HeaderLabel2.Name = "iTalk_HeaderLabel2";
            this.iTalk_HeaderLabel2.Size = new System.Drawing.Size(147, 21);
            this.iTalk_HeaderLabel2.TabIndex = 10;
            this.iTalk_HeaderLabel2.Text = "Gecko Version: 45.0";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Silver;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(3, 320);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(137, 21);
            this.iTalk_HeaderLabel1.TabIndex = 9;
            this.iTalk_HeaderLabel1.Text = "Lynda Version: 1.0";
            // 
            // lyndaLogo
            // 
            this.lyndaLogo.Image = global::Lynda_Browser.Properties.Resources.LyndaLogo;
            this.lyndaLogo.Location = new System.Drawing.Point(10, 3);
            this.lyndaLogo.Name = "lyndaLogo";
            this.lyndaLogo.Size = new System.Drawing.Size(259, 118);
            this.lyndaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lyndaLogo.TabIndex = 8;
            this.lyndaLogo.TabStop = false;
            // 
            // SaveDoc
            // 
            this.SaveDoc.BackColor = System.Drawing.Color.Transparent;
            this.SaveDoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SaveDoc.Image = null;
            this.SaveDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveDoc.Location = new System.Drawing.Point(7, 127);
            this.SaveDoc.Name = "SaveDoc";
            this.SaveDoc.Size = new System.Drawing.Size(262, 41);
            this.SaveDoc.TabIndex = 3;
            this.SaveDoc.Text = "Open Page Properties";
            this.SaveDoc.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SaveDoc.Click += new System.EventHandler(this.SaveDoc_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exit.Image = null;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(7, 274);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(262, 41);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit Lynda";
            this.exit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // creditsBtn
            // 
            this.creditsBtn.BackColor = System.Drawing.Color.Transparent;
            this.creditsBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.creditsBtn.Image = null;
            this.creditsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creditsBtn.Location = new System.Drawing.Point(7, 225);
            this.creditsBtn.Name = "creditsBtn";
            this.creditsBtn.Size = new System.Drawing.Size(262, 41);
            this.creditsBtn.TabIndex = 1;
            this.creditsBtn.Text = "Credits";
            this.creditsBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.creditsBtn.Click += new System.EventHandler(this.creditsBtn_Click);
            // 
            // viewSource
            // 
            this.viewSource.BackColor = System.Drawing.Color.Transparent;
            this.viewSource.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewSource.Image = null;
            this.viewSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewSource.Location = new System.Drawing.Point(7, 176);
            this.viewSource.Name = "viewSource";
            this.viewSource.Size = new System.Drawing.Size(262, 41);
            this.viewSource.TabIndex = 0;
            this.viewSource.Text = "View Page Source";
            this.viewSource.TextAlignment = System.Drawing.StringAlignment.Center;
            this.viewSource.Click += new System.EventHandler(this.viewSource_Click);
            // 
            // AppControl
            // 
            this.AppControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AppControl.BackColor = System.Drawing.Color.Transparent;
            this.AppControl.Location = new System.Drawing.Point(1418, 0);
            this.AppControl.Name = "AppControl";
            this.AppControl.Size = new System.Drawing.Size(77, 19);
            this.AppControl.TabIndex = 7;
            this.AppControl.Text = "AppControl";
            // 
            // addr_bar
            // 
            this.addr_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addr_bar.BackColor = System.Drawing.Color.Transparent;
            this.addr_bar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.addr_bar.ForeColor = System.Drawing.Color.DimGray;
            this.addr_bar.Location = new System.Drawing.Point(131, 8);
            this.addr_bar.MaxLength = 32767;
            this.addr_bar.Multiline = false;
            this.addr_bar.Name = "addr_bar";
            this.addr_bar.ReadOnly = false;
            this.addr_bar.Size = new System.Drawing.Size(1231, 28);
            this.addr_bar.TabIndex = 1;
            this.addr_bar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addr_bar.UseSystemPasswordChar = false;
            this.addr_bar.TextChanged += new System.EventHandler(this.addr_bar_TextChanged);
            this.addr_bar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addr_bar_KeyDown);
            this.addr_bar.Leave += new System.EventHandler(this.addr_bar_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Lynda_Browser.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1502, 810);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.AppControl);
            this.Controls.Add(this.PageTabLoader);
            this.Controls.Add(this.polyMo);
            this.Controls.Add(this.refreshPageButton);
            this.Controls.Add(this.goForward);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.addr_bar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lynda Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyMo)).EndInit();
            this.PageTabLoader.ResumeLayout(false);
            this.currentPage.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyndaLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gecko.GeckoWebBrowser UIActivePageElement;
        private iTalk.iTalk_TextBox_Small addr_bar;
        private System.Windows.Forms.PictureBox backbutton;
        private System.Windows.Forms.PictureBox goForward;
        private System.Windows.Forms.PictureBox refreshPageButton;
        private System.Windows.Forms.PictureBox polyMo;
        private System.Windows.Forms.CustomTabControl PageTabLoader;
        private System.Windows.Forms.TabPage currentPage;
        private iTalk.iTalk_ControlBox AppControl;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox lyndaLogo;
        private iTalk.iTalk_Button_1 SaveDoc;
        private iTalk.iTalk_Button_1 exit;
        private iTalk.iTalk_Button_1 creditsBtn;
        private iTalk.iTalk_Button_1 viewSource;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel2;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel3;
    }
}

