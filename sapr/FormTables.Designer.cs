
namespace sapr
{
    partial class FormTables
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbstepU = new System.Windows.Forms.ComboBox();
            this.tableN = new System.Windows.Forms.DataGridView();
            this.tableU = new System.Windows.Forms.DataGridView();
            this.CbstepN = new System.Windows.Forms.ComboBox();
            this.UdU = new System.Windows.Forms.NumericUpDown();
            this.UdN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tableN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(402, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "U";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // CbstepU
            // 
            this.CbstepU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbstepU.FormattingEnabled = true;
            this.CbstepU.Items.AddRange(new object[] {
            "Шаг:",
            "Шагов:"});
            this.CbstepU.Location = new System.Drawing.Point(452, 15);
            this.CbstepU.Name = "CbstepU";
            this.CbstepU.Size = new System.Drawing.Size(69, 21);
            this.CbstepU.TabIndex = 7;
            this.CbstepU.SelectedIndexChanged += new System.EventHandler(this.CbstepU_SelectedIndexChanged);
            // 
            // tableN
            // 
            this.tableN.AllowUserToAddRows = false;
            this.tableN.AllowUserToDeleteRows = false;
            this.tableN.AllowUserToOrderColumns = true;
            this.tableN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableN.ColumnHeadersVisible = false;
            this.tableN.Location = new System.Drawing.Point(60, 38);
            this.tableN.Name = "tableN";
            this.tableN.ReadOnly = true;
            this.tableN.RowHeadersVisible = false;
            this.tableN.ShowEditingIcon = false;
            this.tableN.Size = new System.Drawing.Size(211, 508);
            this.tableN.TabIndex = 42;
            // 
            // tableU
            // 
            this.tableU.AllowUserToAddRows = false;
            this.tableU.AllowUserToDeleteRows = false;
            this.tableU.AllowUserToOrderColumns = true;
            this.tableU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableU.ColumnHeadersVisible = false;
            this.tableU.Location = new System.Drawing.Point(408, 38);
            this.tableU.Name = "tableU";
            this.tableU.ReadOnly = true;
            this.tableU.RowHeadersVisible = false;
            this.tableU.ShowEditingIcon = false;
            this.tableU.Size = new System.Drawing.Size(196, 508);
            this.tableU.TabIndex = 43;
            // 
            // CbstepN
            // 
            this.CbstepN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbstepN.FormattingEnabled = true;
            this.CbstepN.Items.AddRange(new object[] {
            "Шаг:",
            "Шагов:"});
            this.CbstepN.Location = new System.Drawing.Point(122, 11);
            this.CbstepN.Name = "CbstepN";
            this.CbstepN.Size = new System.Drawing.Size(69, 21);
            this.CbstepN.TabIndex = 44;
            this.CbstepN.SelectedIndexChanged += new System.EventHandler(this.CbstepN_SelectedIndexChanged);
            // 
            // UdU
            // 
            this.UdU.Location = new System.Drawing.Point(541, 16);
            this.UdU.Name = "UdU";
            this.UdU.Size = new System.Drawing.Size(63, 20);
            this.UdU.TabIndex = 45;
            this.UdU.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UdU.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // UdN
            // 
            this.UdN.Location = new System.Drawing.Point(208, 12);
            this.UdN.Name = "UdN";
            this.UdN.Size = new System.Drawing.Size(63, 20);
            this.UdN.TabIndex = 46;
            this.UdN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UdN.ValueChanged += new System.EventHandler(this.UdN_ValueChanged);
            // 
            // FormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 622);
            this.Controls.Add(this.UdN);
            this.Controls.Add(this.UdU);
            this.Controls.Add(this.CbstepN);
            this.Controls.Add(this.tableU);
            this.Controls.Add(this.tableN);
            this.Controls.Add(this.CbstepU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTables";
            this.Text = "FormTables";
            this.Load += new System.EventHandler(this.FormTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbstepU;
        private System.Windows.Forms.DataGridView tableN;
        private System.Windows.Forms.DataGridView tableU;
        private System.Windows.Forms.ComboBox CbstepN;
        private System.Windows.Forms.NumericUpDown UdU;
        private System.Windows.Forms.NumericUpDown UdN;
    }
}