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
    public partial class DialogBoxPorEspecialidad : Form
    {
        public DialogBoxPorEspecialidad()
        {
            InitializeComponent();
        }

        xls.Application a = new xls.Application();
        int i = 4;

        private void DialogBoxPorEspecialidad_Load(object sender, EventArgs e)
        {
            a.Workbooks.Open(Application.StartupPath + @"\Formato.xlsx");
            while (a.ActiveWorkbook.ActiveSheet.Cells(i, 1).Value != null)
            {
                i++;
            }
            i--;
        }

        private void btnInformatica_Click(object sender, EventArgs e)
        {
            lvEspecialidad.Items.Clear();
            int x = 4;
            string i = "Informatica";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (especialidad == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvEspecialidad.Items.Add(lista);
                }

                x++;
            }
        }

        private void btnMecanica_Click(object sender, EventArgs e)
        {
            lvEspecialidad.Items.Clear();
            int x = 4;
            string m = "Mecánica";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (especialidad == m)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvEspecialidad.Items.Add(lista);
                }

                x++;
            }
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            lvEspecialidad.Items.Clear();
            int x = 4;
            string g = "Gestion Empresarial";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (especialidad == g)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvEspecialidad.Items.Add(lista);
                }

                x++;
            }
        }

        private void btnElectronica_Click(object sender, EventArgs e)
        {
            lvEspecialidad.Items.Clear();
            int x = 4;
            string ele = "Electronica";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (especialidad == ele)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvEspecialidad.Items.Add(lista);
                }

                x++;
            }
        }

        private void btnIndustrial_Click(object sender, EventArgs e)
        {
            lvEspecialidad.Items.Clear();
            int x = 4;
            string i = "Industrial";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (especialidad == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvEspecialidad.Items.Add(lista);
                }

                x++;
            }
        }

        private void btnEnergias_Click(object sender, EventArgs e)
        {
            lvEspecialidad.Items.Clear();
            int x = 4;
            string en = "Energias Renovables";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (especialidad == en)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvEspecialidad.Items.Add(lista);
                }

                x++;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
