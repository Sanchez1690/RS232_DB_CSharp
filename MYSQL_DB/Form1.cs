using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using System.Threading;

namespace MYSQL_DB
{
    public partial class Form1 : Form
    {
        private delegate void DelegadoAcceso(string accion);
        private string strBufferIn;
        string dato2;
        int x = 0;
        string fact_1;
        //private string strBufferOut;

        Clases.Conexion conexion = new Clases.Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        /*public void ListaUsuarios(MySqlConnection conexion,string pTitulo,string pValor) 
        {
            dataGridView1.DataSource = Clases.Usuario.Buscar(conexion, pTitulo,pValor);
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            Conectar_Port_Serial.Enabled = false;
            //strBufferOut = "";
            /*
            try
            {
                if (conexion.AbrirConexion() == true) 
                {
                    ListaUsuarios(conexion.conexion, TX_Titulo.Text, TX_Valor.Text);
                    conexion.CerrarConexion();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    Clases.Usuario pUsuario = new Clases.Usuario();
                    //pUsuario.id_p = 1;
                    pUsuario.titulo = TX_Titulo.Text;
                    pUsuario.valor = TX_Valor.Text;

                    int res;

                    res = Clases.Usuario.Agregar(conexion.conexion,pUsuario);

                    if (res != 0) 
                    {
                        TX_ID.Clear();
                        TX_Titulo.Clear();
                        TX_Valor.Clear();
                        ListaUsuarios(conexion.conexion, TX_Titulo.Text, TX_Valor.Text);
                    }

                    conexion.CerrarConexion();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) { MessageBox.Show(ex.Message); }
            */
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {/*
            try
            {
                if (conexion.AbrirConexion() == true)
                {
                    ListaUsuarios(conexion.conexion, TX_Titulo.Text, TX_Valor.Text);
                    conexion.CerrarConexion();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            CBX_Ports.Items.Clear();
            foreach(string puertoSimple in PuertosDisponibles)
            {
                CBX_Ports.Items.Add(puertoSimple);
            }
            if (CBX_Ports.Items.Count > 0) { /*MessageBox.Show("Seleccionar puerto de trabajo");*/Conectar_Port_Serial.Enabled = true; }
            else { 
                MessageBox.Show("Ningun puerto detectado"); 
                CBX_Ports.Items.Clear();
                strBufferIn = "";
                //strBufferOut = "";
            }
        }

        private void Conectar_Port_Serial_Click(object sender, EventArgs e)
        {
            LED_Conexion.BackColor = Color.Green;
            try 
            {
                if (Conectar_Port_Serial.Text == "Conectar") 
                {
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.PortName = CBX_Ports.Text;
                    serialPort1.ParityReplace = 0;
                    try
                    {
                        serialPort1.Open();
                        Conectar_Port_Serial.Text = "Desconectar";
                        timer1.Enabled = true;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                }

                else if(Conectar_Port_Serial.Text == "Desconectar") 
                {
                    serialPort1.Close();
                    Conectar_Port_Serial.Text = "Conectar";
                    LED_Conexion.BackColor = Color.White;
                    LED_Recepcion.BackColor = Color.White;
                    timer1.Enabled = false;
                }
                
            }

            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void AccesoForm(string accion) 
        {
            strBufferIn = accion;
            TX_Datos_RS232.Text =  strBufferIn;
        }

        private void AccesoInterrupcion(string accion) 
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);
        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(serialPort1.ReadExisting());
            //TX_Datos_RS232.Text = TX_Datos_RS232.Text.Replace(System.Environment.NewLine, "replacement text");
            //MessageBox.Show(TX_Datos_RS232.Text);
            LED_Recepcion.BackColor = Color.Green;
            Thread.Sleep(2000);
            /* string DataIn = serialPort1.ReadExisting();
             MessageBox.Show(DataIn);
             TX_Datos_RS232.Text = DataIn;*/
        }


        private void enviarBD() 
        {
            string[] separadas;
            separadas = TX_Datos_RS232.Text.Split('\n');
            //MessageBox.Show(TX_Datos_RS232.Text);
            //MessageBox.Show(separadas[0]);
            string dato = separadas[0];

            x = 0;

            if (dato == " \r" || dato == " \n" || string.IsNullOrEmpty(dato))
            {
                dato = "0";
            }
            
            else 
            {
                if (!string.IsNullOrEmpty(fact_1)) 
                {
                    dato = fact_1 + dato;
                    fact_1 = "";
                }

                char[] chars = dato.ToCharArray();
                for (int i = 0; i < dato.Length; i++)
                {
                    if (chars[i] == '\r') 
                    {
                        x++;
                    }
                    
                }

                if (x > 0) { 
                if (dato != dato2)
                {
                    try
                    {
                        if (conexion.AbrirConexion() == true)
                        {
                            LED_Envio_BD.BackColor = Color.Green;
                            Clases.Usuario pUsuario = new Clases.Usuario();
                            //pUsuario.id_p = 1;
                            pUsuario.titulo = "Pot";
                            pUsuario.valor = dato;

                            int res;

                            res = Clases.Usuario.Agregar(conexion.conexion, pUsuario);

                            if (res != 0)
                            {
                                //TX_ID.Clear();
                                //TX_Titulo.Clear();
                                //TX_Valor.Clear();
                                //TX_Datos_RS232.Clear();
                                //ListaUsuarios(conexion.conexion, "", "");
                            }

                            conexion.CerrarConexion();
                        }
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex) { MessageBox.Show(ex.Message); }
                }
                dato2 = dato;
                }
                else 
                {
                    fact_1 = dato;
                }
            }

            /*
            if (dato != "0" && dato != "4" && dato != "0 \r" && dato != "4 \r") 
            {
                separadas[0] = "0";
            }
            */
 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            LED_Recepcion.BackColor = Color.White;           
            enviarBD();
            LED_Envio_BD.BackColor = Color.White;
        }
    }
}
