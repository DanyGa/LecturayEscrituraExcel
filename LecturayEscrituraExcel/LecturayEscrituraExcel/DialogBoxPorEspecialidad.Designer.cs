
namespace LecturayEscrituraExcel
{
    partial class DialogBoxPorEspecialidad
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
            this.lbIntro = new System.Windows.Forms.Label();
            this.btnMecanica = new System.Windows.Forms.Button();
            this.btnInformatica = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnElectronica = new System.Windows.Forms.Button();
            this.btnIndustrial = new System.Windows.Forms.Button();
            this.btnEnergias = new System.Windows.Forms.Button();
            this.lvEspecialidad = new System.Windows.Forms.ListView();
            this.cNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMatricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEspecialidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSemestre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbIntro
            // 
            this.lbIntro.AutoSize = true;
            this.lbIntro.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbIntro.Location = new System.Drawing.Point(224, 28);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(260, 21);
            this.lbIntro.TabIndex = 0;
            this.lbIntro.Text = "Selecciona una especialidad:";
            // 
            // btnMecanica
            // 
            this.btnMecanica.BackColor = System.Drawing.Color.Snow;
            this.btnMecanica.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnMecanica.Location = new System.Drawing.Point(284, 76);
            this.btnMecanica.Name = "btnMecanica";
            this.btnMecanica.Size = new System.Drawing.Size(133, 63);
            this.btnMecanica.TabIndex = 1;
            this.btnMecanica.Text = "Mecanica";
            this.btnMecanica.UseVisualStyleBackColor = false;
            // 
            // btnInformatica
            // 
            this.btnInformatica.BackColor = System.Drawing.Color.Snow;
            this.btnInformatica.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnInformatica.Location = new System.Drawing.Point(128, 76);
            this.btnInformatica.Name = "btnInformatica";
            this.btnInformatica.Size = new System.Drawing.Size(133, 63);
            this.btnInformatica.TabIndex = 2;
            this.btnInformatica.Text = "Informatica";
            this.btnInformatica.UseVisualStyleBackColor = false;
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.Color.Snow;
            this.btnGestion.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestion.Location = new System.Drawing.Point(438, 76);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(133, 63);
            this.btnGestion.TabIndex = 3;
            this.btnGestion.Text = "Gestion Empresarial";
            this.btnGestion.UseVisualStyleBackColor = false;
            // 
            // btnElectronica
            // 
            this.btnElectronica.BackColor = System.Drawing.Color.Snow;
            this.btnElectronica.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnElectronica.Location = new System.Drawing.Point(128, 168);
            this.btnElectronica.Name = "btnElectronica";
            this.btnElectronica.Size = new System.Drawing.Size(133, 63);
            this.btnElectronica.TabIndex = 4;
            this.btnElectronica.Text = "Electronica";
            this.btnElectronica.UseVisualStyleBackColor = false;
            // 
            // btnIndustrial
            // 
            this.btnIndustrial.BackColor = System.Drawing.Color.Snow;
            this.btnIndustrial.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnIndustrial.Location = new System.Drawing.Point(284, 168);
            this.btnIndustrial.Name = "btnIndustrial";
            this.btnIndustrial.Size = new System.Drawing.Size(133, 63);
            this.btnIndustrial.TabIndex = 5;
            this.btnIndustrial.Text = "Industrial";
            this.btnIndustrial.UseVisualStyleBackColor = false;
            // 
            // btnEnergias
            // 
            this.btnEnergias.BackColor = System.Drawing.Color.Snow;
            this.btnEnergias.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnEnergias.Location = new System.Drawing.Point(438, 168);
            this.btnEnergias.Name = "btnEnergias";
            this.btnEnergias.Size = new System.Drawing.Size(133, 63);
            this.btnEnergias.TabIndex = 6;
            this.btnEnergias.Text = "Energias Renovables";
            this.btnEnergias.UseVisualStyleBackColor = false;
            // 
            // lvEspecialidad
            // 
            this.lvEspecialidad.BackColor = System.Drawing.Color.Snow;
            this.lvEspecialidad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNumero,
            this.cMatricula,
            this.cNombre,
            this.cEspecialidad,
            this.cSemestre});
            this.lvEspecialidad.Font = new System.Drawing.Font("Century Schoolbook", 7.8F);
            this.lvEspecialidad.HideSelection = false;
            this.lvEspecialidad.Location = new System.Drawing.Point(38, 258);
            this.lvEspecialidad.Name = "lvEspecialidad";
            this.lvEspecialidad.Size = new System.Drawing.Size(635, 387);
            this.lvEspecialidad.TabIndex = 7;
            this.lvEspecialidad.UseCompatibleStateImageBehavior = false;
            this.lvEspecialidad.View = System.Windows.Forms.View.Details;
            // 
            // cNumero
            // 
            this.cNumero.Text = "N";
            this.cNumero.Width = 44;
            // 
            // cMatricula
            // 
            this.cMatricula.Text = "Matricula";
            this.cMatricula.Width = 134;
            // 
            // cNombre
            // 
            this.cNombre.Text = "Nombre";
            this.cNombre.Width = 257;
            // 
            // cEspecialidad
            // 
            this.cEspecialidad.Text = "Especialidad";
            this.cEspecialidad.Width = 109;
            // 
            // cSemestre
            // 
            this.cSemestre.Text = "Semestre";
            this.cSemestre.Width = 86;
            // 
            // DialogBoxPorEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(703, 674);
            this.Controls.Add(this.lvEspecialidad);
            this.Controls.Add(this.btnEnergias);
            this.Controls.Add(this.btnIndustrial);
            this.Controls.Add(this.btnElectronica);
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.btnInformatica);
            this.Controls.Add(this.btnMecanica);
            this.Controls.Add(this.lbIntro);
            this.Name = "DialogBoxPorEspecialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda por Especialidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIntro;
        private System.Windows.Forms.Button btnMecanica;
        private System.Windows.Forms.Button btnInformatica;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnElectronica;
        private System.Windows.Forms.Button btnIndustrial;
        private System.Windows.Forms.Button btnEnergias;
        private System.Windows.Forms.ListView lvEspecialidad;
        private System.Windows.Forms.ColumnHeader cNumero;
        private System.Windows.Forms.ColumnHeader cMatricula;
        private System.Windows.Forms.ColumnHeader cNombre;
        private System.Windows.Forms.ColumnHeader cEspecialidad;
        private System.Windows.Forms.ColumnHeader cSemestre;
    }
}