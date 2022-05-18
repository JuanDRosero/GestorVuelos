namespace GestorVuelos
{
    partial class AgregarVuelo
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
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBoxestado = new System.Windows.Forms.ComboBox();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLlegada = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAerolinea = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(141, 85);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(218, 23);
            this.textBoxNo.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(459, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(44, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Aerolinea:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(414, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Hora Llegada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(29, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hora Salida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(467, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(403, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ciudad destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ciudad origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "No. Vuelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(355, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Agregar Vuelo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 35);
            this.button2.TabIndex = 38;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(538, 85);
            this.dateTimePickerFecha.MinDate = new System.DateTime(2022, 5, 17, 0, 0, 0, 0);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(216, 23);
            this.dateTimePickerFecha.TabIndex = 39;
            this.dateTimePickerFecha.Value = new System.DateTime(2022, 5, 17, 19, 35, 2, 0);
            // 
            // comboBoxestado
            // 
            this.comboBoxestado.FormattingEnabled = true;
            this.comboBoxestado.Items.AddRange(new object[] {
            "En vuelo",
            "Terminado"});
            this.comboBoxestado.Location = new System.Drawing.Point(538, 248);
            this.comboBoxestado.Name = "comboBoxestado";
            this.comboBoxestado.Size = new System.Drawing.Size(218, 23);
            this.comboBoxestado.TabIndex = 40;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(141, 139);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(218, 23);
            this.comboBoxOrigen.TabIndex = 41;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(538, 139);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(218, 23);
            this.comboBoxDestino.TabIndex = 42;
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerSalida.Location = new System.Drawing.Point(141, 190);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.ShowUpDown = true;
            this.dateTimePickerSalida.Size = new System.Drawing.Size(218, 23);
            this.dateTimePickerSalida.TabIndex = 43;
            // 
            // dateTimePickerLlegada
            // 
            this.dateTimePickerLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerLlegada.Location = new System.Drawing.Point(536, 194);
            this.dateTimePickerLlegada.Name = "dateTimePickerLlegada";
            this.dateTimePickerLlegada.ShowUpDown = true;
            this.dateTimePickerLlegada.Size = new System.Drawing.Size(218, 23);
            this.dateTimePickerLlegada.TabIndex = 44;
            // 
            // comboBoxAerolinea
            // 
            this.comboBoxAerolinea.FormattingEnabled = true;
            this.comboBoxAerolinea.Location = new System.Drawing.Point(141, 249);
            this.comboBoxAerolinea.Name = "comboBoxAerolinea";
            this.comboBoxAerolinea.Size = new System.Drawing.Size(218, 23);
            this.comboBoxAerolinea.TabIndex = 45;
            // 
            // AgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.comboBoxAerolinea);
            this.Controls.Add(this.dateTimePickerLlegada);
            this.Controls.Add(this.dateTimePickerSalida);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.comboBoxestado);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgregarVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarVuelo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarVuelo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxNo;
        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private DateTimePicker dateTimePickerFecha;
        private ComboBox comboBoxestado;
        private ComboBox comboBoxOrigen;
        private ComboBox comboBoxDestino;
        private DateTimePicker dateTimePickerSalida;
        private DateTimePicker dateTimePickerLlegada;
        private ComboBox comboBoxAerolinea;
    }
}