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
        public FormTables()
        {
            InitializeComponent();
            
           // CbstepN.SelectedIndex = 1;
           // CbstepU.SelectedIndex = 1;
            tableU.Columns.Add("", "");
            tableU.Columns.Add("", "");
            tableN.Columns.Add("", "");
            tableN.Columns.Add("", "");
        }


        private void FormTables_Load(object sender, EventArgs e)
        {
            
        }
        public void getMatrix(double[,] nx, double[,] u, double[] l, int n)
        {
            Nx = nx;
            U = u;
            L = l;
            N = n;
            fillTableN(Nx, L, N);
            fillTableU(U, L, N);
        }
        void fillTableN(double[,] Nx, double[] L, int N)
        {
            tableN.Rows.Clear();
            double len = 0;
            foreach (var l in L)
            {
                len += l;
            }
            double split = (double)UdN.Value;
            if (CbstepN.SelectedIndex == 1 || CbstepN.SelectedIndex == -1)
                split = len / split;     
            double lastX = 0, x = 0;
            int j = 0;
            for (int i = 0; i < N; i++)
            {
                for (x = x; x < L[i] + lastX; x += split)
                {
                    tableN.Rows.Add();
                    tableN.Rows[j].Cells[0].Value = x.ToString() + ";";
                    double val = Nx[i, 0] + Nx[i, 1] * (x - lastX);
                    string temp = Auxil.optstr(val.ToString("E2"));
                    tableN.Rows[j].Cells[1].Value = temp;
                    j++;
                }
                lastX += L[i];
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
            double split = (double)UdU.Value;
            if (CbstepU.SelectedIndex == 1 || CbstepU.SelectedIndex == -1)
                split = len / split;
            int j = 0;
            double lastX=0, x = 0;
            for (int i = 0; i < N; i++)
            {
                for (x=x; x < L[i] + lastX; x += split)
                {
                    tableU.Rows.Add();
                    tableU.Rows[j].Cells[0].Value = x.ToString() + ";";
                    double val = U[i, 0] + U[i, 1] * (x - lastX) + U[i, 2] * (x - lastX) * (x - lastX);
                    string temp = Auxil.optstr(val.ToString("E2"));
                    tableU.Rows[j].Cells[1].Value = temp;
                    j++;
                }
                lastX += L[i];
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
    }
}
