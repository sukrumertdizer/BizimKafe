namespace BizimKafe.UI
{
    partial class SiparisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            this.btnTasi = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // cboUrun
            // 
            this.cboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(14, 47);
            this.cboUrun.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(261, 38);
            this.cboUrun.TabIndex = 2;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(285, 49);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudAdet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(171, 35);
            this.nudAdet.TabIndex = 3;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(466, 46);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 38);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.AllowUserToAddRows = false;
            this.dgvSiparisDetaylar.AllowUserToDeleteRows = false;
            this.dgvSiparisDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(14, 94);
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.ReadOnly = true;
            this.dgvSiparisDetaylar.RowTemplate.Height = 25;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(565, 498);
            this.dgvSiparisDetaylar.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UrunAd";
            this.Column1.HeaderText = "Ürün";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "c2";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Birim Fiyatı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Adet";
            this.Column3.HeaderText = "Adet";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TutarTL";
            this.Column4.HeaderText = "Tutar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masa No:";
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMasaNo.BackColor = System.Drawing.SystemColors.Window;
            this.cboMasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(668, 46);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(146, 38);
            this.cboMasaNo.TabIndex = 7;
            // 
            // btnTasi
            // 
            this.btnTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTasi.Location = new System.Drawing.Point(834, 44);
            this.btnTasi.Name = "btnTasi";
            this.btnTasi.Size = new System.Drawing.Size(119, 40);
            this.btnTasi.TabIndex = 8;
            this.btnTasi.Text = "TAŞI";
            this.btnTasi.UseVisualStyleBackColor = true;
            this.btnTasi.Click += new System.EventHandler(this.btnTasi_Click);
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.OrangeRed;
            this.lblMasaNo.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMasaNo.Location = new System.Drawing.Point(637, 94);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(316, 218);
            this.lblMasaNo.TabIndex = 9;
            this.lblMasaNo.Text = "00";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Location = new System.Drawing.Point(834, 368);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(62, 30);
            this.lblOdemeTutari.TabIndex = 11;
            this.lblOdemeTutari.Text = "0.00₺";
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.BackColor = System.Drawing.Color.DarkRed;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIptal.Location = new System.Drawing.Point(637, 450);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(152, 73);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "SİPARİŞ İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOde
            // 
            this.btnOde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOde.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOde.Location = new System.Drawing.Point(807, 450);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(146, 73);
            this.btnOde.TabIndex = 13;
            this.btnOde.Text = "ÖDEME AL";
            this.btnOde.UseVisualStyleBackColor = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnasayfa.BackColor = System.Drawing.Color.Gold;
            this.btnAnasayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAnasayfa.Location = new System.Drawing.Point(637, 529);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(316, 63);
            this.btnAnasayfa.TabIndex = 14;
            this.btnAnasayfa.Text = "ANASAYFAYA DÖN";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 609);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnTasi);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboUrun;
        private NumericUpDown nudAdet;
        private Button btnEkle;
        private DataGridView dgvSiparisDetaylar;
        private Label label3;
        private ComboBox cboMasaNo;
        private Button btnTasi;
        private Label lblMasaNo;
        private Label label5;
        private Label lblOdemeTutari;
        private Button btnIptal;
        private Button btnOde;
        private Button btnAnasayfa;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}