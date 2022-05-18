namespace GestorVuelos
{
    partial class Vista_Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAerolineasEditar = new System.Windows.Forms.Button();
            this.btnAerolineasAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCiudadesEditar = new System.Windows.Forms.Button();
            this.btnCiudadesAgregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditarEstado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(708, 276);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vista Vuelos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAerolineasEditar);
            this.groupBox1.Controls.Add(this.btnAerolineasAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(71, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aerolineas";
            // 
            // btnAerolineasEditar
            // 
            this.btnAerolineasEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAerolineasEditar.Location = new System.Drawing.Point(340, 22);
            this.btnAerolineasEditar.Name = "btnAerolineasEditar";
            this.btnAerolineasEditar.Size = new System.Drawing.Size(253, 34);
            this.btnAerolineasEditar.TabIndex = 1;
            this.btnAerolineasEditar.Text = "Editar";
            this.btnAerolineasEditar.UseVisualStyleBackColor = true;
            this.btnAerolineasEditar.Click += new System.EventHandler(this.btnAerolineasEditar_Click);
            // 
            // btnAerolineasAgregar
            // 
            this.btnAerolineasAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAerolineasAgregar.Location = new System.Drawing.Point(19, 22);
            this.btnAerolineasAgregar.Name = "btnAerolineasAgregar";
            this.btnAerolineasAgregar.Size = new System.Drawing.Size(246, 34);
            this.btnAerolineasAgregar.TabIndex = 0;
            this.btnAerolineasAgregar.Text = "Agregar";
            this.btnAerolineasAgregar.UseVisualStyleBackColor = true;
            this.btnAerolineasAgregar.Click += new System.EventHandler(this.btnAerolineasAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCiudadesEditar);
            this.groupBox2.Controls.Add(this.btnCiudadesAgregar);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(71, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 68);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ciudades";
            // 
            // btnCiudadesEditar
            // 
            this.btnCiudadesEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCiudadesEditar.Location = new System.Drawing.Point(340, 22);
            this.btnCiudadesEditar.Name = "btnCiudadesEditar";
            this.btnCiudadesEditar.Size = new System.Drawing.Size(253, 34);
            this.btnCiudadesEditar.TabIndex = 4;
            this.btnCiudadesEditar.Text = "Editar";
            this.btnCiudadesEditar.UseVisualStyleBackColor = true;
            this.btnCiudadesEditar.Click += new System.EventHandler(this.btnCiudadesEditar_Click);
            // 
            // btnCiudadesAgregar
            // 
            this.btnCiudadesAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCiudadesAgregar.Location = new System.Drawing.Point(19, 22);
            this.btnCiudadesAgregar.Name = "btnCiudadesAgregar";
            this.btnCiudadesAgregar.Size = new System.Drawing.Size(246, 34);
            this.btnCiudadesAgregar.TabIndex = 3;
            this.btnCiudadesAgregar.Text = "Agregar";
            this.btnCiudadesAgregar.UseVisualStyleBackColor = true;
            this.btnCiudadesAgregar.Click += new System.EventHandler(this.btnCiudadesAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditarEstado);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(71, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 68);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vuelos";
            // 
            // btnEditarEstado
            // 
            this.btnEditarEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarEstado.Location = new System.Drawing.Point(340, 22);
            this.btnEditarEstado.Name = "btnEditarEstado";
            this.btnEditarEstado.Size = new System.Drawing.Size(253, 34);
            this.btnEditarEstado.TabIndex = 9;
            this.btnEditarEstado.Text = "Cambiar estado";
            this.btnEditarEstado.UseVisualStyleBackColor = true;
            this.btnEditarEstado.Click += new System.EventHandler(this.btnEditarEstado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(50, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(228, 34);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Vista_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Vista_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista_Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vista_Admin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnAerolineasEditar;
        private Button btnAerolineasAgregar;
        private GroupBox groupBox2;
        private Button btnCiudadesEditar;
        private Button btnCiudadesAgregar;
        private GroupBox groupBox3;
        private Button btnEditarEstado;
        private Button btnAgregar;
    }
}