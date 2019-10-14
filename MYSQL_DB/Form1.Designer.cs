namespace MYSQL_DB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TX_ID = new System.Windows.Forms.TextBox();
            this.TX_Titulo = new System.Windows.Forms.TextBox();
            this.TX_Valor = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TX_Datos_RS232 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CBX_Ports = new System.Windows.Forms.ComboBox();
            this.Conectar_Port_Serial = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LED_Conexion = new System.Windows.Forms.Button();
            this.LED_Envio_BD = new System.Windows.Forms.Button();
            this.LED_Recepcion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // TX_ID
            // 
            this.TX_ID.Location = new System.Drawing.Point(15, 29);
            this.TX_ID.Name = "TX_ID";
            this.TX_ID.ReadOnly = true;
            this.TX_ID.Size = new System.Drawing.Size(44, 22);
            this.TX_ID.TabIndex = 3;
            // 
            // TX_Titulo
            // 
            this.TX_Titulo.Location = new System.Drawing.Point(90, 29);
            this.TX_Titulo.Name = "TX_Titulo";
            this.TX_Titulo.Size = new System.Drawing.Size(100, 22);
            this.TX_Titulo.TabIndex = 4;
            // 
            // TX_Valor
            // 
            this.TX_Valor.Location = new System.Drawing.Point(227, 29);
            this.TX_Valor.Name = "TX_Valor";
            this.TX_Valor.Size = new System.Drawing.Size(100, 22);
            this.TX_Valor.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(373, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(82, 31);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(373, 60);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(82, 31);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(461, 16);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(82, 31);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(461, 60);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(82, 31);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 232);
            this.dataGridView1.TabIndex = 10;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // TX_Datos_RS232
            // 
            this.TX_Datos_RS232.Location = new System.Drawing.Point(581, 97);
            this.TX_Datos_RS232.Multiline = true;
            this.TX_Datos_RS232.Name = "TX_Datos_RS232";
            this.TX_Datos_RS232.Size = new System.Drawing.Size(471, 232);
            this.TX_Datos_RS232.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "B.Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBX_Ports
            // 
            this.CBX_Ports.FormattingEnabled = true;
            this.CBX_Ports.Location = new System.Drawing.Point(687, 20);
            this.CBX_Ports.Name = "CBX_Ports";
            this.CBX_Ports.Size = new System.Drawing.Size(132, 24);
            this.CBX_Ports.TabIndex = 13;
            // 
            // Conectar_Port_Serial
            // 
            this.Conectar_Port_Serial.Location = new System.Drawing.Point(581, 60);
            this.Conectar_Port_Serial.Name = "Conectar_Port_Serial";
            this.Conectar_Port_Serial.Size = new System.Drawing.Size(82, 31);
            this.Conectar_Port_Serial.TabIndex = 14;
            this.Conectar_Port_Serial.Text = "Conectar";
            this.Conectar_Port_Serial.UseVisualStyleBackColor = true;
            this.Conectar_Port_Serial.Click += new System.EventHandler(this.Conectar_Port_Serial_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LED_Conexion
            // 
            this.LED_Conexion.Location = new System.Drawing.Point(844, 9);
            this.LED_Conexion.Name = "LED_Conexion";
            this.LED_Conexion.Size = new System.Drawing.Size(30, 30);
            this.LED_Conexion.TabIndex = 15;
            this.LED_Conexion.UseVisualStyleBackColor = true;
            // 
            // LED_Envio_BD
            // 
            this.LED_Envio_BD.Location = new System.Drawing.Point(880, 9);
            this.LED_Envio_BD.Name = "LED_Envio_BD";
            this.LED_Envio_BD.Size = new System.Drawing.Size(30, 30);
            this.LED_Envio_BD.TabIndex = 16;
            this.LED_Envio_BD.UseVisualStyleBackColor = true;
            // 
            // LED_Recepcion
            // 
            this.LED_Recepcion.Location = new System.Drawing.Point(916, 9);
            this.LED_Recepcion.Name = "LED_Recepcion";
            this.LED_Recepcion.Size = new System.Drawing.Size(30, 30);
            this.LED_Recepcion.TabIndex = 17;
            this.LED_Recepcion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 341);
            this.Controls.Add(this.LED_Recepcion);
            this.Controls.Add(this.LED_Envio_BD);
            this.Controls.Add(this.LED_Conexion);
            this.Controls.Add(this.Conectar_Port_Serial);
            this.Controls.Add(this.CBX_Ports);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TX_Datos_RS232);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.TX_Valor);
            this.Controls.Add(this.TX_Titulo);
            this.Controls.Add(this.TX_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TX_ID;
        private System.Windows.Forms.TextBox TX_Titulo;
        private System.Windows.Forms.TextBox TX_Valor;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox TX_Datos_RS232;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBX_Ports;
        private System.Windows.Forms.Button Conectar_Port_Serial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button LED_Conexion;
        private System.Windows.Forms.Button LED_Envio_BD;
        private System.Windows.Forms.Button LED_Recepcion;
    }
}

