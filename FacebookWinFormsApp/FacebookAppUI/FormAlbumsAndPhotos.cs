using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures.FacebookAppUI
{
    public partial class FormAlbumsAndPhotos : Form, ILightDarkMode
    {
        private User m_LoggedInUser = null;
        private int m_AlbumPictureIndex;
        private const string k_PictureIndex = "{0}/{1}"; 
        private FacebookObjectCollection<Photo> m_currentAlbum = null;
        private LightDarkMode m_LightDarkMode;

        public FormAlbumsAndPhotos(User i_LoggedInUser, LightDarkMode i_LightDarkMode)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fillComboboxWithAlbumsNames();
            m_LightDarkMode = i_LightDarkMode;
            m_LightDarkMode.OnChanged += SwitchMode;
        }

        public void SwitchMode(Image i_BackgroundImage)
        {
            panelMainPanel.BackgroundImage = i_BackgroundImage;
            panelMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }


        private void fillComboboxWithAlbumsNames()
        {
            albumBindingSource.DataSource = m_LoggedInUser.Albums;
            if (comboBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve");
            }
        }

        private void buttonDisplayAlbum_Click(object sender, EventArgs e)
        {
            Album chosenAlbum = comboBoxAlbums.SelectedItem as Album;
            if (chosenAlbum != null)
            {
                pictureBoxPictureFromAlbum.Visible = true;
                labelAlbumsPhotoCounter.Visible = true;
                pictureBoxPictureFromAlbum.LoadAsync(chosenAlbum.PictureAlbumURL);
                m_AlbumPictureIndex = 0;
                updateAlbumPictureIndexLabel(ref labelAlbumsPhotoCounter, m_AlbumPictureIndex + 1, 
                    chosenAlbum.Photos.Count);
                m_currentAlbum = chosenAlbum.Photos;
            }
            else
            {
                MessageBox.Show("Please select an album first");
            }
        }
        private void updateAlbumPictureIndexLabel(ref Label i_labelToUpdate, 
            int i_CurrentIndex, int i_TotalAmountOfPhotos)
        {
            i_labelToUpdate.Text = String.Format(k_PictureIndex, i_CurrentIndex, i_TotalAmountOfPhotos);
        }

        private void pictureBoxPictureFromAlbum_Click(object sender, EventArgs e)
        {
            m_AlbumPictureIndex++;
            if (m_currentAlbum.Count - 1 < m_AlbumPictureIndex)
            {
                m_AlbumPictureIndex = 0;
            }

            if (m_currentAlbum.Count > 0)
            {
                pictureBoxPictureFromAlbum.LoadAsync(m_currentAlbum[m_AlbumPictureIndex].PictureNormalURL);
                updateAlbumPictureIndexLabel(ref labelAlbumsPhotoCounter, m_AlbumPictureIndex + 1, m_currentAlbum.Count);
            }
        }
    }
}
