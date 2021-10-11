
namespace sapr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TbLen = new System.Windows.Forms.TextBox();
            this.TbAr = new System.Windows.Forms.TextBox();
            this.TbEla = new System.Windows.Forms.TextBox();
            this.TbVolt = new System.Windows.Forms.TextBox();
            this.ButAdd = new System.Windows.Forms.Button();
            this.ButDel = new System.Windows.Forms.Button();
            this.CbNumKer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkLeft = new System.Windows.Forms.CheckBox();
            this.checkRight = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CbKnot = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TbF = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ButAddF = new System.Windows.Forms.Button();
            this.ButRmF = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Pbleft = new System.Windows.Forms.PictureBox();
            this.PbSyst = new System.Windows.Forms.PictureBox();
            this.antiscroll1 = new System.Windows.Forms.PictureBox();
            this.scalepl = new System.Windows.Forms.Button();
            this.scalemin = new System.Windows.Forms.Button();
            this.lbkers = new System.Windows.Forms.ListBox();
            this.ButShowAll = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Cbmove = new System.Windows.Forms.CheckBox();
            this.but_opengraf = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSyst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiscroll1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbLen
            // 
            this.TbLen.Location = new System.Drawing.Point(114, 47);
            this.TbLen.Name = "TbLen";
            this.TbLen.Size = new System.Drawing.Size(74, 20);
            this.TbLen.TabIndex = 0;
            this.TbLen.Text = "100";
            this.TbLen.TextChanged += new System.EventHandler(this.TbLen_TextChanged);
            // 
            // TbAr
            // 
            this.TbAr.Location = new System.Drawing.Point(216, 47);
            this.TbAr.Name = "TbAr";
            this.TbAr.Size = new System.Drawing.Size(66, 20);
            this.TbAr.TabIndex = 1;
            this.TbAr.Text = "100";
            this.TbAr.TextChanged += new System.EventHandler(this.TbAr_TextChanged);
            // 
            // TbEla
            // 
            this.TbEla.BackColor = System.Drawing.SystemColors.Window;
            this.TbEla.Location = new System.Drawing.Point(320, 47);
            this.TbEla.Name = "TbEla";
            this.TbEla.Size = new System.Drawing.Size(69, 20);
            this.TbEla.TabIndex = 2;
            this.TbEla.Text = "10";
            this.TbEla.TextChanged += new System.EventHandler(this.TbEla_TextChanged);
            // 
            // TbVolt
            // 
            this.TbVolt.Location = new System.Drawing.Point(436, 47);
            this.TbVolt.Name = "TbVolt";
            this.TbVolt.Size = new System.Drawing.Size(49, 20);
            this.TbVolt.TabIndex = 3;
            this.TbVolt.Text = "10";
            this.TbVolt.TextChanged += new System.EventHandler(this.TbVolt_TextChanged);
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(622, 31);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(87, 37);
            this.ButAdd.TabIndex = 4;
            this.ButAdd.Text = "Добавить (Изменить)";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // ButDel
            // 
            this.ButDel.Location = new System.Drawing.Point(715, 31);
            this.ButDel.Name = "ButDel";
            this.ButDel.Size = new System.Drawing.Size(85, 37);
            this.ButDel.TabIndex = 5;
            this.ButDel.Text = "Удалить";
            this.ButDel.UseVisualStyleBackColor = true;
            this.ButDel.Click += new System.EventHandler(this.ButDel_Click);
            // 
            // CbNumKer
            // 
            this.CbNumKer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbNumKer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNumKer.FormattingEnabled = true;
            this.CbNumKer.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CbNumKer.Location = new System.Drawing.Point(13, 47);
            this.CbNumKer.Name = "CbNumKer";
            this.CbNumKer.Size = new System.Drawing.Size(84, 21);
            this.CbNumKer.TabIndex = 6;
            this.CbNumKer.SelectedIndexChanged += new System.EventHandler(this.CbNumKer_SelectedIndexChanged);
            this.CbNumKer.TextUpdate += new System.EventHandler(this.CbNumKer_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер стержня";
            // 
            // checkLeft
            // 
            this.checkLeft.AutoSize = true;
            this.checkLeft.Location = new System.Drawing.Point(13, 117);
            this.checkLeft.Name = "checkLeft";
            this.checkLeft.Size = new System.Drawing.Size(96, 17);
            this.checkLeft.TabIndex = 9;
            this.checkLeft.Text = "Левая стенка";
            this.checkLeft.UseVisualStyleBackColor = true;
            this.checkLeft.CheckedChanged += new System.EventHandler(this.checkLeft_CheckedChanged);
            // 
            // checkRight
            // 
            this.checkRight.AutoSize = true;
            this.checkRight.Location = new System.Drawing.Point(114, 117);
            this.checkRight.Name = "checkRight";
            this.checkRight.Size = new System.Drawing.Size(102, 17);
            this.checkRight.TabIndex = 10;
            this.checkRight.Text = "Правая стенка";
            this.checkRight.UseVisualStyleBackColor = true;
            this.checkRight.CheckedChanged += new System.EventHandler(this.checkRight_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "L, Длина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "S, Площадь п. с.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "E, Модуль упругости";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "σ Доп. напряж.";
            // 
            // TbQ
            // 
            this.TbQ.Location = new System.Drawing.Point(537, 47);
            this.TbQ.Name = "TbQ";
            this.TbQ.Size = new System.Drawing.Size(42, 20);
            this.TbQ.TabIndex = 15;
            this.TbQ.Text = "0";
            this.TbQ.TextChanged += new System.EventHandler(this.TbQ_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "q, Нагрузка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(188, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "M";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(389, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "МПа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(485, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "МПа";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(579, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "H/м";
            // 
            // CbKnot
            // 
            this.CbKnot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbKnot.FormattingEnabled = true;
            this.CbKnot.Location = new System.Drawing.Point(13, 90);
            this.CbKnot.Name = "CbKnot";
            this.CbKnot.Size = new System.Drawing.Size(84, 21);
            this.CbKnot.TabIndex = 22;
            this.CbKnot.SelectedIndexChanged += new System.EventHandler(this.CbKnot_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Номер узла";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "F, Нагрузка";
            // 
            // TbF
            // 
            this.TbF.Location = new System.Drawing.Point(114, 90);
            this.TbF.Name = "TbF";
            this.TbF.Size = new System.Drawing.Size(74, 20);
            this.TbF.TabIndex = 25;
            this.TbF.Text = "1";
            this.TbF.TextChanged += new System.EventHandler(this.TbF_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(189, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "H";
            // 
            // ButAddF
            // 
            this.ButAddF.Location = new System.Drawing.Point(213, 74);
            this.ButAddF.Name = "ButAddF";
            this.ButAddF.Size = new System.Drawing.Size(88, 37);
            this.ButAddF.TabIndex = 27;
            this.ButAddF.Text = "Добавить (Изменить)";
            this.ButAddF.UseVisualStyleBackColor = true;
            this.ButAddF.Click += new System.EventHandler(this.ButAddF_Click);
            // 
            // ButRmF
            // 
            this.ButRmF.Location = new System.Drawing.Point(320, 74);
            this.ButRmF.Name = "ButRmF";
            this.ButRmF.Size = new System.Drawing.Size(106, 37);
            this.ButRmF.TabIndex = 28;
            this.ButRmF.Text = "Удалить";
            this.ButRmF.UseVisualStyleBackColor = true;
            this.ButRmF.Click += new System.EventHandler(this.ButRmF_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.OpenToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.Pbleft);
            this.flowLayoutPanel1.Controls.Add(this.PbSyst);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 140);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(683, 318);
            this.flowLayoutPanel1.TabIndex = 30;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            // 
            // Pbleft
            // 
            this.Pbleft.Location = new System.Drawing.Point(0, 3);
            this.Pbleft.Margin = new System.Windows.Forms.Padding(0);
            this.Pbleft.Name = "Pbleft";
            this.Pbleft.Size = new System.Drawing.Size(10, 299);
            this.Pbleft.TabIndex = 33;
            this.Pbleft.TabStop = false;
            // 
            // PbSyst
            // 
            this.PbSyst.Location = new System.Drawing.Point(10, 0);
            this.PbSyst.Margin = new System.Windows.Forms.Padding(0);
            this.PbSyst.Name = "PbSyst";
            this.PbSyst.Size = new System.Drawing.Size(684, 302);
            this.PbSyst.TabIndex = 0;
            this.PbSyst.TabStop = false;
            this.PbSyst.Click += new System.EventHandler(this.PbSyst_Click);
            this.PbSyst.MouseLeave += new System.EventHandler(this.PbSyst_MouseLeave);
            this.PbSyst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbSyst_MouseMove);
            // 
            // antiscroll1
            // 
            this.antiscroll1.Location = new System.Drawing.Point(26, 461);
            this.antiscroll1.Name = "antiscroll1";
            this.antiscroll1.Size = new System.Drawing.Size(346, 16);
            this.antiscroll1.TabIndex = 31;
            this.antiscroll1.TabStop = false;
            // 
            // scalepl
            // 
            this.scalepl.Location = new System.Drawing.Point(6, 140);
            this.scalepl.Name = "scalepl";
            this.scalepl.Size = new System.Drawing.Size(25, 26);
            this.scalepl.TabIndex = 32;
            this.scalepl.Text = "+";
            this.scalepl.UseVisualStyleBackColor = true;
            this.scalepl.Click += new System.EventHandler(this.scalepl_Click);
            // 
            // scalemin
            // 
            this.scalemin.Location = new System.Drawing.Point(6, 164);
            this.scalemin.Name = "scalemin";
            this.scalemin.Size = new System.Drawing.Size(25, 26);
            this.scalemin.TabIndex = 33;
            this.scalemin.Text = "-";
            this.scalemin.UseVisualStyleBackColor = true;
            this.scalemin.Click += new System.EventHandler(this.scalemin_Click);
            // 
            // lbkers
            // 
            this.lbkers.FormattingEnabled = true;
            this.lbkers.Location = new System.Drawing.Point(715, 183);
            this.lbkers.Name = "lbkers";
            this.lbkers.Size = new System.Drawing.Size(382, 251);
            this.lbkers.TabIndex = 34;
            this.lbkers.Visible = false;
            this.lbkers.SelectedIndexChanged += new System.EventHandler(this.lbkers_SelectedIndexChanged);
            // 
            // ButShowAll
            // 
            this.ButShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButShowAll.Location = new System.Drawing.Point(715, 143);
            this.ButShowAll.Name = "ButShowAll";
            this.ButShowAll.Size = new System.Drawing.Size(41, 34);
            this.ButShowAll.TabIndex = 35;
            this.ButShowAll.Text = "...";
            this.ButShowAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButShowAll.UseVisualStyleBackColor = true;
            this.ButShowAll.Click += new System.EventHandler(this.ButShowAll_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(295, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 12);
            this.label15.TabIndex = 36;
            this.label15.Text = "2";
            // 
            // Cbmove
            // 
            this.Cbmove.AutoSize = true;
            this.Cbmove.Location = new System.Drawing.Point(114, 12);
            this.Cbmove.Name = "Cbmove";
            this.Cbmove.Size = new System.Drawing.Size(114, 17);
            this.Cbmove.TabIndex = 37;
            this.Cbmove.Text = "Сдвинуть констр.";
            this.Cbmove.UseVisualStyleBackColor = true;
            this.Cbmove.CheckedChanged += new System.EventHandler(this.Cbmove_CheckedChanged);
            // 
            // but_opengraf
            // 
            this.but_opengraf.Location = new System.Drawing.Point(26, 562);
            this.but_opengraf.Name = "but_opengraf";
            this.but_opengraf.Size = new System.Drawing.Size(89, 48);
            this.but_opengraf.TabIndex = 38;
            this.but_opengraf.Text = "открыть график";
            this.but_opengraf.UseVisualStyleBackColor = true;
            this.but_opengraf.Click += new System.EventHandler(this.but_opengraf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 609);
            this.Controls.Add(this.but_opengraf);
            this.Controls.Add(this.Cbmove);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ButShowAll);
            this.Controls.Add(this.lbkers);
            this.Controls.Add(this.scalemin);
            this.Controls.Add(this.scalepl);
            this.Controls.Add(this.antiscroll1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ButRmF);
            this.Controls.Add(this.ButAddF);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TbF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CbKnot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkRight);
            this.Controls.Add(this.checkLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbNumKer);
            this.Controls.Add(this.ButDel);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.TbVolt);
            this.Controls.Add(this.TbEla);
            this.Controls.Add(this.TbAr);
            this.Controls.Add(this.TbLen);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "САПР";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSyst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiscroll1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbLen;
        private System.Windows.Forms.TextBox TbAr;
        private System.Windows.Forms.TextBox TbEla;
        private System.Windows.Forms.TextBox TbVolt;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Button ButDel;
        private System.Windows.Forms.ComboBox CbNumKer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkLeft;
        private System.Windows.Forms.CheckBox checkRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbKnot;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TbF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ButAddF;
        private System.Windows.Forms.Button ButRmF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox PbSyst;
        private System.Windows.Forms.PictureBox antiscroll1;
        private System.Windows.Forms.PictureBox Pbleft;
        private System.Windows.Forms.Button scalepl;
        private System.Windows.Forms.Button scalemin;
        private System.Windows.Forms.ListBox lbkers;
        private System.Windows.Forms.Button ButShowAll;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox Cbmove;
        private System.Windows.Forms.Button but_opengraf;
    }
}

