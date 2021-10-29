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
    public partial class FormTables : Form
    {
        double[,] Nx;
        double[,] U;
        double[] L;
        int N;
        double[] A1;
        double[] Sig;
        public FormTables()
        {
            InitializeComponent();
            
           // CbstepN.SelectedIndex = 1;
           // CbstepU.SelectedIndex = 1;
            tableU.Columns.Add("", "");
            tableU.Columns.Add("", "");
            tableN.Columns.Add("", "");
            tableN.Columns.Add("", "");
            table6.Columns.Add("", "");
            table6.Columns.Add("", "");
        }


        private void FormTables_Load(object sender, EventArgs e)
        {
            
        }
        public void getMatrix(double[,] nx, double[,] u, double[] l, double[]A, double[]sig, int n)
        {
            Nx = nx;
            U = u;
            L = l;
            N = n;
            A1 = A;
            Sig = sig;
            for (int i = 0; i < n; i++)
            {
                CbstepN.Items.Add(i + 1);
                Cbstep6.Items.Add(i + 1);
            }
            Cbstep6.SelectedIndex = 0;
            CbstepN.SelectedIndex = 0;
            fillTableN(Nx, L, N);
            fillTableU(U, L, N);
            fillTable6(Nx, L, A, sig, N);
        }
        void fillTableN(double[,] Nx, double[] L, int N)
        {
            tableN.Rows.Clear();
            int i = CbstepN.SelectedIndex;
            double split = L[i]/(double)UdN.Value;
            int j = 0;
            for (double x = 0; x < L[i]; x += split)
            {
                tableN.Rows.Add();
                tableN.Rows[j].Cells[0].Value = Auxil.optstr(x.ToString("E2"));
                double val = Nx[i, 0] + Nx[i, 1] * x;
                string temp = Auxil.optstr(val.ToString("E2"));
                tableN.Rows[j].Cells[1].Value = temp;
                j++;
            }
        }
        void fillTableU(double[,] U, double[] L, int N)
        {
            tableU.Rows.Clear();
            double len = 0;
            foreach (var l in L)
            {
                len += l;
            }
            double split = len/(double)UdU.Value;
            int j = 0;
            double lastX=0, x = 0;
            for (int i = 0; i < N; i++)
            {
                for (; x < L[i] + lastX; x += split)
                {
                    tableU.Rows.Add();
                    tableU.Rows[j].Cells[0].Value = Auxil.optstr(x.ToString("E2"));
                    double val = U[i, 0] + U[i, 1] * (x - lastX) + U[i, 2] * (x - lastX) * (x - lastX);
                    string temp = Auxil.optstr(val.ToString("E2"));
                    tableU.Rows[j].Cells[1].Value = temp;
                    j++;
                }
                lastX += L[i];
            }
        }
        void fillTable6(double[,] Nx, double[] L, double[]A, double[]sig, int N)
        {
            table6.Rows.Clear();
            int i = Cbstep6.SelectedIndex;
            double split = L[i] / (double)Ud6.Value;
            int j = 0;
            for (double x = 0; x < L[i]; x += split)
            {
                table6.Rows.Add();
                table6.Rows[j].Cells[0].Value = Auxil.optstr(x.ToString("E2"));
                double val = (Nx[i, 0] + Nx[i, 1] * x)/A[i];
                if (Math.Abs(val) > sig[i])
                    table6.Rows[j].Cells[1].Style.BackColor = Color.Red;
                string temp = Auxil.optstr(val.ToString("E2"));
                table6.Rows[j].Cells[1].Value = temp;
                j++;
            }
        }
        private void CbstepU_SelectedIndexChanged(object sender, EventArgs e)
        {
             fillTableU(U, L, N);
        }

        private void CbstepN_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTableN(Nx, L, N);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fillTableU(U, L, N);
        }

        private void UdN_ValueChanged(object sender, EventArgs e)
        {
            fillTableN(Nx, L, N);
        }

        private void Cbstep6_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTable6(Nx, L, A1, Sig, N);
        }
    }
}
