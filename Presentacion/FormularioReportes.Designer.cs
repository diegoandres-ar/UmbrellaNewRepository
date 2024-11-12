namespace Presentacion
{
    partial class FormularioReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioReportes));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelReporteGeneral = new System.Windows.Forms.Panel();
            this.panelReporteVentas = new System.Windows.Forms.Panel();
            this.panelReportesJuegos = new System.Windows.Forms.Panel();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pdfViewerReportes = new PdfiumViewer.PdfViewer();
            this.BtGenerarReporte = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pickerFin = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.pickerInicio = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.pictureReporteGeneral = new System.Windows.Forms.PictureBox();
            this.picturePanelVentas = new System.Windows.Forms.PictureBox();
            this.picturePanelJuegos = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelReporteGeneral.SuspendLayout();
            this.panelReporteVentas.SuspendLayout();
            this.panelReportesJuegos.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReporteGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanelVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanelJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelReporteGeneral);
            this.panel1.Controls.Add(this.panelReporteVentas);
            this.panel1.Controls.Add(this.panelReportesJuegos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 82);
            this.panel1.TabIndex = 0;
            // 
            // panelReporteGeneral
            // 
            this.panelReporteGeneral.Controls.Add(this.pictureReporteGeneral);
            this.panelReporteGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelReporteGeneral.Location = new System.Drawing.Point(894, 12);
            this.panelReporteGeneral.Name = "panelReporteGeneral";
            this.panelReporteGeneral.Size = new System.Drawing.Size(158, 54);
            this.panelReporteGeneral.TabIndex = 3;
            // 
            // panelReporteVentas
            // 
            this.panelReporteVentas.Controls.Add(this.picturePanelVentas);
            this.panelReporteVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelReporteVentas.Location = new System.Drawing.Point(505, 12);
            this.panelReporteVentas.Name = "panelReporteVentas";
            this.panelReporteVentas.Size = new System.Drawing.Size(158, 54);
            this.panelReporteVentas.TabIndex = 2;
            // 
            // panelReportesJuegos
            // 
            this.panelReportesJuegos.Controls.Add(this.picturePanelJuegos);
            this.panelReportesJuegos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelReportesJuegos.Location = new System.Drawing.Point(116, 12);
            this.panelReportesJuegos.Name = "panelReportesJuegos";
            this.panelReportesJuegos.Size = new System.Drawing.Size(158, 54);
            this.panelReportesJuegos.TabIndex = 0;
            // 
            // panelFiltro
            // 
            this.panelFiltro.Controls.Add(this.BtGenerarReporte);
            this.panelFiltro.Controls.Add(this.pickerFin);
            this.panelFiltro.Controls.Add(this.pickerInicio);
            this.panelFiltro.Controls.Add(this.label2);
            this.panelFiltro.Controls.Add(this.label1);
            this.panelFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltro.Location = new System.Drawing.Point(0, 82);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(1200, 42);
            this.panelFiltro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde:";
            // 
            // pdfViewerReportes
            // 
            this.pdfViewerReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerReportes.Location = new System.Drawing.Point(0, 124);
            this.pdfViewerReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pdfViewerReportes.Name = "pdfViewerReportes";
            this.pdfViewerReportes.Size = new System.Drawing.Size(1200, 515);
            this.pdfViewerReportes.TabIndex = 2;
            this.pdfViewerReportes.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // BtGenerarReporte
            // 
            this.BtGenerarReporte.AllowAnimations = true;
            this.BtGenerarReporte.AllowMouseEffects = true;
            this.BtGenerarReporte.AllowToggling = false;
            this.BtGenerarReporte.AnimationSpeed = 200;
            this.BtGenerarReporte.AutoGenerateColors = false;
            this.BtGenerarReporte.AutoRoundBorders = false;
            this.BtGenerarReporte.AutoSizeLeftIcon = true;
            this.BtGenerarReporte.AutoSizeRightIcon = true;
            this.BtGenerarReporte.BackColor = System.Drawing.Color.Transparent;
            this.BtGenerarReporte.BackColor1 = System.Drawing.Color.Black;
            this.BtGenerarReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtGenerarReporte.BackgroundImage")));
            this.BtGenerarReporte.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGenerarReporte.ButtonText = "Generar Reporte";
            this.BtGenerarReporte.ButtonTextMarginLeft = 0;
            this.BtGenerarReporte.ColorContrastOnClick = 45;
            this.BtGenerarReporte.ColorContrastOnHover = 45;
            this.BtGenerarReporte.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtGenerarReporte.CustomizableEdges = borderEdges1;
            this.BtGenerarReporte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtGenerarReporte.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtGenerarReporte.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtGenerarReporte.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtGenerarReporte.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtGenerarReporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.BtGenerarReporte.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtGenerarReporte.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtGenerarReporte.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtGenerarReporte.IconMarginLeft = 11;
            this.BtGenerarReporte.IconPadding = 10;
            this.BtGenerarReporte.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtGenerarReporte.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtGenerarReporte.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtGenerarReporte.IconSize = 25;
            this.BtGenerarReporte.IdleBorderColor = System.Drawing.Color.Black;
            this.BtGenerarReporte.IdleBorderRadius = 20;
            this.BtGenerarReporte.IdleBorderThickness = 1;
            this.BtGenerarReporte.IdleFillColor = System.Drawing.Color.Black;
            this.BtGenerarReporte.IdleIconLeftImage = null;
            this.BtGenerarReporte.IdleIconRightImage = null;
            this.BtGenerarReporte.IndicateFocus = false;
            this.BtGenerarReporte.Location = new System.Drawing.Point(612, 4);
            this.BtGenerarReporte.Name = "BtGenerarReporte";
            this.BtGenerarReporte.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtGenerarReporte.OnDisabledState.BorderRadius = 20;
            this.BtGenerarReporte.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGenerarReporte.OnDisabledState.BorderThickness = 1;
            this.BtGenerarReporte.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtGenerarReporte.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtGenerarReporte.OnDisabledState.IconLeftImage = null;
            this.BtGenerarReporte.OnDisabledState.IconRightImage = null;
            this.BtGenerarReporte.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(175)))), ((int)(((byte)(185)))));
            this.BtGenerarReporte.onHoverState.BorderRadius = 20;
            this.BtGenerarReporte.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGenerarReporte.onHoverState.BorderThickness = 1;
            this.BtGenerarReporte.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(175)))), ((int)(((byte)(185)))));
            this.BtGenerarReporte.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtGenerarReporte.onHoverState.IconLeftImage = null;
            this.BtGenerarReporte.onHoverState.IconRightImage = null;
            this.BtGenerarReporte.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.BtGenerarReporte.OnIdleState.BorderRadius = 20;
            this.BtGenerarReporte.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGenerarReporte.OnIdleState.BorderThickness = 1;
            this.BtGenerarReporte.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.BtGenerarReporte.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtGenerarReporte.OnIdleState.IconLeftImage = null;
            this.BtGenerarReporte.OnIdleState.IconRightImage = null;
            this.BtGenerarReporte.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtGenerarReporte.OnPressedState.BorderRadius = 20;
            this.BtGenerarReporte.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtGenerarReporte.OnPressedState.BorderThickness = 1;
            this.BtGenerarReporte.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.BtGenerarReporte.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtGenerarReporte.OnPressedState.IconLeftImage = null;
            this.BtGenerarReporte.OnPressedState.IconRightImage = null;
            this.BtGenerarReporte.Size = new System.Drawing.Size(136, 32);
            this.BtGenerarReporte.TabIndex = 12;
            this.BtGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtGenerarReporte.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtGenerarReporte.TextMarginLeft = 0;
            this.BtGenerarReporte.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtGenerarReporte.UseDefaultRadiusAndThickness = true;
            // 
            // pickerFin
            // 
            this.pickerFin.BackColor = System.Drawing.Color.Transparent;
            this.pickerFin.BorderRadius = 17;
            this.pickerFin.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(146)))), ((int)(((byte)(246)))));
            this.pickerFin.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.pickerFin.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.pickerFin.DisabledColor = System.Drawing.Color.Gray;
            this.pickerFin.DisplayWeekNumbers = false;
            this.pickerFin.DPHeight = 0;
            this.pickerFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.pickerFin.FillDatePicker = true;
            this.pickerFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pickerFin.ForeColor = System.Drawing.Color.White;
            this.pickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerFin.Icon = ((System.Drawing.Image)(resources.GetObject("pickerFin.Icon")));
            this.pickerFin.IconColor = System.Drawing.Color.White;
            this.pickerFin.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.pickerFin.LeftTextMargin = 5;
            this.pickerFin.Location = new System.Drawing.Point(373, 4);
            this.pickerFin.MinimumSize = new System.Drawing.Size(4, 32);
            this.pickerFin.Name = "pickerFin";
            this.pickerFin.Size = new System.Drawing.Size(220, 32);
            this.pickerFin.TabIndex = 6;
            this.pickerFin.Value = new System.DateTime(2024, 11, 11, 10, 52, 0, 0);
            // 
            // pickerInicio
            // 
            this.pickerInicio.BackColor = System.Drawing.Color.Transparent;
            this.pickerInicio.BorderRadius = 17;
            this.pickerInicio.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(146)))), ((int)(((byte)(246)))));
            this.pickerInicio.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.pickerInicio.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.pickerInicio.DisabledColor = System.Drawing.Color.Gray;
            this.pickerInicio.DisplayWeekNumbers = false;
            this.pickerInicio.DPHeight = 0;
            this.pickerInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.pickerInicio.FillDatePicker = true;
            this.pickerInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pickerInicio.ForeColor = System.Drawing.Color.White;
            this.pickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerInicio.Icon = ((System.Drawing.Image)(resources.GetObject("pickerInicio.Icon")));
            this.pickerInicio.IconColor = System.Drawing.Color.White;
            this.pickerInicio.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.pickerInicio.LeftTextMargin = 5;
            this.pickerInicio.Location = new System.Drawing.Point(76, 4);
            this.pickerInicio.MinimumSize = new System.Drawing.Size(4, 32);
            this.pickerInicio.Name = "pickerInicio";
            this.pickerInicio.Size = new System.Drawing.Size(220, 32);
            this.pickerInicio.TabIndex = 2;
            this.pickerInicio.Value = new System.DateTime(2024, 11, 11, 10, 52, 0, 0);
            // 
            // pictureReporteGeneral
            // 
            this.pictureReporteGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureReporteGeneral.Image = global::Presentacion.Properties.Resources.BtReporteGeneral;
            this.pictureReporteGeneral.Location = new System.Drawing.Point(0, 0);
            this.pictureReporteGeneral.Name = "pictureReporteGeneral";
            this.pictureReporteGeneral.Size = new System.Drawing.Size(158, 54);
            this.pictureReporteGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureReporteGeneral.TabIndex = 0;
            this.pictureReporteGeneral.TabStop = false;
            this.pictureReporteGeneral.Click += new System.EventHandler(this.pictureReporteGeneral_Click);
            // 
            // picturePanelVentas
            // 
            this.picturePanelVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePanelVentas.Image = global::Presentacion.Properties.Resources.BtReporteVentas;
            this.picturePanelVentas.Location = new System.Drawing.Point(0, 0);
            this.picturePanelVentas.Name = "picturePanelVentas";
            this.picturePanelVentas.Size = new System.Drawing.Size(158, 54);
            this.picturePanelVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePanelVentas.TabIndex = 0;
            this.picturePanelVentas.TabStop = false;
            this.picturePanelVentas.Click += new System.EventHandler(this.picturePanelVentas_Click);
            // 
            // picturePanelJuegos
            // 
            this.picturePanelJuegos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePanelJuegos.Image = global::Presentacion.Properties.Resources.BtReporteJuegos;
            this.picturePanelJuegos.Location = new System.Drawing.Point(0, 0);
            this.picturePanelJuegos.Name = "picturePanelJuegos";
            this.picturePanelJuegos.Size = new System.Drawing.Size(158, 54);
            this.picturePanelJuegos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePanelJuegos.TabIndex = 0;
            this.picturePanelJuegos.TabStop = false;
            this.picturePanelJuegos.Click += new System.EventHandler(this.picturePanelJuegos_Click);
            // 
            // FormularioReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1200, 639);
            this.Controls.Add(this.pdfViewerReportes);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioReportes";
            this.Load += new System.EventHandler(this.FormularioReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panelReporteGeneral.ResumeLayout(false);
            this.panelReporteVentas.ResumeLayout(false);
            this.panelReportesJuegos.ResumeLayout(false);
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReporteGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanelVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanelJuegos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelReportesJuegos;
        private System.Windows.Forms.Panel panelReporteGeneral;
        private System.Windows.Forms.PictureBox pictureReporteGeneral;
        private System.Windows.Forms.Panel panelReporteVentas;
        private System.Windows.Forms.PictureBox picturePanelVentas;
        private System.Windows.Forms.PictureBox picturePanelJuegos;
        private System.Windows.Forms.Panel panelFiltro;
        private Bunifu.UI.WinForms.BunifuDatePicker pickerInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDatePicker pickerFin;
        private PdfiumViewer.PdfViewer pdfViewerReportes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtGenerarReporte;
    }
}