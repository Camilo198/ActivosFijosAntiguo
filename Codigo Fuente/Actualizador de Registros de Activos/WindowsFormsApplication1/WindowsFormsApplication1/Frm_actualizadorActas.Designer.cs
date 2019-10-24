namespace RegistrosActas
{
    partial class actualizadorActasControlador
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actualizadorActasControlador));
            this.b1Actualizar = new System.Windows.Forms.Button();
            this.l1Acta = new System.Windows.Forms.Label();
            this.t1Acta = new System.Windows.Forms.TextBox();
            this.p1Credo = new System.Windows.Forms.PictureBox();
            this.l2Info = new System.Windows.Forms.Label();
            this.b2Salir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.p1Credo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b1Actualizar
            // 
            this.b1Actualizar.Location = new System.Drawing.Point(81, 85);
            this.b1Actualizar.Name = "b1Actualizar";
            this.b1Actualizar.Size = new System.Drawing.Size(75, 23);
            this.b1Actualizar.TabIndex = 1;
            this.b1Actualizar.Text = "Actualizar";
            this.b1Actualizar.UseVisualStyleBackColor = true;
            this.b1Actualizar.Click += new System.EventHandler(this.b1Actualizar_Click);
            // 
            // l1Acta
            // 
            this.l1Acta.AutoSize = true;
            this.l1Acta.Location = new System.Drawing.Point(28, 62);
            this.l1Acta.Name = "l1Acta";
            this.l1Acta.Size = new System.Drawing.Size(54, 13);
            this.l1Acta.TabIndex = 1;
            this.l1Acta.Text = "# de Acta";
            // 
            // t1Acta
            // 
            this.t1Acta.Location = new System.Drawing.Point(81, 59);
            this.t1Acta.Name = "t1Acta";
            this.t1Acta.Size = new System.Drawing.Size(100, 20);
            this.t1Acta.TabIndex = 0;
            this.t1Acta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // p1Credo
            // 
            this.p1Credo.Image = ((System.Drawing.Image)(resources.GetObject("p1Credo.Image")));
            this.p1Credo.Location = new System.Drawing.Point(-22, 158);
            this.p1Credo.Name = "p1Credo";
            this.p1Credo.Size = new System.Drawing.Size(301, 118);
            this.p1Credo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Credo.TabIndex = 3;
            this.p1Credo.TabStop = false;
            this.p1Credo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // l2Info
            // 
            this.l2Info.AutoSize = true;
            this.l2Info.BackColor = System.Drawing.SystemColors.Control;
            this.l2Info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l2Info.Location = new System.Drawing.Point(24, 204);
            this.l2Info.Name = "l2Info";
            this.l2Info.Size = new System.Drawing.Size(207, 26);
            this.l2Info.TabIndex = 4;
            this.l2Info.Text = "Programa para Actualizar el registro de las \n              Actas  de los activos";
            this.l2Info.Click += new System.EventHandler(this.l2Info_Click);
            // 
            // b2Salir
            // 
            this.b2Salir.Location = new System.Drawing.Point(181, 116);
            this.b2Salir.Name = "b2Salir";
            this.b2Salir.Size = new System.Drawing.Size(75, 23);
            this.b2Salir.TabIndex = 3;
            this.b2Salir.Text = "Salir";
            this.b2Salir.UseVisualStyleBackColor = true;
            this.b2Salir.Click += new System.EventHandler(this.b2Salir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(256, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activosToolStripMenuItem});
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // activosToolStripMenuItem
            // 
            this.activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            this.activosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.activosToolStripMenuItem.Text = "Activos";
            this.activosToolStripMenuItem.Click += new System.EventHandler(this.activosToolStripMenuItem_Click);
            // 
            // actualizadorActasControlador
            // 
            this.AcceptButton = this.b1Actualizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(256, 261);
            this.Controls.Add(this.b2Salir);
            this.Controls.Add(this.l2Info);
            this.Controls.Add(this.p1Credo);
            this.Controls.Add(this.t1Acta);
            this.Controls.Add(this.l1Acta);
            this.Controls.Add(this.b1Actualizar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "actualizadorActasControlador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizador Registro de Actas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.actualizadorActasControlador_FormClosed);
            this.Load += new System.EventHandler(this.frm_actLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.actualizadorActasControlador_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.p1Credo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1Actualizar;
        private System.Windows.Forms.Label l1Acta;
        private System.Windows.Forms.TextBox t1Acta;
        private System.Windows.Forms.PictureBox p1Credo;
        private System.Windows.Forms.Label l2Info;
        private System.Windows.Forms.Button b2Salir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem;

    }
}

