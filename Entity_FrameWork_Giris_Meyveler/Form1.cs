using Entity_FrameWork_Giris_Meyveler.Data;

namespace Entity_FrameWork_Giris_Meyveler
{
    public partial class Form1 : Form
    {
        ManavContext db = new ManavContext();
        public Form1()
        {
            InitializeComponent();
            dgvMeyveler.DataSource = db.Meyveler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();

            if (ad == "")
            {
                MessageBox.Show("Ad girmediniz!");
                return;
            }
            db.Meyveler.Add(new Meyve() { Ad = ad });
            db.SaveChanges();
            dgvMeyveler.DataSource = db.Meyveler.ToList();
            Ara();
            MessageBox.Show(ad + " meyvesi eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMeyveler.SelectedRows.Count == 0) return; // kýsa devre

            int id = (int)dgvMeyveler.SelectedRows[0].Cells[0].Value;
            Meyve? meyve = db.Meyveler.Find(id);

            if (meyve != null)
            {
                db.Meyveler.Remove(meyve);
                db.SaveChanges();
                dgvMeyveler.DataSource = db.Meyveler.ToList();
                Ara();
                MessageBox.Show(meyve.Ad + " meyvesi silindi.");
            }
        }

        private void btnSil2_Click(object sender, EventArgs e)
        {
            if (dgvMeyveler.SelectedRows.Count == 0) return; // kýsa devre

            // NOT BU YONTEM CALISMASI ICIN MEYVELERI ILK GETIRILEN DB ILE KALDIRINA DB NESNESI AYNI OLMALI!
            Meyve meyve = (Meyve)dgvMeyveler.SelectedRows[0].DataBoundItem;
            db.Meyveler.Remove(meyve);
            db.SaveChanges();
            dgvMeyveler.DataSource = db.Meyveler.ToList();
            Ara();
            MessageBox.Show(meyve.Ad + " meyvesi silindi.");
        }

        private void txtBul_TextChanged(object sender, EventArgs e)
        {
            Ara();
        }

        void Ara()
        {
            lstAramaSonuclar.DataSource =
               db.Meyveler.Where(m => m.Ad.Contains(txtBul.Text)).ToList();
        }
    }
}