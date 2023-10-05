
namespace BasicFacebookFeatures.FacebookAppUI
{
    partial class FormPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosts));
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 67);
            this.label3.TabIndex = 26;
            this.label3.Text = "Posts";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.Color.White;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(40, 181);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(579, 244);
            this.listBoxPosts.TabIndex = 27;
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 619);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPosts";
            this.Text = "Facebook - Posts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxPosts;
    }
}