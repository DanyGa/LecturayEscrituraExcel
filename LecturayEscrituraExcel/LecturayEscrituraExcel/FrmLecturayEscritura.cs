using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xls = Microsoft.Office.Interop.Excel;

namespace LecturayEscrituraExcel
{
    public partial class FrmLecturayEscritura : Form
    {
        public FrmLecturayEscritura()
        {
            InitializeComponent();
        }

        xls.Application a = new xls.Application();
        DialogBoxPorEspecialidad especial = new DialogBoxPorEspecialidad();
        DialogBoxPorSemestre seme = new DialogBoxPorSemestre();
        int i = 4;

        private void FrmLecturayEscritura_Load(object sender, EventArgs e)
        {
            a.Workbooks.Open(Application.StartupPath + @"\Formato.xlsx");
            while (a.ActiveWorkbook.ActiveSheet.Cells(i, 1).Value != null)
            {
                i++;
            }
            i--;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lvCaracteristicas.Items.Clear();
            int x = 4;
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);
                lista.SubItems.Add(matricula);
                lista.SubItems.Add(nombre);
                lista.SubItems.Add(especialidad);
                lista.SubItems.Add(semestre);
                lvCaracteristicas.Items.Add(lista);
                x++;
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string nombre = txtNombre.Text;
            string especialidad = cbEspecialidad.Text;
            string semestre = cbSemestre.Text;
            a.ActiveWorkbook.Worksheets[1].Cells(i, 1).Value = i - 3;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 2).Value = matricula;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 3).Value = nombre;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 4).Value = especialidad;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 5).Value = semestre;
            i++;
            a.ActiveWorkbook.Save();
            MessageBox.Show("Se agregaron los datos al excel", "Lestura y Escritura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvCaracteristicas.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            especial.Show();
        }

        private void btnSemestre_Click(object sender, EventArgs e)
        {
            seme.Show();
        }
    }
}
