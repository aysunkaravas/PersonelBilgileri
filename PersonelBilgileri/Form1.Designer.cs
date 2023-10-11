namespace PersonelBilgileri
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
            lblad = new Label();
            lblıd = new Label();
            lblsoyad = new Label();
            lbldogumtarihi = new Label();
            lblisegiris = new Label();
            lbladres = new Label();
            maskedtelefon = new MaskedTextBox();
            txtpersonelıd = new TextBox();
            txtemail = new TextBox();
            txtsoyad = new TextBox();
            txtad = new TextBox();
            txtadres = new TextBox();
            datedogumtarihi = new DateTimePicker();
            dateisegiris = new DateTimePicker();
            pboxresim = new PictureBox();
            lvikisiler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            btnresimsec = new Button();
            btnkaydet = new Button();
            btnguncelle = new Button();
            btnsil = new Button();
            grpbilgiler = new GroupBox();
            lblemail = new Label();
            lbltelefon = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxresim).BeginInit();
            grpbilgiler.SuspendLayout();
            SuspendLayout();
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(31, 102);
            lblad.Name = "lblad";
            lblad.Size = new Size(28, 20);
            lblad.TabIndex = 0;
            lblad.Text = "Ad";
            // 
            // lblıd
            // 
            lblıd.AutoSize = true;
            lblıd.Location = new Point(31, 56);
            lblıd.Name = "lblıd";
            lblıd.Size = new Size(83, 20);
            lblıd.TabIndex = 1;
            lblıd.Text = "Personel ID";
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(31, 158);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(50, 20);
            lblsoyad.TabIndex = 2;
            lblsoyad.Text = "Soyad";
            // 
            // lbldogumtarihi
            // 
            lbldogumtarihi.AutoSize = true;
            lbldogumtarihi.Location = new Point(31, 204);
            lbldogumtarihi.Name = "lbldogumtarihi";
            lbldogumtarihi.Size = new Size(98, 20);
            lbldogumtarihi.TabIndex = 3;
            lbldogumtarihi.Text = "Doğum Tarihi";
            // 
            // lblisegiris
            // 
            lblisegiris.AutoSize = true;
            lblisegiris.Location = new Point(638, 100);
            lblisegiris.Name = "lblisegiris";
            lblisegiris.Size = new Size(99, 20);
            lblisegiris.TabIndex = 4;
            lblisegiris.Text = "İşe Giriş Tarihi";
            // 
            // lbladres
            // 
            lbladres.AutoSize = true;
            lbladres.Location = new Point(671, 24);
            lbladres.Name = "lbladres";
            lbladres.Size = new Size(47, 20);
            lbladres.TabIndex = 5;
            lbladres.Text = "Adres";
            // 
            // maskedtelefon
            // 
            maskedtelefon.Location = new Point(167, 263);
            maskedtelefon.Mask = "(999) 000-0000";
            maskedtelefon.Name = "maskedtelefon";
            maskedtelefon.Size = new Size(125, 27);
            maskedtelefon.TabIndex = 6;
            // 
            // txtpersonelıd
            // 
            txtpersonelıd.Location = new Point(167, 49);
            txtpersonelıd.Name = "txtpersonelıd";
            txtpersonelıd.Size = new Size(125, 27);
            txtpersonelıd.TabIndex = 7;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(167, 318);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(125, 27);
            txtemail.TabIndex = 8;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(167, 155);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(125, 27);
            txtsoyad.TabIndex = 9;
            // 
            // txtad
            // 
            txtad.Location = new Point(167, 99);
            txtad.Name = "txtad";
            txtad.Size = new Size(125, 27);
            txtad.TabIndex = 10;
            // 
            // txtadres
            // 
            txtadres.Location = new Point(862, 16);
            txtadres.Multiline = true;
            txtadres.Name = "txtadres";
            txtadres.Size = new Size(142, 73);
            txtadres.TabIndex = 11;
            // 
            // datedogumtarihi
            // 
            datedogumtarihi.Location = new Point(167, 199);
            datedogumtarihi.Name = "datedogumtarihi";
            datedogumtarihi.Size = new Size(250, 27);
            datedogumtarihi.TabIndex = 12;
            // 
            // dateisegiris
            // 
            dateisegiris.Location = new Point(773, 95);
            dateisegiris.Name = "dateisegiris";
            dateisegiris.Size = new Size(250, 27);
            dateisegiris.TabIndex = 13;
            // 
            // pboxresim
            // 
            pboxresim.Location = new Point(655, 168);
            pboxresim.Name = "pboxresim";
            pboxresim.Size = new Size(141, 107);
            pboxresim.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxresim.TabIndex = 14;
            pboxresim.TabStop = false;
            // 
            // lvikisiler
            // 
            lvikisiler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            lvikisiler.FullRowSelect = true;
            lvikisiler.GridLines = true;
            lvikisiler.Location = new Point(43, 427);
            lvikisiler.Name = "lvikisiler";
            lvikisiler.Size = new Size(1137, 234);
            lvikisiler.TabIndex = 15;
            lvikisiler.UseCompatibleStateImageBehavior = false;
            lvikisiler.View = View.Details;
            lvikisiler.SelectedIndexChanged += lvikisiler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel ID";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Doğum Tarihi";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Email";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Adres";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "İşe Giriş Tarihi";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Resim Yolu";
            columnHeader9.Width = 120;
            // 
            // btnresimsec
            // 
            btnresimsec.Location = new Point(902, 131);
            btnresimsec.Name = "btnresimsec";
            btnresimsec.Size = new Size(94, 29);
            btnresimsec.TabIndex = 16;
            btnresimsec.Text = "Resim Seç";
            btnresimsec.UseVisualStyleBackColor = true;
            btnresimsec.Click += btnresimsec_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(902, 166);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(94, 29);
            btnkaydet.TabIndex = 17;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.Location = new Point(902, 206);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(94, 29);
            btnguncelle.TabIndex = 18;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.Location = new Point(902, 246);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 29);
            btnsil.TabIndex = 19;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // grpbilgiler
            // 
            grpbilgiler.Controls.Add(lblemail);
            grpbilgiler.Controls.Add(lbltelefon);
            grpbilgiler.Controls.Add(datedogumtarihi);
            grpbilgiler.Controls.Add(txtad);
            grpbilgiler.Controls.Add(txtsoyad);
            grpbilgiler.Controls.Add(txtemail);
            grpbilgiler.Controls.Add(txtpersonelıd);
            grpbilgiler.Controls.Add(maskedtelefon);
            grpbilgiler.Controls.Add(lblsoyad);
            grpbilgiler.Controls.Add(lblad);
            grpbilgiler.Controls.Add(lblıd);
            grpbilgiler.Controls.Add(lbldogumtarihi);
            grpbilgiler.Location = new Point(12, 2);
            grpbilgiler.Name = "grpbilgiler";
            grpbilgiler.Size = new Size(558, 409);
            grpbilgiler.TabIndex = 20;
            grpbilgiler.TabStop = false;
            grpbilgiler.Text = "Personel Bilgileri";
            grpbilgiler.Enter += groupBox1_Enter;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(31, 340);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(46, 20);
            lblemail.TabIndex = 14;
            lblemail.Text = "Email";
            // 
            // lbltelefon
            // 
            lbltelefon.AutoSize = true;
            lbltelefon.Location = new Point(31, 270);
            lbltelefon.Name = "lbltelefon";
            lbltelefon.Size = new Size(58, 20);
            lbltelefon.TabIndex = 13;
            lbltelefon.Text = "Telefon";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 713);
            Controls.Add(grpbilgiler);
            Controls.Add(btnsil);
            Controls.Add(btnguncelle);
            Controls.Add(btnkaydet);
            Controls.Add(btnresimsec);
            Controls.Add(lvikisiler);
            Controls.Add(pboxresim);
            Controls.Add(dateisegiris);
            Controls.Add(txtadres);
            Controls.Add(lbladres);
            Controls.Add(lblisegiris);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pboxresim).EndInit();
            grpbilgiler.ResumeLayout(false);
            grpbilgiler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblad;
        private Label lblıd;
        private Label lblsoyad;
        private Label lbldogumtarihi;
        private Label lblisegiris;
        private Label lbladres;
        private MaskedTextBox maskedtelefon;
        private TextBox txtpersonelıd;
        private TextBox txtemail;
        private TextBox txtsoyad;
        private TextBox txtad;
        private TextBox txtadres;
        private DateTimePicker datedogumtarihi;
        private DateTimePicker dateisegiris;
        private PictureBox pboxresim;
        private ListView lvikisiler;
        private Button btnresimsec;
        private Button btnkaydet;
        private Button btnguncelle;
        private Button btnsil;
        private GroupBox grpbilgiler;
        private Label lblemail;
        private Label lbltelefon;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}