namespace MoneyFlow
{
    partial class SignUp
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSignUpMinimize = new System.Windows.Forms.Button();
            this.labelSignUpAppname = new System.Windows.Forms.Label();
            this.buttonSignUpClose = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelSignUp = new System.Windows.Forms.Label();
            this.linkLabelSignUpSignIn = new System.Windows.Forms.LinkLabel();
            this.labelSignUpError = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuButtonSignUpNext = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuTextBoxSignUpPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBoxSignUpUsername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuPictureBoxSignUpIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuTextBoxSignUpPassword2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxSignUpIcon)).BeginInit();
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
            this.panel1.Controls.Add(this.buttonSignUpMinimize);
            this.panel1.Controls.Add(this.labelSignUpAppname);
            this.panel1.Controls.Add(this.bunifuPictureBoxSignUpIcon);
            this.panel1.Controls.Add(this.buttonSignUpClose);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 27);
            this.panel1.TabIndex = 0;
            // 
            // buttonSignUpMinimize
            // 
            this.bunifuTransition1.SetDecoration(this.buttonSignUpMinimize, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.buttonSignUpMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSignUpMinimize.FlatAppearance.BorderSize = 0;
            this.buttonSignUpMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUpMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUpMinimize.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSignUpMinimize.Location = new System.Drawing.Point(453, 0);
            this.buttonSignUpMinimize.Name = "buttonSignUpMinimize";
            this.buttonSignUpMinimize.Size = new System.Drawing.Size(33, 27);
            this.buttonSignUpMinimize.TabIndex = 0;
            this.buttonSignUpMinimize.TabStop = false;
            this.buttonSignUpMinimize.Text = "_";
            this.buttonSignUpMinimize.UseVisualStyleBackColor = true;
            this.buttonSignUpMinimize.Click += new System.EventHandler(this.buttonSignUpMinimize_Click);
            // 
            // labelSignUpAppname
            // 
            this.labelSignUpAppname.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelSignUpAppname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.labelSignUpAppname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSignUpAppname.ForeColor = System.Drawing.Color.White;
            this.labelSignUpAppname.Location = new System.Drawing.Point(33, 6);
            this.labelSignUpAppname.Name = "labelSignUpAppname";
            this.labelSignUpAppname.Size = new System.Drawing.Size(77, 16);
            this.labelSignUpAppname.TabIndex = 2;
            this.labelSignUpAppname.Text = "MoneyFlow";
            // 
            // buttonSignUpClose
            // 
            this.buttonSignUpClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.buttonSignUpClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.buttonSignUpClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSignUpClose.FlatAppearance.BorderSize = 0;
            this.buttonSignUpClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSignUpClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonSignUpClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUpClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUpClose.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSignUpClose.Location = new System.Drawing.Point(486, 0);
            this.buttonSignUpClose.Name = "buttonSignUpClose";
            this.buttonSignUpClose.Size = new System.Drawing.Size(39, 27);
            this.buttonSignUpClose.TabIndex = 0;
            this.buttonSignUpClose.Text = "X";
            this.buttonSignUpClose.UseVisualStyleBackColor = true;
            this.buttonSignUpClose.Click += new System.EventHandler(this.buttonSignUpClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelSignUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.labelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSignUp.ForeColor = System.Drawing.Color.White;
            this.labelSignUp.Location = new System.Drawing.Point(180, 152);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(158, 42);
            this.labelSignUp.TabIndex = 3;
            this.labelSignUp.Text = "Sign Up";
            // 
            // linkLabelSignUpSignIn
            // 
            this.linkLabelSignUpSignIn.AutoSize = true;
            this.linkLabelSignUpSignIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.linkLabelSignUpSignIn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.linkLabelSignUpSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelSignUpSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.linkLabelSignUpSignIn.Location = new System.Drawing.Point(181, 492);
            this.linkLabelSignUpSignIn.Name = "linkLabelSignUpSignIn";
            this.linkLabelSignUpSignIn.Size = new System.Drawing.Size(148, 16);
            this.linkLabelSignUpSignIn.TabIndex = 6;
            this.linkLabelSignUpSignIn.TabStop = true;
            this.linkLabelSignUpSignIn.Text = "Already has an account";
            this.linkLabelSignUpSignIn.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.linkLabelSignUpSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUpSignIn_LinkClicked);
            // 
            // labelSignUpError
            // 
            this.labelSignUpError.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelSignUpError, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.labelSignUpError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSignUpError.ForeColor = System.Drawing.Color.Red;
            this.labelSignUpError.Location = new System.Drawing.Point(188, 398);
            this.labelSignUpError.Name = "labelSignUpError";
            this.labelSignUpError.Size = new System.Drawing.Size(140, 16);
            this.labelSignUpError.TabIndex = 7;
            this.labelSignUpError.Text = "Registration Failed";
            this.labelSignUpError.Visible = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 5F;
            animation1.MinTime = 3F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 3F;
            animation1.TransparencyCoeff = 3F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 10000;
            // 
            // bunifuButtonSignUpNext
            // 
            this.bunifuButtonSignUpNext.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonSignUpNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonSignUpNext.BackgroundImage")));
            this.bunifuButtonSignUpNext.ButtonText = "NEXT";
            this.bunifuButtonSignUpNext.ButtonTextMarginLeft = 0;
            this.bunifuButtonSignUpNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuButtonSignUpNext, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuButtonSignUpNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButtonSignUpNext.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButtonSignUpNext.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButtonSignUpNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButtonSignUpNext.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonSignUpNext.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonSignUpNext.IconPadding = 10;
            this.bunifuButtonSignUpNext.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonSignUpNext.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButtonSignUpNext.IdleBorderRadius = 1;
            this.bunifuButtonSignUpNext.IdleBorderThickness = 0;
            this.bunifuButtonSignUpNext.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButtonSignUpNext.IdleIconLeftImage = null;
            this.bunifuButtonSignUpNext.IdleIconRightImage = null;
            this.bunifuButtonSignUpNext.Location = new System.Drawing.Point(169, 425);
            this.bunifuButtonSignUpNext.Name = "bunifuButtonSignUpNext";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButtonSignUpNext.onHoverState = stateProperties1;
            this.bunifuButtonSignUpNext.Size = new System.Drawing.Size(170, 45);
            this.bunifuButtonSignUpNext.TabIndex = 4;
            this.bunifuButtonSignUpNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuTextBoxSignUpPassword
            // 
            this.bunifuTextBoxSignUpPassword.AcceptsReturn = false;
            this.bunifuTextBoxSignUpPassword.AcceptsTab = false;
            this.bunifuTextBoxSignUpPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxSignUpPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxSignUpPassword.BackColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignUpPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxSignUpPassword.BackgroundImage")));
            this.bunifuTextBoxSignUpPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.bunifuTextBoxSignUpPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBoxSignUpPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.bunifuTextBoxSignUpPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuTextBoxSignUpPassword.BorderRadius = 1;
            this.bunifuTextBoxSignUpPassword.BorderThickness = 2;
            this.bunifuTextBoxSignUpPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBoxSignUpPassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBoxSignUpPassword.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBoxSignUpPassword.DefaultText = "";
            this.bunifuTextBoxSignUpPassword.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignUpPassword.HideSelection = true;
            this.bunifuTextBoxSignUpPassword.IconLeft = global::MoneyFlow.Properties.Resources.pas;
            this.bunifuTextBoxSignUpPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignUpPassword.IconPadding = 10;
            this.bunifuTextBoxSignUpPassword.IconRight = null;
            this.bunifuTextBoxSignUpPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignUpPassword.Location = new System.Drawing.Point(160, 288);
            this.bunifuTextBoxSignUpPassword.MaxLength = 32767;
            this.bunifuTextBoxSignUpPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBoxSignUpPassword.Modified = false;
            this.bunifuTextBoxSignUpPassword.Name = "bunifuTextBoxSignUpPassword";
            this.bunifuTextBoxSignUpPassword.PasswordChar = '•';
            this.bunifuTextBoxSignUpPassword.ReadOnly = false;
            this.bunifuTextBoxSignUpPassword.SelectedText = "";
            this.bunifuTextBoxSignUpPassword.SelectionLength = 0;
            this.bunifuTextBoxSignUpPassword.SelectionStart = 0;
            this.bunifuTextBoxSignUpPassword.ShortcutsEnabled = true;
            this.bunifuTextBoxSignUpPassword.Size = new System.Drawing.Size(200, 35);
            this.bunifuTextBoxSignUpPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBoxSignUpPassword.TabIndex = 2;
            this.bunifuTextBoxSignUpPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxSignUpPassword.TextMarginLeft = 10;
            this.bunifuTextBoxSignUpPassword.TextPlaceholder = "Password";
            this.bunifuTextBoxSignUpPassword.UseSystemPasswordChar = false;
            // 
            // bunifuTextBoxSignUpUsername
            // 
            this.bunifuTextBoxSignUpUsername.AcceptsReturn = false;
            this.bunifuTextBoxSignUpUsername.AcceptsTab = false;
            this.bunifuTextBoxSignUpUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxSignUpUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxSignUpUsername.BackColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignUpUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxSignUpUsername.BackgroundImage")));
            this.bunifuTextBoxSignUpUsername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.bunifuTextBoxSignUpUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBoxSignUpUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.bunifuTextBoxSignUpUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuTextBoxSignUpUsername.BorderRadius = 1;
            this.bunifuTextBoxSignUpUsername.BorderThickness = 1;
            this.bunifuTextBoxSignUpUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBoxSignUpUsername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBoxSignUpUsername.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBoxSignUpUsername.DefaultText = "";
            this.bunifuTextBoxSignUpUsername.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignUpUsername.HideSelection = true;
            this.bunifuTextBoxSignUpUsername.IconLeft = global::MoneyFlow.Properties.Resources.username;
            this.bunifuTextBoxSignUpUsername.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignUpUsername.IconPadding = 10;
            this.bunifuTextBoxSignUpUsername.IconRight = null;
            this.bunifuTextBoxSignUpUsername.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignUpUsername.Location = new System.Drawing.Point(160, 232);
            this.bunifuTextBoxSignUpUsername.MaxLength = 32767;
            this.bunifuTextBoxSignUpUsername.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBoxSignUpUsername.Modified = false;
            this.bunifuTextBoxSignUpUsername.Name = "bunifuTextBoxSignUpUsername";
            this.bunifuTextBoxSignUpUsername.PasswordChar = '\0';
            this.bunifuTextBoxSignUpUsername.ReadOnly = false;
            this.bunifuTextBoxSignUpUsername.SelectedText = "";
            this.bunifuTextBoxSignUpUsername.SelectionLength = 0;
            this.bunifuTextBoxSignUpUsername.SelectionStart = 0;
            this.bunifuTextBoxSignUpUsername.ShortcutsEnabled = true;
            this.bunifuTextBoxSignUpUsername.Size = new System.Drawing.Size(200, 35);
            this.bunifuTextBoxSignUpUsername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBoxSignUpUsername.TabIndex = 1;
            this.bunifuTextBoxSignUpUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxSignUpUsername.TextMarginLeft = 10;
            this.bunifuTextBoxSignUpUsername.TextPlaceholder = "Username";
            this.bunifuTextBoxSignUpUsername.UseSystemPasswordChar = false;
            // 
            // bunifuPictureBoxSignUpIcon
            // 
            this.bunifuPictureBoxSignUpIcon.AllowFocused = false;
            this.bunifuPictureBoxSignUpIcon.BorderRadius = 13;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBoxSignUpIcon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBoxSignUpIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPictureBoxSignUpIcon.Image = global::MoneyFlow.Properties.Resources._320x0w;
            this.bunifuPictureBoxSignUpIcon.IsCircle = true;
            this.bunifuPictureBoxSignUpIcon.Location = new System.Drawing.Point(0, 0);
            this.bunifuPictureBoxSignUpIcon.Name = "bunifuPictureBoxSignUpIcon";
            this.bunifuPictureBoxSignUpIcon.Size = new System.Drawing.Size(27, 27);
            this.bunifuPictureBoxSignUpIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBoxSignUpIcon.TabIndex = 1;
            this.bunifuPictureBoxSignUpIcon.TabStop = false;
            this.bunifuPictureBoxSignUpIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuTextBoxSignUpPassword2
            // 
            this.bunifuTextBoxSignUpPassword2.AcceptsReturn = false;
            this.bunifuTextBoxSignUpPassword2.AcceptsTab = false;
            this.bunifuTextBoxSignUpPassword2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxSignUpPassword2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxSignUpPassword2.BackColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignUpPassword2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxSignUpPassword2.BackgroundImage")));
            this.bunifuTextBoxSignUpPassword2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.bunifuTextBoxSignUpPassword2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBoxSignUpPassword2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.bunifuTextBoxSignUpPassword2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuTextBoxSignUpPassword2.BorderRadius = 1;
            this.bunifuTextBoxSignUpPassword2.BorderThickness = 2;
            this.bunifuTextBoxSignUpPassword2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBoxSignUpPassword2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBoxSignUpPassword2.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBoxSignUpPassword2.DefaultText = "";
            this.bunifuTextBoxSignUpPassword2.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxSignUpPassword2.HideSelection = true;
            this.bunifuTextBoxSignUpPassword2.IconLeft = global::MoneyFlow.Properties.Resources.pas;
            this.bunifuTextBoxSignUpPassword2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignUpPassword2.IconPadding = 10;
            this.bunifuTextBoxSignUpPassword2.IconRight = null;
            this.bunifuTextBoxSignUpPassword2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBoxSignUpPassword2.Location = new System.Drawing.Point(160, 344);
            this.bunifuTextBoxSignUpPassword2.MaxLength = 32767;
            this.bunifuTextBoxSignUpPassword2.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBoxSignUpPassword2.Modified = false;
            this.bunifuTextBoxSignUpPassword2.Name = "bunifuTextBoxSignUpPassword2";
            this.bunifuTextBoxSignUpPassword2.PasswordChar = '\0';
            this.bunifuTextBoxSignUpPassword2.ReadOnly = false;
            this.bunifuTextBoxSignUpPassword2.SelectedText = "";
            this.bunifuTextBoxSignUpPassword2.SelectionLength = 0;
            this.bunifuTextBoxSignUpPassword2.SelectionStart = 0;
            this.bunifuTextBoxSignUpPassword2.ShortcutsEnabled = true;
            this.bunifuTextBoxSignUpPassword2.Size = new System.Drawing.Size(200, 35);
            this.bunifuTextBoxSignUpPassword2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBoxSignUpPassword2.TabIndex = 8;
            this.bunifuTextBoxSignUpPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxSignUpPassword2.TextMarginLeft = 10;
            this.bunifuTextBoxSignUpPassword2.TextPlaceholder = "Repeat Password";
            this.bunifuTextBoxSignUpPassword2.UseSystemPasswordChar = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(525, 600);
            this.Controls.Add(this.bunifuTextBoxSignUpPassword2);
            this.Controls.Add(this.labelSignUpError);
            this.Controls.Add(this.linkLabelSignUpSignIn);
            this.Controls.Add(this.bunifuButtonSignUpNext);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.bunifuTextBoxSignUpPassword);
            this.Controls.Add(this.bunifuTextBoxSignUpUsername);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxSignUpIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSignUpClose;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBoxSignUpIcon;
        private System.Windows.Forms.Label labelSignUpAppname;
        private System.Windows.Forms.Button buttonSignUpMinimize;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBoxSignUpUsername;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBoxSignUpPassword;
        private System.Windows.Forms.Label labelSignUp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonSignUpNext;
        private System.Windows.Forms.LinkLabel linkLabelSignUpSignIn;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Label labelSignUpError;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBoxSignUpPassword2;
    }
}
