namespace Taller2
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNota1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonMostrarID = new System.Windows.Forms.Button();
            this.buttonProm = new System.Windows.Forms.Button();
            this.textBoxNotaLista = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNota3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNota4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNota5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(132, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(288, 24);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "TALLER 2 - 16 DE SEPTIEMBRE";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(63, 84);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(63, 118);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Location = new System.Drawing.Point(63, 153);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(39, 13);
            this.labelNota1.TabIndex = 3;
            this.labelNota1.Text = "Nota 1";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(136, 81);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(136, 118);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(136, 153);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota1.TabIndex = 6;
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(41, 414);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(472, 126);
            this.dgvListado.TabIndex = 7;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(81, 365);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 8;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonMostrarID
            // 
            this.buttonMostrarID.Location = new System.Drawing.Point(191, 365);
            this.buttonMostrarID.Name = "buttonMostrarID";
            this.buttonMostrarID.Size = new System.Drawing.Size(106, 23);
            this.buttonMostrarID.TabIndex = 9;
            this.buttonMostrarID.Text = "Mostrar por ID";
            this.buttonMostrarID.UseVisualStyleBackColor = true;
            this.buttonMostrarID.Click += new System.EventHandler(this.buttonMostrarID_Click);
            // 
            // buttonProm
            // 
            this.buttonProm.Location = new System.Drawing.Point(12, 54);
            this.buttonProm.Name = "buttonProm";
            this.buttonProm.Size = new System.Drawing.Size(150, 23);
            this.buttonProm.TabIndex = 10;
            this.buttonProm.Text = "Listar mejores promedios";
            this.buttonProm.UseVisualStyleBackColor = true;
            this.buttonProm.Click += new System.EventHandler(this.buttonProm_Click);
            // 
            // textBoxNotaLista
            // 
            this.textBoxNotaLista.Location = new System.Drawing.Point(16, 21);
            this.textBoxNotaLista.Name = "textBoxNotaLista";
            this.textBoxNotaLista.Size = new System.Drawing.Size(100, 20);
            this.textBoxNotaLista.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNotaLista);
            this.groupBox1.Controls.Add(this.buttonProm);
            this.groupBox1.Location = new System.Drawing.Point(268, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 93);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar estudiantes con notas superiores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Mostrar ordenado por notas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(136, 190);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nota 2";
            // 
            // textBoxNota3
            // 
            this.textBoxNota3.Location = new System.Drawing.Point(136, 235);
            this.textBoxNota3.Name = "textBoxNota3";
            this.textBoxNota3.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nota 3";
            // 
            // textBoxNota4
            // 
            this.textBoxNota4.Location = new System.Drawing.Point(136, 274);
            this.textBoxNota4.Name = "textBoxNota4";
            this.textBoxNota4.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota4.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nota 4";
            // 
            // textBoxNota5
            // 
            this.textBoxNota5.Location = new System.Drawing.Point(136, 314);
            this.textBoxNota5.Name = "textBoxNota5";
            this.textBoxNota5.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota5.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nota 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 591);
            this.Controls.Add(this.textBoxNota5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNota4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNota3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMostrarID);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelNota1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonMostrarID;
        private System.Windows.Forms.Button buttonProm;
        private System.Windows.Forms.TextBox textBoxNotaLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNota3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNota4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNota5;
        private System.Windows.Forms.Label label4;
    }
}

