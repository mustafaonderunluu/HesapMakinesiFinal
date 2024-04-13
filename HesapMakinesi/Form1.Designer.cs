namespace HesapMakinesi
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
            Tuslar = new TableLayoutPanel();
            buttonesit = new Button();
            button_CE = new Button();
            buttonClear = new Button();
            button_AC = new Button();
            buttontopla = new Button();
            buttonondalık = new Button();
            button0 = new Button();
            buttonNP = new Button();
            buttoneksi = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonCarp = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonbol = new Button();
            button_9 = new Button();
            button_8 = new Button();
            button7 = new Button();
            ekran = new TableLayoutPanel();
            islemler = new Label();
            labelsayı = new Label();
            soltaraf = new TableLayoutPanel();
            anaekran = new TableLayoutPanel();
            listboxgecmis = new ListBox();
            Tuslar.SuspendLayout();
            ekran.SuspendLayout();
            soltaraf.SuspendLayout();
            anaekran.SuspendLayout();
            SuspendLayout();
            // 
            // Tuslar
            // 
            Tuslar.ColumnCount = 4;
            Tuslar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Tuslar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Tuslar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Tuslar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Tuslar.Controls.Add(buttonesit, 3, 4);
            Tuslar.Controls.Add(button_CE, 2, 4);
            Tuslar.Controls.Add(buttonClear, 1, 4);
            Tuslar.Controls.Add(button_AC, 0, 4);
            Tuslar.Controls.Add(buttontopla, 3, 3);
            Tuslar.Controls.Add(buttonondalık, 2, 3);
            Tuslar.Controls.Add(button0, 1, 3);
            Tuslar.Controls.Add(buttonNP, 0, 3);
            Tuslar.Controls.Add(buttoneksi, 3, 2);
            Tuslar.Controls.Add(button3, 2, 2);
            Tuslar.Controls.Add(button2, 1, 2);
            Tuslar.Controls.Add(button1, 0, 2);
            Tuslar.Controls.Add(buttonCarp, 3, 1);
            Tuslar.Controls.Add(button6, 2, 1);
            Tuslar.Controls.Add(button5, 1, 1);
            Tuslar.Controls.Add(button4, 0, 1);
            Tuslar.Controls.Add(buttonbol, 3, 0);
            Tuslar.Controls.Add(button_9, 2, 0);
            Tuslar.Controls.Add(button_8, 1, 0);
            Tuslar.Controls.Add(button7, 0, 0);
            Tuslar.Dock = DockStyle.Fill;
            Tuslar.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Tuslar.Location = new Point(3, 143);
            Tuslar.Name = "Tuslar";
            Tuslar.RowCount = 5;
            Tuslar.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Tuslar.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Tuslar.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Tuslar.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Tuslar.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Tuslar.Size = new Size(375, 321);
            Tuslar.TabIndex = 0;
            // 
            // buttonesit
            // 
            buttonesit.BackColor = Color.WhiteSmoke;
            buttonesit.Dock = DockStyle.Fill;
            buttonesit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonesit.Location = new Point(282, 259);
            buttonesit.Name = "buttonesit";
            buttonesit.Size = new Size(90, 59);
            buttonesit.TabIndex = 19;
            buttonesit.Text = "=";
            buttonesit.UseVisualStyleBackColor = false;
            buttonesit.Click += buttonesit_Click;
            // 
            // button_CE
            // 
            button_CE.BackColor = Color.Silver;
            button_CE.Dock = DockStyle.Fill;
            button_CE.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_CE.ForeColor = SystemColors.ButtonHighlight;
            button_CE.Location = new Point(189, 259);
            button_CE.Name = "button_CE";
            button_CE.Size = new Size(87, 59);
            button_CE.TabIndex = 18;
            button_CE.Text = "CE";
            button_CE.UseVisualStyleBackColor = false;
            button_CE.Click += button_CE_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Gray;
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonClear.ForeColor = SystemColors.ButtonFace;
            buttonClear.Location = new Point(96, 259);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(87, 59);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // button_AC
            // 
            button_AC.BackColor = SystemColors.ControlDarkDark;
            button_AC.Dock = DockStyle.Fill;
            button_AC.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_AC.ForeColor = SystemColors.ButtonHighlight;
            button_AC.Location = new Point(3, 259);
            button_AC.Name = "button_AC";
            button_AC.Size = new Size(87, 59);
            button_AC.TabIndex = 16;
            button_AC.Text = "AC";
            button_AC.UseVisualStyleBackColor = false;
            button_AC.Click += button_AC_Click;
            // 
            // buttontopla
            // 
            buttontopla.BackColor = Color.WhiteSmoke;
            buttontopla.Dock = DockStyle.Fill;
            buttontopla.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttontopla.Location = new Point(282, 195);
            buttontopla.Name = "buttontopla";
            buttontopla.Size = new Size(90, 58);
            buttontopla.TabIndex = 15;
            buttontopla.Text = "+";
            buttontopla.UseVisualStyleBackColor = false;
            buttontopla.Click += islemler_Click;
            // 
            // buttonondalık
            // 
            buttonondalık.Dock = DockStyle.Fill;
            buttonondalık.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonondalık.Location = new Point(189, 195);
            buttonondalık.Name = "buttonondalık";
            buttonondalık.Size = new Size(87, 58);
            buttonondalık.TabIndex = 14;
            buttonondalık.Text = ",";
            buttonondalık.UseVisualStyleBackColor = true;
            buttonondalık.Click += Sayilar_Click;
            // 
            // button0
            // 
            button0.Dock = DockStyle.Fill;
            button0.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button0.Location = new Point(96, 195);
            button0.Name = "button0";
            button0.Size = new Size(87, 58);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += Sayilar_Click;
            // 
            // buttonNP
            // 
            buttonNP.Dock = DockStyle.Fill;
            buttonNP.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonNP.Location = new Point(3, 195);
            buttonNP.Name = "buttonNP";
            buttonNP.Size = new Size(87, 58);
            buttonNP.TabIndex = 12;
            buttonNP.Text = "-/+";
            buttonNP.UseVisualStyleBackColor = true;
            buttonNP.Click += Sayilar_Click;
            // 
            // buttoneksi
            // 
            buttoneksi.BackColor = Color.WhiteSmoke;
            buttoneksi.Dock = DockStyle.Fill;
            buttoneksi.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttoneksi.Location = new Point(282, 131);
            buttoneksi.Name = "buttoneksi";
            buttoneksi.Size = new Size(90, 58);
            buttoneksi.TabIndex = 11;
            buttoneksi.Text = "-";
            buttoneksi.UseVisualStyleBackColor = false;
            buttoneksi.Click += islemler_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(189, 131);
            button3.Name = "button3";
            button3.Size = new Size(87, 58);
            button3.TabIndex = 10;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Sayilar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(96, 131);
            button2.Name = "button2";
            button2.Size = new Size(87, 58);
            button2.TabIndex = 9;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Sayilar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(3, 131);
            button1.Name = "button1";
            button1.Size = new Size(87, 58);
            button1.TabIndex = 8;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Sayilar_Click;
            // 
            // buttonCarp
            // 
            buttonCarp.BackColor = Color.WhiteSmoke;
            buttonCarp.Dock = DockStyle.Fill;
            buttonCarp.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonCarp.Location = new Point(282, 67);
            buttonCarp.Name = "buttonCarp";
            buttonCarp.Size = new Size(90, 58);
            buttonCarp.TabIndex = 7;
            buttonCarp.Text = "x";
            buttonCarp.UseVisualStyleBackColor = false;
            buttonCarp.Click += islemler_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(189, 67);
            button6.Name = "button6";
            button6.Size = new Size(87, 58);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Sayilar_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(96, 67);
            button5.Name = "button5";
            button5.Size = new Size(87, 58);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Sayilar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(3, 67);
            button4.Name = "button4";
            button4.Size = new Size(87, 58);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Sayilar_Click;
            // 
            // buttonbol
            // 
            buttonbol.BackColor = Color.WhiteSmoke;
            buttonbol.Dock = DockStyle.Fill;
            buttonbol.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonbol.Location = new Point(282, 3);
            buttonbol.Name = "buttonbol";
            buttonbol.Size = new Size(90, 58);
            buttonbol.TabIndex = 3;
            buttonbol.Text = "/";
            buttonbol.UseVisualStyleBackColor = false;
            buttonbol.Click += islemler_Click;
            // 
            // button_9
            // 
            button_9.BackColor = Color.Transparent;
            button_9.Dock = DockStyle.Fill;
            button_9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_9.Location = new Point(189, 3);
            button_9.Name = "button_9";
            button_9.Size = new Size(87, 58);
            button_9.TabIndex = 2;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = false;
            button_9.Click += Sayilar_Click;
            // 
            // button_8
            // 
            button_8.BackColor = Color.Transparent;
            button_8.Dock = DockStyle.Fill;
            button_8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_8.Location = new Point(96, 3);
            button_8.Name = "button_8";
            button_8.Size = new Size(87, 58);
            button_8.TabIndex = 1;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = false;
            button_8.Click += Sayilar_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(87, 58);
            button7.TabIndex = 0;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Sayilar_Click;
            // 
            // ekran
            // 
            ekran.ColumnCount = 1;
            ekran.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ekran.Controls.Add(islemler, 0, 0);
            ekran.Controls.Add(labelsayı, 0, 1);
            ekran.Dock = DockStyle.Fill;
            ekran.Location = new Point(3, 3);
            ekran.Name = "ekran";
            ekran.RowCount = 2;
            ekran.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            ekran.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            ekran.Size = new Size(375, 134);
            ekran.TabIndex = 1;
            // 
            // islemler
            // 
            islemler.AutoSize = true;
            islemler.BackColor = Color.WhiteSmoke;
            islemler.Dock = DockStyle.Fill;
            islemler.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            islemler.Location = new Point(3, 0);
            islemler.Name = "islemler";
            islemler.Size = new Size(369, 53);
            islemler.TabIndex = 2;
            // 
            // labelsayı
            // 
            labelsayı.AutoSize = true;
            labelsayı.BackColor = Color.Transparent;
            labelsayı.Dock = DockStyle.Fill;
            labelsayı.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelsayı.Location = new Point(3, 53);
            labelsayı.Name = "labelsayı";
            labelsayı.Size = new Size(369, 81);
            labelsayı.TabIndex = 2;
            labelsayı.Text = "0";
            labelsayı.TextAlign = ContentAlignment.TopRight;
            // 
            // soltaraf
            // 
            soltaraf.ColumnCount = 1;
            soltaraf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            soltaraf.Controls.Add(ekran, 0, 0);
            soltaraf.Controls.Add(Tuslar, 0, 1);
            soltaraf.Dock = DockStyle.Fill;
            soltaraf.Location = new Point(3, 3);
            soltaraf.Name = "soltaraf";
            soltaraf.RowCount = 2;
            soltaraf.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            soltaraf.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            soltaraf.Size = new Size(381, 467);
            soltaraf.TabIndex = 2;
            // 
            // anaekran
            // 
            anaekran.ColumnCount = 2;
            anaekran.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            anaekran.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            anaekran.Controls.Add(soltaraf, 0, 0);
            anaekran.Controls.Add(listboxgecmis, 1, 0);
            anaekran.Dock = DockStyle.Fill;
            anaekran.Location = new Point(0, 0);
            anaekran.Name = "anaekran";
            anaekran.RowCount = 1;
            anaekran.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            anaekran.Size = new Size(774, 473);
            anaekran.TabIndex = 3;
            // 
            // listboxgecmis
            // 
            listboxgecmis.Dock = DockStyle.Fill;
            listboxgecmis.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listboxgecmis.FormattingEnabled = true;
            listboxgecmis.HorizontalScrollbar = true;
            listboxgecmis.ItemHeight = 37;
            listboxgecmis.Location = new Point(390, 3);
            listboxgecmis.Name = "listboxgecmis";
            listboxgecmis.Size = new Size(381, 467);
            listboxgecmis.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 473);
            Controls.Add(anaekran);
            MinimumSize = new Size(520, 460);
            Name = "Form1";
            Text = "Hesap Makinesi";
            Click += Sayilar_Click;
            Tuslar.ResumeLayout(false);
            ekran.ResumeLayout(false);
            ekran.PerformLayout();
            soltaraf.ResumeLayout(false);
            anaekran.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Tuslar;
        private Button button7;
        private Button buttonesit;
        private Button button_CE;
        private Button buttonClear;
        private Button button_AC;
        private Button buttontopla;
        private Button buttonondalık;
        private Button button0;
        private Button buttonNP;
        private Button buttoneksi;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonCarp;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonbol;
        private Button button_9;
        private Button button_8;
        private TableLayoutPanel ekran;
        private Label islemler;
        private Label labelsayı;
        private TableLayoutPanel soltaraf;
        private TableLayoutPanel anaekran;
        private ListBox listboxgecmis;
    }
}
