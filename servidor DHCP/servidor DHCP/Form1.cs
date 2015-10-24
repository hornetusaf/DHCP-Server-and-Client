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

namespace servidor_DHCP
{
    public partial class Form1 : Form
    {
        Socket receivesocket;
        IPEndPoint receive_ep;
        EndPoint Remote;
        Thread t1;
        string[] clientes = new string[50];
        List<string> items = new List<string>();
        List<int> ip_usadas = new List<int>();
        string mac_cliente;
        string ip_ofertado;
        bool offer, request, reject, release;

        public Form1()
        {
            InitializeComponent();
            estado.Text = "ESPERANDO DHCPDISCOVER";
            modo.Text = "NINGUNO";
            tiempo_box.Enabled = false;
            ip_asignada.Enabled = false;
            boton_automatico.Enabled = true;
            boton_manual.Enabled = true;
            boton_temporal.Enabled = true;
            boton_avance.Enabled = false;
            boton_reset.Enabled = false;
            boton_cambiar_ip.Enabled = true;
            boton_cambiar_rango.Enabled = true;
            boton_cambiar_mac.Enabled = true;
            offer = false;
            request = false;
            reject = false;
            release = false;

            for (int i = 0; i < 50; i++)
                clientes[i] = null;

            lista_clientes.DataSource = items;
        }

        private void boton_avance_Click(object sender, EventArgs e)
        {
            if (offer)
            {
                if (modo.Text.Trim() == "AUTOMATICO")
                {
                    Random r = new Random();
                    int aleatorio;
                    bool band = false;
                    char[] seps = { '~' };
                    string[] cadena = rango_servidor.Text.Trim().Split(seps);
                    int desde = Convert.ToInt32(cadena[0]);
                    int hasta = Convert.ToInt32(cadena[1]);
                    do
                    {
                        band = false;
                        aleatorio = r.Next(desde, hasta);
                        foreach (int number in ip_usadas)
                            if (number == aleatorio)
                                band = true;
                    }
                    while (band);

                    ip_usadas.Add(aleatorio);
                    seps[0] = '.';
                    cadena = ip_servidor.Text.Trim().Split(seps);
                    ip_ofertado = cadena[0] + "." + cadena[1] + "." + cadena[2] + "." + aleatorio;
                    envia_udp("255.255.255.255", "DHCPOFFER-" + mac_cliente + "-"+ ip_ofertado + "-AUTOMATICO");
                    boton_avance.Enabled = false;
                    estado.Text = "ENVIADO DHCPOFFER";
                    offer = false;
                }

                if (modo.Text.Trim() == "MANUAL")
                {
                    string str;
                    bool isNum;
                    int num, desde, hasta;
                    bool band = false;

                    str = ip_asignada.Text.Trim();
                    isNum = int.TryParse(str, out num);
                    char[] seps = { '~' };
                    string[] cadena = rango_servidor.Text.Trim().Split(seps);
                    desde = Convert.ToInt32(cadena[0]);
                    hasta = Convert.ToInt32(cadena[1]);

                    if (isNum && Convert.ToInt32(ip_asignada.Text.Trim()) >= desde && Convert.ToInt32(ip_asignada.Text.Trim()) <= hasta)
                    {
                        foreach (int number in ip_usadas)
                            if (number == Convert.ToInt32(ip_asignada.Text.Trim()))
                                band = true;
                    }

                    if (!band)
                    {
                        if (isNum && Convert.ToInt32(ip_asignada.Text.Trim()) >= desde && Convert.ToInt32(ip_asignada.Text.Trim()) <= hasta)
                        {
                            ip_usadas.Add(Convert.ToInt32(ip_asignada.Text.Trim()));
                            seps[0] = '.';
                            cadena = ip_servidor.Text.Trim().Split(seps);
                            ip_ofertado = cadena[0] + "." + cadena[1] + "." + cadena[2] + "." + Convert.ToInt32(ip_asignada.Text.Trim());
                            envia_udp("255.255.255.255", "DHCPOFFER-" + mac_cliente + "-" + ip_ofertado + "-MANUAL");
                            boton_avance.Enabled = false;
                            estado.Text = "ENVIADO DHCPOFFER";
                            offer = false;
                        }
                        else
                        {
                            if (ip_asignada.Text != String.Empty)
                            {
                                if (Convert.ToInt32(ip_asignada.Text.Trim()) < desde || Convert.ToInt32(ip_asignada.Text.Trim()) > hasta)
                                    estado.Text = "IP FUERA DE RANGO";
                            }
                            else
                                estado.Text = "INGRESE IP A ASIGNAR";
                        }
                    }
                    else
                    {
                        estado.Text = "IP OCUPADA ESPERANDO DHCPDISCOVER";
                        boton_avance.Enabled = false;
                        offer = false;
                    }
                }

                if (modo.Text.Trim() == "TEMPORAL")
                {
                    string str;
                    bool isNum;
                    int num;
                    str = tiempo_box.Text.Trim();
                    isNum = int.TryParse(str, out num);
                    if (isNum && num >= 1)
                    {
                        Random r = new Random();
                        int aleatorio;
                        bool band = false;
                        char[] seps = { '~' };
                        string[] cadena = rango_servidor.Text.Trim().Split(seps);
                        int desde = Convert.ToInt32(cadena[0]);
                        int hasta = Convert.ToInt32(cadena[1]);
                        do
                        {
                            band = false;
                            aleatorio = r.Next(desde, hasta);
                            foreach (int number in ip_usadas)
                                if (number == aleatorio)
                                    band = true;
                        }
                        while (band);

                        ip_usadas.Add(aleatorio);
                        seps[0] = '.';
                        cadena = ip_servidor.Text.Trim().Split(seps);
                        ip_ofertado = cadena[0] + "." + cadena[1] + "." + cadena[2] + "." + aleatorio;
                        envia_udp("255.255.255.255", "DHCPOFFER-" + mac_cliente + "-" + ip_ofertado + "-TEMPORAL-" + num);
                        boton_avance.Enabled = false;
                        estado.Text = "ENVIADO DHCPOFFER";
                        offer = false;
                    }
                    else
                        estado.Text = "INGRESE EL TIEMPO";
                }
            }

            if (release)
            {
                estado.Text = "ESPERANDO DHCPDISCOVER";
                release = false;
                boton_avance.Enabled = false;
                char[] seps = { '.' };
                string[] cadena1 = ip_ofertado.Split(seps);
                ip_usadas.Remove(Convert.ToInt32(cadena1[3]));
                bool enc = false;
                int i = 0;
                string cadena = mac_cliente + "-" + ip_ofertado;
                while (i < 50 && !enc)
                {
                    if (cadena == clientes[i])
                    {
                        enc = true;
                        break;
                    }
                    i++;
                }

                if (enc)
                {
                    clientes[i] = null;
                    items.Remove(cadena);
                    lista_clientes.DataSource = null;
                    lista_clientes.DataSource = items;
                }
            }

            if (request)
            {
                string mac = mac_servidor.Text.Trim();
                envia_udp("255.255.255.255", "DHCPACK-" + ip_ofertado + "-" + mac + "-" + mac_cliente);
                bool enc = false;
                int i = 0;
                while (i < 50 && !enc)
                {
                    if ((mac_cliente + "-" + ip_ofertado) == clientes[i])
                    {
                        enc = true;
                        break;
                    }
                    i++;
                }

                if (!enc)
                {
                    i = 0;
                    while (i < 50)
                    {
                        if (clientes[i] == null)
                        {
                            clientes[i] = mac_cliente + "-" + ip_ofertado;
                            items.Add(mac_cliente + "-" + ip_ofertado);
                            lista_clientes.DataSource = null;
                            lista_clientes.DataSource = items;
                            break;
                        }
                        i++;
                    }
                }

                boton_avance.Enabled = false;
                request = false;
                estado.Text = "ESPERANDO DHCPDISCOVER";
            }

            if (reject)
            {
                estado.Text = "ESPERANDO DHCPDISCOVER";
                reject = false;
                boton_avance.Enabled = false;
            }
        }

        private void boton_cambiar_ip_Click(object sender, EventArgs e)
        {
            string str;
            bool isNum, band1 = false, band2 = false, band3 = false, band4 = false;
            int num, desde;

            str = primer_octeto.Text.Trim();
            isNum = int.TryParse(str, out num);
            if (isNum && num >= 192 && num <= 227)
                band1 = true;

            str = segundo_octeto.Text.Trim();
            isNum = int.TryParse(str, out num);
            if (isNum && num >= 0 && num <= 255)
                band2 = true;

            str = tercer_octeto.Text.Trim();
            isNum = int.TryParse(str, out num);
            if (isNum && num >= 0 && num <= 255)
                band3 = true;

            str = cuarto_octeto.Text.Trim();
            isNum = int.TryParse(str, out num);
            if (isNum && num >= 1 && num <= 253)
                band4 = true;

            if (band1 && band2 && band3 && band4)
            {
                ip_servidor.Text = primer_octeto.Text.Trim() + "." + segundo_octeto.Text.Trim() + "." + tercer_octeto.Text.Trim() + "." + cuarto_octeto.Text.Trim();
                desde = Convert.ToInt32(cuarto_octeto.Text.Trim());
                desde += 1;
                rango_servidor.Text = (desde).ToString() + "~254";
            }
        }

        private void boton_cambiar_mac_Click(object sender, EventArgs e)
        {
            mac_servidor.Text = mac_nuevo.Text.Trim();
        }

        private void boton_cambiar_rango_Click(object sender, EventArgs e)
        {
            string str;
            bool isNum;
            int num, desde;

            str = rango_desde.Text.Trim();
            isNum = int.TryParse(str, out num);
            char[] seps = { '.' };
            string[] cadena = ip_servidor.Text.Trim().Split(seps);
            desde = Convert.ToInt32(cadena[3]);
            if (isNum && num >= (desde + 1) && num <= 254)
            {
                str = rango_hasta.Text.Trim();
                isNum = int.TryParse(str, out num);
                if (isNum && num >= (desde + 1) && num <= 254)
                    rango_servidor.Text = rango_desde.Text.Trim() + "~" + rango_hasta.Text.Trim();
            }
        }

        private void recibe_udp()//funcion recibe mensajes udp
        {
            string comando, str;
            byte[] data = new byte[1024];
            receivesocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            receive_ep = new IPEndPoint(IPAddress.Any, 50500);
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

                if (comando == "DHCPDISCOVER")
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(
                            delegate()
                            {
                                estado.Text = "SOLICITADO DHCPDISCOVER";
                                boton_avance.Enabled = true;
                            }
                            ));
                    }
                    else
                    {
                        estado.Text = "SOLICITADO DHCPDISCOVER";
                        boton_avance.Enabled = true;
                    }
                    mac_cliente = cadena[1];
                    offer = true;
                }

                if (comando == "DHCPREQUEST")
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(
                            delegate()
                            {
                                estado.Text = "DHCPREQUEST ENVIAR DHCPACK";
                                boton_avance.Enabled = true;
                            }
                            ));
                    }
                    else
                    {
                        estado.Text = "DHCPREQUEST ENVIAR DHCPACK";
                        boton_avance.Enabled = true;
                    }
                    ip_ofertado = cadena[1];
                    mac_cliente = cadena[2];
                    request = true;
                }

                if (comando == "DHCPREJECT")
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(
                            delegate()
                            {
                                estado.Text = "RECHAZADO DHCPOFFER";
                                boton_avance.Enabled = true;
                            }
                            ));
                    }
                    else
                    {
                        estado.Text = "RECHAZADO DHCPOFFER";
                        boton_avance.Enabled = true;
                    }

                    reject = true;
                }

                if (comando == "DHCPRELEASE")
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(
                            delegate()
                            {
                                estado.Text = "SOLICITUD DHCPRELEASE";
                                boton_avance.Enabled = true;
                            }
                            ));
                    }
                    else
                    {
                        estado.Text = "SOLICITUD DHCPRELEASE";
                        boton_avance.Enabled = true;
                    }

                    mac_cliente = cadena[1];
                    ip_ofertado = cadena[2];
                    release = true;
                }
            }
        }

        private void envia_udp(string ip, string mensaje)//funcion envia mensajes udp
        {
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(mensaje);
            Socket sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sendSocket.EnableBroadcast = true;
            IPEndPoint send_ep = new IPEndPoint(IPAddress.Parse(ip), 50600);
            sendSocket.SendTo(data, send_ep);
            sendSocket.Close();
        }

        private void boton_automatico_Click(object sender, EventArgs e)
        {
            modo.Text = "AUTOMATICO";
            boton_automatico.Enabled = false;
            boton_manual.Enabled = false;
            boton_temporal.Enabled = false;
            boton_reset.Enabled = true;
            boton_cambiar_ip.Enabled = false;
            boton_cambiar_rango.Enabled = false;
            boton_cambiar_mac.Enabled = false;
            t1 = new Thread(new ThreadStart(recibe_udp));
            t1.Start();
        }

        private void boton_manual_Click(object sender, EventArgs e)
        {
            modo.Text = "MANUAL";
            ip_asignada.Enabled = true;
            boton_automatico.Enabled = false;
            boton_manual.Enabled = false;
            boton_temporal.Enabled = false;
            boton_reset.Enabled = true;
            boton_cambiar_ip.Enabled = false;
            boton_cambiar_rango.Enabled = false;
            boton_cambiar_mac.Enabled = false;
            t1 = new Thread(new ThreadStart(recibe_udp));
            t1.Start();
        }

        private void boton_temporal_Click(object sender, EventArgs e)
        {
            modo.Text = "TEMPORAL";
            tiempo_box.Enabled = true;
            boton_automatico.Enabled = false;
            boton_manual.Enabled = false;
            boton_temporal.Enabled = false;
            boton_reset.Enabled = true;
            boton_cambiar_ip.Enabled = false;
            boton_cambiar_rango.Enabled = false;
            boton_cambiar_mac.Enabled = false;
            t1 = new Thread(new ThreadStart(recibe_udp));
            t1.Start();
        }

        private void boton_reset_Click(object sender, EventArgs e)
        {
            estado.Text = "ESPERANDO DHCPDISCOVER";
            modo.Text = "NINGUNO";
            tiempo_box.Enabled = false;
            ip_asignada.Enabled = false;
            boton_automatico.Enabled = true;
            boton_manual.Enabled = true;
            boton_temporal.Enabled = true;
            boton_avance.Enabled = false;
            boton_reset.Enabled = false;
            boton_cambiar_ip.Enabled = true;
            boton_cambiar_rango.Enabled = true;
            boton_cambiar_mac.Enabled = true;
            offer = false;
            request = false;
            reject = false;
            release = false;

            ip_servidor.Text = "192.168.1.1";
            rango_servidor.Text = "2~254";

            for (int i = 0; i < 50; i++)
                clientes[i] = null;

            receivesocket.Close();
            items.Clear();
            lista_clientes.DataSource = null;
            lista_clientes.DataSource = items;
            t1.Abort();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            receivesocket.Close();
            t1.Abort();
        }
    }
}
