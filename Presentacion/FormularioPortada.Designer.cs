namespace Presentacion
{
    partial class FormularioPortada
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
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.labelNombreJuego = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtCerrar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.picturePortada = new System.Windows.Forms.PictureBox();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePortada)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCabecera.Controls.Add(this.labelNombreJuego);
            this.panelCabecera.Controls.Add(this.label1);
            this.panelCabecera.Controls.Add(this.BtCerrar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(478, 49);
            this.panelCabecera.TabIndex = 1;
            // 
            // labelNombreJuego
            // 
            this.labelNombreJuego.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreJuego.Location = new System.Drawing.Point(95, 0);
            this.labelNombreJuego.Name = "labelNombreJuego";
            this.labelNombreJuego.Size = new System.Drawing.Size(332, 49);
            this.labelNombreJuego.TabIndex = 3;
            this.labelNombreJuego.Text = "Portada:";
            this.labelNombreJuego.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Portada:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtCerrar
            // 
            this.BtCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCerrar.Image = global::Presentacion.Properties.Resources.Cerrar;
            this.BtCerrar.Location = new System.Drawing.Point(436, 8);
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
            // picturePortada
            // 
            this.picturePortada.Location = new System.Drawing.Point(50, 73);
            this.picturePortada.Name = "picturePortada";
            this.picturePortada.Size = new System.Drawing.Size(377, 521);
            this.picturePortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePortada.TabIndex = 2;
            this.picturePortada.TabStop = false;
            // 
            // FormularioPortada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(478, 616);
            this.Controls.Add(this.picturePortada);
            this.Controls.Add(this.panelCabecera);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioPortada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPortada";
            this.panelCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePortada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Label labelNombreJuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox picturePortada;
    }
}