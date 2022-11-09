
namespace debase
{
    partial class reviewpage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "herres",
            "vandaag",
            "best lang",
            "veeel tekst",
            "idfk",
            "hellyeah",
            "hetflix",
            "een 6"}, -1, System.Drawing.SystemColors.InactiveCaptionText, System.Drawing.Color.Empty, null);
            this.button1 = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pagereview = new System.Windows.Forms.ListView();
            this.Titelmovie = new System.Windows.Forms.ColumnHeader();
            this.uitkomstmovie = new System.Windows.Forms.ColumnHeader();
            this.Lengtemovie = new System.Windows.Forms.ColumnHeader();
            this.Smallomschrijving = new System.Windows.Forms.ColumnHeader();
            this.ratedmovie = new System.Windows.Forms.ColumnHeader();
            this.categoriemovie = new System.Windows.Forms.ColumnHeader();
            this.plaatsmovie = new System.Windows.Forms.ColumnHeader();
            this.cijfermovie = new System.Windows.Forms.ColumnHeader();
            this.bewerkbttn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.categoriezoeken = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cijferzoeken = new System.Windows.Forms.ComboBox();
            this.titelzoeken = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(513, 456);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(155, 60);
            this.Filter.TabIndex = 1;
            this.Filter.Text = "Zoeken";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Verwijderen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 16);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::debase.Properties.Resources.Marvel_Logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(0, 436);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::debase.Properties.Resources.Disney_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(313, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::debase.Properties.Resources._20th_century;
            this.pictureBox3.Location = new System.Drawing.Point(478, 438);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(190, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::debase.Properties.Resources.warnerbors;
            this.pictureBox4.Location = new System.Drawing.Point(665, 438);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::debase.Properties.Resources.paramount;
            this.pictureBox5.Location = new System.Drawing.Point(810, 436);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(137, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::debase.Properties.Resources.schermfoto1;
            this.pictureBox6.Location = new System.Drawing.Point(206, 436);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(125, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pagereview
            // 
            this.pagereview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pagereview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titelmovie,
            this.uitkomstmovie,
            this.Lengtemovie,
            this.Smallomschrijving,
            this.ratedmovie,
            this.categoriemovie,
            this.plaatsmovie,
            this.cijfermovie});
            this.pagereview.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pagereview.FullRowSelect = true;
            this.pagereview.HideSelection = false;
            this.pagereview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.pagereview.Location = new System.Drawing.Point(0, 0);
            this.pagereview.Name = "pagereview";
            this.pagereview.Size = new System.Drawing.Size(947, 430);
            this.pagereview.TabIndex = 12;
            this.pagereview.UseCompatibleStateImageBehavior = false;
            this.pagereview.View = System.Windows.Forms.View.Details;
            this.pagereview.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Titelmovie
            // 
            this.Titelmovie.Text = "Titel";
            this.Titelmovie.Width = 90;
            // 
            // uitkomstmovie
            // 
            this.uitkomstmovie.Text = "Uitkomst";
            this.uitkomstmovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uitkomstmovie.Width = 100;
            // 
            // Lengtemovie
            // 
            this.Lengtemovie.Text = "Lengte";
            this.Lengtemovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lengtemovie.Width = 100;
            // 
            // Smallomschrijving
            // 
            this.Smallomschrijving.Text = "Omschrijving";
            this.Smallomschrijving.Width = 200;
            // 
            // ratedmovie
            // 
            this.ratedmovie.Text = "Rated";
            this.ratedmovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ratedmovie.Width = 100;
            // 
            // categoriemovie
            // 
            this.categoriemovie.Text = "Categorie";
            this.categoriemovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoriemovie.Width = 100;
            // 
            // plaatsmovie
            // 
            this.plaatsmovie.Text = "Plaats";
            this.plaatsmovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.plaatsmovie.Width = 100;
            // 
            // cijfermovie
            // 
            this.cijfermovie.Text = "Cijfer";
            this.cijfermovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cijfermovie.Width = 100;
            // 
            // bewerkbttn
            // 
            this.bewerkbttn.Location = new System.Drawing.Point(286, 456);
            this.bewerkbttn.Name = "bewerkbttn";
            this.bewerkbttn.Size = new System.Drawing.Size(97, 60);
            this.bewerkbttn.TabIndex = 13;
            this.bewerkbttn.Text = "Bewerk";
            this.bewerkbttn.UseVisualStyleBackColor = true;
            this.bewerkbttn.Visible = false;
            this.bewerkbttn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(389, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 60);
            this.button4.TabIndex = 16;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // categoriezoeken
            // 
            this.categoriezoeken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriezoeken.FormattingEnabled = true;
            this.categoriezoeken.Items.AddRange(new object[] {
            "Horror",
            "Fantasie",
            "Actie",
            "Romance",
            "Humor",
            "Superhero",
            "Documantaire",
            "Dramas",
            "Scifi",
            "Animation"});
            this.categoriezoeken.Location = new System.Drawing.Point(674, 488);
            this.categoriezoeken.Name = "categoriezoeken";
            this.categoriezoeken.Size = new System.Drawing.Size(130, 28);
            this.categoriezoeken.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Refresh!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // cijferzoeken
            // 
            this.cijferzoeken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cijferzoeken.FormattingEnabled = true;
            this.cijferzoeken.Items.AddRange(new object[] {
            "Disappointed",
            "Bad",
            "Alright",
            "Good",
            "Very good",
            "Amazing",
            "Perfect "});
            this.cijferzoeken.Location = new System.Drawing.Point(674, 454);
            this.cijferzoeken.Name = "cijferzoeken";
            this.cijferzoeken.Size = new System.Drawing.Size(130, 28);
            this.cijferzoeken.TabIndex = 18;
            this.cijferzoeken.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // titelzoeken
            // 
            this.titelzoeken.Location = new System.Drawing.Point(810, 473);
            this.titelzoeken.Name = "titelzoeken";
            this.titelzoeken.PlaceholderText = "Titel zoeken...";
            this.titelzoeken.Size = new System.Drawing.Size(137, 27);
            this.titelzoeken.TabIndex = 19;
            this.titelzoeken.TextChanged += new System.EventHandler(this.titelzoeken_TextChanged);
            // 
            // reviewpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::debase.Properties.Resources.star_wars_backgrounds_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.titelzoeken);
            this.Controls.Add(this.cijferzoeken);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.categoriezoeken);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bewerkbttn);
            this.Controls.Add(this.pagereview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Name = "reviewpage";
            this.Size = new System.Drawing.Size(947, 552);
            this.Load += new System.EventHandler(this.reviewpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ListView pagereview;
        private System.Windows.Forms.ColumnHeader Titel;
        private System.Windows.Forms.ColumnHeader uitkomst;
        private System.Windows.Forms.ColumnHeader Titelmovie;
        private System.Windows.Forms.ColumnHeader uitkomstmovie;
        private System.Windows.Forms.ColumnHeader Lengtemovie;
        private System.Windows.Forms.ColumnHeader Smallomschrijving;
        private System.Windows.Forms.ColumnHeader ratedmovie;
        private System.Windows.Forms.ColumnHeader categoriemovie;
        private System.Windows.Forms.ColumnHeader plaatsmovie;
        private System.Windows.Forms.ColumnHeader cijfermovie;
        private System.Windows.Forms.Button bewerkbttn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox categoriezoeken;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cijferzoeken;
        private System.Windows.Forms.TextBox titelzoeken;
    }
}
