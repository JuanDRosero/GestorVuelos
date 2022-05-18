namespace GestorVuelos
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(196, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso";
            // 
            // pb1
            // 
            this.pb1.Image = global::GestorVuelos.Properties.Resources.user__1_;
            this.pb1.Location = new System.Drawing.Point(166, 55);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(129, 101);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.Location = new System.Drawing.Point(134, 172);
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(245, 23);
            this.textBoxDoc.TabIndex = 4;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(134, 206);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(245, 23);
            this.textBoxPass.TabIndex = 5;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(30, 246);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(186, 38);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Ingresar como Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(236, 246);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(169, 38);
            this.btnUsuario.TabIndex = 7;
            this.btnUsuario.Text = "Continuar como usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(444, 296);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pb1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDoc;
        private TextBox textBoxPass;
        private Button btnAdmin;
        private Button btnUsuario;
    }
}