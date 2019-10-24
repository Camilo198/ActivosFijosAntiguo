namespace RegistrosActas
{
    partial class actualizadorActivosControlador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actualizadorActivosControlador));
            this.b1BuscarPlaca = new System.Windows.Forms.Button();
            this.t1refActivo = new System.Windows.Forms.TextBox();
            this.l1refActivo = new System.Windows.Forms.Label();
            this.l2Placa = new System.Windows.Forms.Label();
            this.t2Placa = new System.Windows.Forms.TextBox();
            this.t4IdActa = new System.Windows.Forms.TextBox();
            this.l4idActa = new System.Windows.Forms.Label();
            this.b2BuscarActa = new System.Windows.Forms.Button();
            this.t3nombreActivo = new System.Windows.Forms.TextBox();
            this.l3nombreActivo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.b3actualizarHirtoricoPlaca = new System.Windows.Forms.Button();
            this.t5id_Historico = new System.Windows.Forms.TextBox();
            this.l5IdHistorico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1BuscarPlaca
            // 
            this.b1BuscarPlaca.Location = new System.Drawing.Point(303, 23);
            this.b1BuscarPlaca.Name = "b1BuscarPlaca";
            this.b1BuscarPlaca.Size = new System.Drawing.Size(75, 23);
            this.b1BuscarPlaca.TabIndex = 0;
            this.b1BuscarPlaca.Text = "BuscarPlaca";
            this.b1BuscarPlaca.UseVisualStyleBackColor = true;
            this.b1BuscarPlaca.Click += new System.EventHandler(this.b1BuscarActivo_Click);
            // 
            // t1refActivo
            // 
            this.t1refActivo.Location = new System.Drawing.Point(80, 25);
            this.t1refActivo.Name = "t1refActivo";
            this.t1refActivo.Size = new System.Drawing.Size(217, 20);
            this.t1refActivo.TabIndex = 1;
            // 
            // l1refActivo
            // 
            this.l1refActivo.AutoSize = true;
            this.l1refActivo.Location = new System.Drawing.Point(2, 28);
            this.l1refActivo.Name = "l1refActivo";
            this.l1refActivo.Size = new System.Drawing.Size(72, 13);
            this.l1refActivo.TabIndex = 2;
            this.l1refActivo.Text = "Ref de Activo";
            // 
            // l2Placa
            // 
            this.l2Placa.AutoSize = true;
            this.l2Placa.Location = new System.Drawing.Point(2, 59);
            this.l2Placa.Name = "l2Placa";
            this.l2Placa.Size = new System.Drawing.Size(34, 13);
            this.l2Placa.TabIndex = 3;
            this.l2Placa.Text = "Placa";
            // 
            // t2Placa
            // 
            this.t2Placa.Enabled = false;
            this.t2Placa.Location = new System.Drawing.Point(5, 75);
            this.t2Placa.Name = "t2Placa";
            this.t2Placa.Size = new System.Drawing.Size(119, 20);
            this.t2Placa.TabIndex = 5;
            this.t2Placa.TextChanged += new System.EventHandler(this.t2idActivo_TextChanged);
            // 
            // t4IdActa
            // 
            this.t4IdActa.Location = new System.Drawing.Point(227, 107);
            this.t4IdActa.Name = "t4IdActa";
            this.t4IdActa.Size = new System.Drawing.Size(100, 20);
            this.t4IdActa.TabIndex = 7;
            // 
            // l4idActa
            // 
            this.l4idActa.AutoSize = true;
            this.l4idActa.Location = new System.Drawing.Point(175, 110);
            this.l4idActa.Name = "l4idActa";
            this.l4idActa.Size = new System.Drawing.Size(39, 13);
            this.l4idActa.TabIndex = 6;
            this.l4idActa.Text = "# Acta";
            // 
            // b2BuscarActa
            // 
            this.b2BuscarActa.Location = new System.Drawing.Point(345, 104);
            this.b2BuscarActa.Name = "b2BuscarActa";
            this.b2BuscarActa.Size = new System.Drawing.Size(75, 23);
            this.b2BuscarActa.TabIndex = 8;
            this.b2BuscarActa.Text = "BuscarActa";
            this.b2BuscarActa.UseVisualStyleBackColor = true;
            // 
            // t3nombreActivo
            // 
            this.t3nombreActivo.Enabled = false;
            this.t3nombreActivo.Location = new System.Drawing.Point(168, 75);
            this.t3nombreActivo.Name = "t3nombreActivo";
            this.t3nombreActivo.Size = new System.Drawing.Size(444, 20);
            this.t3nombreActivo.TabIndex = 10;
            // 
            // l3nombreActivo
            // 
            this.l3nombreActivo.AutoSize = true;
            this.l3nombreActivo.Location = new System.Drawing.Point(175, 59);
            this.l3nombreActivo.Name = "l3nombreActivo";
            this.l3nombreActivo.Size = new System.Drawing.Size(92, 13);
            this.l3nombreActivo.TabIndex = 9;
            this.l3nombreActivo.Text = "Nombre de Activo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 133);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(609, 202);
            this.textBox3.TabIndex = 13;
            // 
            // b3actualizarHirtoricoPlaca
            // 
            this.b3actualizarHirtoricoPlaca.Location = new System.Drawing.Point(111, 372);
            this.b3actualizarHirtoricoPlaca.Name = "b3actualizarHirtoricoPlaca";
            this.b3actualizarHirtoricoPlaca.Size = new System.Drawing.Size(91, 23);
            this.b3actualizarHirtoricoPlaca.TabIndex = 16;
            this.b3actualizarHirtoricoPlaca.Text = "Actualizar Placa";
            this.b3actualizarHirtoricoPlaca.UseVisualStyleBackColor = true;
            this.b3actualizarHirtoricoPlaca.Click += new System.EventHandler(this.b3actualizarHirtoricoPlaca_Click);
            // 
            // t5id_Historico
            // 
            this.t5id_Historico.Location = new System.Drawing.Point(5, 372);
            this.t5id_Historico.Name = "t5id_Historico";
            this.t5id_Historico.Size = new System.Drawing.Size(100, 20);
            this.t5id_Historico.TabIndex = 15;
            // 
            // l5IdHistorico
            // 
            this.l5IdHistorico.AutoSize = true;
            this.l5IdHistorico.Location = new System.Drawing.Point(2, 356);
            this.l5IdHistorico.Name = "l5IdHistorico";
            this.l5IdHistorico.Size = new System.Drawing.Size(75, 13);
            this.l5IdHistorico.TabIndex = 14;
            this.l5IdHistorico.Text = "# ID_Historico";
            // 
            // actualizadorActivosControlador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 430);
            this.Controls.Add(this.b3actualizarHirtoricoPlaca);
            this.Controls.Add(this.t5id_Historico);
            this.Controls.Add(this.l5IdHistorico);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.t3nombreActivo);
            this.Controls.Add(this.l3nombreActivo);
            this.Controls.Add(this.b2BuscarActa);
            this.Controls.Add(this.t4IdActa);
            this.Controls.Add(this.l4idActa);
            this.Controls.Add(this.t2Placa);
            this.Controls.Add(this.l2Placa);
            this.Controls.Add(this.l1refActivo);
            this.Controls.Add(this.t1refActivo);
            this.Controls.Add(this.b1BuscarPlaca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "actualizadorActivosControlador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizador Activos - Placas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.actualizadorActivosControlador_FormClosed);
            this.Load += new System.EventHandler(this.actualizadorActivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1BuscarPlaca;
        private System.Windows.Forms.TextBox t1refActivo;
        private System.Windows.Forms.Label l1refActivo;
        private System.Windows.Forms.Label l2Placa;
        private System.Windows.Forms.TextBox t2Placa;
        private System.Windows.Forms.TextBox t4IdActa;
        private System.Windows.Forms.Label l4idActa;
        private System.Windows.Forms.Button b2BuscarActa;
        private System.Windows.Forms.TextBox t3nombreActivo;
        private System.Windows.Forms.Label l3nombreActivo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button b3actualizarHirtoricoPlaca;
        private System.Windows.Forms.TextBox t5id_Historico;
        private System.Windows.Forms.Label l5IdHistorico;
    }
}