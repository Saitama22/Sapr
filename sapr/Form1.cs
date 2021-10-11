using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sapr
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();
        Graphics g;
        //  Pen pen;
        int numkers;
        double scale = 1;
        SolidBrush br = new SolidBrush(Color.LightBlue);
        int lastx = -1;
        public Form1()
        {
            InitializeComponent();
            g = PbSyst.CreateGraphics();
            //g = Pbsyst.CreateGraphics();
            //   pen = new Pen(Color.Black);
            numkers = 0;
            CbNumKer.Items.Add(1);
            CbNumKer.SelectedIndex = 0;
            string curDir = Environment.CurrentDirectory;
            Directory.CreateDirectory("projects");
            saveFileDialog1.InitialDirectory = curDir + "\\projects";
            saveFileDialog1.DefaultExt = "dat";
            saveFileDialog1.FileName = "project1";
            openFileDialog1.InitialDirectory = curDir + "\\projects";
            openFileDialog1.DefaultExt = "dat";
            
            flowLayoutPanel1.MouseWheel  += new MouseEventHandler(this.PbWheel);
            //flowLayoutPanel1.HorizontalScroll.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CbNumKer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (CbNumKer.Text)
            int numb = CbNumKer.SelectedIndex;
            if (numb != CbNumKer.Items.Count - 1)
            {
                select(numb);
                //(string, string, string, string, string) data = logic.getdata(numb);
                //TbLen.Text = data.Item1;
                //TbAr.Text = data.Item2;
                //TbEla.Text = data.Item3;
                //TbVolt.Text = data.Item4;
                //TbQ.Text = data.Item5;
            }
        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            if (!Auxil.IsPosnumb(TbLen.Text))
                TbLen.BackColor = Color.Pink;
            if (!Auxil.IsPosnumb(TbAr.Text))
                TbAr.BackColor = Color.Pink;
            if (!Auxil.IsPosnumb(TbEla.Text))
                TbEla.BackColor = Color.Pink;
            if (!Auxil.IsPosnumb(TbVolt.Text))
                TbVolt.BackColor = Color.Pink;

            if (Auxil.IsPosnumb(TbLen.Text) && Auxil.IsPosnumb(TbAr.Text) &&
                Auxil.IsPosnumb(TbEla.Text) && Auxil.IsPosnumb(TbVolt.Text) &&
                Auxil.IsNumb(TbQ.Text))
            {
                double Kerq = 0;
                if (TbQ.Text.Length != 0)
                    Kerq = Double.Parse(TbQ.Text);
                if (logic.max() == 0 && CbNumKer.SelectedIndex >= CbNumKer.Items.Count - 1)
                {
                    CbKnot.Items.Add(1);
                    CbKnot.Items.Add(2);
                    logic.addZeroF();
                    logic.addZeroF();
                }
                else if (CbNumKer.SelectedIndex >= CbNumKer.Items.Count - 1)
                {
                    CbKnot.Items.Add(CbKnot.Items.Count + 1);
                    logic.addZeroF();
                }
                else if (Cbmove.Checked == true)
                {
                    CbKnot.Items.Add(CbKnot.Items.Count + 1);
                    logic.addZeroF();
                    logic.moveF(CbNumKer.SelectedIndex);
                }
                if (CbNumKer.SelectedIndex >= CbNumKer.Items.Count - 1)
                {
                    logic.addKer(new Kernel(
                        ++numkers,
                        Double.Parse(TbLen.Text),
                        Double.Parse(TbAr.Text),
                        Double.Parse(TbEla.Text),
                        Double.Parse(TbVolt.Text),
                        Kerq));
                    CbNumKer.Items.Add((int)CbNumKer.SelectedItem + 1);
                }
                else
                {
                    if (Cbmove.Checked == true)
                    {
                        logic.addKer(new Kernel(
                        ++numkers,
                        Double.Parse(TbLen.Text),
                        Double.Parse(TbAr.Text),
                        Double.Parse(TbEla.Text),
                        Double.Parse(TbVolt.Text),
                        Kerq), CbNumKer.SelectedIndex);
                        CbNumKer.Items.Add(CbNumKer.Items.Count+1);
                    }
                    else
                    logic.setKer(new Kernel(
                            CbNumKer.SelectedIndex,
                            Double.Parse(TbLen.Text),
                            Double.Parse(TbAr.Text),
                            Double.Parse(TbEla.Text),
                            Double.Parse(TbVolt.Text),
                            Kerq),
                        CbNumKer.SelectedIndex);
                }
                draw();
            }
            CbNumKer.SelectedIndex = CbNumKer.Items.Count - 1;
            lbkers.Items.Clear();
            lbkers.Visible = false;
            Cbmove.Checked = false;
        }
        void drawWall(string str, int y, int x = 9)
        {
            if (str == "l")
                Pbleft.CreateGraphics().Clear(Color.White);
            if (!logic.hasEls())
            {
                return;
            }
            int a = Pbleft.Height;
            a = PbSyst.Height;
            Pen pen = new Pen(Color.Black);
            if (str == "l")
                g = Pbleft.CreateGraphics();
            int y1 = y - 25, y2 = y + 25, yplus = 5;
            int isright = 1;
            if (str == "r")
                isright = -1;
            g.DrawLine(pen, x, y1, x, y2);
            while (y1 <= y2)
            {
                g.DrawLine(pen, x, y1, x - 10 * isright, y1 - yplus * isright);
                y1 += yplus;
            }
            if (str == "l")
                g = PbSyst.CreateGraphics();
        }
        void drawQ(int x1, int x2, double q, int y)
        {
            Pen pen = new Pen(Color.Red);
            if (q != 0)
            {
                pen.Color = Color.Red;
                g.DrawLine(pen, x1, y, x2, y);
                q /= Math.Abs(q);
                if (q > 0)
                    x1 += 5;
                while (x1 <= x2)
                {
                    g.DrawLine(pen, x1, y, (int)(x1 - 5 * q), y - 5);
                    g.DrawLine(pen, x1, y, (int)(x1 - 5 * q), y + 5);
                    x1 += 10;
                    if (q < 0 && x2 - x1 < 5)
                        break;
                }
                pen.Color = Color.Black;
            }
        }
        void drawf(int x, int f, int y)
        {
            Pen pen = new Pen(Color.Blue);
            if (f != 0)
            {
                pen.Color = Color.Blue;
                f /= Math.Abs(f);
                g.DrawLine(pen, x, y + 2, x + 8 * f, y + 2);
                g.DrawLine(pen, x, y - 2, x + 8 * f, y - 2);
                g.DrawLine(pen, x + 10 * f, y, x + 5 * f, y + 4);
                g.DrawLine(pen, x + 10 * f, y, x + 5 * f, y - 4);
                pen.Color = Color.Black;
            }
        }
        void drawRect(int med, int prevX, int l, int a)
        {
            Pen pen = new Pen(Color.Black);
            //  SolidBrush sbr = new SolidBrush(Color.LightGray);
            a /= 2;
            l += prevX;
            g.DrawLine(pen, prevX, med + a, prevX, med - a);
            g.DrawLine(pen, l, med + a, l, med - a);
            g.DrawLine(pen, prevX, med + a, l, med + a);
            g.DrawLine(pen, prevX, med - a, l, med - a);
            //g.FillRectangle(sbr, )
        }
        void drawq(int med, int prevX, int l, int q)
        {
            if (q == 0)
                return;
            Pen pen = new Pen(Color.Red);
            l += prevX;
            g.DrawLine(pen, prevX, med, l, med);
            if (l - prevX <= 5)
                return;
            q /= Math.Abs(q);
            while (prevX <= l - 5)
            {
                if (q > 0)
                {
                    g.DrawLine(pen, prevX, med + 5, prevX + 5, med);
                    g.DrawLine(pen, prevX, med - 5, prevX + 5, med);
                }
                else
                {
                    g.DrawLine(pen, prevX, med, prevX + 5, med + 5);
                    g.DrawLine(pen, prevX, med, prevX + 5, med - 5);
                }
                prevX += 5;
            }
        }
        void drawF(int med, int prevX, int l, int a, int f, string str = "")
        {
            if (f == 0)
                return;
            //  if (a < 5 && Math.Abs(l - prevX) < 10)
            //      return;
            Pen pen = new Pen(Color.Blue);
            f /= Math.Abs(f);
            if (prevX == 0 && f < 0)
                prevX = 10;
            if (str == "r" && f > 0)
                prevX -= 10;
            //    if (Math.Abs(l - prevX) < 10)
            //    {
            //         g.DrawLine(pen, prevX, med + 2 * f, l, med);
            //         g.DrawLine(pen, prevX, med - 2 * f, l, med);
            //     }
            //   else
            //  {
            g.DrawLine(pen, prevX, med + 2, prevX + 7 * f, med + 2);
            g.DrawLine(pen, prevX, med - 2, prevX + 7 * f, med - 2);
            g.DrawLine(pen, prevX + 10 * f, med, prevX + 5 * f, med + 5);
            g.DrawLine(pen, prevX + 10 * f, med, prevX + 5 * f, med - 5);
            //   }
        }
        void draw()
        {
            g.Clear(Color.White);
            int med = PbSyst.Height / 2;
            if (logic.left)
                drawWall("l", med);
            else
                Pbleft.CreateGraphics().Clear(Color.White);
            if (logic.hasEls() == false)
                return;
            double prevX = 0;
            Kernel[] kers = logic.getKernels();
            Knot[] knots = logic.GetKnots();
            int i = 0;
            double l = 0, a = 0, q;
            int maxA;
            foreach (var ker in kers)
            {
                l = ker.L * scale;
                a = ker.A * scale;
                q = ker.Q;
                if (l < 1)
                    l = 1;
                if (a < 1)
                    a = 1;
                if (q < 1 && q > 0)
                    q = 1;
                if (q > -1 && q < 0)
                    q = -1;
                drawF(med, (int)prevX, (int)l, (int)a, (int)knots[i++].F);
                drawRect(med, (int)prevX, (int)l, (int)a);
                drawq(med, (int)prevX, (int)l, (int)q);
                prevX += l;
                if (a > PbSyst.Height)
                {
                    PbSyst.Height = (int)(a + 30);
                    Pbleft.Height = (int)(a + 30);
                }
            }
            drawF(med, (int)prevX, (int)l, (int)a, (int)knots[i++].F, "r");
            if (logic.hasEls() == true && logic.right)
                drawWall("r", med, (int)prevX+1);
            if (prevX - 20 > PbSyst.Width)
                PbSyst.Width = (int)(prevX + 20);
            if (prevX + 1000 < PbSyst.Width )
                PbSyst.Width = (int)(prevX + 100);
            g = PbSyst.CreateGraphics();

            //int med = PbSyst.Size.Height / 2;
            //(double, double, double) rect;
            //double Q = 0;
            //double prevX = 0;
            //int nF = 0;
            //double F = 0;
            //int last=0;
            //g.Clear(Color.White);
            //Pbleft.CreateGraphics().Clear(Color.White);
            //if (logic.hasEls())
            //{
            //    if (logic.left == true)
            //        drowWall("l", med);
            //    rect = logic.getFker();
            //    rect.Item1 *= scale;
            //    rect.Item2 *= scale;

            //    if (logic.max() != 0)
            //        drawf((int)prevX, (int)(logic.getKnotDouble(nF++)), med);
            //    while (rect.Item1 > 0)
            //    {
            //        drawQ((int)prevX, (int)(rect.Item1 + prevX), rect.Item3, med);
            //        g.DrawRectangle(pen, (int)prevX, (int)(med - rect.Item2 / 2), (int)(rect.Item1), (int)(rect.Item2));
            //   //     if (PbSyst.Cursor.HotSpot.X > prevX && PbSyst.Cursor.HotSpot.X < prevX + rect.Item1)
            //   //         g.FillRectangle(br, (int)prevX +1 , (int)(med - rect.Item2 / 2) + 1 , (int)(rect.Item1) -1, (int)(rect.Item2) -1);
            //        prevX += rect.Item1;
            //        rect = logic.getNextker();
            //        rect.Item1 *= scale;
            //        rect.Item2 *= scale;
            //        drawf((int)prevX, (int)(logic.getKnotDouble(nF++)), med);
            //        //antiscroll1.Visible = false;
            //        //if (prevX < 500)
            //        //    antiscroll1.Visible = true;
            //        if (rect.Item2 > PbSyst.Height)
            //            PbSyst.Height = (int)(rect.Item2 + 20);
            //        if (rect.Item1 != -1)
            //            last = (int)rect.Item1;
            //    }

            //    if (prevX + 10 + last > PbSyst.Width)
            //        PbSyst.Width = (int)(prevX + rect.Item1 + 50);

            //    g = PbSyst.CreateGraphics();
            //    if (logic.right == true)
            //        drowWall("r", med, (int)(prevX) + 1);
            //}
        }
        private void ButDel_Click(object sender, EventArgs e)
        {
            if (logic.max() == 1)
            {
                CbKnot.Items.Clear();
                logic.rmf(1);
                logic.rmf(0);
            }
            else
            {
                CbKnot.Items.Remove(CbKnot.Items.Count);
                logic.rmf(CbNumKer.SelectedIndex);
            }

            if (CbNumKer.Items.Count != 1)
            {
                if (CbNumKer.SelectedIndex != CbNumKer.Items.Count - 1)
                    logic.rm(CbNumKer.SelectedIndex);
                else if (CbNumKer.SelectedIndex == CbNumKer.Items.Count - 1)
                {
                    logic.rm(CbNumKer.SelectedIndex - 1);
                    CbNumKer.SelectedIndex = CbNumKer.SelectedIndex - 1;
                }
                CbNumKer.Items.RemoveAt(CbNumKer.Items.Count - 1);
                draw();
            }
            
            lbkers.Items.Clear();
            lbkers.Visible = false;
            Cbmove.Checked = false;
        }

        private void TbLen_TextChanged(object sender, EventArgs e)
        {
            if (!Auxil.IsPosnumb(TbLen.Text))
                TbLen.BackColor = Color.Pink;
            else if (TbLen.BackColor != Color.White)
                TbLen.BackColor = Color.White;

        }

        private void TbAr_TextChanged(object sender, EventArgs e)
        {
            if (!Auxil.IsPosnumb(TbAr.Text))
                TbAr.BackColor = Color.Pink;
            else if (TbAr.BackColor != Color.White)
                TbAr.BackColor = Color.White;
        }

        private void TbEla_TextChanged(object sender, EventArgs e)
        {
            if (!Auxil.IsPosnumb(TbEla.Text))
                TbEla.BackColor = Color.Pink;
            else if (TbEla.BackColor != Color.White)
                TbEla.BackColor = Color.White;
        }

        private void TbVolt_TextChanged(object sender, EventArgs e)
        {
            if (!Auxil.IsPosnumb(TbVolt.Text))
                TbVolt.BackColor = Color.Pink;
            else if (TbVolt.BackColor != Color.White)
                TbVolt.BackColor = Color.White;
        }

        private void TbQ_TextChanged(object sender, EventArgs e)
        {
            if (!Auxil.IsNumb(TbQ.Text))
                TbQ.BackColor = Color.Pink;
            else if (TbQ.BackColor != Color.White)
                TbQ.BackColor = Color.White;
        }

        private void checkRight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRight.Checked)
                logic.right = true;
            else
                logic.right = false;
            draw();
        }

        private void checkLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLeft.Checked)
                logic.left = true;
            else
                logic.left = false;
            draw();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel || logic.max() < 1)
            {
                MessageBox.Show("Файл HE сохранен");
                return;
            }
            string filename = saveFileDialog1.FileName;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, logic);
            }
            MessageBox.Show("Файл сохранен");
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                logic = (Logic)formatter.Deserialize(fs);
            }
            draw();
            CbNumKer.Items.Clear();
            for (int i = 1; i < logic.max(); i++)
            {
                CbNumKer.Items.Add(i);
            }
            CbNumKer.SelectedIndex = CbNumKer.Items.Count - 1;
        }
        private void CbNumKer_TextUpdate(object sender, EventArgs e)
        {
            CbNumKer.SelectedIndex = CbNumKer.Items.Count - 1;
        }

        private void TbF_TextChanged(object sender, EventArgs e)
        {
            if (!Auxil.IsNumb(TbF.Text))
                TbF.BackColor = Color.Pink;
            else if (TbF.BackColor != Color.White)
                TbF.BackColor = Color.White;
        }

        private void ButAddF_Click(object sender, EventArgs e)
        {
            int temp = CbKnot.SelectedIndex;
            if (CbKnot.SelectedIndex != -1 && Auxil.IsNumb(TbF.Text))
            {
                logic.setf(CbKnot.SelectedIndex, Double.Parse(TbF.Text));
                draw();
            }
        }

        private void ButRmF_Click(object sender, EventArgs e)
        {
            if (CbKnot.SelectedIndex != -1)
            {
                logic.rmf(CbKnot.SelectedIndex);
                draw();
            }
        }

        private void CbKnot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbKnot.SelectedIndex != -1)
            {
                TbF.Text = logic.getKnot(CbKnot.SelectedIndex);
            }

        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            draw();
        }

        private void PbWheel(object sender, MouseEventArgs e)
        {
            draw();
        }

        private void PbSyst_Click(object sender, EventArgs e)
        {
            if (lastx != -1)
            {
                select(lastx);
                //CbNumKer.SelectedIndex = lastx;
                //(string, string, string, string, string) data = logic.getdata(lastx);
                //TbLen.Text = data.Item1;
                //TbAr.Text = data.Item2;
                //TbEla.Text = data.Item3;
                //TbVolt.Text = data.Item4;
                //TbQ.Text = data.Item5;
            }
        }
        void select(int number)
        {
            if (number < logic.max())
            {
                CbNumKer.SelectedIndex = number;
                (string, string, string, string, string) data = logic.getdata(number);
                TbLen.Text = data.Item1;
                TbAr.Text = data.Item2;
                TbEla.Text = data.Item3;
                TbVolt.Text = data.Item4;
                TbQ.Text = data.Item5;
            }
        }
        private void scalepl_Click(object sender, EventArgs e)
        {
            scale *= 2;
            draw();
        }

        private void scalemin_Click(object sender, EventArgs e)
        {
            scale /= 2;
            draw();
        }


        private void PbSyst_MouseMove(object sender, MouseEventArgs e)
        {
            Kernel[] kers = logic.getKernels();
            int CurX = Cursor.Position.X - this.Location.X - flowLayoutPanel1.Location.X - Pbleft.Width - PbSyst.Location.X + 2;
            double kerX = 0;
            int numb = 0;
            foreach (var ker in kers)
            {
                if ((numb == logic.max()-1) && ((kerX + ker.L) * scale < CurX) && lastx != -1)
                {
                    draw();
                    lastx = -1;
                }
                else if (kerX * scale < CurX && (kerX + ker.L) * scale > CurX)
                {
                    if (numb != lastx)
                    {
                        draw();
                        SolidBrush solid = new SolidBrush(Color.LightBlue);
                        g.FillRectangle(solid, (int)(kerX * scale + 1), (int)(PbSyst.Height / 2 - ker.A * scale / 2 + 2), (int)(ker.L * scale - 1), (int)(ker.A * scale - 2));
                        lastx = numb;
                        break;
                    }

                }
                numb++;

                kerX += ker.L ;
            }
        }

        private void PbSyst_MouseLeave(object sender, EventArgs e)
        {
            draw();
            lastx = -1;
        }

        private void ButShowAll_Click(object sender, EventArgs e)
        {
            lbkers.Items.Clear();
            if (logic.max() > 0)
                lbkers.Visible = true;
            Kernel[] kers = logic.getKernels();
            int i = 0;
            foreach (var kernel in kers)
            {
                string dataK = (i+1).ToString() + ") ";
                dataK += "L = " + kernel.L.ToString() + "M; ";
                dataK += "A = " + kernel.A.ToString() + "M^2; ";
                dataK += "E = " + kernel.E.ToString() + "MПa; ";
                dataK += "σ = " + kernel.V.ToString() + "MПa; ";
                dataK += "q = " + kernel.Q.ToString() + "H/M ";
                lbkers.Items.Add(dataK);
                i++;
            }
        }

        private void lbkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbkers.SelectedIndex >= 0)
            {
                select(lbkers.SelectedIndex);
            }
        }

        private void Cbmove_CheckedChanged(object sender, EventArgs e)
        {
            if (logic.max() == 0 || CbNumKer.SelectedIndex == logic.max())
                Cbmove.Checked = false;
            
        }

        private void but_opengraf_Click(object sender, EventArgs e)
        {
            //Application.Run(new FormGraf());
            FormGraf formGraf = new FormGraf();
            formGraf.Show();
        }
    }
}
