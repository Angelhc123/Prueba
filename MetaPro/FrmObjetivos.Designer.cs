namespace MetaPro
{
    partial class FrmObjetivos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjetivos));
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDificultad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpbAñadirOb = new System.Windows.Forms.GroupBox();
            this.txtAvance = new System.Windows.Forms.ComboBox();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.dgvMisObj = new System.Windows.Forms.DataGridView();
            this.lblModTitu = new System.Windows.Forms.Label();
            this.lblEstadoMod = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.chartAvance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtPrueba = new System.Windows.Forms.TextBox();
            this.btnMisObj = new System.Windows.Forms.Button();
            this.btnEliminarObjt = new System.Windows.Forms.Button();
            this.btnModObj = new System.Windows.Forms.Button();
            this.btnAñadirAm = new System.Windows.Forms.Button();
            this.gpbAñadirOb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.ForeColor = System.Drawing.Color.Red;
            this.btnAtras.Location = new System.Drawing.Point(47, 354);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(125, 31);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "<- Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(172, 37);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(163, 22);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(45, 95);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(392, 116);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Avance:";
            // 
            // cmbDificultad
            // 
            this.cmbDificultad.FormattingEnabled = true;
            this.cmbDificultad.Location = new System.Drawing.Point(316, 227);
            this.cmbDificultad.Name = "cmbDificultad";
            this.cmbDificultad.Size = new System.Drawing.Size(121, 24);
            this.cmbDificultad.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dificultad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mis objetivos uwu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 37);
            this.label6.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(45, 282);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 31);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gpbAñadirOb
            // 
            this.gpbAñadirOb.Controls.Add(this.txtAvance);
            this.gpbAñadirOb.Controls.Add(this.btnCancelarMod);
            this.gpbAñadirOb.Controls.Add(this.btnGuardarC);
            this.gpbAñadirOb.Controls.Add(this.lbl);
            this.gpbAñadirOb.Controls.Add(this.label2);
            this.gpbAñadirOb.Controls.Add(this.btnAgregar);
            this.gpbAñadirOb.Controls.Add(this.txtTitulo);
            this.gpbAñadirOb.Controls.Add(this.txtDescripcion);
            this.gpbAñadirOb.Controls.Add(this.label1);
            this.gpbAñadirOb.Controls.Add(this.label4);
            this.gpbAñadirOb.Controls.Add(this.label3);
            this.gpbAñadirOb.Controls.Add(this.cmbDificultad);
            this.gpbAñadirOb.Location = new System.Drawing.Point(305, 119);
            this.gpbAñadirOb.Name = "gpbAñadirOb";
            this.gpbAñadirOb.Size = new System.Drawing.Size(452, 319);
            this.gpbAñadirOb.TabIndex = 18;
            this.gpbAñadirOb.TabStop = false;
            this.gpbAñadirOb.Visible = false;
            // 
            // txtAvance
            // 
            this.txtAvance.FormattingEnabled = true;
            this.txtAvance.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtAvance.Location = new System.Drawing.Point(104, 227);
            this.txtAvance.Name = "txtAvance";
            this.txtAvance.Size = new System.Drawing.Size(109, 24);
            this.txtAvance.TabIndex = 21;
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.Location = new System.Drawing.Point(312, 282);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(125, 31);
            this.btnCancelarMod.TabIndex = 20;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Location = new System.Drawing.Point(176, 282);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(125, 31);
            this.btnGuardarC.TabIndex = 19;
            this.btnGuardarC.Text = "Guardar Cambios";
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(-3, 7);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(201, 16);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "¡Añade tu nuevo objetivo! :D";
            // 
            // dgvMisObj
            // 
            this.dgvMisObj.AllowUserToAddRows = false;
            this.dgvMisObj.AllowUserToDeleteRows = false;
            this.dgvMisObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisObj.Location = new System.Drawing.Point(227, 168);
            this.dgvMisObj.Name = "dgvMisObj";
            this.dgvMisObj.ReadOnly = true;
            this.dgvMisObj.RowHeadersWidth = 51;
            this.dgvMisObj.RowTemplate.Height = 24;
            this.dgvMisObj.Size = new System.Drawing.Size(547, 202);
            this.dgvMisObj.TabIndex = 19;
            this.dgvMisObj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisObj_CellClick);
            this.dgvMisObj.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMisObj_CellFormatting);
            // 
            // lblModTitu
            // 
            this.lblModTitu.AutoSize = true;
            this.lblModTitu.Location = new System.Drawing.Point(831, 109);
            this.lblModTitu.Name = "lblModTitu";
            this.lblModTitu.Size = new System.Drawing.Size(10, 16);
            this.lblModTitu.TabIndex = 20;
            this.lblModTitu.Text = ".";
            // 
            // lblEstadoMod
            // 
            this.lblEstadoMod.AutoSize = true;
            this.lblEstadoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMod.Location = new System.Drawing.Point(801, 121);
            this.lblEstadoMod.Name = "lblEstadoMod";
            this.lblEstadoMod.Size = new System.Drawing.Size(64, 22);
            this.lblEstadoMod.TabIndex = 21;
            this.lblEstadoMod.Text = "label8";
            this.lblEstadoMod.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 65);
            this.label8.TabIndex = 22;
            this.label8.Text = "MetaPro";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(805, 58);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(212, 120);
            this.txtDescrip.TabIndex = 23;
            // 
            // chartAvance
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAvance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAvance.Legends.Add(legend1);
            this.chartAvance.Location = new System.Drawing.Point(805, 214);
            this.chartAvance.Name = "chartAvance";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Progreso";
            this.chartAvance.Series.Add(series1);
            this.chartAvance.Size = new System.Drawing.Size(328, 266);
            this.chartAvance.TabIndex = 24;
            this.chartAvance.Text = "chart1";
            // 
            // txtPrueba
            // 
            this.txtPrueba.Location = new System.Drawing.Point(321, 75);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.Size = new System.Drawing.Size(100, 22);
            this.txtPrueba.TabIndex = 25;
            // 
            // btnMisObj
            // 
            this.btnMisObj.Image = ((System.Drawing.Image)(resources.GetObject("btnMisObj.Image")));
            this.btnMisObj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMisObj.Location = new System.Drawing.Point(47, 119);
            this.btnMisObj.Name = "btnMisObj";
            this.btnMisObj.Size = new System.Drawing.Size(160, 31);
            this.btnMisObj.TabIndex = 16;
            this.btnMisObj.Text = "Mis objetivos";
            this.btnMisObj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisObj.UseVisualStyleBackColor = true;
            this.btnMisObj.Click += new System.EventHandler(this.btnMisObj_Click);
            // 
            // btnEliminarObjt
            // 
            this.btnEliminarObjt.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarObjt.Image")));
            this.btnEliminarObjt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarObjt.Location = new System.Drawing.Point(47, 274);
            this.btnEliminarObjt.Name = "btnEliminarObjt";
            this.btnEliminarObjt.Size = new System.Drawing.Size(160, 31);
            this.btnEliminarObjt.TabIndex = 2;
            this.btnEliminarObjt.Text = "Eliminar Objetivo";
            this.btnEliminarObjt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarObjt.UseVisualStyleBackColor = true;
            this.btnEliminarObjt.Click += new System.EventHandler(this.btnEliminarObjt_Click);
            // 
            // btnModObj
            // 
            this.btnModObj.Image = global::MetaPro.Properties.Resources.page_edit;
            this.btnModObj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModObj.Location = new System.Drawing.Point(47, 222);
            this.btnModObj.Name = "btnModObj";
            this.btnModObj.Size = new System.Drawing.Size(160, 31);
            this.btnModObj.TabIndex = 1;
            this.btnModObj.Text = "Modificar Objetivo";
            this.btnModObj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModObj.UseVisualStyleBackColor = true;
            this.btnModObj.Click += new System.EventHandler(this.btnModObj_Click);
            // 
            // btnAñadirAm
            // 
            this.btnAñadirAm.Image = global::MetaPro.Properties.Resources.page_add;
            this.btnAñadirAm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirAm.Location = new System.Drawing.Point(47, 168);
            this.btnAñadirAm.Name = "btnAñadirAm";
            this.btnAñadirAm.Size = new System.Drawing.Size(160, 31);
            this.btnAñadirAm.TabIndex = 0;
            this.btnAñadirAm.Text = "Añadir objetivo";
            this.btnAñadirAm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirAm.UseVisualStyleBackColor = true;
            this.btnAñadirAm.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1159, 528);
            this.Controls.Add(this.txtPrueba);
            this.Controls.Add(this.chartAvance);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEstadoMod);
            this.Controls.Add(this.lblModTitu);
            this.Controls.Add(this.gpbAñadirOb);
            this.Controls.Add(this.btnMisObj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminarObjt);
            this.Controls.Add(this.btnModObj);
            this.Controls.Add(this.btnAñadirAm);
            this.Controls.Add(this.dgvMisObj);
            this.Name = "FrmObjetivos";
            this.Text = "FrmObjetivos";
            this.Load += new System.EventHandler(this.FrmObjetivos_Load);
            this.gpbAñadirOb.ResumeLayout(false);
            this.gpbAñadirOb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadirAm;
        private System.Windows.Forms.Button btnModObj;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEliminarObjt;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDificultad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMisObj;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gpbAñadirOb;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView dgvMisObj;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Label lblModTitu;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Label lblEstadoMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtAvance;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAvance;
        private System.Windows.Forms.TextBox txtPrueba;
    }
}