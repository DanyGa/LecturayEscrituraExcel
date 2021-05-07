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
    public partial class DialogBoxPorSemestre : Form
    {
        public DialogBoxPorSemestre()
        {
            InitializeComponent();
        }

        xls.Application a = new xls.Application();
        int i = 5;

        private void DialogBoxPorSemestre_Load(object sender, EventArgs e)
        {
            a.Workbooks.Open(Application.StartupPath + @"\Formato.xlsx");
            while (a.ActiveWorkbook.ActiveSheet.Cells(i, 1).Value != null)
            {
                i++;
            }
            i--;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "1";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "2";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "3";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "4";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "5";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "6";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "7";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "8";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "9";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "10";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "11";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
                }

                x++;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            lvSemestre.Items.Clear();
            int x = 5;
            string i = "12";
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                ListViewItem lista = new ListViewItem(num);

                if (semestre == i)
                {
                    lista.SubItems.Add(matricula);
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(especialidad);
                    lista.SubItems.Add(semestre);
                    lvSemestre.Items.Add(lista);
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
