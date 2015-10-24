namespace cliente_DHCP
{
    partial class Form1
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
            this.mac_cliente_label = new System.Windows.Forms.Label();
            this.cliente_mac = new System.Windows.Forms.Label();
            this.mac_nuevo = new System.Windows.Forms.TextBox();
            this.boton_cambiar_mac = new System.Windows.Forms.Button();
            this.mac_servidor_label = new System.Windows.Forms.Label();
            this.mac_servidor = new System.Windows.Forms.Label();
            this.ip_servidor = new System.Windows.Forms.Label();
            this.ip_asignada_label = new System.Windows.Forms.Label();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.boton_rechazar = new System.Windows.Forms.Button();
            this.boton_suspender = new System.Windows.Forms.Button();
            this.boton_reiniciar = new System.Windows.Forms.Button();
            this.boton_solicitar = new System.Windows.Forms.Button();
            this.estado_label = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mac_cliente_label
            // 
            this.mac_cliente_label.AutoSize = true;
            this.mac_cliente_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mac_cliente_label.Location = new System.Drawing.Point(19, 53);
            this.mac_cliente_label.Name = "mac_cliente_label";
            this.mac_cliente_label.Size = new System.Drawing.Size(125, 18);
            this.mac_cliente_label.TabIndex = 12;
            this.mac_cliente_label.Text = "MAC CLIENTE:";
            // 
            // cliente_mac
            // 
            this.cliente_mac.AutoSize = true;
            this.cliente_mac.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_mac.Location = new System.Drawing.Point(143, 53);
            this.cliente_mac.Name = "cliente_mac";
            this.cliente_mac.Size = new System.Drawing.Size(166, 18);
            this.cliente_mac.TabIndex = 13;
            this.cliente_mac.Text = "32:G4:F2:C7:98:1A";
            // 
            // mac_nuevo
            // 
            this.mac_nuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mac_nuevo.Location = new System.Drawing.Point(314, 52);
            this.mac_nuevo.MaxLength = 17;
            this.mac_nuevo.Name = "mac_nuevo";
            this.mac_nuevo.Size = new System.Drawing.Size(107, 20);
            this.mac_nuevo.TabIndex = 14;
            // 
            // boton_cambiar_mac
            // 
            this.boton_cambiar_mac.Location = new System.Drawing.Point(429, 50);
            this.boton_cambiar_mac.Name = "boton_cambiar_mac";
            this.boton_cambiar_mac.Size = new System.Drawing.Size(75, 23);
            this.boton_cambiar_mac.TabIndex = 15;
            this.boton_cambiar_mac.Text = "Cambiar";
            this.boton_cambiar_mac.UseVisualStyleBackColor = true;
            this.boton_cambiar_mac.Click += new System.EventHandler(this.boton_cambiar_mac_Click);
            // 
            // mac_servidor_label
            // 
            this.mac_servidor_label.AutoSize = true;
            this.mac_servidor_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mac_servidor_label.Location = new System.Drawing.Point(272, 85);
            this.mac_servidor_label.Name = "mac_servidor_label";
            this.mac_servidor_label.Size = new System.Drawing.Size(141, 18);
            this.mac_servidor_label.TabIndex = 19;
            this.mac_servidor_label.Text = "MAC SERVIDOR:";
            // 
            // mac_servidor
            // 
            this.mac_servidor.AutoSize = true;
            this.mac_servidor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mac_servidor.Location = new System.Drawing.Point(412, 85);
            this.mac_servidor.Name = "mac_servidor";
            this.mac_servidor.Size = new System.Drawing.Size(169, 18);
            this.mac_servidor.TabIndex = 17;
            this.mac_servidor.Text = "12:4E:56:G3:6H:3D";
            // 
            // ip_servidor
            // 
            this.ip_servidor.AutoSize = true;
            this.ip_servidor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_servidor.Location = new System.Drawing.Point(123, 85);
            this.ip_servidor.Name = "ip_servidor";
            this.ip_servidor.Size = new System.Drawing.Size(146, 18);
            this.ip_servidor.TabIndex = 16;
            this.ip_servidor.Text = "192.168.255.255";
            // 
            // ip_asignada_label
            // 
            this.ip_asignada_label.AutoSize = true;
            this.ip_asignada_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_asignada_label.Location = new System.Drawing.Point(2, 85);
            this.ip_asignada_label.Name = "ip_asignada_label";
            this.ip_asignada_label.Size = new System.Drawing.Size(124, 18);
            this.ip_asignada_label.TabIndex = 20;
            this.ip_asignada_label.Text = "IP ASIGNADA:";
            // 
            // boton_aceptar
            // 
            this.boton_aceptar.Location = new System.Drawing.Point(140, 118);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(75, 23);
            this.boton_aceptar.TabIndex = 21;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.UseVisualStyleBackColor = true;
            this.boton_aceptar.Click += new System.EventHandler(this.boton_aceptar_Click);
            // 
            // boton_rechazar
            // 
            this.boton_rechazar.Location = new System.Drawing.Point(257, 118);
            this.boton_rechazar.Name = "boton_rechazar";
            this.boton_rechazar.Size = new System.Drawing.Size(75, 23);
            this.boton_rechazar.TabIndex = 22;
            this.boton_rechazar.Text = "Rechazar";
            this.boton_rechazar.UseVisualStyleBackColor = true;
            this.boton_rechazar.Click += new System.EventHandler(this.boton_rechazar_Click);
            // 
            // boton_suspender
            // 
            this.boton_suspender.Location = new System.Drawing.Point(372, 118);
            this.boton_suspender.Name = "boton_suspender";
            this.boton_suspender.Size = new System.Drawing.Size(75, 23);
            this.boton_suspender.TabIndex = 23;
            this.boton_suspender.Text = "Suspender";
            this.boton_suspender.UseVisualStyleBackColor = true;
            this.boton_suspender.Click += new System.EventHandler(this.boton_suspender_Click);
            // 
            // boton_reiniciar
            // 
            this.boton_reiniciar.Location = new System.Drawing.Point(481, 118);
            this.boton_reiniciar.Name = "boton_reiniciar";
            this.boton_reiniciar.Size = new System.Drawing.Size(75, 23);
            this.boton_reiniciar.TabIndex = 24;
            this.boton_reiniciar.Text = "Reiniciar";
            this.boton_reiniciar.UseVisualStyleBackColor = true;
            this.boton_reiniciar.Click += new System.EventHandler(this.boton_reiniciar_Click);
            // 
            // boton_solicitar
            // 
            this.boton_solicitar.Location = new System.Drawing.Point(24, 118);
            this.boton_solicitar.Name = "boton_solicitar";
            this.boton_solicitar.Size = new System.Drawing.Size(75, 23);
            this.boton_solicitar.TabIndex = 29;
            this.boton_solicitar.Text = "Solicitar";
            this.boton_solicitar.UseVisualStyleBackColor = true;
            this.boton_solicitar.Click += new System.EventHandler(this.boton_solicitar_Click);
            // 
            // estado_label
            // 
            this.estado_label.AutoSize = true;
            this.estado_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_label.Location = new System.Drawing.Point(19, 20);
            this.estado_label.Name = "estado_label";
            this.estado_label.Size = new System.Drawing.Size(81, 18);
            this.estado_label.TabIndex = 30;
            this.estado_label.Text = "ESTADO:";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(98, 20);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(179, 18);
            this.estado.TabIndex = 31;
            this.estado.Text = "SOLICITUD ENVIADA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 162);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.estado_label);
            this.Controls.Add(this.boton_solicitar);
            this.Controls.Add(this.boton_reiniciar);
            this.Controls.Add(this.boton_suspender);
            this.Controls.Add(this.boton_rechazar);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.ip_asignada_label);
            this.Controls.Add(this.mac_servidor_label);
            this.Controls.Add(this.mac_servidor);
            this.Controls.Add(this.ip_servidor);
            this.Controls.Add(this.boton_cambiar_mac);
            this.Controls.Add(this.mac_nuevo);
            this.Controls.Add(this.cliente_mac);
            this.Controls.Add(this.mac_cliente_label);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 200);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "Form1";
            this.Text = "Cliente DHCP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mac_cliente_label;
        private System.Windows.Forms.Label cliente_mac;
        private System.Windows.Forms.TextBox mac_nuevo;
        private System.Windows.Forms.Button boton_cambiar_mac;
        private System.Windows.Forms.Label mac_servidor_label;
        private System.Windows.Forms.Label mac_servidor;
        private System.Windows.Forms.Label ip_servidor;
        private System.Windows.Forms.Label ip_asignada_label;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.Button boton_rechazar;
        private System.Windows.Forms.Button boton_suspender;
        private System.Windows.Forms.Button boton_reiniciar;
        private System.Windows.Forms.Button boton_solicitar;
        private System.Windows.Forms.Label estado_label;
        private System.Windows.Forms.Label estado;
    }
}

