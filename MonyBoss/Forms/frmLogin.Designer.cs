using System.ComponentModel;

namespace MonyBoss.Forms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CloseBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.loginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.showPwd = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbShowPwd = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.backLoginLbl = new System.Windows.Forms.Label();
            this.AlreadyAccLbl = new System.Windows.Forms.Label();
            this.LblPwd = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.White;
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BorderRadius = 10;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(75, 252);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = true;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.White;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Enter Password";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(223, 38);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 4;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 1;
            this.bunifuTextBox1.TextPlaceholder = "Enter Password";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = false;
            this.txtUsername.AcceptsTab = false;
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.AnimationSpeed = 200;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.AutoSizeHeight = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUsername.BorderColorDisabled = System.Drawing.Color.White;
            this.txtUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.DefaultText = "";
            this.txtUsername.FillColor = System.Drawing.Color.White;
            this.txtUsername.HideSelection = true;
            this.txtUsername.IconLeft = null;
            this.txtUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.IconPadding = 10;
            this.txtUsername.IconRight = null;
            this.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(75, 159);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsername.Modified = false;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.White;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Transparent;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnIdleState = stateProperties8;
            this.txtUsername.Padding = new System.Windows.Forms.Padding(3);
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUsername.PlaceholderText = "Enter Username";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(223, 38);
            this.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMarginBottom = 0;
            this.txtUsername.TextMarginLeft = 3;
            this.txtUsername.TextMarginTop = 1;
            this.txtUsername.TextPlaceholder = "Enter Username";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WordWrap = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.ActiveImage = null;
            this.CloseBtn.AllowAnimations = true;
            this.CloseBtn.AllowBuffering = false;
            this.CloseBtn.AllowToggling = false;
            this.CloseBtn.AllowZooming = true;
            this.CloseBtn.AllowZoomingOnFocus = false;
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CloseBtn.ErrorImage")));
            this.CloseBtn.FadeWhenInactive = false;
            this.CloseBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.ImageLocation = null;
            this.CloseBtn.ImageMargin = 20;
            this.CloseBtn.ImageSize = new System.Drawing.Size(18, 19);
            this.CloseBtn.ImageZoomSize = new System.Drawing.Size(38, 39);
            this.CloseBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseBtn.InitialImage")));
            this.CloseBtn.Location = new System.Drawing.Point(328, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Rotation = 0;
            this.CloseBtn.ShowActiveImage = true;
            this.CloseBtn.ShowCursorChanges = true;
            this.CloseBtn.ShowImageBorders = true;
            this.CloseBtn.ShowSizeMarkers = false;
            this.CloseBtn.Size = new System.Drawing.Size(38, 39);
            this.CloseBtn.TabIndex = 46;
            this.CloseBtn.ToolTipText = "";
            this.CloseBtn.WaitOnLoad = false;
            this.CloseBtn.Zoom = 20;
            this.CloseBtn.ZoomSpeed = 10;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.AllowAnimations = true;
            this.loginBtn.AllowMouseEffects = true;
            this.loginBtn.AllowToggling = false;
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.AnimationSpeed = 200;
            this.loginBtn.AutoGenerateColors = false;
            this.loginBtn.AutoRoundBorders = true;
            this.loginBtn.AutoSizeLeftIcon = true;
            this.loginBtn.AutoSizeRightIcon = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
            this.loginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.ButtonText = "Login";
            this.loginBtn.ButtonTextMarginLeft = 0;
            this.loginBtn.ColorContrastOnClick = 45;
            this.loginBtn.ColorContrastOnHover = 45;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.loginBtn.CustomizableEdges = borderEdges1;
            this.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.loginBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.loginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.IconLeft = null;
            this.loginBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.loginBtn.IconMarginLeft = 11;
            this.loginBtn.IconPadding = 10;
            this.loginBtn.IconRight = null;
            this.loginBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.loginBtn.IconSize = 25;
            this.loginBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.loginBtn.IdleBorderRadius = 0;
            this.loginBtn.IdleBorderThickness = 0;
            this.loginBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.loginBtn.IdleIconLeftImage = null;
            this.loginBtn.IdleIconRightImage = null;
            this.loginBtn.IndicateFocus = false;
            this.loginBtn.Location = new System.Drawing.Point(75, 343);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBtn.OnDisabledState.BorderRadius = 39;
            this.loginBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.OnDisabledState.BorderThickness = 1;
            this.loginBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.loginBtn.OnDisabledState.IconLeftImage = null;
            this.loginBtn.OnDisabledState.IconRightImage = null;
            this.loginBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(177)))), ((int)(((byte)(63)))));
            this.loginBtn.onHoverState.BorderRadius = 39;
            this.loginBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.onHoverState.BorderThickness = 1;
            this.loginBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(177)))), ((int)(((byte)(63)))));
            this.loginBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.loginBtn.onHoverState.IconLeftImage = null;
            this.loginBtn.onHoverState.IconRightImage = null;
            this.loginBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(177)))), ((int)(((byte)(63)))));
            this.loginBtn.OnIdleState.BorderRadius = 39;
            this.loginBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.OnIdleState.BorderThickness = 1;
            this.loginBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(177)))), ((int)(((byte)(63)))));
            this.loginBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.loginBtn.OnIdleState.IconLeftImage = null;
            this.loginBtn.OnIdleState.IconRightImage = null;
            this.loginBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.loginBtn.OnPressedState.BorderRadius = 39;
            this.loginBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.OnPressedState.BorderThickness = 1;
            this.loginBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(177)))), ((int)(((byte)(63)))));
            this.loginBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.loginBtn.OnPressedState.IconLeftImage = null;
            this.loginBtn.OnPressedState.IconRightImage = null;
            this.loginBtn.Size = new System.Drawing.Size(223, 39);
            this.loginBtn.TabIndex = 49;
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBtn.TextMarginLeft = 0;
            this.loginBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.loginBtn.UseDefaultRadiusAndThickness = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // showPwd
            // 
            this.showPwd.AllowParentOverrides = false;
            this.showPwd.AutoEllipsis = false;
            this.showPwd.CursorType = null;
            this.showPwd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPwd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showPwd.Location = new System.Drawing.Point(102, 299);
            this.showPwd.Name = "showPwd";
            this.showPwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showPwd.Size = new System.Drawing.Size(91, 17);
            this.showPwd.TabIndex = 48;
            this.showPwd.Text = "Show Password";
            this.showPwd.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.showPwd.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbShowPwd
            // 
            this.cbShowPwd.AllowBindingControlAnimation = true;
            this.cbShowPwd.AllowBindingControlColorChanges = false;
            this.cbShowPwd.AllowBindingControlLocation = true;
            this.cbShowPwd.AllowCheckBoxAnimation = false;
            this.cbShowPwd.AllowCheckmarkAnimation = true;
            this.cbShowPwd.AllowOnHoverStates = true;
            this.cbShowPwd.AutoCheck = true;
            this.cbShowPwd.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbShowPwd.BackgroundImage")));
            this.cbShowPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbShowPwd.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbShowPwd.BorderRadius = 12;
            this.cbShowPwd.Checked = true;
            this.cbShowPwd.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.cbShowPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPwd.CustomCheckmarkImage = null;
            this.cbShowPwd.Location = new System.Drawing.Point(75, 299);
            this.cbShowPwd.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbShowPwd.Name = "cbShowPwd";
            this.cbShowPwd.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cbShowPwd.OnCheck.BorderRadius = 12;
            this.cbShowPwd.OnCheck.BorderThickness = 2;
            this.cbShowPwd.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.cbShowPwd.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbShowPwd.OnCheck.CheckmarkThickness = 2;
            this.cbShowPwd.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.cbShowPwd.OnDisable.BorderRadius = 12;
            this.cbShowPwd.OnDisable.BorderThickness = 2;
            this.cbShowPwd.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbShowPwd.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.cbShowPwd.OnDisable.CheckmarkThickness = 2;
            this.cbShowPwd.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbShowPwd.OnHoverChecked.BorderRadius = 12;
            this.cbShowPwd.OnHoverChecked.BorderThickness = 2;
            this.cbShowPwd.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbShowPwd.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbShowPwd.OnHoverChecked.CheckmarkThickness = 2;
            this.cbShowPwd.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbShowPwd.OnHoverUnchecked.BorderRadius = 12;
            this.cbShowPwd.OnHoverUnchecked.BorderThickness = 1;
            this.cbShowPwd.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbShowPwd.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbShowPwd.OnUncheck.BorderRadius = 12;
            this.cbShowPwd.OnUncheck.BorderThickness = 1;
            this.cbShowPwd.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbShowPwd.Size = new System.Drawing.Size(21, 21);
            this.cbShowPwd.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbShowPwd.TabIndex = 47;
            this.cbShowPwd.ThreeState = false;
            this.cbShowPwd.ToolTipText = null;
            // 
            // backLoginLbl
            // 
            this.backLoginLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backLoginLbl.AutoSize = true;
            this.backLoginLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLoginLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLoginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(177)))), ((int)(((byte)(63)))));
            this.backLoginLbl.Location = new System.Drawing.Point(120, 405);
            this.backLoginLbl.Name = "backLoginLbl";
            this.backLoginLbl.Size = new System.Drawing.Size(118, 20);
            this.backLoginLbl.TabIndex = 56;
            this.backLoginLbl.Text = "Back to Register";
            this.backLoginLbl.Click += new System.EventHandler(this.backLoginLbl_Click);
            // 
            // AlreadyAccLbl
            // 
            this.AlreadyAccLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlreadyAccLbl.AutoSize = true;
            this.AlreadyAccLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyAccLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AlreadyAccLbl.Location = new System.Drawing.Point(98, 385);
            this.AlreadyAccLbl.Name = "AlreadyAccLbl";
            this.AlreadyAccLbl.Size = new System.Drawing.Size(166, 20);
            this.AlreadyAccLbl.TabIndex = 55;
            this.AlreadyAccLbl.Text = "Don\'t Have an Account";
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPwd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblPwd.Location = new System.Drawing.Point(71, 226);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(82, 23);
            this.LblPwd.TabIndex = 54;
            this.LblPwd.Text = "Password";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblUsername.Location = new System.Drawing.Point(71, 133);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(87, 23);
            this.LblUsername.TabIndex = 53;
            this.LblUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(177)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(68, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 38);
            this.label1.TabIndex = 57;
            this.label1.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backLoginLbl);
            this.Controls.Add(this.AlreadyAccLbl);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.showPwd);
            this.Controls.Add(this.cbShowPwd);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox txtUsername;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuImageButton CloseBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton loginBtn;
        private Bunifu.UI.WinForms.BunifuLabel showPwd;
        private Bunifu.UI.WinForms.BunifuCheckBox cbShowPwd;
        private System.Windows.Forms.Label backLoginLbl;
        private System.Windows.Forms.Label AlreadyAccLbl;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label1;
    }
}