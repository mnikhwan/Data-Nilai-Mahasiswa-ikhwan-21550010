namespace Data_Nilai_Mahasiswa_ikhwan_21550010
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mongocheck = new System.Windows.Forms.Label();
            this.Bsimpan = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtUas = new System.Windows.Forms.TextBox();
            this.txtUts = new System.Windows.Forms.TextBox();
            this.txtTugas = new System.Windows.Forms.TextBox();
            this.txtNpm = new System.Windows.Forms.TextBox();
            this.Bhapus = new System.Windows.Forms.Button();
            this.Bedit = new System.Windows.Forms.Button();
            this.btnSaveToSQL = new System.Windows.Forms.Button();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 33);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(584, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(555, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 13;
            this.button4.Text = "-";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data Nilai Mahasiswa | ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(195, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(213, 19);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Muhammad Nurul Ikhwan - 21550010";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(26, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama,
            this.npm,
            this.tugas,
            this.uts,
            this.UAS,
            this.akhir});
            this.dataGridView1.Location = new System.Drawing.Point(31, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cek Data di MongoDB Atlas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(568, 54);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // mongocheck
            // 
            this.mongocheck.AutoSize = true;
            this.mongocheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.mongocheck.Font = new System.Drawing.Font("Poppins", 7F);
            this.mongocheck.ForeColor = System.Drawing.Color.Black;
            this.mongocheck.Location = new System.Drawing.Point(28, 429);
            this.mongocheck.Name = "mongocheck";
            this.mongocheck.Size = new System.Drawing.Size(184, 17);
            this.mongocheck.TabIndex = 28;
            this.mongocheck.Text = "⚠ | MongoDB Atlas Not Connected";
            // 
            // Bsimpan
            // 
            this.Bsimpan.Location = new System.Drawing.Point(298, 52);
            this.Bsimpan.Name = "Bsimpan";
            this.Bsimpan.Size = new System.Drawing.Size(75, 23);
            this.Bsimpan.TabIndex = 31;
            this.Bsimpan.Text = "Simpan";
            this.Bsimpan.UseVisualStyleBackColor = true;
            this.Bsimpan.Click += new System.EventHandler(this.Bsimpan_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(56, 52);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(137, 20);
            this.txtNama.TabIndex = 32;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // txtUas
            // 
            this.txtUas.Location = new System.Drawing.Point(91, 166);
            this.txtUas.Name = "txtUas";
            this.txtUas.Size = new System.Drawing.Size(137, 20);
            this.txtUas.TabIndex = 33;
            this.txtUas.TextChanged += new System.EventHandler(this.txtUas_TextChanged);
            // 
            // txtUts
            // 
            this.txtUts.Location = new System.Drawing.Point(91, 140);
            this.txtUts.Name = "txtUts";
            this.txtUts.Size = new System.Drawing.Size(137, 20);
            this.txtUts.TabIndex = 34;
            this.txtUts.TextChanged += new System.EventHandler(this.txtUts_TextChanged);
            // 
            // txtTugas
            // 
            this.txtTugas.Location = new System.Drawing.Point(91, 114);
            this.txtTugas.Name = "txtTugas";
            this.txtTugas.Size = new System.Drawing.Size(137, 20);
            this.txtTugas.TabIndex = 35;
            this.txtTugas.TextChanged += new System.EventHandler(this.txtTugas_TextChanged);
            // 
            // txtNpm
            // 
            this.txtNpm.Location = new System.Drawing.Point(56, 78);
            this.txtNpm.Name = "txtNpm";
            this.txtNpm.Size = new System.Drawing.Size(137, 20);
            this.txtNpm.TabIndex = 36;
            this.txtNpm.TextChanged += new System.EventHandler(this.txtNpm_TextChanged);
            // 
            // Bhapus
            // 
            this.Bhapus.Location = new System.Drawing.Point(460, 52);
            this.Bhapus.Name = "Bhapus";
            this.Bhapus.Size = new System.Drawing.Size(75, 23);
            this.Bhapus.TabIndex = 37;
            this.Bhapus.Text = "Hapus";
            this.Bhapus.UseVisualStyleBackColor = true;
            this.Bhapus.Click += new System.EventHandler(this.Bhapus_Click);
            // 
            // Bedit
            // 
            this.Bedit.Location = new System.Drawing.Point(379, 51);
            this.Bedit.Name = "Bedit";
            this.Bedit.Size = new System.Drawing.Size(75, 23);
            this.Bedit.TabIndex = 38;
            this.Bedit.Text = "Edit";
            this.Bedit.UseVisualStyleBackColor = true;
            this.Bedit.Click += new System.EventHandler(this.Bedit_Click);
            // 
            // btnSaveToSQL
            // 
            this.btnSaveToSQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveToSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnSaveToSQL.Location = new System.Drawing.Point(427, 425);
            this.btnSaveToSQL.Name = "btnSaveToSQL";
            this.btnSaveToSQL.Size = new System.Drawing.Size(172, 21);
            this.btnSaveToSQL.TabIndex = 39;
            this.btnSaveToSQL.Text = "Simpan data menjadi .SQL File";
            this.btnSaveToSQL.UseVisualStyleBackColor = true;
            this.btnSaveToSQL.Click += new System.EventHandler(this.btnSaveToSQL_Click);
            // 
            // nama
            // 
            this.nama.HeaderText = "NAMA";
            this.nama.Name = "nama";
            // 
            // npm
            // 
            this.npm.HeaderText = "NPM";
            this.npm.Name = "npm";
            // 
            // tugas
            // 
            this.tugas.HeaderText = "TUGAS";
            this.tugas.Name = "tugas";
            // 
            // uts
            // 
            this.uts.HeaderText = "UTS";
            this.uts.Name = "uts";
            this.uts.Width = 70;
            // 
            // UAS
            // 
            this.UAS.HeaderText = "UAS";
            this.UAS.Name = "UAS";
            // 
            // akhir
            // 
            this.akhir.HeaderText = "AKHIR";
            this.akhir.Name = "akhir";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveToSQL);
            this.Controls.Add(this.Bedit);
            this.Controls.Add(this.Bhapus);
            this.Controls.Add(this.txtNpm);
            this.Controls.Add(this.txtTugas);
            this.Controls.Add(this.txtUts);
            this.Controls.Add(this.txtUas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.Bsimpan);
            this.Controls.Add(this.mongocheck);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Nilai Mahasiswa | Muhammad Nurul Ikhwan -21550010";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label mongocheck;
        private System.Windows.Forms.Button Bsimpan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtUas;
        private System.Windows.Forms.TextBox txtUts;
        private System.Windows.Forms.TextBox txtTugas;
        private System.Windows.Forms.TextBox txtNpm;
        private System.Windows.Forms.Button Bhapus;
        private System.Windows.Forms.Button Bedit;
        private System.Windows.Forms.Button btnSaveToSQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn npm;
        private System.Windows.Forms.DataGridViewTextBoxColumn tugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn uts;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn akhir;
    }
}

