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
        public void getMatrix(double[,] Nx, double[,] U, double[] L, int N)
        {
            drawGrafN(Nx, L, N);
            drawGrafU(U, L, N);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

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

        private void butSaveAll_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
