using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace cliente_DHCP
{
    public partial class Form1 : Form
    {
        Socket receivesocket;
        IPEndPoint receive_ep;
        EndPoint Remote;
        string mac_cliente;
        string ip_ofertado;
        Thread t1;
        public Form1()
        {
            InitializeComponent();
            mac_cliente = cliente_mac.Text.Trim();
            ip_servidor.Text = "";
            mac_servidor.Text = "";
            estado.Text = "ESPERANDO POR EL CLIENTE";
            boton_cambiar_mac.Enabled = true;
            boton_solicitar.Enabled = true;
            boton_aceptar.Enabled = false;
            boton_rechazar.Enabled = false;
            boton_suspender.Enabled = false;
            boton_reiniciar.Enabled = false;

            t1 = new Thread(new ThreadStart(recibe_udp));
            t1.Start();
        }

        private void boton_cambiar_mac_Click(object sender, EventArgs e)
        {
            string str = mac_nuevo.Text.Trim();
            cliente_mac.Text = str;
            mac_cliente = str;
        }

        private void boton_solicitar_Click(object sender, EventArgs e)
        {
            envia_udp("255.255.255.255", "DHCPDISCOVER-" + mac_cliente);
            boton_cambiar_mac.Enabled = false;
            estado.Text = "ENVIADO DHCPDISCOVER";
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            envia_udp("255.255.255.255", "DHCPREQUEST-" + ip_ofertado + "-" + mac_cliente);
            estado.Text = "ENVIADO DHCPREQUEST";
        }

        private void boton_rechazar_Click(object sender, EventArgs e)
        {
            envia_udp("255.255.255.255", "DHCPREJECT-" + "NADA");
            estado.Text = "ESPERANDO POR EL CLIENTE";
            boton_aceptar.Enabled = false;
            boton_rechazar.Enabled = false;
            boton_cambiar_mac.Enabled = true;
            boton_solicitar.Enabled = true;
        }

        private void boton_suspender_Click(object sender, EventArgs e)
        {
            envia_udp("255.255.255.255", "DHCPRELEASE-" + mac_cliente + "-" + ip_ofertado);
            estado.Text = "ESPERANDO POR EL CLIENTE";
            boton_cambiar_mac.Enabled = false;
            boton_solicitar.Enabled = true;
            boton_suspender.Enabled = false;
            boton_reiniciar.Enabled = false;
            ip_servidor.Text = "";
            mac_servidor.Text = "";
        }

        private void boton_reiniciar_Click(object sender, EventArgs e)
        {
            envia_udp("255.255.255.255", "DHCPRELEASE-" + mac_cliente + "-" + ip_ofertado);
            estado.Text = "ESPERANDO POR EL CLIENTE";
            boton_cambiar_mac.Enabled = true;
            boton_solicitar.Enabled = true;
            boton_suspender.Enabled = false;
            boton_reiniciar.Enabled = false;
            ip_servidor.Text = "";
            mac_servidor.Text = "";
        }

        private void envia_udp(string ip, string mensaje)//funcion envia mensajes udp
        {
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(mensaje);
            Socket sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sendSocket.EnableBroadcast = true;
            IPEndPoint send_ep = new IPEndPoint(IPAddress.Parse(ip), 50500);
            sendSocket.SendTo(data, send_ep);
            sendSocket.Close();
        }

        private void recibe_udp()//funcion recibe mensajes udp
        {
            string comando, str;
            byte[] data = new byte[1024];
            receivesocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            receive_ep = new IPEndPoint(IPAddress.Any, 50600);
            Remote = (EndPoint)receive_ep;
            receivesocket.Bind(Remote);
            int recv = 0;

            while (true)
            {
                Console.WriteLine("Servidor esperando mensajes\n");
                try
                {
                    recv = receivesocket.ReceiveFrom(data, ref Remote);
                }
                catch (SocketException exc)
                {

                }
                Console.WriteLine("Mensaje desde {0}:", Remote.ToString());
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
                str = Encoding.ASCII.GetString(data, 0, recv);
                char[] seps = { '-' };
                string[] cadena = str.Split(seps);
                comando = cadena[0];

                if (comando == "DHCPOFFER")
                {
                    if (cadena[1] == mac_cliente)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(
                                delegate()
                                {
                                    estado.Text = "IP OFERTADA " + cadena[2] + " " + cadena[3];
                                    if (cadena[3] == "TEMPORAL")
                                        estado.Text += " " + cadena[3] + " MINUTOS";
                                    boton_solicitar.Enabled = false;
                                    boton_aceptar.Enabled = true;
                                    boton_rechazar.Enabled = true;
                                }
                                ));
                        }
                        else
                        {
                            estado.Text = "IP OFERTADA " + cadena[2] + " " + cadena[3];
                            if (cadena[3] == "TEMPORAL")
                                estado.Text += " " + cadena[3] + " MINUTOS";
                            boton_solicitar.Enabled = false;
                            boton_aceptar.Enabled = true;
                            boton_rechazar.Enabled = true;
                        }
                        ip_ofertado = cadena[2];
                    }
                }

                if (comando == "DHCPACK")
                {
                    if (cadena[3] == mac_cliente)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(
                                delegate()
                                {
                                    estado.Text = "IP ASIGNADA";
                                    boton_aceptar.Enabled = false;
                                    boton_rechazar.Enabled = false;
                                    boton_suspender.Enabled = true;
                                    boton_reiniciar.Enabled = true;
                                    ip_servidor.Text = cadena[1];
                                    mac_servidor.Text = cadena[2];
                                }
                                ));
                        }
                        else
                        {
                            estado.Text = "IP ASIGNADA";
                            boton_aceptar.Enabled = false;
                            boton_rechazar.Enabled = false;
                            boton_suspender.Enabled = true;
                            boton_reiniciar.Enabled = true;
                            ip_servidor.Text = cadena[1];
                            mac_servidor.Text = cadena[2];
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            receivesocket.Close();
            t1.Abort();
        }
    }
}
