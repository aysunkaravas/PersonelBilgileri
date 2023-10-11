using System;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelBilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> People = new List<Personel>();

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
            try
            {
                Personel personel = new Personel();
                personel.Ad = txtad.Text;
                personel.Adres = txtadres.Text;
                personel.PersonelID = txtpersonelýd.Text;
                personel.Soyad = txtsoyad.Text;
                personel.DogumTarihi = datedogumtarihi.Value;
                personel.ÝseGirisTarhi = dateisegiris.Value;
                personel.Email = txtemail.Text;
                personel.Telefon = maskedtelefon.Text;
                People.Add(personel);
                ListeViewiDoldur();



                //DurumKontrolEt(personel.PersonelID, personel.Email, personel.DogumTarihi,personel.ÝseGirisTarhi);                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        

        private void DurumKontrolEt(int personelID,DateTime dogumTarihi,DateTime iseGirisTarihi,string email )
        {
            if (personelID < 5)
            {
                throw new Exception("Personel ID uzunluðunuz 5'den küçük olamaz");
                
            }
            else if ( DateTime.Now.Year-dogumTarihi.Year < 18)
            {
                throw new Exception("Yaþý 18den küçük olamaz");

            }
            else if (iseGirisTarihi > DateTime.Now)

            {
                throw new Exception("Ýþe girilen tarih þuanki tarihten sonra olamaz.");

            }
            else if (email !="aysun@gmail.com")
            {
                throw new Exception("E-mail adresinizi yanlýþ girdiniz");
            }
        }

        private void ListeViewiDoldur()
        {
            lvikisiler.Items.Clear();

            foreach (Personel personel in People)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = personel.PersonelID;
                lvi.SubItems.Add(personel.Ad);
                lvi.SubItems.Add(personel.Soyad);
                lvi.SubItems.Add(personel.DogumTarihi.ToShortDateString());
                lvi.SubItems.Add(personel.Telefon);
                lvi.SubItems.Add(personel.Email);
                lvi.SubItems.Add(personel.Adres);
                lvi.SubItems.Add(personel.ÝseGirisTarhi.ToShortDateString());

                lvikisiler.Items.Add(lvi);

            }
        }

        private void lvikisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnguncelle.Enabled = true;
            btnsil.Enabled = true;

            if (lvikisiler.SelectedItems.Count > 0)
            {


                ListViewItem selectedRow = lvikisiler.SelectedItems[0];
                txtpersonelýd.Text = selectedRow.SubItems[0].Text;
                txtad.Text = selectedRow.SubItems[1].Text;
                txtsoyad.Text = selectedRow.SubItems[2].Text;
                DateTime selectedDate;
                if (DateTime.TryParse(lvikisiler.SelectedItems[0].SubItems[3].Text, out selectedDate))
                {
                    datedogumtarihi.Value = selectedDate;
                }

                maskedtelefon.Text = selectedRow.SubItems[4].Text;

                if (DateTime.TryParse(lvikisiler.SelectedItems[0].SubItems[7].Text,out selectedDate))
                {
                    dateisegiris.Value = selectedDate;
                }

                txtemail.Text= selectedRow.SubItems[5].Text;
                txtadres.Text= selectedRow.SubItems[6].Text;




}
        }
        private void btnresimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg(.jpg)|*.jpg |Png(.png)|*.png";
            ofd.ShowDialog();
            string resimYolu = ofd.FileName;

            pboxresim.ImageLocation = resimYolu;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (lvikisiler.SelectedItems.Count > 0)
            {
                int index = lvikisiler.FocusedItem.Index;
                lvikisiler.Items.RemoveAt(lvikisiler.SelectedIndices[index]);
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (lvikisiler.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvikisiler.SelectedItems[0].Tag as ListViewItem;

                

            }
        }
    }
}