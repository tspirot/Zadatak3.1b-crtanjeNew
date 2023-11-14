namespace Zadatak3._1b
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            colorDialog1 = new ColorDialog();
            groupBox2 = new GroupBox();
            radioButtonCrtanje = new RadioButton();
            radioButtonElipsa = new RadioButton();
            radioButtonPravougaonik = new RadioButton();
            radioButtonLinija = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            checkBoxProvidan = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(130, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 296);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(8, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(116, 59);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Boja";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(33, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 27);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonCrtanje);
            groupBox2.Controls.Add(radioButtonElipsa);
            groupBox2.Controls.Add(radioButtonPravougaonik);
            groupBox2.Controls.Add(radioButtonLinija);
            groupBox2.Location = new Point(8, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(116, 129);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oblik";
            // 
            // radioButtonCrtanje
            // 
            radioButtonCrtanje.AutoSize = true;
            radioButtonCrtanje.Location = new Point(12, 97);
            radioButtonCrtanje.Name = "radioButtonCrtanje";
            radioButtonCrtanje.Size = new Size(63, 19);
            radioButtonCrtanje.TabIndex = 3;
            radioButtonCrtanje.TabStop = true;
            radioButtonCrtanje.Text = "Crtanje";
            radioButtonCrtanje.UseVisualStyleBackColor = true;
            // 
            // radioButtonElipsa
            // 
            radioButtonElipsa.AutoSize = true;
            radioButtonElipsa.Location = new Point(12, 72);
            radioButtonElipsa.Name = "radioButtonElipsa";
            radioButtonElipsa.Size = new Size(55, 19);
            radioButtonElipsa.TabIndex = 2;
            radioButtonElipsa.Text = "Elipsa";
            radioButtonElipsa.UseVisualStyleBackColor = true;
            // 
            // radioButtonPravougaonik
            // 
            radioButtonPravougaonik.AutoSize = true;
            radioButtonPravougaonik.Location = new Point(12, 47);
            radioButtonPravougaonik.Name = "radioButtonPravougaonik";
            radioButtonPravougaonik.Size = new Size(98, 19);
            radioButtonPravougaonik.TabIndex = 1;
            radioButtonPravougaonik.Text = "Pravougaonik";
            radioButtonPravougaonik.UseVisualStyleBackColor = true;
            // 
            // radioButtonLinija
            // 
            radioButtonLinija.AutoSize = true;
            radioButtonLinija.Checked = true;
            radioButtonLinija.Location = new Point(12, 22);
            radioButtonLinija.Name = "radioButtonLinija";
            radioButtonLinija.Size = new Size(53, 19);
            radioButtonLinija.TabIndex = 0;
            radioButtonLinija.TabStop = true;
            radioButtonLinija.Text = "Linija";
            radioButtonLinija.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(20, 231);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(65, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 207);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "Debljina";
            // 
            // checkBoxProvidan
            // 
            checkBoxProvidan.AutoSize = true;
            checkBoxProvidan.Checked = true;
            checkBoxProvidan.CheckState = CheckState.Checked;
            checkBoxProvidan.Location = new Point(28, 267);
            checkBoxProvidan.Name = "checkBoxProvidan";
            checkBoxProvidan.Size = new Size(73, 19);
            checkBoxProvidan.TabIndex = 5;
            checkBoxProvidan.Text = "Providan";
            checkBoxProvidan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 301);
            Controls.Add(checkBoxProvidan);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private ColorDialog colorDialog1;
        private GroupBox groupBox2;
        private RadioButton radioButtonPravougaonik;
        private RadioButton radioButtonLinija;
        private RadioButton radioButtonElipsa;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private RadioButton radioButtonCrtanje;
        private CheckBox checkBoxProvidan;
    }
}