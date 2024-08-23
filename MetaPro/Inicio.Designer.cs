namespace MetaPro
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnAñadirA = new System.Windows.Forms.Button();
            this.btnObjetivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAmigos = new System.Windows.Forms.DataGridView();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.dgvAgregacion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadirA
            // 
            this.btnAñadirA.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirA.Image")));
            this.btnAñadirA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirA.Location = new System.Drawing.Point(12, 399);
            this.btnAñadirA.Name = "btnAñadirA";
            this.btnAñadirA.Size = new System.Drawing.Size(166, 42);
            this.btnAñadirA.TabIndex = 11;
            this.btnAñadirA.Text = "Encontrar amigos";
            this.btnAñadirA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirA.UseVisualStyleBackColor = true;
            this.btnAñadirA.Click += new System.EventHandler(this.btnAñadirA_Click);
            // 
            // btnObjetivo
            // 
            this.btnObjetivo.Image = ((System.Drawing.Image)(resources.GetObject("btnObjetivo.Image")));
            this.btnObjetivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObjetivo.Location = new System.Drawing.Point(52, 148);
            this.btnObjetivo.Name = "btnObjetivo";
            this.btnObjetivo.Size = new System.Drawing.Size(179, 42);
            this.btnObjetivo.TabIndex = 10;
            this.btnObjetivo.Text = "Ver mis objetivos";
            this.btnObjetivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObjetivo.UseVisualStyleBackColor = true;
            this.btnObjetivo.Click += new System.EventHandler(this.btnObjetivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 65);
            this.label1.TabIndex = 9;
            this.label1.Text = "MetaPro";
            // 
            // dgvAmigos
            // 
            this.dgvAmigos.AllowUserToAddRows = false;
            this.dgvAmigos.AllowUserToDeleteRows = false;
            this.dgvAmigos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmigos.ColumnHeadersVisible = false;
            this.dgvAmigos.Location = new System.Drawing.Point(730, 108);
            this.dgvAmigos.Name = "dgvAmigos";
            this.dgvAmigos.ReadOnly = true;
            this.dgvAmigos.RowHeadersVisible = false;
            this.dgvAmigos.RowHeadersWidth = 51;
            this.dgvAmigos.RowTemplate.Height = 24;
            this.dgvAmigos.Size = new System.Drawing.Size(268, 469);
            this.dgvAmigos.TabIndex = 8;
            this.dgvAmigos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmigos_CellClick);
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.AllowUserToAddRows = false;
            this.dgvAgregar.AllowUserToDeleteRows = false;
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(12, 459);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.ReadOnly = true;
            this.dgvAgregar.RowHeadersVisible = false;
            this.dgvAgregar.RowHeadersWidth = 51;
            this.dgvAgregar.RowTemplate.Height = 24;
            this.dgvAgregar.Size = new System.Drawing.Size(435, 130);
            this.dgvAgregar.TabIndex = 13;
            this.dgvAgregar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregar_CellContentClick);
            this.dgvAgregar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregar_CellDoubleClick);
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(184, 409);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(116, 22);
            this.txtNick.TabIndex = 14;
            // 
            // dgvAgregacion
            // 
            this.dgvAgregacion.AllowUserToAddRows = false;
            this.dgvAgregacion.AllowUserToDeleteRows = false;
            this.dgvAgregacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregacion.Location = new System.Drawing.Point(12, 494);
            this.dgvAgregacion.Name = "dgvAgregacion";
            this.dgvAgregacion.ReadOnly = true;
            this.dgvAgregacion.RowHeadersVisible = false;
            this.dgvAgregacion.RowHeadersWidth = 51;
            this.dgvAgregacion.RowTemplate.Height = 24;
            this.dgvAgregacion.Size = new System.Drawing.Size(399, 62);
            this.dgvAgregacion.TabIndex = 15;
            this.dgvAgregacion.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(900, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Amigos";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(889, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cerrar Sesion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(248)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1042, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.dgvAgregar);
            this.Controls.Add(this.btnAñadirA);
            this.Controls.Add(this.btnObjetivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAmigos);
            this.Controls.Add(this.dgvAgregacion);
            this.Name = "Inicio";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAñadirA;
        private System.Windows.Forms.Button btnObjetivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAmigos;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.DataGridView dgvAgregacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}