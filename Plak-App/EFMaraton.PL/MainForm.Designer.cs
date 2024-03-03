namespace EFMaraton.PL
{
    partial class MainForm
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
            cboxLists = new ComboBox();
            dgvMain = new DataGridView();
            btnShowList = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboxIsActive = new ComboBox();
            dtpReleaseDate = new DateTimePicker();
            cboxArtist = new ComboBox();
            txtAlbumName = new TextBox();
            numDisc = new NumericUpDown();
            numAlbumPrice = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtArtistName = new TextBox();
            label7 = new Label();
            SanatciEkle = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDisc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAlbumPrice).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cboxLists
            // 
            cboxLists.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxLists.FormattingEnabled = true;
            cboxLists.Location = new Point(28, 284);
            cboxLists.Name = "cboxLists";
            cboxLists.Size = new Size(121, 23);
            cboxLists.TabIndex = 0;
            // 
            // dgvMain
            // 
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(28, 313);
            dgvMain.Name = "dgvMain";
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(588, 212);
            dgvMain.TabIndex = 1;
            dgvMain.CellClick += dgvMain_CellClick;
            // 
            // btnShowList
            // 
            btnShowList.Location = new Point(169, 284);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(108, 23);
            btnShowList.TabIndex = 2;
            btnShowList.Text = "Listeyi Goruntule";
            btnShowList.UseVisualStyleBackColor = true;
            btnShowList.Click += btnShowList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Albüm Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 55);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Sanatçı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 85);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 112);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 6;
            label4.Text = "Albüm Fiyatı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 138);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 7;
            label5.Text = "İndirim Oranı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 168);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 8;
            label6.Text = "Satış Durumu:";
            // 
            // cboxIsActive
            // 
            cboxIsActive.FormattingEnabled = true;
            cboxIsActive.Location = new Point(103, 165);
            cboxIsActive.Name = "cboxIsActive";
            cboxIsActive.Size = new Size(121, 23);
            cboxIsActive.TabIndex = 9;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(103, 79);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(200, 23);
            dtpReleaseDate.TabIndex = 10;
            // 
            // cboxArtist
            // 
            cboxArtist.FormattingEnabled = true;
            cboxArtist.Location = new Point(103, 52);
            cboxArtist.Name = "cboxArtist";
            cboxArtist.Size = new Size(121, 23);
            cboxArtist.TabIndex = 11;
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(103, 25);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(100, 23);
            txtAlbumName.TabIndex = 12;
            // 
            // numDisc
            // 
            numDisc.DecimalPlaces = 2;
            numDisc.Location = new Point(104, 136);
            numDisc.Name = "numDisc";
            numDisc.Size = new Size(120, 23);
            numDisc.TabIndex = 13;
            // 
            // numAlbumPrice
            // 
            numAlbumPrice.DecimalPlaces = 2;
            numAlbumPrice.Location = new Point(104, 107);
            numAlbumPrice.Name = "numAlbumPrice";
            numAlbumPrice.Size = new Size(120, 23);
            numAlbumPrice.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 47);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(103, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 47);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Guncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(189, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 47);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(100, 22);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(100, 23);
            txtArtistName.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 25);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 18;
            label7.Text = "Sanatçı Adı:";
            // 
            // SanatciEkle
            // 
            SanatciEkle.Location = new Point(100, 52);
            SanatciEkle.Name = "SanatciEkle";
            SanatciEkle.Size = new Size(100, 47);
            SanatciEkle.TabIndex = 20;
            SanatciEkle.Text = "Ekle";
            SanatciEkle.UseVisualStyleBackColor = true;
            SanatciEkle.Click += SanatciEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cboxIsActive);
            groupBox1.Controls.Add(numAlbumPrice);
            groupBox1.Controls.Add(dtpReleaseDate);
            groupBox1.Controls.Add(numDisc);
            groupBox1.Controls.Add(cboxArtist);
            groupBox1.Controls.Add(txtAlbumName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 260);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Albüm Ekranı";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtArtistName);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(SanatciEkle);
            groupBox2.Location = new Point(363, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(221, 115);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sanatçı Ekranı";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 540);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnShowList);
            Controls.Add(dgvMain);
            Controls.Add(cboxLists);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDisc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAlbumPrice).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboxLists;
        private DataGridView dgvMain;
        private Button btnShowList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboxIsActive;
        private DateTimePicker dtpReleaseDate;
        private ComboBox cboxArtist;
        private TextBox txtAlbumName;
        private NumericUpDown numDisc;
        private NumericUpDown numAlbumPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtArtistName;
        private Label label7;
        private Button SanatciEkle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}