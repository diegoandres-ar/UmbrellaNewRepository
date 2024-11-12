namespace Presentacion
{
    partial class FormularioPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPermisos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.BtCerrar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelEdicion = new System.Windows.Forms.Panel();
            this.BtGuardar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtDescripcion = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.BtEliminar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BtAgregar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.dgvMediosPago = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).BeginInit();
            this.panelContenido.SuspendLayout();
            this.panelEdicion.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediosPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCabecera.Controls.Add(this.BtCerrar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1088, 49);
            this.panelCabecera.TabIndex = 0;
            // 
            // BtCerrar
            // 
            this.BtCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCerrar.Image = global::Presentacion.Properties.Resources.Cerrar;
            this.BtCerrar.Location = new System.Drawing.Point(1046, 8);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(30, 33);
            this.BtCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtCerrar.TabIndex = 1;
            this.BtCerrar.TabStop = false;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.panelEdicion);
            this.panelContenido.Controls.Add(this.panelGrid);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 49);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1088, 563);
            this.panelContenido.TabIndex = 1;
            // 
            // panelEdicion
            // 
            this.panelEdicion.Controls.Add(this.label3);
            this.panelEdicion.Controls.Add(this.checkedListBox1);
            this.panelEdicion.Controls.Add(this.BtGuardar);
            this.panelEdicion.Controls.Add(this.txtDescripcion);
            this.panelEdicion.Controls.Add(this.txtID);
            this.panelEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdicion.Location = new System.Drawing.Point(0, 379);
            this.panelEdicion.Name = "panelEdicion";
            this.panelEdicion.Size = new System.Drawing.Size(1088, 184);
            this.panelEdicion.TabIndex = 1;
            // 
            // BtGuardar
            // 
            this.BtGuardar.AllowAnimations = true;
            this.BtGuardar.AllowMouseEffects = true;
            this.BtGuardar.AllowToggling = false;
            this.BtGuardar.AnimationSpeed = 200;
            this.BtGuardar.AutoGenerateColors = false;
            this.BtGuardar.AutoRoundBorders = false;
            this.BtGuardar.AutoSizeLeftIcon = true;
            this.BtGuardar.AutoSizeRightIcon = true;
            this.BtGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtGuardar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtGuardar.BackgroundImage")));
            this.BtGuardar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGuardar.ButtonText = "Guardar";
            this.BtGuardar.ButtonTextMarginLeft = 0;
            this.BtGuardar.ColorContrastOnClick = 45;
            this.BtGuardar.ColorContrastOnHover = 45;
            this.BtGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.BtGuardar.CustomizableEdges = borderEdges3;
            this.BtGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtGuardar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtGuardar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtGuardar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtGuardar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGuardar.ForeColor = System.Drawing.Color.White;
            this.BtGuardar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtGuardar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtGuardar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtGuardar.IconMarginLeft = 11;
            this.BtGuardar.IconPadding = 10;
            this.BtGuardar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtGuardar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtGuardar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtGuardar.IconSize = 25;
            this.BtGuardar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtGuardar.IdleBorderRadius = 50;
            this.BtGuardar.IdleBorderThickness = 1;
            this.BtGuardar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtGuardar.IdleIconLeftImage = null;
            this.BtGuardar.IdleIconRightImage = null;
            this.BtGuardar.IndicateFocus = false;
            this.BtGuardar.Location = new System.Drawing.Point(619, 72);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtGuardar.OnDisabledState.BorderRadius = 50;
            this.BtGuardar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGuardar.OnDisabledState.BorderThickness = 1;
            this.BtGuardar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtGuardar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtGuardar.OnDisabledState.IconLeftImage = null;
            this.BtGuardar.OnDisabledState.IconRightImage = null;
            this.BtGuardar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(175)))), ((int)(((byte)(185)))));
            this.BtGuardar.onHoverState.BorderRadius = 50;
            this.BtGuardar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGuardar.onHoverState.BorderThickness = 1;
            this.BtGuardar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(175)))), ((int)(((byte)(185)))));
            this.BtGuardar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtGuardar.onHoverState.IconLeftImage = null;
            this.BtGuardar.onHoverState.IconRightImage = null;
            this.BtGuardar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtGuardar.OnIdleState.BorderRadius = 50;
            this.BtGuardar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGuardar.OnIdleState.BorderThickness = 1;
            this.BtGuardar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtGuardar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtGuardar.OnIdleState.IconLeftImage = null;
            this.BtGuardar.OnIdleState.IconRightImage = null;
            this.BtGuardar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtGuardar.OnPressedState.BorderRadius = 50;
            this.BtGuardar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGuardar.OnPressedState.BorderThickness = 1;
            this.BtGuardar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtGuardar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtGuardar.OnPressedState.IconLeftImage = null;
            this.BtGuardar.OnPressedState.IconRightImage = null;
            this.BtGuardar.Size = new System.Drawing.Size(155, 46);
            this.BtGuardar.TabIndex = 11;
            this.BtGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtGuardar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtGuardar.TextMarginLeft = 0;
            this.BtGuardar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtGuardar.UseDefaultRadiusAndThickness = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = false;
            this.txtDescripcion.AcceptsTab = false;
            this.txtDescripcion.AnimationSpeed = 200;
            this.txtDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.txtDescripcion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDescripcion.BackgroundImage")));
            this.txtDescripcion.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            this.txtDescripcion.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDescripcion.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            this.txtDescripcion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.txtDescripcion.BorderRadius = 1;
            this.txtDescripcion.BorderThickness = 2;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.txtDescripcion.HideSelection = true;
            this.txtDescripcion.IconLeft = null;
            this.txtDescripcion.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.IconPadding = 10;
            this.txtDescripcion.IconRight = null;
            this.txtDescripcion.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(35, 100);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDescripcion.Modified = false;
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescripcion.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescripcion.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            stateProperties20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescripcion.OnIdleState = stateProperties20;
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(3);
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.PlaceholderText = "Descripción";
            this.txtDescripcion.ReadOnly = false;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(260, 47);
            this.txtDescripcion.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.TextMarginBottom = 0;
            this.txtDescripcion.TextMarginLeft = 3;
            this.txtDescripcion.TextMarginTop = 0;
            this.txtDescripcion.TextPlaceholder = "Descripción";
            this.txtDescripcion.UseSystemPasswordChar = false;
            this.txtDescripcion.WordWrap = true;
            // 
            // txtID
            // 
            this.txtID.AcceptsReturn = false;
            this.txtID.AcceptsTab = false;
            this.txtID.AnimationSpeed = 200;
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.txtID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtID.BackgroundImage")));
            this.txtID.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            this.txtID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            this.txtID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.txtID.BorderRadius = 1;
            this.txtID.BorderThickness = 2;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.DefaultText = "";
            this.txtID.Enabled = false;
            this.txtID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.txtID.HideSelection = true;
            this.txtID.IconLeft = null;
            this.txtID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.IconPadding = 10;
            this.txtID.IconRight = null;
            this.txtID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(35, 22);
            this.txtID.MaxLength = 32767;
            this.txtID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtID.Modified = false;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtID.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtID.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtID.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            stateProperties24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtID.OnIdleState = stateProperties24;
            this.txtID.Padding = new System.Windows.Forms.Padding(3);
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtID.PlaceholderText = "ID";
            this.txtID.ReadOnly = false;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(260, 47);
            this.txtID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.TextMarginBottom = 0;
            this.txtID.TextMarginLeft = 3;
            this.txtID.TextMarginTop = 0;
            this.txtID.TextPlaceholder = "ID";
            this.txtID.UseSystemPasswordChar = false;
            this.txtID.WordWrap = true;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.BtEliminar);
            this.panelGrid.Controls.Add(this.BtAgregar);
            this.panelGrid.Controls.Add(this.dgvMediosPago);
            this.panelGrid.Controls.Add(this.label2);
            this.panelGrid.Controls.Add(this.label1);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1088, 379);
            this.panelGrid.TabIndex = 0;
            // 
            // BtEliminar
            // 
            this.BtEliminar.ActiveImage = null;
            this.BtEliminar.AllowAnimations = true;
            this.BtEliminar.AllowBuffering = false;
            this.BtEliminar.AllowToggling = false;
            this.BtEliminar.AllowZooming = true;
            this.BtEliminar.AllowZoomingOnFocus = false;
            this.BtEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtEliminar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtEliminar.ErrorImage")));
            this.BtEliminar.FadeWhenInactive = false;
            this.BtEliminar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtEliminar.Image = global::Presentacion.Properties.Resources.Eliminar;
            this.BtEliminar.ImageActive = null;
            this.BtEliminar.ImageLocation = null;
            this.BtEliminar.ImageMargin = 40;
            this.BtEliminar.ImageSize = new System.Drawing.Size(21, 21);
            this.BtEliminar.ImageZoomSize = new System.Drawing.Size(61, 61);
            this.BtEliminar.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtEliminar.InitialImage")));
            this.BtEliminar.Location = new System.Drawing.Point(943, 11);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Rotation = 0;
            this.BtEliminar.ShowActiveImage = true;
            this.BtEliminar.ShowCursorChanges = true;
            this.BtEliminar.ShowImageBorders = true;
            this.BtEliminar.ShowSizeMarkers = false;
            this.BtEliminar.Size = new System.Drawing.Size(61, 61);
            this.BtEliminar.TabIndex = 11;
            this.BtEliminar.ToolTipText = "";
            this.BtEliminar.WaitOnLoad = false;
            this.BtEliminar.Zoom = 40;
            this.BtEliminar.ZoomSpeed = 10;
            // 
            // BtAgregar
            // 
            this.BtAgregar.ActiveImage = null;
            this.BtAgregar.AllowAnimations = true;
            this.BtAgregar.AllowBuffering = false;
            this.BtAgregar.AllowToggling = false;
            this.BtAgregar.AllowZooming = true;
            this.BtAgregar.AllowZoomingOnFocus = false;
            this.BtAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtAgregar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtAgregar.ErrorImage")));
            this.BtAgregar.FadeWhenInactive = false;
            this.BtAgregar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtAgregar.Image = global::Presentacion.Properties.Resources.Agregar;
            this.BtAgregar.ImageActive = null;
            this.BtAgregar.ImageLocation = null;
            this.BtAgregar.ImageMargin = 40;
            this.BtAgregar.ImageSize = new System.Drawing.Size(21, 21);
            this.BtAgregar.ImageZoomSize = new System.Drawing.Size(61, 61);
            this.BtAgregar.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtAgregar.InitialImage")));
            this.BtAgregar.Location = new System.Drawing.Point(1010, 11);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Rotation = 0;
            this.BtAgregar.ShowActiveImage = true;
            this.BtAgregar.ShowCursorChanges = true;
            this.BtAgregar.ShowImageBorders = true;
            this.BtAgregar.ShowSizeMarkers = false;
            this.BtAgregar.Size = new System.Drawing.Size(61, 61);
            this.BtAgregar.TabIndex = 9;
            this.BtAgregar.ToolTipText = "";
            this.BtAgregar.WaitOnLoad = false;
            this.BtAgregar.Zoom = 40;
            this.BtAgregar.ZoomSpeed = 10;
            // 
            // dgvMediosPago
            // 
            this.dgvMediosPago.AllowUserToAddRows = false;
            this.dgvMediosPago.AllowUserToDeleteRows = false;
            this.dgvMediosPago.AllowUserToResizeColumns = false;
            this.dgvMediosPago.AllowUserToResizeRows = false;
            this.dgvMediosPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMediosPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.dgvMediosPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMediosPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMediosPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMediosPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMediosPago.ColumnHeadersHeight = 35;
            this.dgvMediosPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMediosPago.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMediosPago.EnableHeadersVisualStyles = false;
            this.dgvMediosPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.dgvMediosPago.Location = new System.Drawing.Point(12, 76);
            this.dgvMediosPago.Name = "dgvMediosPago";
            this.dgvMediosPago.ReadOnly = true;
            this.dgvMediosPago.RowHeadersVisible = false;
            this.dgvMediosPago.RowHeadersWidth = 51;
            this.dgvMediosPago.RowTemplate.Height = 30;
            this.dgvMediosPago.Size = new System.Drawing.Size(1059, 286);
            this.dgvMediosPago.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Listado de Roles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Permisos";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.Eliminar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.FillWeight = 30F;
            this.dataGridViewImageColumn2.Frozen = true;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Presentacion.Properties.Resources.Editar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.FillWeight = 71.49103F;
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 353;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 71.49103F;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Descripción";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 353;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 71.49103F;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "N° Usuarios";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 353;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "MODULO FACTURACION",
            "MODULO REPORTES",
            "MODULO CATEGORIAS",
            "MODULO CLIENTES",
            "MODULO JUEGOS",
            "MODULO MEDIOS DE PAGO",
            "MODULO CLIENTES",
            "MODULO JUEGOS",
            "MODULO PROVEEDORES",
            "MODULO PROVEEDORES-JUEGOS",
            "MODULO USUARIOS",
            "MODULO PLATAFORMAS",
            "MODULO ROLES",
            "MODULO TIPOS DE DOCUMENTOS"});
            this.checkedListBox1.Location = new System.Drawing.Point(319, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(242, 130);
            this.checkedListBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(315, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Permisos";
            // 
            // FormularioPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1088, 612);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelCabecera);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioClientes";
            this.Load += new System.EventHandler(this.FormularioClientes_Load);
            this.panelCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.panelEdicion.ResumeLayout(false);
            this.panelEdicion.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediosPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox BtCerrar;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvMediosPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEdicion;
        private Bunifu.UI.WinForms.BunifuImageButton BtEliminar;
        private Bunifu.UI.WinForms.BunifuImageButton BtAgregar;
        private Bunifu.UI.WinForms.BunifuTextBox txtDescripcion;
        private Bunifu.UI.WinForms.BunifuTextBox txtID;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtGuardar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
    }
}