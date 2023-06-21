namespace Entity_FrameWork_Giris_Meyveler
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
            dgvMeyveler = new DataGridView();
            txtAd = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnSil2 = new Button();
            txtBul = new TextBox();
            lstAramaSonuclar = new ListBox();
            Label = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMeyveler).BeginInit();
            SuspendLayout();
            // 
            // dgvMeyveler
            // 
            dgvMeyveler.AllowUserToAddRows = false;
            dgvMeyveler.AllowUserToDeleteRows = false;
            dgvMeyveler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeyveler.Location = new Point(53, 85);
            dgvMeyveler.MultiSelect = false;
            dgvMeyveler.Name = "dgvMeyveler";
            dgvMeyveler.ReadOnly = true;
            dgvMeyveler.RowTemplate.Height = 25;
            dgvMeyveler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeyveler.Size = new Size(484, 320);
            dgvMeyveler.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(128, 40);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(224, 23);
            txtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 44);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "Meyve Adı: ";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(375, 40);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(462, 40);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 4;
            btnSil.Text = "Secili Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnSil2
            // 
            btnSil2.Location = new Point(462, 422);
            btnSil2.Name = "btnSil2";
            btnSil2.Size = new Size(75, 23);
            btnSil2.TabIndex = 5;
            btnSil2.Text = "Secili Sil V2";
            btnSil2.UseVisualStyleBackColor = true;
            btnSil2.Click += btnSil2_Click;
            // 
            // txtBul
            // 
            txtBul.Location = new Point(668, 40);
            txtBul.Name = "txtBul";
            txtBul.Size = new Size(184, 23);
            txtBul.TabIndex = 6;
            txtBul.TextChanged += txtBul_TextChanged;
            // 
            // lstAramaSonuclar
            // 
            lstAramaSonuclar.DisplayMember = "Ad";
            lstAramaSonuclar.FormattingEnabled = true;
            lstAramaSonuclar.ItemHeight = 15;
            lstAramaSonuclar.Location = new Point(590, 86);
            lstAramaSonuclar.Name = "lstAramaSonuclar";
            lstAramaSonuclar.Size = new Size(262, 319);
            lstAramaSonuclar.TabIndex = 7;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(590, 43);
            Label.Name = "Label";
            Label.Size = new Size(72, 15);
            Label.TabIndex = 8;
            Label.Text = "Meyve Ara : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 475);
            Controls.Add(Label);
            Controls.Add(lstAramaSonuclar);
            Controls.Add(txtBul);
            Controls.Add(btnSil2);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(txtAd);
            Controls.Add(dgvMeyveler);
            Name = "Form1";
            Text = "EF_Meyveler";
            ((System.ComponentModel.ISupportInitialize)dgvMeyveler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMeyveler;
        private TextBox txtAd;
        private Label label1;
        private Button btnEkle;
        private Button btnSil;
        private Button btnSil2;
        private TextBox txtBul;
        private ListBox lstAramaSonuclar;
        private Label Label;
    }
}