namespace MetaPro
{
    partial class FrmPerfilAmigocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilAmigocs));
            this.txtPrueba = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEstadoMod = new System.Windows.Forms.Label();
            this.lblModTitu = new System.Windows.Forms.Label();
            this.btnComentar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvMisObj2 = new System.Windows.Forms.DataGridView();
            this.gpbComentario = new System.Windows.Forms.GroupBox();
            this.btnGuardarComentario = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIdObjetivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObj2)).BeginInit();
            this.gpbComentario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrueba
            // 
            this.txtPrueba.Location = new System.Drawing.Point(302, 94);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.Size = new System.Drawing.Size(100, 22);
            this.txtPrueba.TabIndex = 40;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(786, 140);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(240, 202);
            this.txtDescrip.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 65);
            this.label8.TabIndex = 37;
            this.label8.Text = "MetaPro";
            // 
            // lblEstadoMod
            // 
            this.lblEstadoMod.AutoSize = true;
            this.lblEstadoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMod.Location = new System.Drawing.Point(782, 106);
            this.lblEstadoMod.Name = "lblEstadoMod";
            this.lblEstadoMod.Size = new System.Drawing.Size(64, 22);
            this.lblEstadoMod.TabIndex = 36;
            this.lblEstadoMod.Text = "label8";
            this.lblEstadoMod.Visible = false;
            // 
            // lblModTitu
            // 
            this.lblModTitu.AutoSize = true;
            this.lblModTitu.Location = new System.Drawing.Point(812, 128);
            this.lblModTitu.Name = "lblModTitu";
            this.lblModTitu.Size = new System.Drawing.Size(10, 16);
            this.lblModTitu.TabIndex = 35;
            this.lblModTitu.Text = ".";
            // 
            // btnComentar
            // 
            this.btnComentar.Image = ((System.Drawing.Image)(resources.GetObject("btnComentar.Image")));
            this.btnComentar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComentar.Location = new System.Drawing.Point(28, 138);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(160, 31);
            this.btnComentar.TabIndex = 32;
            this.btnComentar.Text = "Comentar";
            this.btnComentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComentar.UseVisualStyleBackColor = true;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 37);
            this.label6.TabIndex = 31;
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Font = new System.Drawing.Font("MV Boli", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNick.Location = new System.Drawing.Point(481, 53);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(274, 37);
            this.lblNick.TabIndex = 30;
            this.lblNick.Text = "Mis objetivos uwu";
            // 
            // btnAtras
            // 
            this.btnAtras.ForeColor = System.Drawing.Color.Red;
            this.btnAtras.Location = new System.Drawing.Point(28, 511);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(125, 31);
            this.btnAtras.TabIndex = 29;
            this.btnAtras.Text = "<- Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvMisObj2
            // 
            this.dgvMisObj2.AllowUserToAddRows = false;
            this.dgvMisObj2.AllowUserToDeleteRows = false;
            this.dgvMisObj2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisObj2.Location = new System.Drawing.Point(208, 140);
            this.dgvMisObj2.Name = "dgvMisObj2";
            this.dgvMisObj2.ReadOnly = true;
            this.dgvMisObj2.RowHeadersWidth = 51;
            this.dgvMisObj2.RowTemplate.Height = 24;
            this.dgvMisObj2.Size = new System.Drawing.Size(547, 151);
            this.dgvMisObj2.TabIndex = 34;
            this.dgvMisObj2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisObj2_CellClick);
            // 
            // gpbComentario
            // 
            this.gpbComentario.Controls.Add(this.btnCancelar);
            this.gpbComentario.Controls.Add(this.txtContenido);
            this.gpbComentario.Controls.Add(this.btnGuardarComentario);
            this.gpbComentario.Enabled = false;
            this.gpbComentario.Location = new System.Drawing.Point(217, 321);
            this.gpbComentario.Name = "gpbComentario";
            this.gpbComentario.Size = new System.Drawing.Size(538, 221);
            this.gpbComentario.TabIndex = 41;
            this.gpbComentario.TabStop = false;
            this.gpbComentario.Text = "Comentario";
            this.gpbComentario.Visible = false;
            // 
            // btnGuardarComentario
            // 
            this.btnGuardarComentario.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarComentario.Image")));
            this.btnGuardarComentario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarComentario.Location = new System.Drawing.Point(25, 174);
            this.btnGuardarComentario.Name = "btnGuardarComentario";
            this.btnGuardarComentario.Size = new System.Drawing.Size(160, 31);
            this.btnGuardarComentario.TabIndex = 42;
            this.btnGuardarComentario.Text = "GuardarComentario";
            this.btnGuardarComentario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComentario.UseVisualStyleBackColor = true;
            this.btnGuardarComentario.Click += new System.EventHandler(this.btnGuardarComentario_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(6, 35);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(526, 121);
            this.txtContenido.TabIndex = 42;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(339, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 31);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblIdObjetivo
            // 
            this.lblIdObjetivo.AutoSize = true;
            this.lblIdObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdObjetivo.Location = new System.Drawing.Point(811, 504);
            this.lblIdObjetivo.Name = "lblIdObjetivo";
            this.lblIdObjetivo.Size = new System.Drawing.Size(0, 22);
            this.lblIdObjetivo.TabIndex = 42;
            // 
            // FrmPerfilAmigocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(248)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1057, 554);
            this.Controls.Add(this.lblIdObjetivo);
            this.Controls.Add(this.gpbComentario);
            this.Controls.Add(this.txtPrueba);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEstadoMod);
            this.Controls.Add(this.lblModTitu);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvMisObj2);
            this.Name = "FrmPerfilAmigocs";
            this.Text = "FrmPerfilAmigocs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObj2)).EndInit();
            this.gpbComentario.ResumeLayout(false);
            this.gpbComentario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrueba;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEstadoMod;
        private System.Windows.Forms.Label lblModTitu;
        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgvMisObj2;
        private System.Windows.Forms.GroupBox gpbComentario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Button btnGuardarComentario;
        private System.Windows.Forms.Label lblIdObjetivo;
    }
}