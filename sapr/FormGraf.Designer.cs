
namespace sapr
{
    partial class FormGraf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PbgrafN = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butSaveN = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.PbgrafU = new System.Windows.Forms.PictureBox();
            this.butSaveU = new System.Windows.Forms.Button();
            this.butSaveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbgrafN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbgrafU)).BeginInit();
            this.SuspendLayout();
            // 
            // PbgrafN
            // 
            this.PbgrafN.Location = new System.Drawing.Point(12, 67);
            this.PbgrafN.Name = "PbgrafN";
            this.PbgrafN.Size = new System.Drawing.Size(802, 301);
            this.PbgrafN.TabIndex = 0;
            this.PbgrafN.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "График N";
            // 
            // butSaveN
            // 
            this.butSaveN.Location = new System.Drawing.Point(149, 10);
            this.butSaveN.Name = "butSaveN";
            this.butSaveN.Size = new System.Drawing.Size(69, 34);
            this.butSaveN.TabIndex = 2;
            this.butSaveN.Text = "Сохранить";
            this.butSaveN.UseVisualStyleBackColor = true;
            this.butSaveN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "График U";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PbgrafU
            // 
            this.PbgrafU.Location = new System.Drawing.Point(12, 414);
            this.PbgrafU.Name = "PbgrafU";
            this.PbgrafU.Size = new System.Drawing.Size(802, 314);
            this.PbgrafU.TabIndex = 5;
            this.PbgrafU.TabStop = false;
            // 
            // butSaveU
            // 
            this.butSaveU.Location = new System.Drawing.Point(149, 375);
            this.butSaveU.Name = "butSaveU";
            this.butSaveU.Size = new System.Drawing.Size(69, 34);
            this.butSaveU.TabIndex = 8;
            this.butSaveU.Text = "Сохранить";
            this.butSaveU.UseVisualStyleBackColor = true;
            this.butSaveU.Click += new System.EventHandler(this.button2_Click);
            // 
            // butSaveAll
            // 
            this.butSaveAll.Location = new System.Drawing.Point(235, 10);
            this.butSaveAll.Name = "butSaveAll";
            this.butSaveAll.Size = new System.Drawing.Size(69, 37);
            this.butSaveAll.TabIndex = 9;
            this.butSaveAll.Text = "Сохранить все";
            this.butSaveAll.UseVisualStyleBackColor = true;
            this.butSaveAll.Click += new System.EventHandler(this.butSaveAll_Click);
            // 
            // FormGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 750);
            this.Controls.Add(this.butSaveAll);
            this.Controls.Add(this.butSaveU);
            this.Controls.Add(this.PbgrafN);
            this.Controls.Add(this.PbgrafU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butSaveN);
            this.Controls.Add(this.label1);
            this.Name = "FormGraf";
            this.Text = "FormGraf";
            this.Load += new System.EventHandler(this.FormGraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbgrafN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbgrafU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbgrafN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSaveN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PbgrafU;
        private System.Windows.Forms.Button butSaveU;
        private System.Windows.Forms.Button butSaveAll;
    }
}