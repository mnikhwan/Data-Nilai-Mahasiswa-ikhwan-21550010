using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Data_Nilai_Mahasiswa_ikhwan_21550010
{
    public partial class Form1 : Form
    {
        private IMongoDatabase database;
        private IMongoClient client;
        private Timer timer;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate dari sudut kiri atas
            int nTopRect,      // y-coordinate dari sudut kiri atas
            int nRightRect,    // x-coordinate dari sudut kanan bawah
            int nBottomRect,   // y-coordinate dari sudut kanan bawah
            int nWidthEllipse, // lebar dari lingkaran oval
            int nHeightEllipse // tinggi dari lingkaran oval
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if (IsConnectedToInternet())
            {
                DialogResult result = MessageBox.Show("Internet status: Connected.\nLayanan Nilai Mahasiswa dapat digunakan sekarang.", "Internet Connection Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeMongoDB();
                if (result == DialogResult.OK)
                {
                    CheckMongodbATLAS();                    
                }

            }
            else
            {
                MessageBox.Show("Internet status: Not Connected.\nLayanan Nilai Mahasiswa membutuhkan koneksi Internet", "Internet Connection Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                Application.Exit();
            }
            InitializeMongoDB();
            InitializeTimer();
            LoadData();

        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 10000; // Set interval to 10 seconds
            timer.Tick += new EventHandler(CheckMongodbATLASS);
            timer.Start();
        }
        private async void CheckMongodbATLAS()
        {
            mongocheck.Text = "⚠ | Checking MongoDB Atlas Connection...";
            try
            {
                InitializeMongoDB();
                // Perform a simple operation to check the connection
                var collections = await database.ListCollectionNamesAsync();
                await collections.MoveNextAsync();
                if (collections.Current != null)
                {
                    mongocheck.Text = "🚀 | Connected to MongoDB Atlas successfully!";
                }
                else
                {
                    mongocheck.Text = "⚠ | Connected to MongoDB Atlas, but no collections found.";
                }
            }
            catch (Exception ex)
            {
                mongocheck.Text = "⚠ | MongoDB Atlas Disconnect!";
                richTextBox1.AppendText("Failed to connect to MongoDB Atlas COK: " + ex.Message);
            }
        }

        private async void CheckMongodbATLASS(object sender, EventArgs e)
        {
            mongocheck.Text = "⚠ | Checking MongoDB Atlas Connection...";
            try
            {
                
                // Perform a simple operation to check the connection
                var collections = await database.ListCollectionNamesAsync();
                await collections.MoveNextAsync();
                if (collections.Current != null)
                {
                    mongocheck.Text = "🚀 | MongoDB Atlas Connected!";
                }
                else
                {
                    mongocheck.Text = "⚠ | MongoDB Atlas Connected, but no collections found.";
                }
            }
            catch (Exception)
            {
                mongocheck.Text = "⚠ | MongoDB Atlas Disconnect!";
                DialogResult resultss = MessageBox.Show("Internet status: Not Connected.\nLayanan Nilai Mahasiswa membutuhkan koneksi Internet\nAplikasi Akan diclose otomatis setelah ini!", "Internet Connection Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (resultss == DialogResult.OK)
                {
                    this.Close();
                    Application.Exit();
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
            }
        }

        private bool IsConnectedToInternet()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (client.OpenRead("http://www.google.com"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        
        private void InitializeMongoDB()
        {
            string connectionString = "mongodb+srv://uas_21550010:ptiunisri@unisricluster0.ygg5ivm.mongodb.net/?retryWrites=true&w=majority&appName=UNISRICluster0";
            var client = new MongoClient(connectionString);
            database = client.GetDatabase("uas_21550010");
            
        }

    
        



        public void changeLabelText(string text)
        {
             // label1 is the label that you want to change the text
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                InitializeMongoDB();
                var collection = database.GetCollection<BsonDocument>("tb_nil_21550010");
                var filter = Builders<BsonDocument>.Filter.Empty;
                var documents = await collection.Find(filter).ToListAsync();

                richTextBox1.Clear();
                foreach (var doc in documents)
                {
                    richTextBox1.AppendText(doc.ToJson() + "\n\n");
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "Failed to fetch data from MongoDB Atlas: " + ex.Message;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mnikhwan.my.id/");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtNama.Text = row.Cells["Nama"].Value.ToString();
                    txtNpm.Text = row.Cells["NPM"].Value.ToString();
                    txtTugas.Text = row.Cells["Tugas"].Value.ToString();
                    txtUts.Text = row.Cells["UTS"].Value.ToString();
                    txtUas.Text = row.Cells["UAS"].Value.ToString();
                    
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bsimpan_Click(object sender, EventArgs e)
        {
            {
                var collection = database.GetCollection<BsonDocument>("tb_nil_21550010");
                var hAkhirnilai = (int.Parse(txtTugas.Text) * 1) + (int.Parse(txtUts.Text) * 2) + (int.Parse(txtUas.Text) * 3) / 6;
                var document = new BsonDocument
            {
                { "nama", txtNama.Text },
                { "npm", txtNpm.Text },
                { "tugas", int.Parse(txtTugas.Text) },
                { "uts", int.Parse(txtUts.Text) },
                { "uas", int.Parse(txtUas.Text) },
                { "akhir", hAkhirnilai }
            };

                collection.InsertOne(document);
                LoadData();
                MessageBox.Show("Data berhasil di Simpan");
            }
        }

        private void Bhapus_Click(object sender, EventArgs e)
        {
            {
                var collection = database.GetCollection<BsonDocument>("tb_nil_21550010");

                var filter = Builders<BsonDocument>.Filter.Eq("npm", txtNpm.Text);

                collection.DeleteOne(filter);
                LoadData();
                MessageBox.Show("Data berhasil di Hapus");
            }
        }
        private void Bedit_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("tb_nil_21550010");
            var hAkhirnilai = (int.Parse(txtTugas.Text) * 1) + (int.Parse(txtUts.Text) * 2) + (int.Parse(txtUas.Text) * 3) / 6;
            var filter = Builders<BsonDocument>.Filter.Eq("npm", txtNpm.Text);
            var update = Builders<BsonDocument>.Update
                .Set("nama", txtNama.Text)
                .Set("tugas", int.Parse(txtTugas.Text))
                .Set("uts", int.Parse(txtUts.Text))
                .Set("uas", int.Parse(txtUas.Text))
                .Set("akhir", hAkhirnilai);

            collection.UpdateOne(filter, update);
            LoadData();
            MessageBox.Show("Data berhasil di Edit");
        }


        private void LoadData()
        {
            var collection = database.GetCollection<BsonDocument>("tb_nil_21550010");
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = collection.Find(filter).ToList();

            dataGridView1.Rows.Clear();
            
            foreach (var doc in documents)
            {
                dataGridView1.Rows.Add(doc["nama"], doc["npm"], doc["tugas"], doc["uas"], doc["uts"], doc["akhir"]);
            }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNpm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTugas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveToSQL_Click(object sender, EventArgs e)
        {
            SaveDataToSQL();
        }
        private void SaveDataToSQL()
        {
            var collection = database.GetCollection<BsonDocument>("tb_nil_21550010");
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = collection.Find(filter).ToList();

            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.AppendLine("CREATE TABLE IF NOT EXISTS tb_nil_21550010 (nama TEXT, npm TEXT, tugas INTEGER, uts INTEGER, uas INTEGER, akhir INTEGER);");

            foreach (var doc in documents)
            {
                sqlBuilder.AppendLine($"INSERT INTO tb_nil_21550010 (nama, npm, tugas, uts, uas, akhir) VALUES ('{doc["nama"]}', '{doc["npm"]}', {doc["tugas"]}, {doc["uts"]}, {doc["uas"]}, {doc["akhir"]});");
            }

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB_TP24_21550010.sql");

            File.WriteAllText(filePath, sqlBuilder.ToString());

            MessageBox.Show($"Data has been saved to {filePath}", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
