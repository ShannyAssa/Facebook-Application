
namespace BasicFacebookFeatures.FacebookAppUI
{
    partial class FormPostsComposer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostsComposer));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPostType = new System.Windows.Forms.ComboBox();
            this.buttonShowFilteredPosts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 67);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter Posts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(237, 130);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(394, 36);
            this.dateTimePickerStart.TabIndex = 6;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(237, 193);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(394, 36);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Post Type:";
            // 
            // comboBoxPostType
            // 
            this.comboBoxPostType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPostType.FormattingEnabled = true;
            this.comboBoxPostType.Items.AddRange(new object[] {
            "link",
            "checkin",
            "status",
            "all posts"});
            this.comboBoxPostType.Location = new System.Drawing.Point(237, 255);
            this.comboBoxPostType.Name = "comboBoxPostType";
            this.comboBoxPostType.Size = new System.Drawing.Size(394, 37);
            this.comboBoxPostType.TabIndex = 9;
            // 
            // buttonShowFilteredPosts
            // 
            this.buttonShowFilteredPosts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowFilteredPosts.Location = new System.Drawing.Point(71, 327);
            this.buttonShowFilteredPosts.Name = "buttonShowFilteredPosts";
            this.buttonShowFilteredPosts.Size = new System.Drawing.Size(324, 62);
            this.buttonShowFilteredPosts.TabIndex = 10;
            this.buttonShowFilteredPosts.Text = "Show Filtered Posts";
            this.buttonShowFilteredPosts.UseVisualStyleBackColor = true;
            this.buttonShowFilteredPosts.Click += new System.EventHandler(this.buttonShowFilteredPosts_Click);
            // 
            // FormPostsComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 452);
            this.Controls.Add(this.buttonShowFilteredPosts);
            this.Controls.Add(this.comboBoxPostType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPostsComposer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook - Filter Posts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPostType;
        private System.Windows.Forms.Button buttonShowFilteredPosts;
    }
}