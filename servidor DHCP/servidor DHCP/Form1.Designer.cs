namespace servidor_DHCP
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
            this.ip_servidor = new System.Windows.Forms.Label();
            this.mac_servidor = new System.Windows.Forms.Label();
            this.ip_label = new System.Windows.Forms.Label();
            this.mac_label = new System.Windows.Forms.Label();
            this.rango_label = new System.Windows.Forms.Label();
            this.rango_desde = new System.Windows.Forms.TextBox();
            this.tilda_label = new System.Windows.Forms.Label();
            this.rango_hasta = new System.Windows.Forms.TextBox();
            this.lista_clientes = new System.Windows.Forms.ListBox();
            this.boton_cambiar_rango = new System.Windows.Forms.Button();
            this.boton_avance = new System.Windows.Forms.Button();
            this.estado_label = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.clientes_label = new System.Windows.Forms.Label();
            this.cuarto_octeto = new System.Windows.Forms.TextBox();
            this.boton_cambiar_ip = new System.Windows.Forms.Button();
            this.mac_nuevo = new System.Windows.Forms.TextBox();
            this.boton_cambiar_mac = new System.Windows.Forms.Button();
            this.rango_servidor = new System.Windows.Forms.Label();
            this.modo_label = new System.Windows.Forms.Label();
            this.modo = new System.Windows.Forms.Label();
            this.boton_automatico = new System.Windows.Forms.Button();
            this.boton_manual = new System.Windows.Forms.Button();
            this.boton_temporal = new System.Windows.Forms.Button();
            this.boton_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ip_asignada = new System.Windows.Forms.TextBox();
            this.asignar_label = new System.Windows.Forms.Label();
            this.tiempo_label = new System.Windows.Forms.Label();
            this.tiempo_box = new System.Windows.Forms.TextBox();
            this.tercer_octeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.segundo_octeto = new System.Windows.Forms.TextBox();
            this.primer_octeto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ip_servidor
            // 
            this.ip_servidor.AutoSize = true;
            this.ip_servidor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_servidor.Location = new System.Drawing.Point(132, 40);
            this.ip_servidor.Name = "ip_servidor";
            this.ip_servidor.Size = new System.Drawing.Size(106, 18);
            this.ip_servidor.TabIndex = 0;
            this.ip_servidor.Text = "192.168.1.1";
            // 
            // mac_servidor
            // 
            this.mac_servidor.AutoSize = true;
            this.mac_servidor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mac_servidor.Location = new System.Drawing.Point(149, 108);
            this.mac_servidor.Name = "mac_servidor";
            this.mac_servidor.Size = new System.Drawing.Size(169, 18);
            this.mac_servidor.TabIndex = 1;
            this.mac_servidor.Text = "12:4E:56:G3:6H:3D";
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_label.Location = new System.Drawing.Point(9, 40);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(123, 18);
            this.ip_label.TabIndex = 2;
            this.ip_label.Text = "IP SERVIDOR:";
            // 
            // mac_label
            // 
            this.mac_label.AutoSize = true;
            this.mac_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mac_label.Location = new System.Drawing.Point(9, 108);
            this.mac_label.Name = "mac_label";
            this.mac_label.Size = new System.Drawing.Size(141, 18);
            this.mac_label.TabIndex = 3;
            this.mac_label.Text = "MAC SERVIDOR:";
            // 
            // rango_label
            // 
            this.rango_label.AutoSize = true;
            this.rango_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rango_label.Location = new System.Drawing.Point(9, 74);
            this.rango_label.Name = "rango_label";
            this.rango_label.Size = new System.Drawing.Size(214, 18);
            this.rango_label.TabIndex = 4;
            this.rango_label.Text = "RANGO IP´S A ASIGNAR:";
            // 
            // rango_desde
            // 
            this.rango_desde.Location = new System.Drawing.Point(365, 74);
            this.rango_desde.MaxLength = 3;
            this.rango_desde.Name = "rango_desde";
            this.rango_desde.Size = new System.Drawing.Size(24, 20);
            this.rango_desde.TabIndex = 5;
            // 
            // tilda_label
            // 
            this.tilda_label.AutoSize = true;
            this.tilda_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilda_label.Location = new System.Drawing.Point(389, 73);
            this.tilda_label.Name = "tilda_label";
            this.tilda_label.Size = new System.Drawing.Size(21, 18);
            this.tilda_label.TabIndex = 6;
            this.tilda_label.Text = "~";
            // 
            // rango_hasta
            // 
            this.rango_hasta.Location = new System.Drawing.Point(407, 74);
            this.rango_hasta.MaxLength = 3;
            this.rango_hasta.Name = "rango_hasta";
            this.rango_hasta.Size = new System.Drawing.Size(24, 20);
            this.rango_hasta.TabIndex = 7;
            // 
            // lista_clientes
            // 
            this.lista_clientes.FormattingEnabled = true;
            this.lista_clientes.Location = new System.Drawing.Point(12, 263);
            this.lista_clientes.Name = "lista_clientes";
            this.lista_clientes.Size = new System.Drawing.Size(500, 290);
            this.lista_clientes.TabIndex = 8;
            // 
            // boton_cambiar_rango
            // 
            this.boton_cambiar_rango.Location = new System.Drawing.Point(442, 72);
            this.boton_cambiar_rango.Name = "boton_cambiar_rango";
            this.boton_cambiar_rango.Size = new System.Drawing.Size(75, 23);
            this.boton_cambiar_rango.TabIndex = 9;
            this.boton_cambiar_rango.Text = "Cambiar";
            this.boton_cambiar_rango.UseVisualStyleBackColor = true;
            this.boton_cambiar_rango.Click += new System.EventHandler(this.boton_cambiar_rango_Click);
            // 
            // boton_avance
            // 
            this.boton_avance.Location = new System.Drawing.Point(442, 140);
            this.boton_avance.Name = "boton_avance";
            this.boton_avance.Size = new System.Drawing.Size(75, 23);
            this.boton_avance.TabIndex = 10;
            this.boton_avance.Text = "Avance";
            this.boton_avance.UseVisualStyleBackColor = true;
            this.boton_avance.Click += new System.EventHandler(this.boton_avance_Click);
            // 
            // estado_label
            // 
            this.estado_label.AutoSize = true;
            this.estado_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_label.Location = new System.Drawing.Point(9, 142);
            this.estado_label.Name = "estado_label";
            this.estado_label.Size = new System.Drawing.Size(81, 18);
            this.estado_label.TabIndex = 11;
            this.estado_label.Text = "ESTADO:";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(86, 142);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(123, 18);
            this.estado.TabIndex = 12;
            this.estado.Text = "CONECTANDO";
            // 
            // clientes_label
            // 
            this.clientes_label.AutoSize = true;
            this.clientes_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes_label.Location = new System.Drawing.Point(9, 238);
            this.clientes_label.Name = "clientes_label";
            this.clientes_label.Size = new System.Drawing.Size(213, 18);
            this.clientes_label.TabIndex = 13;
            this.clientes_label.Text = "CLIENTES CONECTADOS:";
            // 
            // cuarto_octeto
            // 
            this.cuarto_octeto.Location = new System.Drawing.Point(405, 40);
            this.cuarto_octeto.MaxLength = 3;
            this.cuarto_octeto.Name = "cuarto_octeto";
            this.cuarto_octeto.Size = new System.Drawing.Size(26, 20);
            this.cuarto_octeto.TabIndex = 17;
            // 
            // boton_cambiar_ip
            // 
            this.boton_cambiar_ip.Location = new System.Drawing.Point(442, 38);
            this.boton_cambiar_ip.Name = "boton_cambiar_ip";
            this.boton_cambiar_ip.Size = new System.Drawing.Size(75, 23);
            this.boton_cambiar_ip.TabIndex = 21;
            this.boton_cambiar_ip.Text = "Cambiar";
            this.boton_cambiar_ip.UseVisualStyleBackColor = true;
            this.boton_cambiar_ip.Click += new System.EventHandler(this.boton_cambiar_ip_Click);
            // 
            // mac_nuevo
            // 
            this.mac_nuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mac_nuevo.Location = new System.Drawing.Point(326, 108);
            this.mac_nuevo.MaxLength = 17;
            this.mac_nuevo.Name = "mac_nuevo";
            this.mac_nuevo.Size = new System.Drawing.Size(107, 20);
            this.mac_nuevo.TabIndex = 22;
            // 
            // boton_cambiar_mac
            // 
            this.boton_cambiar_mac.Location = new System.Drawing.Point(442, 106);
            this.boton_cambiar_mac.Name = "boton_cambiar_mac";
            this.boton_cambiar_mac.Size = new System.Drawing.Size(75, 23);
            this.boton_cambiar_mac.TabIndex = 23;
            this.boton_cambiar_mac.Text = "Cambiar";
            this.boton_cambiar_mac.UseVisualStyleBackColor = true;
            this.boton_cambiar_mac.Click += new System.EventHandler(this.boton_cambiar_mac_Click);
            // 
            // rango_servidor
            // 
            this.rango_servidor.AutoSize = true;
            this.rango_servidor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rango_servidor.Location = new System.Drawing.Point(221, 74);
            this.rango_servidor.Name = "rango_servidor";
            this.rango_servidor.Size = new System.Drawing.Size(61, 18);
            this.rango_servidor.TabIndex = 24;
            this.rango_servidor.Text = "2~254";
            // 
            // modo_label
            // 
            this.modo_label.AutoSize = true;
            this.modo_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modo_label.Location = new System.Drawing.Point(9, 9);
            this.modo_label.Name = "modo_label";
            this.modo_label.Size = new System.Drawing.Size(66, 18);
            this.modo_label.TabIndex = 40;
            this.modo_label.Text = "MODO:";
            // 
            // modo
            // 
            this.modo.AutoSize = true;
            this.modo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modo.Location = new System.Drawing.Point(72, 9);
            this.modo.Name = "modo";
            this.modo.Size = new System.Drawing.Size(119, 18);
            this.modo.TabIndex = 41;
            this.modo.Text = "AUTOMATICO";
            // 
            // boton_automatico
            // 
            this.boton_automatico.Location = new System.Drawing.Point(199, 6);
            this.boton_automatico.Name = "boton_automatico";
            this.boton_automatico.Size = new System.Drawing.Size(75, 23);
            this.boton_automatico.TabIndex = 42;
            this.boton_automatico.Text = "Automatico";
            this.boton_automatico.UseVisualStyleBackColor = true;
            this.boton_automatico.Click += new System.EventHandler(this.boton_automatico_Click);
            // 
            // boton_manual
            // 
            this.boton_manual.Location = new System.Drawing.Point(280, 6);
            this.boton_manual.Name = "boton_manual";
            this.boton_manual.Size = new System.Drawing.Size(75, 23);
            this.boton_manual.TabIndex = 43;
            this.boton_manual.Text = "Manual";
            this.boton_manual.UseVisualStyleBackColor = true;
            this.boton_manual.Click += new System.EventHandler(this.boton_manual_Click);
            // 
            // boton_temporal
            // 
            this.boton_temporal.Location = new System.Drawing.Point(361, 6);
            this.boton_temporal.Name = "boton_temporal";
            this.boton_temporal.Size = new System.Drawing.Size(75, 23);
            this.boton_temporal.TabIndex = 44;
            this.boton_temporal.Text = "Temporal";
            this.boton_temporal.UseVisualStyleBackColor = true;
            this.boton_temporal.Click += new System.EventHandler(this.boton_temporal_Click);
            // 
            // boton_reset
            // 
            this.boton_reset.Location = new System.Drawing.Point(442, 6);
            this.boton_reset.Name = "boton_reset";
            this.boton_reset.Size = new System.Drawing.Size(75, 23);
            this.boton_reset.TabIndex = 45;
            this.boton_reset.Text = "Reset";
            this.boton_reset.UseVisualStyleBackColor = true;
            this.boton_reset.Click += new System.EventHandler(this.boton_reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "192.168.1.";
            // 
            // ip_asignada
            // 
            this.ip_asignada.Location = new System.Drawing.Point(214, 173);
            this.ip_asignada.MaxLength = 3;
            this.ip_asignada.Name = "ip_asignada";
            this.ip_asignada.Size = new System.Drawing.Size(26, 20);
            this.ip_asignada.TabIndex = 46;
            // 
            // asignar_label
            // 
            this.asignar_label.AutoSize = true;
            this.asignar_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignar_label.Location = new System.Drawing.Point(9, 174);
            this.asignar_label.Name = "asignar_label";
            this.asignar_label.Size = new System.Drawing.Size(112, 18);
            this.asignar_label.TabIndex = 48;
            this.asignar_label.Text = "ASIGNAR IP:";
            // 
            // tiempo_label
            // 
            this.tiempo_label.AutoSize = true;
            this.tiempo_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo_label.Location = new System.Drawing.Point(9, 206);
            this.tiempo_label.Name = "tiempo_label";
            this.tiempo_label.Size = new System.Drawing.Size(130, 18);
            this.tiempo_label.TabIndex = 50;
            this.tiempo_label.Text = "TIEMPO (MIN):";
            // 
            // tiempo_box
            // 
            this.tiempo_box.Location = new System.Drawing.Point(139, 206);
            this.tiempo_box.MaxLength = 6;
            this.tiempo_box.Name = "tiempo_box";
            this.tiempo_box.Size = new System.Drawing.Size(56, 20);
            this.tiempo_box.TabIndex = 49;
            // 
            // tercer_octeto
            // 
            this.tercer_octeto.Location = new System.Drawing.Point(373, 40);
            this.tercer_octeto.MaxLength = 3;
            this.tercer_octeto.Name = "tercer_octeto";
            this.tercer_octeto.Size = new System.Drawing.Size(26, 20);
            this.tercer_octeto.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = ".";
            // 
            // segundo_octeto
            // 
            this.segundo_octeto.Location = new System.Drawing.Point(341, 40);
            this.segundo_octeto.MaxLength = 3;
            this.segundo_octeto.Name = "segundo_octeto";
            this.segundo_octeto.Size = new System.Drawing.Size(26, 20);
            this.segundo_octeto.TabIndex = 52;
            // 
            // primer_octeto
            // 
            this.primer_octeto.Location = new System.Drawing.Point(309, 40);
            this.primer_octeto.MaxLength = 3;
            this.primer_octeto.Name = "primer_octeto";
            this.primer_octeto.Size = new System.Drawing.Size(26, 20);
            this.primer_octeto.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 562);
            this.Controls.Add(this.primer_octeto);
            this.Controls.Add(this.segundo_octeto);
            this.Controls.Add(this.tercer_octeto);
            this.Controls.Add(this.tiempo_label);
            this.Controls.Add(this.tiempo_box);
            this.Controls.Add(this.asignar_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ip_asignada);
            this.Controls.Add(this.boton_reset);
            this.Controls.Add(this.boton_temporal);
            this.Controls.Add(this.boton_manual);
            this.Controls.Add(this.boton_automatico);
            this.Controls.Add(this.modo);
            this.Controls.Add(this.modo_label);
            this.Controls.Add(this.rango_servidor);
            this.Controls.Add(this.boton_cambiar_mac);
            this.Controls.Add(this.mac_nuevo);
            this.Controls.Add(this.boton_cambiar_ip);
            this.Controls.Add(this.cuarto_octeto);
            this.Controls.Add(this.clientes_label);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.estado_label);
            this.Controls.Add(this.boton_avance);
            this.Controls.Add(this.boton_cambiar_rango);
            this.Controls.Add(this.lista_clientes);
            this.Controls.Add(this.rango_hasta);
            this.Controls.Add(this.tilda_label);
            this.Controls.Add(this.rango_desde);
            this.Controls.Add(this.rango_label);
            this.Controls.Add(this.mac_label);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.mac_servidor);
            this.Controls.Add(this.ip_servidor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 600);
            this.MinimumSize = new System.Drawing.Size(540, 600);
            this.Name = "Form1";
            this.Text = "Servidor DHCP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ip_servidor;
        private System.Windows.Forms.Label mac_servidor;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.Label mac_label;
        private System.Windows.Forms.Label rango_label;
        private System.Windows.Forms.TextBox rango_desde;
        private System.Windows.Forms.Label tilda_label;
        private System.Windows.Forms.TextBox rango_hasta;
        private System.Windows.Forms.ListBox lista_clientes;
        private System.Windows.Forms.Button boton_cambiar_rango;
        private System.Windows.Forms.Button boton_avance;
        private System.Windows.Forms.Label estado_label;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label clientes_label;
        private System.Windows.Forms.TextBox cuarto_octeto;
        private System.Windows.Forms.Button boton_cambiar_ip;
        private System.Windows.Forms.TextBox mac_nuevo;
        private System.Windows.Forms.Button boton_cambiar_mac;
        private System.Windows.Forms.Label rango_servidor;
        private System.Windows.Forms.Label modo_label;
        private System.Windows.Forms.Label modo;
        private System.Windows.Forms.Button boton_automatico;
        private System.Windows.Forms.Button boton_manual;
        private System.Windows.Forms.Button boton_temporal;
        private System.Windows.Forms.Button boton_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ip_asignada;
        private System.Windows.Forms.Label asignar_label;
        private System.Windows.Forms.Label tiempo_label;
        private System.Windows.Forms.TextBox tiempo_box;
        private System.Windows.Forms.TextBox tercer_octeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox segundo_octeto;
        private System.Windows.Forms.TextBox primer_octeto;
    }
}

