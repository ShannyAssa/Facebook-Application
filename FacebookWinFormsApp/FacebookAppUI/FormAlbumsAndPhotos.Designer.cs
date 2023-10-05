
namespace BasicFacebookFeatures.FacebookAppUI
{
    partial class FormAlbumsAndPhotos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbumsAndPhotos));
            this.panelMainPanel = new System.Windows.Forms.Panel();
            this.labelAlbumsPhotoCounter = new System.Windows.Forms.Label();
            this.pictureBoxPictureFromAlbum = new System.Windows.Forms.PictureBox();
            this.buttonDisplayAlbum = new System.Windows.Forms.Button();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureFromAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainPanel
            // 
            this.panelMainPanel.AutoScroll = true;
            this.panelMainPanel.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.photo;
            this.panelMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainPanel.Controls.Add(this.labelAlbumsPhotoCounter);
            this.panelMainPanel.Controls.Add(this.pictureBoxPictureFromAlbum);
            this.panelMainPanel.Controls.Add(this.buttonDisplayAlbum);
            this.panelMainPanel.Controls.Add(this.comboBoxAlbums);
            this.panelMainPanel.Controls.Add(this.label1);
            this.panelMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainPanel.Location = new System.Drawing.Point(0, 0);
            this.panelMainPanel.Name = "panelMainPanel";
            this.panelMainPanel.Size = new System.Drawing.Size(887, 771);
            this.panelMainPanel.TabIndex = 1;
            // 
            // labelAlbumsPhotoCounter
            // 
            this.labelAlbumsPhotoCounter.AutoSize = true;
            this.labelAlbumsPhotoCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelAlbumsPhotoCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumsPhotoCounter.Location = new System.Drawing.Point(70, 658);
            this.labelAlbumsPhotoCounter.Name = "labelAlbumsPhotoCounter";
            this.labelAlbumsPhotoCounter.Size = new System.Drawing.Size(51, 32);
            this.labelAlbumsPhotoCounter.TabIndex = 6;
            this.labelAlbumsPhotoCounter.Text = "0/0";
            // 
            // pictureBoxPictureFromAlbum
            // 
            this.pictureBoxPictureFromAlbum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPictureFromAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPictureFromAlbum.Location = new System.Drawing.Point(76, 180);
            this.pictureBoxPictureFromAlbum.Name = "pictureBoxPictureFromAlbum";
            this.pictureBoxPictureFromAlbum.Size = new System.Drawing.Size(549, 460);
            this.pictureBoxPictureFromAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPictureFromAlbum.TabIndex = 5;
            this.pictureBoxPictureFromAlbum.TabStop = false;
            this.pictureBoxPictureFromAlbum.Click += new System.EventHandler(this.pictureBoxPictureFromAlbum_Click);
            // 
            // buttonDisplayAlbum
            // 
            this.buttonDisplayAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayAlbum.Location = new System.Drawing.Point(545, 109);
            this.buttonDisplayAlbum.Name = "buttonDisplayAlbum";
            this.buttonDisplayAlbum.Size = new System.Drawing.Size(161, 56);
            this.buttonDisplayAlbum.TabIndex = 4;
            this.buttonDisplayAlbum.Text = "Display";
            this.buttonDisplayAlbum.UseVisualStyleBackColor = true;
            this.buttonDisplayAlbum.Click += new System.EventHandler(this.buttonDisplayAlbum_Click);
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.DataSource = this.albumBindingSource;
            this.comboBoxAlbums.DisplayMember = "Name";
            this.comboBoxAlbums.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(76, 120);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(463, 38);
            this.comboBoxAlbums.TabIndex = 3;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Albums and Photos";
            // 
            // FormAlbumsAndPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 771);
            this.Controls.Add(this.panelMainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAlbumsAndPhotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook - Albums & Photos";
            this.panelMainPanel.ResumeLayout(false);
            this.panelMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureFromAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainPanel;
        private System.Windows.Forms.Label labelAlbumsPhotoCounter;
        private System.Windows.Forms.PictureBox pictureBoxPictureFromAlbum;
        private System.Windows.Forms.Button buttonDisplayAlbum;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource albumBindingSource;
    }
}