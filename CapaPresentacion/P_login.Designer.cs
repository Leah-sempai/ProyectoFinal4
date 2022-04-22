namespace CapaPresentacion
{
    partial class P_login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.P_medialogin = new System.Windows.Forms.PictureBox();
            this.P_Cerrarlogin = new System.Windows.Forms.PictureBox();
            this.P_minimizarlogin = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUsuariologin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseñalogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_medialogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Cerrarlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_minimizarlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.P_medialogin);
            this.panel1.Controls.Add(this.P_Cerrarlogin);
            this.panel1.Controls.Add(this.P_minimizarlogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 66);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iniciar seccion";
            // 
            // P_medialogin
            // 
            this.P_medialogin.Image = global::CapaPresentacion.Properties.Resources.restore_window_50px;
            this.P_medialogin.Location = new System.Drawing.Point(454, 12);
            this.P_medialogin.Name = "P_medialogin";
            this.P_medialogin.Size = new System.Drawing.Size(40, 36);
            this.P_medialogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_medialogin.TabIndex = 5;
            this.P_medialogin.TabStop = false;
            this.P_medialogin.Click += new System.EventHandler(this.P_medialogin_Click_1);
            // 
            // P_Cerrarlogin
            // 
            this.P_Cerrarlogin.Image = global::CapaPresentacion.Properties.Resources.close_window_80px;
            this.P_Cerrarlogin.Location = new System.Drawing.Point(515, 3);
            this.P_Cerrarlogin.Name = "P_Cerrarlogin";
            this.P_Cerrarlogin.Size = new System.Drawing.Size(51, 45);
            this.P_Cerrarlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_Cerrarlogin.TabIndex = 4;
            this.P_Cerrarlogin.TabStop = false;
            this.P_Cerrarlogin.Click += new System.EventHandler(this.P_Cerrarlogin_Click_1);
            // 
            // P_minimizarlogin
            // 
            this.P_minimizarlogin.Image = global::CapaPresentacion.Properties.Resources.minimize_window_24px;
            this.P_minimizarlogin.Location = new System.Drawing.Point(395, 14);
            this.P_minimizarlogin.Name = "P_minimizarlogin";
            this.P_minimizarlogin.Size = new System.Drawing.Size(35, 34);
            this.P_minimizarlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_minimizarlogin.TabIndex = 3;
            this.P_minimizarlogin.TabStop = false;
            this.P_minimizarlogin.Click += new System.EventHandler(this.P_minimizarlogin_Click_1);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(81, 444);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 37);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "Usuario";
            // 
            // txtUsuariologin
            // 
            this.txtUsuariologin.BackColor = System.Drawing.Color.Lavender;
            this.txtUsuariologin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuariologin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuariologin.Location = new System.Drawing.Point(91, 484);
            this.txtUsuariologin.Name = "txtUsuariologin";
            this.txtUsuariologin.Size = new System.Drawing.Size(392, 23);
            this.txtUsuariologin.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contraseña";
            // 
            // txtContraseñalogin
            // 
            this.txtContraseñalogin.BackColor = System.Drawing.Color.Lavender;
            this.txtContraseñalogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñalogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñalogin.Location = new System.Drawing.Point(91, 589);
            this.txtContraseñalogin.Name = "txtContraseñalogin";
            this.txtContraseñalogin.Size = new System.Drawing.Size(392, 23);
            this.txtContraseñalogin.TabIndex = 15;
            this.txtContraseñalogin.TextChanged += new System.EventHandler(this.txtContraseñalogin_TextChanged);
            this.txtContraseñalogin.Enter += new System.EventHandler(this.txtContraseñalogin_Enter_1);
            this.txtContraseñalogin.Leave += new System.EventHandler(this.txtContraseñalogin_Leave_1);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(186, 651);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(218, 61);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Iniciar seccion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.itla1;
            this.pictureBox1.Location = new System.Drawing.Point(91, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // P_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 724);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtContraseñalogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuariologin);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.P_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_medialogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Cerrarlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_minimizarlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox P_medialogin;
        private System.Windows.Forms.PictureBox P_Cerrarlogin;
        private System.Windows.Forms.PictureBox P_minimizarlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUsuariologin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseñalogin;
        private System.Windows.Forms.Button btnLogin;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

