namespace BookStore
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            this.iconButtonSeller = new FontAwesome.Sharp.IconButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.iconButtonBack);
            this.bunifuGradientPanel1.Controls.Add(this.iconButtonSeller);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-2, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(485, 700);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // iconButtonBack
            // 
            this.iconButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.iconButtonBack.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBack.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.iconButtonBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButtonBack.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonBack.IconSize = 40;
            this.iconButtonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBack.Location = new System.Drawing.Point(132, 604);
            this.iconButtonBack.Name = "iconButtonBack";
            this.iconButtonBack.Size = new System.Drawing.Size(176, 56);
            this.iconButtonBack.TabIndex = 13;
            this.iconButtonBack.Text = "Back";
            this.iconButtonBack.UseVisualStyleBackColor = false;
            this.iconButtonBack.Click += new System.EventHandler(this.iconButtonBack_Click);
            // 
            // iconButtonSeller
            // 
            this.iconButtonSeller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(138)))), ((int)(((byte)(198)))));
            this.iconButtonSeller.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSeller.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.iconButtonSeller.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButtonSeller.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonSeller.IconSize = 55;
            this.iconButtonSeller.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSeller.Location = new System.Drawing.Point(95, 385);
            this.iconButtonSeller.Name = "iconButtonSeller";
            this.iconButtonSeller.Size = new System.Drawing.Size(305, 74);
            this.iconButtonSeller.TabIndex = 12;
            this.iconButtonSeller.Text = "Admin";
            this.iconButtonSeller.UseVisualStyleBackColor = false;
            this.iconButtonSeller.Click += new System.EventHandler(this.iconButtonSeller_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(482, 694);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private FontAwesome.Sharp.IconButton iconButtonBack;
        private FontAwesome.Sharp.IconButton iconButtonSeller;
    }
}