namespace MoneyFlow
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMainFormMinimize = new System.Windows.Forms.Button();
            this.labelMainFormAppname = new System.Windows.Forms.Label();
            this.bunifuPictureBoxMainFormIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.buttonMainFormClose = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxMainFormIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
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
            this.panel1.Controls.Add(this.buttonMainFormMinimize);
            this.panel1.Controls.Add(this.labelMainFormAppname);
            this.panel1.Controls.Add(this.bunifuPictureBoxMainFormIcon);
            this.panel1.Controls.Add(this.buttonMainFormClose);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 27);
            this.panel1.TabIndex = 0;
            // 
            // buttonMainFormMinimize
            // 
            this.bunifuTransition1.SetDecoration(this.buttonMainFormMinimize, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.buttonMainFormMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMainFormMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMainFormMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainFormMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainFormMinimize.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonMainFormMinimize.Location = new System.Drawing.Point(978, 0);
            this.buttonMainFormMinimize.Name = "buttonMainFormMinimize";
            this.buttonMainFormMinimize.Size = new System.Drawing.Size(33, 27);
            this.buttonMainFormMinimize.TabIndex = 0;
            this.buttonMainFormMinimize.TabStop = false;
            this.buttonMainFormMinimize.Text = "_";
            this.buttonMainFormMinimize.UseVisualStyleBackColor = true;
            this.buttonMainFormMinimize.Click += new System.EventHandler(this.buttonMainFormMinimize_Click);
            // 
            // labelMainFormAppname
            // 
            this.labelMainFormAppname.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelMainFormAppname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.labelMainFormAppname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainFormAppname.ForeColor = System.Drawing.Color.White;
            this.labelMainFormAppname.Location = new System.Drawing.Point(33, 6);
            this.labelMainFormAppname.Name = "labelMainFormAppname";
            this.labelMainFormAppname.Size = new System.Drawing.Size(77, 16);
            this.labelMainFormAppname.TabIndex = 2;
            this.labelMainFormAppname.Text = "MoneyFlow";
            // 
            // bunifuPictureBoxMainFormIcon
            // 
            this.bunifuPictureBoxMainFormIcon.AllowFocused = false;
            this.bunifuPictureBoxMainFormIcon.BorderRadius = 13;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBoxMainFormIcon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBoxMainFormIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPictureBoxMainFormIcon.Image = global::MoneyFlow.Properties.Resources._320x0w;
            this.bunifuPictureBoxMainFormIcon.IsCircle = true;
            this.bunifuPictureBoxMainFormIcon.Location = new System.Drawing.Point(0, 0);
            this.bunifuPictureBoxMainFormIcon.Name = "bunifuPictureBoxMainFormIcon";
            this.bunifuPictureBoxMainFormIcon.Size = new System.Drawing.Size(27, 27);
            this.bunifuPictureBoxMainFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBoxMainFormIcon.TabIndex = 1;
            this.bunifuPictureBoxMainFormIcon.TabStop = false;
            this.bunifuPictureBoxMainFormIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // buttonMainFormClose
            // 
            this.buttonMainFormClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.buttonMainFormClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.buttonMainFormClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMainFormClose.FlatAppearance.BorderSize = 0;
            this.buttonMainFormClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMainFormClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonMainFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainFormClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainFormClose.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonMainFormClose.Location = new System.Drawing.Point(1011, 0);
            this.buttonMainFormClose.Name = "buttonMainFormClose";
            this.buttonMainFormClose.Size = new System.Drawing.Size(39, 27);
            this.buttonMainFormClose.TabIndex = 0;
            this.buttonMainFormClose.Text = "X";
            this.buttonMainFormClose.UseVisualStyleBackColor = true;
            this.buttonMainFormClose.Click += new System.EventHandler(this.buttonMainFormClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            // splitContainer1
            // 
            this.bunifuTransition1.SetDecoration(this.splitContainer1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.bunifuTransition1.SetDecoration(this.splitContainer1.Panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            // 
            // splitContainer1.Panel2
            // 
            this.bunifuTransition1.SetDecoration(this.splitContainer1.Panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 620);
            this.splitContainer1.SplitterDistance = 439;
            this.splitContainer1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1050, 647);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxMainFormIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMainFormClose;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBoxMainFormIcon;
        private System.Windows.Forms.Label labelMainFormAppname;
        private System.Windows.Forms.Button buttonMainFormMinimize;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
