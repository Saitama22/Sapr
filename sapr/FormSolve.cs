using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sapr
{
    public partial class FormSolve : Form
    {
        public FormSolve()
        {
            InitializeComponent();
        }
        public void getMatrix(double[,] A, double[] B, double[] v6, double[,] Nx, double[,] U, int N)
        {
            visualA(A, N);
            visualB(B, N);
            visualC(v6, N);
            visualN(Nx, N - 1);
            visualU(U, N - 1);
        }
        void visualA(double[,] A, int N)
        {
            table.Rows.Clear();
            table.Columns.Clear();
            for (int i = 0; i <= N; i++)
            {
                table.Columns.Add("", "");
                table.Columns[i].Width = 55;
            }
            for (int i = 0; i <= N; i++)
            {
                table.Rows.Add();
                for (int j = 0; j <= N; j++)
                {
                    string temp = Auxil.optstr(A[i, j].ToString("E2"));
                    table.Rows[i].Cells[j].Value = temp;
                }
            }
        }
        void visualB(double[] B, int N)
        {
            tableB.Rows.Clear();
            tableB.Columns.Clear();
            tableB.Columns.Add("", "");
            tableB.Columns[0].Width = 55;
            for (int i = 0; i <= N; i++)
            {
                tableB.Rows.Add("", "");
                string temp = Auxil.optstr(B[i].ToString("E2"));
                tableB.Rows[i].Cells[0].Value = temp;
            }
        }
        void visualC(double[] B, int N)
        {
            table6.Rows.Clear();
            table6.Columns.Clear();
            table6.Columns.Add("", "");
            table6.Columns[0].Width = 55;
            for (int i = 0; i <= N; i++)
            {
                table6.Rows.Add("", "");
                string temp = Auxil.optstr(B[i].ToString("E2"));
                table6.Rows[i].Cells[0].Value = temp;
            }
        }

        void visualN(double[,] Nx, int N)
        {
            tableN.Rows.Clear();
            tableN.Columns.Clear();
            for (int i = 0; i < 4; i++)
            {
                tableN.Columns.Add("", "");
                tableN.Columns[i].Width = 15;
                if (i % 2 == 0)
                    tableN.Columns[i].Width = 55;
            }
            for (int i = 0; i <= N; i++)
            {
                tableN.Rows.Add();

                string temp = Auxil.optstr(Nx[i, 0].ToString("E2"));
                tableN.Rows[i].Cells[0].Value = temp;
                tableN.Rows[i].Cells[1].Value = "+";

                temp = Auxil.optstr(Nx[i, 1].ToString("E2"));
                tableN.Rows[i].Cells[2].Value = temp;
                tableN.Rows[i].Cells[3].Value = "X";
            }
        }
        void visualU(double[,] U, int N)
        {
            tableU.Rows.Clear();
            tableU.Columns.Clear();
            for (int i = 0; i < 6; i++)
            {
                tableU.Columns.Add("", "");
                tableU.Columns[i].Width = 15;
                if (i % 2 == 0)
                    tableU.Columns[i].Width = 55;
                if (i == 5)
                    tableU.Columns[i].Width = 30;
            }
            for (int i = 0; i <= N; i++)
            {
                tableU.Rows.Add();
                string temp = Auxil.optstr(U[i, 0].ToString("E2"));
                tableU.Rows[i].Cells[0].Value = temp;
                tableU.Rows[i].Cells[1].Value = "+";

                temp = Auxil.optstr(U[i, 1].ToString("E2"));
                tableU.Rows[i].Cells[2].Value = temp;
                tableU.Rows[i].Cells[3].Value = "X";

                temp = Auxil.optstr(U[i, 2].ToString("E2"));
                tableU.Rows[i].Cells[4].Value = temp;
                tableU.Rows[i].Cells[5].Value = "X*X";
            }
        }
        private void FormSolve_Load(object sender, EventArgs e)
        {

        }
    }
}
