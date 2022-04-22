namespace CapaPresentacion
{
    partial class P_consultarvisitas
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
            this.components = new System.ComponentModel.Container();
            this.panelConsultarVisitas = new System.Windows.Forms.Panel();
            this.lblConsultarVisitas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEdificios = new System.Windows.Forms.ComboBox();
            this.cbxAula = new System.Windows.Forms.ComboBox();
            this.txtEdificios = new System.Windows.Forms.TextBox();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.TablaConsultarVisitas = new System.Windows.Forms.DataGridView();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnBuscarConsultarAula = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBuscarEdificiosConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrarConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelConsultarVisitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaConsultarVisitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultarVisitas
            // 
            this.panelConsultarVisitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panelConsultarVisitas.Controls.Add(this.btnCerrarConsultar);
            this.panelConsultarVisitas.Controls.Add(this.pictureBox1);
            this.panelConsultarVisitas.Controls.Add(this.lblConsultarVisitas);
            this.panelConsultarVisitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConsultarVisitas.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarVisitas.Name = "panelConsultarVisitas";
            this.panelConsultarVisitas.Size = new System.Drawing.Size(800, 68);
            this.panelConsultarVisitas.TabIndex = 2;
            // 
            // lblConsultarVisitas
            // 
            this.lblConsultarVisitas.AutoSize = true;
            this.lblConsultarVisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarVisitas.Location = new System.Drawing.Point(282, 23);
            this.lblConsultarVisitas.Name = "lblConsultarVisitas";
            this.lblConsultarVisitas.Size = new System.Drawing.Size(245, 32);
            this.lblConsultarVisitas.TabIndex = 0;
            this.lblConsultarVisitas.Text = "Consultar Visitas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edificios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(479, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aula";
            // 
            // cbxEdificios
            // 
            this.cbxEdificios.BackColor = System.Drawing.Color.Lavender;
            this.cbxEdificios.FormattingEnabled = true;
            this.cbxEdificios.Items.AddRange(new object[] {
            "uno",
            "dos",
            "tres",
            "cuatro"});
            this.cbxEdificios.Location = new System.Drawing.Point(136, 145);
            this.cbxEdificios.Name = "cbxEdificios";
            this.cbxEdificios.Size = new System.Drawing.Size(211, 28);
            this.cbxEdificios.TabIndex = 5;
            this.cbxEdificios.SelectedIndexChanged += new System.EventHandler(this.cbxEdificios_SelectedIndexChanged);
            // 
            // cbxAula
            // 
            this.cbxAula.BackColor = System.Drawing.Color.Lavender;
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Items.AddRange(new object[] {
            "1B",
            "2A",
            "1A",
            "2B"});
            this.cbxAula.Location = new System.Drawing.Point(416, 145);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(211, 28);
            this.cbxAula.TabIndex = 6;
            this.cbxAula.SelectedIndexChanged += new System.EventHandler(this.cbxAula_SelectedIndexChanged);
            // 
            // txtEdificios
            // 
            this.txtEdificios.BackColor = System.Drawing.Color.Lavender;
            this.txtEdificios.Location = new System.Drawing.Point(162, 193);
            this.txtEdificios.Name = "txtEdificios";
            this.txtEdificios.Size = new System.Drawing.Size(148, 26);
            this.txtEdificios.TabIndex = 7;
            this.txtEdificios.TextChanged += new System.EventHandler(this.txtEdificios_TextChanged);
            // 
            // txtAulas
            // 
            this.txtAulas.BackColor = System.Drawing.Color.Lavender;
            this.txtAulas.Location = new System.Drawing.Point(443, 193);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(153, 26);
            this.txtAulas.TabIndex = 8;
            // 
            // TablaConsultarVisitas
            // 
            this.TablaConsultarVisitas.AllowUserToAddRows = false;
            this.TablaConsultarVisitas.AllowUserToDeleteRows = false;
            this.TablaConsultarVisitas.BackgroundColor = System.Drawing.Color.SlateGray;
            this.TablaConsultarVisitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaConsultarVisitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaConsultarVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaConsultarVisitas.GridColor = System.Drawing.SystemColors.Control;
            this.TablaConsultarVisitas.Location = new System.Drawing.Point(23, 359);
            this.TablaConsultarVisitas.Name = "TablaConsultarVisitas";
            this.TablaConsultarVisitas.ReadOnly = true;
            this.TablaConsultarVisitas.RowHeadersWidth = 62;
            this.TablaConsultarVisitas.RowTemplate.Height = 28;
            this.TablaConsultarVisitas.Size = new System.Drawing.Size(753, 251);
            this.TablaConsultarVisitas.TabIndex = 11;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelConsultarVisitas;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnBuscarConsultarAula
            // 
            this.btnBuscarConsultarAula.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnBuscarConsultarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnBuscarConsultarAula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarConsultarAula.BorderRadius = 0;
            this.btnBuscarConsultarAula.ButtonText = "Limpiar";
            this.btnBuscarConsultarAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarConsultarAula.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarConsultarAula.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarConsultarAula.Iconimage = global::CapaPresentacion.Properties.Resources.broom_50px;
            this.btnBuscarConsultarAula.Iconimage_right = null;
            this.btnBuscarConsultarAula.Iconimage_right_Selected = null;
            this.btnBuscarConsultarAula.Iconimage_Selected = null;
            this.btnBuscarConsultarAula.IconMarginLeft = 0;
            this.btnBuscarConsultarAula.IconMarginRight = 0;
            this.btnBuscarConsultarAula.IconRightVisible = true;
            this.btnBuscarConsultarAula.IconRightZoom = 0D;
            this.btnBuscarConsultarAula.IconVisible = true;
            this.btnBuscarConsultarAula.IconZoom = 90D;
            this.btnBuscarConsultarAula.IsTab = false;
            this.btnBuscarConsultarAula.Location = new System.Drawing.Point(416, 263);
            this.btnBuscarConsultarAula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarConsultarAula.Name = "btnBuscarConsultarAula";
            this.btnBuscarConsultarAula.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnBuscarConsultarAula.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnBuscarConsultarAula.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscarConsultarAula.selected = false;
            this.btnBuscarConsultarAula.Size = new System.Drawing.Size(211, 65);
            this.btnBuscarConsultarAula.TabIndex = 10;
            this.btnBuscarConsultarAula.Text = "Limpiar";
            this.btnBuscarConsultarAula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarConsultarAula.Textcolor = System.Drawing.Color.White;
            this.btnBuscarConsultarAula.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarConsultarAula.Click += new System.EventHandler(this.btnBuscarConsultarAula_Click);
            // 
            // btnBuscarEdificiosConsultar
            // 
            this.btnBuscarEdificiosConsultar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnBuscarEdificiosConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnBuscarEdificiosConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEdificiosConsultar.BorderRadius = 0;
            this.btnBuscarEdificiosConsultar.ButtonText = " Buscar";
            this.btnBuscarEdificiosConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEdificiosConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarEdificiosConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarEdificiosConsultar.Iconimage = global::CapaPresentacion.Properties.Resources.search_16px;
            this.btnBuscarEdificiosConsultar.Iconimage_right = null;
            this.btnBuscarEdificiosConsultar.Iconimage_right_Selected = null;
            this.btnBuscarEdificiosConsultar.Iconimage_Selected = null;
            this.btnBuscarEdificiosConsultar.IconMarginLeft = 0;
            this.btnBuscarEdificiosConsultar.IconMarginRight = 0;
            this.btnBuscarEdificiosConsultar.IconRightVisible = true;
            this.btnBuscarEdificiosConsultar.IconRightZoom = 0D;
            this.btnBuscarEdificiosConsultar.IconVisible = true;
            this.btnBuscarEdificiosConsultar.IconZoom = 90D;
            this.btnBuscarEdificiosConsultar.IsTab = false;
            this.btnBuscarEdificiosConsultar.Location = new System.Drawing.Point(136, 263);
            this.btnBuscarEdificiosConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarEdificiosConsultar.Name = "btnBuscarEdificiosConsultar";
            this.btnBuscarEdificiosConsultar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnBuscarEdificiosConsultar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnBuscarEdificiosConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscarEdificiosConsultar.selected = false;
            this.btnBuscarEdificiosConsultar.Size = new System.Drawing.Size(211, 65);
            this.btnBuscarEdificiosConsultar.TabIndex = 9;
            this.btnBuscarEdificiosConsultar.Text = " Buscar";
            this.btnBuscarEdificiosConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarEdificiosConsultar.Textcolor = System.Drawing.Color.White;
            this.btnBuscarEdificiosConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEdificiosConsultar.Click += new System.EventHandler(this.btnBuscarEdificiosConsultar_Click);
            // 
            // btnCerrarConsultar
            // 
            this.btnCerrarConsultar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCerrarConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCerrarConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarConsultar.BorderRadius = 0;
            this.btnCerrarConsultar.ButtonText = "";
            this.btnCerrarConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrarConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrarConsultar.Iconimage = global::CapaPresentacion.Properties.Resources.close_window_80px;
            this.btnCerrarConsultar.Iconimage_right = null;
            this.btnCerrarConsultar.Iconimage_right_Selected = null;
            this.btnCerrarConsultar.Iconimage_Selected = null;
            this.btnCerrarConsultar.IconMarginLeft = 0;
            this.btnCerrarConsultar.IconMarginRight = 0;
            this.btnCerrarConsultar.IconRightVisible = true;
            this.btnCerrarConsultar.IconRightZoom = 0D;
            this.btnCerrarConsultar.IconVisible = true;
            this.btnCerrarConsultar.IconZoom = 90D;
            this.btnCerrarConsultar.IsTab = false;
            this.btnCerrarConsultar.Location = new System.Drawing.Point(724, 0);
            this.btnCerrarConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarConsultar.Name = "btnCerrarConsultar";
            this.btnCerrarConsultar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCerrarConsultar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCerrarConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrarConsultar.selected = false;
            this.btnCerrarConsultar.Size = new System.Drawing.Size(76, 68);
            this.btnCerrarConsultar.TabIndex = 2;
            this.btnCerrarConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarConsultar.Textcolor = System.Drawing.Color.White;
            this.btnCerrarConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarConsultar.Click += new System.EventHandler(this.btnCerrarConsultar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.communicate_80px;
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // P_consultarvisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.TablaConsultarVisitas);
            this.Controls.Add(this.btnBuscarConsultarAula);
            this.Controls.Add(this.btnBuscarEdificiosConsultar);
            this.Controls.Add(this.txtAulas);
            this.Controls.Add(this.txtEdificios);
            this.Controls.Add(this.cbxAula);
            this.Controls.Add(this.cbxEdificios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelConsultarVisitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_consultarvisitas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.P_consultarvisitas_Load);
            this.panelConsultarVisitas.ResumeLayout(false);
            this.panelConsultarVisitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaConsultarVisitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultarVisitas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConsultarVisitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEdificios;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.TextBox txtEdificios;
        private System.Windows.Forms.TextBox txtAulas;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarEdificiosConsultar;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarConsultarAula;
        private System.Windows.Forms.DataGridView TablaConsultarVisitas;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrarConsultar;
    }
}