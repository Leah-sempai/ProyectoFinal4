namespace CapaPresentacion
{
    partial class P_agregarusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_agregarusuario));
            this.panelNuevoUsuario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreAgregar = new System.Windows.Forms.Label();
            this.lblApellidoAgregar = new System.Windows.Forms.Label();
            this.txtNombreAgregar = new System.Windows.Forms.TextBox();
            this.txtApellidoAgregar = new System.Windows.Forms.TextBox();
            this.lblFechaAgregar = new System.Windows.Forms.Label();
            this.dtFechaAgregar = new System.Windows.Forms.DateTimePicker();
            this.TablaAgregarUsuario = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModifiarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnCerrarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelNuevoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAgregarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNuevoUsuario
            // 
            this.panelNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panelNuevoUsuario.Controls.Add(this.btnCerrarUsuario);
            this.panelNuevoUsuario.Controls.Add(this.pictureBox1);
            this.panelNuevoUsuario.Controls.Add(this.label1);
            this.panelNuevoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNuevoUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelNuevoUsuario.Name = "panelNuevoUsuario";
            this.panelNuevoUsuario.Size = new System.Drawing.Size(1033, 75);
            this.panelNuevoUsuario.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Usuario";
            // 
            // lblNombreAgregar
            // 
            this.lblNombreAgregar.AutoSize = true;
            this.lblNombreAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAgregar.ForeColor = System.Drawing.Color.White;
            this.lblNombreAgregar.Location = new System.Drawing.Point(43, 118);
            this.lblNombreAgregar.Name = "lblNombreAgregar";
            this.lblNombreAgregar.Size = new System.Drawing.Size(120, 32);
            this.lblNombreAgregar.TabIndex = 2;
            this.lblNombreAgregar.Text = "Nombre";
            // 
            // lblApellidoAgregar
            // 
            this.lblApellidoAgregar.AutoSize = true;
            this.lblApellidoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoAgregar.ForeColor = System.Drawing.Color.White;
            this.lblApellidoAgregar.Location = new System.Drawing.Point(380, 118);
            this.lblApellidoAgregar.Name = "lblApellidoAgregar";
            this.lblApellidoAgregar.Size = new System.Drawing.Size(126, 32);
            this.lblApellidoAgregar.TabIndex = 3;
            this.lblApellidoAgregar.Text = "Apellido";
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAgregar.Location = new System.Drawing.Point(49, 167);
            this.txtNombreAgregar.Multiline = true;
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(248, 61);
            this.txtNombreAgregar.TabIndex = 4;
            // 
            // txtApellidoAgregar
            // 
            this.txtApellidoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAgregar.Location = new System.Drawing.Point(386, 167);
            this.txtApellidoAgregar.Multiline = true;
            this.txtApellidoAgregar.Name = "txtApellidoAgregar";
            this.txtApellidoAgregar.Size = new System.Drawing.Size(231, 61);
            this.txtApellidoAgregar.TabIndex = 5;
            // 
            // lblFechaAgregar
            // 
            this.lblFechaAgregar.AutoSize = true;
            this.lblFechaAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAgregar.ForeColor = System.Drawing.Color.White;
            this.lblFechaAgregar.Location = new System.Drawing.Point(701, 118);
            this.lblFechaAgregar.Name = "lblFechaAgregar";
            this.lblFechaAgregar.Size = new System.Drawing.Size(301, 32);
            this.lblFechaAgregar.TabIndex = 6;
            this.lblFechaAgregar.Text = "Fecha de Nacimiento";
            // 
            // dtFechaAgregar
            // 
            this.dtFechaAgregar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaAgregar.Location = new System.Drawing.Point(691, 165);
            this.dtFechaAgregar.Name = "dtFechaAgregar";
            this.dtFechaAgregar.Size = new System.Drawing.Size(323, 28);
            this.dtFechaAgregar.TabIndex = 7;
            this.dtFechaAgregar.ValueChanged += new System.EventHandler(this.dtFechaAgregar_ValueChanged);
            // 
            // TablaAgregarUsuario
            // 
            this.TablaAgregarUsuario.AllowUserToAddRows = false;
            this.TablaAgregarUsuario.AllowUserToDeleteRows = false;
            this.TablaAgregarUsuario.BackgroundColor = System.Drawing.Color.SlateGray;
            this.TablaAgregarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaAgregarUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaAgregarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAgregarUsuario.Location = new System.Drawing.Point(49, 248);
            this.TablaAgregarUsuario.Name = "TablaAgregarUsuario";
            this.TablaAgregarUsuario.ReadOnly = true;
            this.TablaAgregarUsuario.RowHeadersWidth = 62;
            this.TablaAgregarUsuario.RowTemplate.Height = 28;
            this.TablaAgregarUsuario.Size = new System.Drawing.Size(695, 257);
            this.TablaAgregarUsuario.TabIndex = 8;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarUsuario.BorderRadius = 0;
            this.btnAgregarUsuario.ButtonText = "Agregar";
            this.btnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.Iconimage")));
            this.btnAgregarUsuario.Iconimage_right = null;
            this.btnAgregarUsuario.Iconimage_right_Selected = null;
            this.btnAgregarUsuario.Iconimage_Selected = null;
            this.btnAgregarUsuario.IconMarginLeft = 0;
            this.btnAgregarUsuario.IconMarginRight = 0;
            this.btnAgregarUsuario.IconRightVisible = true;
            this.btnAgregarUsuario.IconRightZoom = 0D;
            this.btnAgregarUsuario.IconVisible = true;
            this.btnAgregarUsuario.IconZoom = 60D;
            this.btnAgregarUsuario.IsTab = false;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(818, 248);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAgregarUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAgregarUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.selected = false;
            this.btnAgregarUsuario.Size = new System.Drawing.Size(196, 71);
            this.btnAgregarUsuario.TabIndex = 9;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarUsuario.Textcolor = System.Drawing.Color.White;
            this.btnAgregarUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnModifiarUsuario
            // 
            this.btnModifiarUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnModifiarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnModifiarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifiarUsuario.BorderRadius = 0;
            this.btnModifiarUsuario.ButtonText = "Modificar";
            this.btnModifiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifiarUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnModifiarUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModifiarUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModifiarUsuario.Iconimage")));
            this.btnModifiarUsuario.Iconimage_right = null;
            this.btnModifiarUsuario.Iconimage_right_Selected = null;
            this.btnModifiarUsuario.Iconimage_Selected = null;
            this.btnModifiarUsuario.IconMarginLeft = 0;
            this.btnModifiarUsuario.IconMarginRight = 0;
            this.btnModifiarUsuario.IconRightVisible = true;
            this.btnModifiarUsuario.IconRightZoom = 0D;
            this.btnModifiarUsuario.IconVisible = true;
            this.btnModifiarUsuario.IconZoom = 60D;
            this.btnModifiarUsuario.IsTab = false;
            this.btnModifiarUsuario.Location = new System.Drawing.Point(818, 342);
            this.btnModifiarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifiarUsuario.Name = "btnModifiarUsuario";
            this.btnModifiarUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnModifiarUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnModifiarUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModifiarUsuario.selected = false;
            this.btnModifiarUsuario.Size = new System.Drawing.Size(196, 71);
            this.btnModifiarUsuario.TabIndex = 10;
            this.btnModifiarUsuario.Text = "Modificar";
            this.btnModifiarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModifiarUsuario.Textcolor = System.Drawing.Color.White;
            this.btnModifiarUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifiarUsuario.Click += new System.EventHandler(this.btnModifiarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarUsuario.BorderRadius = 0;
            this.btnEliminarUsuario.ButtonText = "Eliminar";
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarUsuario.Iconimage")));
            this.btnEliminarUsuario.Iconimage_right = null;
            this.btnEliminarUsuario.Iconimage_right_Selected = null;
            this.btnEliminarUsuario.Iconimage_Selected = null;
            this.btnEliminarUsuario.IconMarginLeft = 0;
            this.btnEliminarUsuario.IconMarginRight = 0;
            this.btnEliminarUsuario.IconRightVisible = true;
            this.btnEliminarUsuario.IconRightZoom = 0D;
            this.btnEliminarUsuario.IconVisible = true;
            this.btnEliminarUsuario.IconZoom = 60D;
            this.btnEliminarUsuario.IsTab = false;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(818, 434);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnEliminarUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnEliminarUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.selected = false;
            this.btnEliminarUsuario.Size = new System.Drawing.Size(196, 71);
            this.btnEliminarUsuario.TabIndex = 11;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarUsuario.Textcolor = System.Drawing.Color.White;
            this.btnEliminarUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelNuevoUsuario;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnCerrarUsuario
            // 
            this.btnCerrarUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCerrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCerrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarUsuario.BorderRadius = 0;
            this.btnCerrarUsuario.ButtonText = "bunifuFlatButton1";
            this.btnCerrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrarUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrarUsuario.Iconimage = global::CapaPresentacion.Properties.Resources.close_window_80px;
            this.btnCerrarUsuario.Iconimage_right = null;
            this.btnCerrarUsuario.Iconimage_right_Selected = null;
            this.btnCerrarUsuario.Iconimage_Selected = null;
            this.btnCerrarUsuario.IconMarginLeft = 0;
            this.btnCerrarUsuario.IconMarginRight = 0;
            this.btnCerrarUsuario.IconRightVisible = true;
            this.btnCerrarUsuario.IconRightZoom = 0D;
            this.btnCerrarUsuario.IconVisible = true;
            this.btnCerrarUsuario.IconZoom = 90D;
            this.btnCerrarUsuario.IsTab = false;
            this.btnCerrarUsuario.Location = new System.Drawing.Point(957, 0);
            this.btnCerrarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarUsuario.Name = "btnCerrarUsuario";
            this.btnCerrarUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCerrarUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCerrarUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrarUsuario.selected = false;
            this.btnCerrarUsuario.Size = new System.Drawing.Size(76, 74);
            this.btnCerrarUsuario.TabIndex = 2;
            this.btnCerrarUsuario.Text = "bunifuFlatButton1";
            this.btnCerrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarUsuario.Textcolor = System.Drawing.Color.White;
            this.btnCerrarUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarUsuario.Click += new System.EventHandler(this.btnCerrarUsuario_Click);
            // 
            // P_agregarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1033, 539);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModifiarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.TablaAgregarUsuario);
            this.Controls.Add(this.dtFechaAgregar);
            this.Controls.Add(this.lblFechaAgregar);
            this.Controls.Add(this.txtApellidoAgregar);
            this.Controls.Add(this.txtNombreAgregar);
            this.Controls.Add(this.lblApellidoAgregar);
            this.Controls.Add(this.lblNombreAgregar);
            this.Controls.Add(this.panelNuevoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_agregarusuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.P_agregarusuario_Load);
            this.panelNuevoUsuario.ResumeLayout(false);
            this.panelNuevoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAgregarUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNuevoUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreAgregar;
        private System.Windows.Forms.Label lblApellidoAgregar;
        private System.Windows.Forms.TextBox txtNombreAgregar;
        private System.Windows.Forms.TextBox txtApellidoAgregar;
        private System.Windows.Forms.Label lblFechaAgregar;
        private System.Windows.Forms.DateTimePicker dtFechaAgregar;
        private System.Windows.Forms.DataGridView TablaAgregarUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnModifiarUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarUsuario;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrarUsuario;
    }
}