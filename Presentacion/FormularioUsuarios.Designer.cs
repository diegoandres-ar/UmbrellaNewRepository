namespace Presentacion
{
    partial class FormularioUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioUsuarios));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.BtCerrar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContenido = new System.Windows.Forms.Panel();
            this.BtNuevoUsuario = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).BeginInit();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.panelContenido.Controls.Add(this.BtNuevoUsuario);
            this.panelContenido.Controls.Add(this.dgvUsuarios);
            this.panelContenido.Controls.Add(this.label2);
            this.panelContenido.Controls.Add(this.label1);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 49);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1088, 563);
            this.panelContenido.TabIndex = 1;
            // 
            // BtNuevoUsuario
            // 
            this.BtNuevoUsuario.AllowAnimations = true;
            this.BtNuevoUsuario.AllowMouseEffects = true;
            this.BtNuevoUsuario.AllowToggling = false;
            this.BtNuevoUsuario.AnimationSpeed = 200;
            this.BtNuevoUsuario.AutoGenerateColors = false;
            this.BtNuevoUsuario.AutoRoundBorders = false;
            this.BtNuevoUsuario.AutoSizeLeftIcon = true;
            this.BtNuevoUsuario.AutoSizeRightIcon = true;
            this.BtNuevoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BtNuevoUsuario.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtNuevoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtNuevoUsuario.BackgroundImage")));
            this.BtNuevoUsuario.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtNuevoUsuario.ButtonText = "Nuevo Usuario";
            this.BtNuevoUsuario.ButtonTextMarginLeft = 0;
            this.BtNuevoUsuario.ColorContrastOnClick = 45;
            this.BtNuevoUsuario.ColorContrastOnHover = 45;
            this.BtNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtNuevoUsuario.CustomizableEdges = borderEdges1;
            this.BtNuevoUsuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtNuevoUsuario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtNuevoUsuario.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtNuevoUsuario.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtNuevoUsuario.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtNuevoUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.BtNuevoUsuario.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtNuevoUsuario.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtNuevoUsuario.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtNuevoUsuario.IconMarginLeft = 11;
            this.BtNuevoUsuario.IconPadding = 10;
            this.BtNuevoUsuario.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtNuevoUsuario.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtNuevoUsuario.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtNuevoUsuario.IconSize = 25;
            this.BtNuevoUsuario.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtNuevoUsuario.IdleBorderRadius = 50;
            this.BtNuevoUsuario.IdleBorderThickness = 1;
            this.BtNuevoUsuario.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtNuevoUsuario.IdleIconLeftImage = null;
            this.BtNuevoUsuario.IdleIconRightImage = null;
            this.BtNuevoUsuario.IndicateFocus = false;
            this.BtNuevoUsuario.Location = new System.Drawing.Point(881, 13);
            this.BtNuevoUsuario.Name = "BtNuevoUsuario";
            this.BtNuevoUsuario.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtNuevoUsuario.OnDisabledState.BorderRadius = 50;
            this.BtNuevoUsuario.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtNuevoUsuario.OnDisabledState.BorderThickness = 1;
            this.BtNuevoUsuario.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtNuevoUsuario.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtNuevoUsuario.OnDisabledState.IconLeftImage = null;
            this.BtNuevoUsuario.OnDisabledState.IconRightImage = null;
            this.BtNuevoUsuario.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(175)))), ((int)(((byte)(185)))));
            this.BtNuevoUsuario.onHoverState.BorderRadius = 50;
            this.BtNuevoUsuario.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtNuevoUsuario.onHoverState.BorderThickness = 1;
            this.BtNuevoUsuario.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(175)))), ((int)(((byte)(185)))));
            this.BtNuevoUsuario.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtNuevoUsuario.onHoverState.IconLeftImage = null;
            this.BtNuevoUsuario.onHoverState.IconRightImage = null;
            this.BtNuevoUsuario.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtNuevoUsuario.OnIdleState.BorderRadius = 50;
            this.BtNuevoUsuario.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtNuevoUsuario.OnIdleState.BorderThickness = 1;
            this.BtNuevoUsuario.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtNuevoUsuario.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtNuevoUsuario.OnIdleState.IconLeftImage = null;
            this.BtNuevoUsuario.OnIdleState.IconRightImage = null;
            this.BtNuevoUsuario.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtNuevoUsuario.OnPressedState.BorderRadius = 50;
            this.BtNuevoUsuario.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtNuevoUsuario.OnPressedState.BorderThickness = 1;
            this.BtNuevoUsuario.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtNuevoUsuario.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtNuevoUsuario.OnPressedState.IconLeftImage = null;
            this.BtNuevoUsuario.OnPressedState.IconRightImage = null;
            this.BtNuevoUsuario.Size = new System.Drawing.Size(195, 58);
            this.BtNuevoUsuario.TabIndex = 5;
            this.BtNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtNuevoUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtNuevoUsuario.TextMarginLeft = 0;
            this.BtNuevoUsuario.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtNuevoUsuario.UseDefaultRadiusAndThickness = true;
            this.BtNuevoUsuario.Click += new System.EventHandler(this.BtNuevoCliente_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 35;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column5,
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(17, 78);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 30;
            this.dgvUsuarios.Size = new System.Drawing.Size(1059, 473);
            this.dgvUsuarios.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listado de Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios";
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
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.Frozen = true;
            this.Column8.HeaderText = " ";
            this.Column8.Image = global::Presentacion.Properties.Resources.Eliminar;
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.MinimumWidth = 50;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 50;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.Frozen = true;
            this.Column5.HeaderText = " ";
            this.Column5.Image = global::Presentacion.Properties.Resources.Editar;
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.MinimumWidth = 50;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 50;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 71.49103F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Nombre Completo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 155;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 71.49103F;
            this.Column6.HeaderText = "T. Documento";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 71.49103F;
            this.Column2.HeaderText = "Documento";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 71.49103F;
            this.Column3.HeaderText = "Teléfono";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 71.49103F;
            this.Column4.HeaderText = "Correo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 71.49103F;
            this.Column7.HeaderText = "No. Ventas";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1088, 612);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelCabecera);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioClientes";
            this.Load += new System.EventHandler(this.FormularioClientes_Load);
            this.panelCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox BtCerrar;
        private System.Windows.Forms.Panel panelContenido;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtNuevoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}