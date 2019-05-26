namespace MoneyFlow
{
    partial class SignIn
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSignInMinimize = new System.Windows.Forms.Button();
            this.labelSignInAppname = new System.Windows.Forms.Label();
            this.bunifuPictureBoxSignInIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.buttonSignInClose = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTextBoxSignInPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBoxSignInUsername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.bunifuButtonSignInNext = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.linkLabelSignInSignUp = new System.Windows.Forms.LinkLabel();
            this.labelSignInError = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxSignInIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.buttonSignInMinimize);
            this.panel1.Controls.Add(this.labelSignInAppname);
            this.panel1.Controls.Add(this.bunifuPictureBoxSignInIcon);
            this.panel1.Controls.Add(this.buttonSignInClose);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 27);
            this.panel1.TabIndex = 0;
            // 
            // buttonSignInMinimize
            // 
            this.bunifuTransition1.SetDecoration(this.buttonSignInMinimize, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.buttonSignInMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSignInMinimize.FlatAppearance.BorderSize = 0;
            this.buttonSignInMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignInMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignInMinimize.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSignInMinimize.Location = new System.Drawing.Point(453, 0);
            this.buttonSignInMinimize.Name = "buttonSignInMinimize";
            this.buttonSignInMinimize.Size = new System.Drawing.Size(33, 27);
            this.buttonSignInMinimize.TabIndex = 0;
            this.buttonSignInMinimize.TabStop = false;
            this.buttonSignInMinimize.Text = "_";
            this.buttonSignInMinimize.UseVisualStyleBackColor = true;
            this.buttonSignInMinimize.Click += new System.EventHandler(this.buttonSignInMinimize_Click);
            // 
            // labelSignInAppname
            // 
            this.labelSignInAppname.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelSignInAppname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.labelSignInAppname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSignInAppname.ForeColor = System.Drawing.Color.White;
            this.labelSignInAppname.Location = new System.Drawing.Point(33, 6);
            this.labelSignInAppname.Name = "labelSignInAppname";
            this.labelSignInAppname.Size = new System.Drawing.Size(77, 16);
            this.labelSignInAppname.TabIndex = 2;
            this.labelSignInAppname.Text = "MoneyFlow";
            // 
            // bunifuPictureBoxSignInIcon
            // 
            this.bunifuPictureBoxSignInIcon.AllowFocused = false;
            this.bunifuPictureBoxSignInIcon.BorderRadius = 13;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBoxSignInIcon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBoxSignInIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPictureBoxSignInIcon.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBoxSignInIcon.Image")));
            this.bunifuPictureBoxSignInIcon.IsCircle = true;
            this.bunifuPictureBoxSignInIcon.Location = new System.Drawing.Point(0, 0);
            this.bunifuPictureBoxSignInIcon.Name = "bunifuPictureBoxSignInIcon";
            this.bunifuPictureBoxSignInIcon.Size = new System.Drawing.Size(27, 27);
            this.bunifuPictureBoxSignInIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBoxSignInIcon.TabIndex = 1;
            this.bunifuPictureBoxSignInIcon.TabStop = false;
            this.bunifuPictureBoxSignInIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // buttonSignInClose
            // 
            this.buttonSignInClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.buttonSignInClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.buttonSignInClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSignInClose.FlatAppearance.BorderSize = 0;
            this.buttonSignInClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSignInClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonSignInClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignInClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignInClose.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSignInClose.Location = new System.Drawing.Point(486, 0);
            this.buttonSignInClose.Name = "buttonSignInClose";
            this.buttonSignInClose.Size = new System.Drawing.Size(39, 27);
            this.buttonSignInClose.TabIndex = 0;
            this.buttonSignInClose.Text = "X";
            this.buttonSignInClose.UseVisualStyleBackColor = true;
            this.buttonSignInClose.Click += new System.EventHandler(this.buttonSignInClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTextBoxSignInPassword
            // 
            this.bunifuTextBoxSignInPassword.AcceptsReturn = false;
            this.bunifuTextBoxSignInPassword.AcceptsTab = false;
            this.bunifuTextBoxSignInPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxSignInPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxSignInPassword.BackColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignInPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxSignInPassword.BackgroundImage")));
            this.bunifuTextBoxSignInPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.bunifuTextBoxSignInPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBoxSignInPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.bunifuTextBoxSignInPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuTextBoxSignInPassword.BorderRadius = 1;
            this.bunifuTextBoxSignInPassword.BorderThickness = 2;
            this.bunifuTextBoxSignInPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBoxSignInPassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBoxSignInPassword.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBoxSignInPassword.DefaultText = "";
            this.bunifuTextBoxSignInPassword.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignInPassword.HideSelection = true;
            this.bunifuTextBoxSignInPassword.IconLeft = global::MoneyFlow.Properties.Resources.pas;
            this.bunifuTextBoxSignInPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignInPassword.IconPadding = 10;
            this.bunifuTextBoxSignInPassword.IconRight = null;
            this.bunifuTextBoxSignInPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignInPassword.Location = new System.Drawing.Point(160, 310);
            this.bunifuTextBoxSignInPassword.MaxLength = 40;
            this.bunifuTextBoxSignInPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBoxSignInPassword.Modified = false;
            this.bunifuTextBoxSignInPassword.Name = "bunifuTextBoxSignInPassword";
            this.bunifuTextBoxSignInPassword.PasswordChar = '•';
            this.bunifuTextBoxSignInPassword.ReadOnly = false;
            this.bunifuTextBoxSignInPassword.SelectedText = "";
            this.bunifuTextBoxSignInPassword.SelectionLength = 0;
            this.bunifuTextBoxSignInPassword.SelectionStart = 0;
            this.bunifuTextBoxSignInPassword.ShortcutsEnabled = true;
            this.bunifuTextBoxSignInPassword.Size = new System.Drawing.Size(200, 35);
            this.bunifuTextBoxSignInPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBoxSignInPassword.TabIndex = 2;
            this.bunifuTextBoxSignInPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxSignInPassword.TextMarginLeft = 10;
            this.bunifuTextBoxSignInPassword.TextPlaceholder = "Password";
            this.bunifuTextBoxSignInPassword.UseSystemPasswordChar = false;
            // 
            // bunifuTextBoxSignInUsername
            // 
            this.bunifuTextBoxSignInUsername.AcceptsReturn = false;
            this.bunifuTextBoxSignInUsername.AcceptsTab = false;
            this.bunifuTextBoxSignInUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxSignInUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxSignInUsername.BackColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignInUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxSignInUsername.BackgroundImage")));
            this.bunifuTextBoxSignInUsername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.bunifuTextBoxSignInUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBoxSignInUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.bunifuTextBoxSignInUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuTextBoxSignInUsername.BorderRadius = 1;
            this.bunifuTextBoxSignInUsername.BorderThickness = 1;
            this.bunifuTextBoxSignInUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBoxSignInUsername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBoxSignInUsername.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBoxSignInUsername.DefaultText = "";
            this.bunifuTextBoxSignInUsername.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignInUsername.HideSelection = true;
            this.bunifuTextBoxSignInUsername.IconLeft = global::MoneyFlow.Properties.Resources.username;
            this.bunifuTextBoxSignInUsername.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignInUsername.IconPadding = 10;
            this.bunifuTextBoxSignInUsername.IconRight = null;
            this.bunifuTextBoxSignInUsername.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignInUsername.Location = new System.Drawing.Point(160, 254);
            this.bunifuTextBoxSignInUsername.MaxLength = 25;
            this.bunifuTextBoxSignInUsername.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBoxSignInUsername.Modified = false;
            this.bunifuTextBoxSignInUsername.Name = "bunifuTextBoxSignInUsername";
            this.bunifuTextBoxSignInUsername.PasswordChar = '\0';
            this.bunifuTextBoxSignInUsername.ReadOnly = false;
            this.bunifuTextBoxSignInUsername.SelectedText = "";
            this.bunifuTextBoxSignInUsername.SelectionLength = 0;
            this.bunifuTextBoxSignInUsername.SelectionStart = 0;
            this.bunifuTextBoxSignInUsername.ShortcutsEnabled = true;
            this.bunifuTextBoxSignInUsername.Size = new System.Drawing.Size(200, 35);
            this.bunifuTextBoxSignInUsername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBoxSignInUsername.TabIndex = 1;
            this.bunifuTextBoxSignInUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxSignInUsername.TextMarginLeft = 10;
            this.bunifuTextBoxSignInUsername.TextPlaceholder = "Username";
            this.bunifuTextBoxSignInUsername.UseSystemPasswordChar = false;
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelSignIn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.labelSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSignIn.ForeColor = System.Drawing.Color.White;
            this.labelSignIn.Location = new System.Drawing.Point(189, 176);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(140, 42);
            this.labelSignIn.TabIndex = 3;
            this.labelSignIn.Text = "Sign In";
            // 
            // bunifuButtonSignInNext
            // 
            this.bunifuButtonSignInNext.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonSignInNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonSignInNext.BackgroundImage")));
            this.bunifuButtonSignInNext.ButtonText = "NEXT";
            this.bunifuButtonSignInNext.ButtonTextMarginLeft = 0;
            this.bunifuTransition1.SetDecoration(this.bunifuButtonSignInNext, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuButtonSignInNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButtonSignInNext.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButtonSignInNext.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButtonSignInNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButtonSignInNext.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonSignInNext.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonSignInNext.IconPadding = 10;
            this.bunifuButtonSignInNext.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonSignInNext.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButtonSignInNext.IdleBorderRadius = 1;
            this.bunifuButtonSignInNext.IdleBorderThickness = 0;
            this.bunifuButtonSignInNext.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButtonSignInNext.IdleIconLeftImage = null;
            this.bunifuButtonSignInNext.IdleIconRightImage = null;
            this.bunifuButtonSignInNext.Location = new System.Drawing.Point(171, 389);
            this.bunifuButtonSignInNext.Name = "bunifuButtonSignInNext";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButtonSignInNext.onHoverState = stateProperties1;
            this.bunifuButtonSignInNext.Size = new System.Drawing.Size(170, 45);
            this.bunifuButtonSignInNext.TabIndex = 4;
            this.bunifuButtonSignInNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonSignInNext.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // linkLabelSignInSignUp
            // 
            this.linkLabelSignInSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.linkLabelSignInSignUp.AutoSize = true;
            this.linkLabelSignInSignUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.linkLabelSignInSignUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.linkLabelSignInSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelSignInSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.linkLabelSignInSignUp.Location = new System.Drawing.Point(198, 456);
            this.linkLabelSignInSignUp.Name = "linkLabelSignInSignUp";
            this.linkLabelSignInSignUp.Size = new System.Drawing.Size(116, 16);
            this.linkLabelSignInSignUp.TabIndex = 6;
            this.linkLabelSignInSignUp.TabStop = true;
            this.linkLabelSignInSignUp.Text = "Create an account";
            this.linkLabelSignInSignUp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.linkLabelSignInSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignInSignUp_LinkClicked);
            // 
            // labelSignInError
            // 
            this.bunifuTransition1.SetDecoration(this.labelSignInError, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.labelSignInError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSignInError.ForeColor = System.Drawing.Color.Red;
            this.labelSignInError.Location = new System.Drawing.Point(-6, 361);
            this.labelSignInError.Name = "labelSignInError";
            this.labelSignInError.Size = new System.Drawing.Size(525, 24);
            this.labelSignInError.TabIndex = 7;
            this.labelSignInError.Text = "Login Failed";
            this.labelSignInError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSignInError.Visible = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(525, 600);
            this.Controls.Add(this.labelSignInError);
            this.Controls.Add(this.linkLabelSignInSignUp);
            this.Controls.Add(this.bunifuButtonSignInNext);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.bunifuTextBoxSignInPassword);
            this.Controls.Add(this.bunifuTextBoxSignInUsername);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxSignInIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSignInClose;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBoxSignInIcon;
        private System.Windows.Forms.Label labelSignInAppname;
        private System.Windows.Forms.Button buttonSignInMinimize;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBoxSignInUsername;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBoxSignInPassword;
        private System.Windows.Forms.Label labelSignIn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonSignInNext;
        private System.Windows.Forms.LinkLabel linkLabelSignInSignUp;
        private System.Windows.Forms.Label labelSignInError;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
    }
}
