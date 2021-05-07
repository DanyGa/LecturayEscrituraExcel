
namespace LecturayEscrituraExcel
{
    partial class FrmLecturayEscritura
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
            this.lMatricula = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lEspecialidad = new System.Windows.Forms.Label();
            this.lSemestre = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.btnSemestre = new System.Windows.Forms.Button();
            this.lvCaracteristicas = new System.Windows.Forms.ListView();
            this.cNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMatricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEspecialidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSemestre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatricula.ForeColor = System.Drawing.Color.Snow;
            this.lMatricula.Location = new System.Drawing.Point(25, 35);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(101, 21);
            this.lMatricula.TabIndex = 0;
            this.lMatricula.Text = "Matricula:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.Snow;
            this.lNombre.Location = new System.Drawing.Point(25, 95);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(85, 21);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre:";
            // 
            // lEspecialidad
            // 
            this.lEspecialidad.AutoSize = true;
            this.lEspecialidad.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEspecialidad.ForeColor = System.Drawing.Color.Snow;
            this.lEspecialidad.Location = new System.Drawing.Point(25, 149);
            this.lEspecialidad.Name = "lEspecialidad";
            this.lEspecialidad.Size = new System.Drawing.Size(126, 21);
            this.lEspecialidad.TabIndex = 2;
            this.lEspecialidad.Text = "Especialidad:";
            // 
            // lSemestre
            // 
            this.lSemestre.AutoSize = true;
            this.lSemestre.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSemestre.ForeColor = System.Drawing.Color.Snow;
            this.lSemestre.Location = new System.Drawing.Point(25, 209);
            this.lSemestre.Name = "lSemestre";
            this.lSemestre.Size = new System.Drawing.Size(97, 21);
            this.lSemestre.TabIndex = 3;
            this.lSemestre.Text = "Semestre:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.Snow;
            this.txtMatricula.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.Color.Black;
            this.txtMatricula.Location = new System.Drawing.Point(197, 34);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(258, 26);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Snow;
            this.txtNombre.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(197, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(258, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.BackColor = System.Drawing.Color.Snow;
            this.cbEspecialidad.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Informatica",
            "Electronica",
            "Mecánica",
            "Industrial",
            "Gestion Empresarial",
            "Energias Renovables"});
            this.cbEspecialidad.Location = new System.Drawing.Point(197, 148);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(258, 26);
            this.cbEspecialidad.TabIndex = 6;
            // 
            // cbSemestre
            // 
            this.cbSemestre.BackColor = System.Drawing.Color.Snow;
            this.cbSemestre.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbSemestre.Location = new System.Drawing.Point(197, 208);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(258, 26);
            this.cbSemestre.TabIndex = 7;
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.Snow;
            this.btnLeer.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnLeer.Location = new System.Drawing.Point(29, 301);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(152, 82);
            this.btnLeer.TabIndex = 8;
            this.btnLeer.Text = "Leer Archivo";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.Color.Snow;
            this.btnEscribir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEscribir.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribir.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnEscribir.Location = new System.Drawing.Point(187, 301);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(152, 82);
            this.btnEscribir.TabIndex = 9;
            this.btnEscribir.Text = "Escribir Archivo";
            this.btnEscribir.UseVisualStyleBackColor = false;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Snow;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnLimpiar.Location = new System.Drawing.Point(345, 301);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 82);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Snow;
            this.btnSalir.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnSalir.Location = new System.Drawing.Point(503, 301);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 82);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.BackColor = System.Drawing.Color.Snow;
            this.btnEspecialidad.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialidad.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnEspecialidad.Location = new System.Drawing.Point(661, 301);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(152, 82);
            this.btnEspecialidad.TabIndex = 12;
            this.btnEspecialidad.Text = "Buscar por especialidad";
            this.btnEspecialidad.UseVisualStyleBackColor = false;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // btnSemestre
            // 
            this.btnSemestre.BackColor = System.Drawing.Color.Snow;
            this.btnSemestre.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemestre.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnSemestre.Location = new System.Drawing.Point(819, 301);
            this.btnSemestre.Name = "btnSemestre";
            this.btnSemestre.Size = new System.Drawing.Size(152, 82);
            this.btnSemestre.TabIndex = 13;
            this.btnSemestre.Text = "Buscar por Semestre";
            this.btnSemestre.UseVisualStyleBackColor = false;
            this.btnSemestre.Click += new System.EventHandler(this.btnSemestre_Click);
            // 
            // lvCaracteristicas
            // 
            this.lvCaracteristicas.BackColor = System.Drawing.Color.Snow;
            this.lvCaracteristicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNumero,
            this.cMatricula,
            this.cNombre,
            this.cEspecialidad,
            this.cSemestre});
            this.lvCaracteristicas.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCaracteristicas.HideSelection = false;
            this.lvCaracteristicas.Location = new System.Drawing.Point(509, 23);
            this.lvCaracteristicas.Name = "lvCaracteristicas";
            this.lvCaracteristicas.Size = new System.Drawing.Size(803, 248);
            this.lvCaracteristicas.TabIndex = 14;
            this.lvCaracteristicas.UseCompatibleStateImageBehavior = false;
            this.lvCaracteristicas.View = System.Windows.Forms.View.Details;
            // 
            // cNumero
            // 
            this.cNumero.Text = "N";
            this.cNumero.Width = 43;
            // 
            // cMatricula
            // 
            this.cMatricula.Text = "Matricula";
            this.cMatricula.Width = 138;
            // 
            // cNombre
            // 
            this.cNombre.Text = "Nombre";
            this.cNombre.Width = 268;
            // 
            // cEspecialidad
            // 
            this.cEspecialidad.Text = "Especialidad";
            this.cEspecialidad.Width = 101;
            // 
            // cSemestre
            // 
            this.cSemestre.Text = "Semestre";
            this.cSemestre.Width = 91;
            // 
            // FrmLecturayEscritura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1343, 427);
            this.ControlBox = false;
            this.Controls.Add(this.lvCaracteristicas);
            this.Controls.Add(this.btnSemestre);
            this.Controls.Add(this.btnEspecialidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.cbSemestre);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lSemestre);
            this.Controls.Add(this.lEspecialidad);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lMatricula);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLecturayEscritura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Archivos con Excel";
            this.Load += new System.EventHandler(this.FrmLecturayEscritura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lEspecialidad;
        private System.Windows.Forms.Label lSemestre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Button btnSemestre;
        private System.Windows.Forms.ListView lvCaracteristicas;
        private System.Windows.Forms.ColumnHeader cNumero;
        private System.Windows.Forms.ColumnHeader cMatricula;
        private System.Windows.Forms.ColumnHeader cNombre;
        private System.Windows.Forms.ColumnHeader cEspecialidad;
        private System.Windows.Forms.ColumnHeader cSemestre;
    }
}

