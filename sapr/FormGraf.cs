using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sapr
{
    public partial class FormGraf : Form
    {

        Chart ChartN = new Chart();
        Chart ChartU = new Chart();
        Chart Chart6 = new Chart();
        double[,] Nx;
        double[,] U;
        double[] L;
        int N;
        double[] A;

        private void FormGraf_Load(object sender, EventArgs e)
        {

        }
        public FormGraf()
        {
            InitializeComponent();
            string curDir = Environment.CurrentDirectory;
            System.IO.Directory.CreateDirectory("projects");
            saveFileDialog1.InitialDirectory = curDir + "\\Images";
            
        }
        public void getMatrix(double[,] nx, double[,] u, double[] l, double[] a, int n)
        {

            Nx = nx;
            U = u;
            L = l;
            N = n;
            A = a;
            drawGrafN(Nx, L, N);
            drawGrafU(U, L, N);
            drawGraf6(Nx, L, A, N);
            //drawLineN(10);
            //drawLineN(6);
        }

        void drawGrafN(double[,] Nx, double[] L, int N)
        {
            ChartN.Parent = PbgrafN;
            ChartN.Dock = DockStyle.Fill;
            ChartN.ChartAreas.Add(new ChartArea("funcN"));
            Series mySeriesOfPoint = new Series("N");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.BorderWidth = 2;
            double lastX = 0;
            mySeriesOfPoint.Points.AddXY(-1e-20, 0);
            for (int i = 0; i < N; i++)
            {
                mySeriesOfPoint.Points.AddXY(lastX, Nx[i, 0]);
                mySeriesOfPoint.Points.AddXY(L[i]+lastX, Nx[i, 0] + Nx[i, 1] * (L[i]));
                lastX += L[i];
            }
            ChartN.Series.Add(mySeriesOfPoint);
        }
        //void drawLineN(int x)
        //{
        //    ChartN.Series.Remove(ChartN.Series.FindByName("Nc"));
        //    Series mySeriesOfPoint = new Series("Nc");
        //    mySeriesOfPoint.ChartType = SeriesChartType.Line;
        //    mySeriesOfPoint.BorderWidth = 2;            
        //    mySeriesOfPoint.Points.AddXY(x, 10);
        //    mySeriesOfPoint.Points.AddXY(x, 0);
        //    ChartN.Series.Add(mySeriesOfPoint);
        //}
        void drawGrafU(double[,] U, double[] L, int N)
        {
            ChartU.Parent = PbgrafU;
            ChartU.Dock = DockStyle.Fill;
            ChartU.ChartAreas.Add(new ChartArea("funcU"));
            Series mySeriesOfPoint = new Series("U");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.BorderWidth = 2;
            mySeriesOfPoint.Points.AddXY(-1e-20, 0);
            double lastX = 0;
            for (int i = 0; i < N; i++)
            {
                for (double x = lastX; x <= L[i] + lastX+0.01; x += 0.01)
                {
                    mySeriesOfPoint.Points.AddXY(x, U[i, 0] + U[i, 1] * (x - lastX) + U[i, 2] * (x - lastX) * (x - lastX));
                }
                lastX += L[i];
            }
            ChartU.Series.Add(mySeriesOfPoint);
        }
        void drawGraf6(double[,] Nx, double[] L, double[]A, int N)
        {
            Chart6.Parent = Pbgraf6;
            Chart6.Dock = DockStyle.Fill;
            Chart6.ChartAreas.Add(new ChartArea("funcN"));
            Series mySeriesOfPoint = new Series("N");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.BorderWidth = 2;
            double lastX = 0;
            mySeriesOfPoint.Points.AddXY(-1e-20, 0);
            for (int i = 0; i < N; i++)
            {
                mySeriesOfPoint.Points.AddXY(lastX, (Nx[i, 0])/A[i]);
                mySeriesOfPoint.Points.AddXY(L[i] + lastX, (Nx[i, 0] + Nx[i, 1] * (L[i]))/A[i]);
                lastX += L[i];
            }
            Chart6.Series.Add(mySeriesOfPoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Файл HE сохранен");
                return;
            }
            ChartN.SaveImage(saveFileDialog1.FileName + ".png", ImageFormat.Png);
            MessageBox.Show("Файл сохранен");
        }

        private void PbgrafN_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = PbgrafN.CreateGraphics();
            Pen p = new Pen(Color.Red);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Файл HE сохранен");
                return;
            }
            ChartU.SaveImage(saveFileDialog1.FileName + ".png", ImageFormat.Png);
            MessageBox.Show("Файл сохранен");
        }

        private void butSave6_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Файл HE сохранен");
                return;
            }
            Chart6.SaveImage(saveFileDialog1.FileName + ".png", ImageFormat.Png);
            MessageBox.Show("Файл сохранен");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void findxy()
        {
            if (!Auxil.IsNumb(TbfindX.Text) || TbfindX.Text.Length == 0)
                return;
            double len = Double.Parse(TbfindX.Text);
            if (len < 0)
                return;
            double lastX = 0;
            int i;
            for (i = 0; i < N; i++)
            {
                lastX += L[i];
                if (lastX >= len)
                {
                    len = len - (lastX - L[i]);
                    break;
                }
            }
            if (lastX < len)
                return;
            double temp=0;
            if (CbXY.SelectedIndex==0)
                temp = Nx[i, 0] + Nx[i, 1] * len;
            else if (CbXY.SelectedIndex == 2)
                temp = (Nx[i, 0] + Nx[i, 1] * len)/A[i];
            else if (CbXY.SelectedIndex == 1)
                temp = (U[i, 0] + U[i, 1] * len + U[i, 2]* len * len);

            Tby.Text = Auxil.optstr(temp.ToString("E2"));
        }
        private void TbfindX_TextChanged(object sender, EventArgs e)
        {
            findxy();
        }

        private void CbXY_SelectedIndexChanged(object sender, EventArgs e)
        {
            findxy();
        }
    }
}
