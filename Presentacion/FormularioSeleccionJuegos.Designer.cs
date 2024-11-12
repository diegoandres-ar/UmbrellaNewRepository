namespace Presentacion
{
    partial class FormularioSeleccionJuegos
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioSeleccionJuegos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtCerrar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtLimpiar = new System.Windows.Forms.PictureBox();
            this.txtID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtAceptar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtLimpiar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCabecera.Controls.Add(this.label1);
            this.panelCabecera.Controls.Add(this.BtCerrar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(960, 49);
            this.panelCabecera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(887, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona tus videojuegos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtCerrar
            // 
            this.BtCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCerrar.Image = global::Presentacion.Properties.Resources.Cerrar;
            this.BtCerrar.Location = new System.Drawing.Point(918, 8);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.BtLimpiar);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.comboFiltro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 63);
            this.panel1.TabIndex = 2;
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLimpiar.Image = global::Presentacion.Properties.Resources.escoba;
            this.BtLimpiar.Location = new System.Drawing.Point(863, 16);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(28, 28);
            this.BtLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtLimpiar.TabIndex = 4;
            this.BtLimpiar.TabStop = false;
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
            this.txtID.BorderThickness = 1;
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
            this.txtID.Location = new System.Drawing.Point(286, 16);
            this.txtID.MaxLength = 32767;
            this.txtID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtID.Modified = false;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtID.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtID.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(132)))), ((int)(((byte)(140)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtID.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtID.OnIdleState = stateProperties4;
            this.txtID.Padding = new System.Windows.Forms.Padding(3);
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = false;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(570, 39);
            this.txtID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtID.TabIndex = 3;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.TextMarginBottom = 0;
            this.txtID.TextMarginLeft = 3;
            this.txtID.TextMarginTop = 0;
            this.txtID.TextPlaceholder = "";
            this.txtID.UseSystemPasswordChar = false;
            this.txtID.WordWrap = true;
            // 
            // comboFiltro
            // 
            this.comboFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "ID",
            "DESCRIPCIÓN",
            "CATEGORÍA",
            "AÑO"});
            this.comboFiltro.Location = new System.Drawing.Point(109, 16);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(171, 28);
            this.comboFiltro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar por:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtAceptar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 63);
            this.panel2.TabIndex = 3;
            // 
            // BtAceptar
            // 
            this.BtAceptar.AllowAnimations = true;
            this.BtAceptar.AllowMouseEffects = true;
            this.BtAceptar.AllowToggling = false;
            this.BtAceptar.AnimationSpeed = 200;
            this.BtAceptar.AutoGenerateColors = false;
            this.BtAceptar.AutoRoundBorders = false;
            this.BtAceptar.AutoSizeLeftIcon = true;
            this.BtAceptar.AutoSizeRightIcon = true;
            this.BtAceptar.BackColor = System.Drawing.Color.Transparent;
            this.BtAceptar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtAceptar.BackgroundImage")));
            this.BtAceptar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAceptar.ButtonText = "Aceptar";
            this.BtAceptar.ButtonTextMarginLeft = 0;
            this.BtAceptar.ColorContrastOnClick = 45;
            this.BtAceptar.ColorContrastOnHover = 45;
            this.BtAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtAceptar.CustomizableEdges = borderEdges1;
            this.BtAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtAceptar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtAceptar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtAceptar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtAceptar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtAceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAceptar.ForeColor = System.Drawing.Color.White;
            this.BtAceptar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAceptar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtAceptar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtAceptar.IconMarginLeft = 11;
            this.BtAceptar.IconPadding = 10;
            this.BtAceptar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAceptar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtAceptar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtAceptar.IconSize = 25;
            this.BtAceptar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtAceptar.IdleBorderRadius = 20;
            this.BtAceptar.IdleBorderThickness = 1;
            this.BtAceptar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtAceptar.IdleIconLeftImage = null;
            this.BtAceptar.IdleIconRightImage = null;
            this.BtAceptar.IndicateFocus = false;
            this.BtAceptar.Location = new System.Drawing.Point(780, 10);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtAceptar.OnDisabledState.BorderRadius = 20;
            this.BtAceptar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAceptar.OnDisabledState.BorderThickness = 1;
            this.BtAceptar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtAceptar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtAceptar.OnDisabledState.IconLeftImage = null;
            this.BtAceptar.OnDisabledState.IconRightImage = null;
            this.BtAceptar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(175)))), ((int)(((byte)(185)))));
            this.BtAceptar.onHoverState.BorderRadius = 20;
            this.BtAceptar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAceptar.onHoverState.BorderThickness = 1;
            this.BtAceptar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(175)))), ((int)(((byte)(185)))));
            this.BtAceptar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtAceptar.onHoverState.IconLeftImage = null;
            this.BtAceptar.onHoverState.IconRightImage = null;
            this.BtAceptar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtAceptar.OnIdleState.BorderRadius = 20;
            this.BtAceptar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAceptar.OnIdleState.BorderThickness = 1;
            this.BtAceptar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtAceptar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtAceptar.OnIdleState.IconLeftImage = null;
            this.BtAceptar.OnIdleState.IconRightImage = null;
            this.BtAceptar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtAceptar.OnPressedState.BorderRadius = 20;
            this.BtAceptar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtAceptar.OnPressedState.BorderThickness = 1;
            this.BtAceptar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtAceptar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtAceptar.OnPressedState.IconLeftImage = null;
            this.BtAceptar.OnPressedState.IconRightImage = null;
            this.BtAceptar.Size = new System.Drawing.Size(168, 39);
            this.BtAceptar.TabIndex = 20;
            this.BtAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtAceptar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtAceptar.TextMarginLeft = 0;
            this.BtAceptar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtAceptar.UseDefaultRadiusAndThickness = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.AllowUserToAddRows = false;
            this.dgvJuegos.AllowUserToDeleteRows = false;
            this.dgvJuegos.AllowUserToResizeColumns = false;
            this.dgvJuegos.AllowUserToResizeRows = false;
            this.dgvJuegos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.dgvJuegos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJuegos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvJuegos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJuegos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJuegos.ColumnHeadersHeight = 35;
            this.dgvJuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column8,
            this.Column1,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column2,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJuegos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJuegos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJuegos.EnableHeadersVisualStyles = false;
            this.dgvJuegos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.dgvJuegos.Location = new System.Drawing.Point(0, 112);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvJuegos.RowHeadersVisible = false;
            this.dgvJuegos.RowHeadersWidth = 51;
            this.dgvJuegos.RowTemplate.Height = 30;
            this.dgvJuegos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJuegos.Size = new System.Drawing.Size(960, 365);
            this.dgvJuegos.TabIndex = 8;
            this.dgvJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJuegos_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "ID";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 90;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 71.49103F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Título";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 180;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.FillWeight = 71.49103F;
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Categoría";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 161;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Año Lanz.";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Stock";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Portada";
            this.Column4.Image = global::Presentacion.Properties.Resources.Ver_portada;
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.Ver_portada;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // FormularioSeleccionJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.dgvJuegos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCabecera);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioSeleccionJuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioSeleccionJuegos";
            this.Load += new System.EventHandler(this.FormularioSeleccionJuegos_Load);
            this.panelCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtLimpiar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvJuegos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFiltro;
        private Bunifu.UI.WinForms.BunifuTextBox txtID;
        private System.Windows.Forms.PictureBox BtLimpiar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtAceptar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}