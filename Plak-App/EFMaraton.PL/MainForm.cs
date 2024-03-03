using EFMaraton.BLL.Manager.Concrete;
using EFMaraton.BLL.Models;
using EFMaraton.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFMaraton.PL
{
    public partial class MainForm : Form
    {
        ArtistModel artistModel = new ArtistModel();
        ArtistManager artistManager = new ArtistManager();
        AlbumManager albumManager = new AlbumManager();
        AlbumModel albumModel = new AlbumModel();



        AlbumModel secilenAlbum;
        ArtistModel secilenArtist;
        public MainForm()
        {
            InitializeComponent();
            cboxIsActive.DataSource = Enum.GetValues(typeof(SaleStatus));
            cboxArtist.DataSource = artistManager.GetAll();
            dgvMain.DataSource = albumManager.GetAll();


            cboxLists.Items.Add("Satışı Durmuş Albümler");
            cboxLists.Items.Add("Satışı Devam Eden Albümler");
            cboxLists.Items.Add("Sisteme Son Eklenen 10 Albüm");
            cboxLists.Items.Add("İndirimdeki Albümler");
            cboxLists.Items.Add("Tam liste");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {


                albumModel.Name = txtAlbumName.Text;
                albumModel.ArtistId = ((ArtistModel)cboxArtist.SelectedItem).Id;
                albumModel.ReleaseDate = dtpReleaseDate.Value;
                albumModel.Price = (float)numAlbumPrice.Value;
                albumModel.Discount = (float)numDisc.Value;
                albumModel.SaleStatus = (SaleStatus)cboxIsActive.SelectedItem;
                albumManager.Add(albumModel);

                dgvMain.DataSource = null;
                dgvMain.DataSource = albumManager.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                secilenAlbum.Name = txtAlbumName.Text;
                secilenAlbum.ReleaseDate = dtpReleaseDate.Value;
                secilenAlbum.Discount = (float)numDisc.Value;
                secilenAlbum.Price = (float)numAlbumPrice.Value;
                secilenAlbum.ArtistId = ((ArtistModel)cboxArtist.SelectedItem).Id;
                secilenAlbum.SaleStatus = (SaleStatus)cboxIsActive.SelectedItem;

                albumManager.Update(secilenAlbum);
                dgvMain.DataSource = null;
                dgvMain.DataSource = albumManager.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                secilenAlbum = (AlbumModel)dgvMain.SelectedRows[0].DataBoundItem;
                txtAlbumName.Text = secilenAlbum.Name;
                cboxArtist.SelectedItem = secilenAlbum.ArtistId; //?
                numAlbumPrice.Value = (decimal)secilenAlbum.Price;
                numDisc.Value = (decimal)secilenAlbum.Discount;
                dtpReleaseDate.Value = secilenAlbum.ReleaseDate;
                cboxIsActive.SelectedItem = secilenAlbum.SaleStatus; //?
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                albumManager.Delete(secilenAlbum);
                dgvMain.DataSource = null;
                dgvMain.DataSource = albumManager.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            try
            {

                switch (cboxLists.SelectedIndex)
                {
                    case 0:
                        var SaleStopped = albumManager.Search(x => x.SaleStatus == SaleStatus.Inactive).Select(album => new { album.Name, album.Artist }).ToList();

                        dgvMain.DataSource = null;
                        dgvMain.DataSource = SaleStopped;

                        break;
                    case 1:
                        var SaleCont = albumManager.Search(x => x.SaleStatus != SaleStatus.Inactive).Select(album => new { album.Name, album.Artist }).ToList();
                        dgvMain.DataSource = null;
                        dgvMain.DataSource = SaleCont;
                        break;
                    case 2:
                        var LastTen = albumManager.GetAll().OrderByDescending(x => x.Created).Take(10).Select(album => new { album.Name, album.Artist }).ToList();
                        dgvMain.DataSource = null;
                        dgvMain.DataSource = LastTen;
                        break;
                    case 3:
                        var DiscAlbums = albumManager.Search(x => x.Discount > 0).OrderByDescending(x => x.Discount).Select(album => new { album.Name, album.Artist }).ToList();
                        dgvMain.DataSource = null;
                        dgvMain.DataSource = DiscAlbums;
                        break;
                    case 4:
                        dgvMain.DataSource = null;
                        dgvMain.DataSource = albumManager.GetAll();
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SanatciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                artistModel.Name = txtArtistName.Text;
                artistManager.Add(artistModel);
                cboxArtist.DataSource = null;
                cboxArtist.DataSource = artistManager.GetAll();
                dgvMain.DataSource = null;
                dgvMain.DataSource = albumManager.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        
    }
}
