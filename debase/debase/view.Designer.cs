
namespace debase
{
    partial class view
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
            this.label1 = new System.Windows.Forms.Label();
            this.fotobox = new System.Windows.Forms.PictureBox();
            this.ratedkiezen = new System.Windows.Forms.ComboBox();
            this.categoriekiezen = new System.Windows.Forms.ComboBox();
            this.omschrijving = new System.Windows.Forms.Label();
            this.Uitkomst = new System.Windows.Forms.Label();
            this.Categorie = new System.Windows.Forms.Label();
            this.Lengte = new System.Windows.Forms.Label();
            this.Where = new System.Windows.Forms.Label();
            this.Rated = new System.Windows.Forms.Label();
            this.Cijfer = new System.Windows.Forms.Label();
            this.Titel = new System.Windows.Forms.Label();
            this.cijferkiezen = new System.Windows.Forms.ComboBox();
            this.stoppen = new System.Windows.Forms.Button();
            this.Titellabel = new System.Windows.Forms.Label();
            this.Lengtelabel = new System.Windows.Forms.Label();
            this.uitkomstlabel = new System.Windows.Forms.Label();
            this.Wherelabel = new System.Windows.Forms.Label();
            this.Omschrijvinglabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotobox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // fotobox
            // 
            this.fotobox.Location = new System.Drawing.Point(614, 140);
            this.fotobox.Name = "fotobox";
            this.fotobox.Size = new System.Drawing.Size(207, 239);
            this.fotobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotobox.TabIndex = 37;
            this.fotobox.TabStop = false;
            this.fotobox.Click += new System.EventHandler(this.fotobox_Click);
            // 
            // ratedkiezen
            // 
            this.ratedkiezen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratedkiezen.Enabled = false;
            this.ratedkiezen.FormattingEnabled = true;
            this.ratedkiezen.Items.AddRange(new object[] {
            "G General Audiences",
            "PG",
            "PG13",
            "R"});
            this.ratedkiezen.Location = new System.Drawing.Point(161, 270);
            this.ratedkiezen.Name = "ratedkiezen";
            this.ratedkiezen.Size = new System.Drawing.Size(151, 28);
            this.ratedkiezen.TabIndex = 35;
            // 
            // categoriekiezen
            // 
            this.categoriekiezen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriekiezen.Enabled = false;
            this.categoriekiezen.FormattingEnabled = true;
            this.categoriekiezen.Items.AddRange(new object[] {
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
            this.categoriekiezen.Location = new System.Drawing.Point(161, 174);
            this.categoriekiezen.Name = "categoriekiezen";
            this.categoriekiezen.Size = new System.Drawing.Size(151, 28);
            this.categoriekiezen.TabIndex = 33;
            // 
            // omschrijving
            // 
            this.omschrijving.AutoSize = true;
            this.omschrijving.Location = new System.Drawing.Point(398, 16);
            this.omschrijving.Name = "omschrijving";
            this.omschrijving.Size = new System.Drawing.Size(141, 20);
            this.omschrijving.TabIndex = 30;
            this.omschrijving.Text = "Kleine omschrijving:";
            // 
            // Uitkomst
            // 
            this.Uitkomst.AutoSize = true;
            this.Uitkomst.Location = new System.Drawing.Point(7, 224);
            this.Uitkomst.Name = "Uitkomst";
            this.Uitkomst.Size = new System.Drawing.Size(125, 20);
            this.Uitkomst.TabIndex = 29;
            this.Uitkomst.Text = "Tijd van uitkomst:";
            // 
            // Categorie
            // 
            this.Categorie.AutoSize = true;
            this.Categorie.Location = new System.Drawing.Point(11, 182);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(77, 20);
            this.Categorie.TabIndex = 28;
            this.Categorie.Text = "Categorie:";
            // 
            // Lengte
            // 
            this.Lengte.AutoSize = true;
            this.Lengte.Location = new System.Drawing.Point(11, 127);
            this.Lengte.Name = "Lengte";
            this.Lengte.Size = new System.Drawing.Size(135, 20);
            this.Lengte.TabIndex = 27;
            this.Lengte.Text = "Lengte van de film:";
            // 
            // Where
            // 
            this.Where.AutoSize = true;
            this.Where.Location = new System.Drawing.Point(7, 316);
            this.Where.Name = "Where";
            this.Where.Size = new System.Drawing.Size(116, 20);
            this.Where.TabIndex = 26;
            this.Where.Text = "Where to watch:";
            // 
            // Rated
            // 
            this.Rated.AutoSize = true;
            this.Rated.Location = new System.Drawing.Point(11, 270);
            this.Rated.Name = "Rated";
            this.Rated.Size = new System.Drawing.Size(51, 20);
            this.Rated.TabIndex = 25;
            this.Rated.Text = "Rated:";
            // 
            // Cijfer
            // 
            this.Cijfer.AutoSize = true;
            this.Cijfer.Location = new System.Drawing.Point(11, 83);
            this.Cijfer.Name = "Cijfer";
            this.Cijfer.Size = new System.Drawing.Size(47, 20);
            this.Cijfer.TabIndex = 24;
            this.Cijfer.Text = "Cijfer:";
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Location = new System.Drawing.Point(11, 32);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(41, 20);
            this.Titel.TabIndex = 23;
            this.Titel.Text = "Titel:";
            // 
            // cijferkiezen
            // 
            this.cijferkiezen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cijferkiezen.Enabled = false;
            this.cijferkiezen.FormattingEnabled = true;
            this.cijferkiezen.Items.AddRange(new object[] {
            "Disappointed",
            "Bad",
            "Alright",
            "Good",
            "Very good",
            "Amazing",
            "Perfect "});
            this.cijferkiezen.Location = new System.Drawing.Point(161, 80);
            this.cijferkiezen.Name = "cijferkiezen";
            this.cijferkiezen.Size = new System.Drawing.Size(151, 28);
            this.cijferkiezen.TabIndex = 22;
            // 
            // stoppen
            // 
            this.stoppen.BackColor = System.Drawing.Color.PeachPuff;
            this.stoppen.Location = new System.Drawing.Point(376, 411);
            this.stoppen.Name = "stoppen";
            this.stoppen.Size = new System.Drawing.Size(128, 59);
            this.stoppen.TabIndex = 21;
            this.stoppen.Text = "Stoppen";
            this.stoppen.UseVisualStyleBackColor = false;
            this.stoppen.Click += new System.EventHandler(this.stoppen_Click);
            // 
            // Titellabel
            // 
            this.Titellabel.AutoSize = true;
            this.Titellabel.Location = new System.Drawing.Point(161, 32);
            this.Titellabel.Name = "Titellabel";
            this.Titellabel.Size = new System.Drawing.Size(50, 20);
            this.Titellabel.TabIndex = 40;
            this.Titellabel.Text = "label2";
            // 
            // Lengtelabel
            // 
            this.Lengtelabel.AutoSize = true;
            this.Lengtelabel.Location = new System.Drawing.Point(161, 127);
            this.Lengtelabel.Name = "Lengtelabel";
            this.Lengtelabel.Size = new System.Drawing.Size(50, 20);
            this.Lengtelabel.TabIndex = 42;
            this.Lengtelabel.Text = "label3";
            // 
            // uitkomstlabel
            // 
            this.uitkomstlabel.AutoSize = true;
            this.uitkomstlabel.Location = new System.Drawing.Point(161, 224);
            this.uitkomstlabel.Name = "uitkomstlabel";
            this.uitkomstlabel.Size = new System.Drawing.Size(50, 20);
            this.uitkomstlabel.TabIndex = 44;
            this.uitkomstlabel.Text = "label5";
            // 
            // Wherelabel
            // 
            this.Wherelabel.AutoSize = true;
            this.Wherelabel.Location = new System.Drawing.Point(161, 316);
            this.Wherelabel.Name = "Wherelabel";
            this.Wherelabel.Size = new System.Drawing.Size(50, 20);
            this.Wherelabel.TabIndex = 46;
            this.Wherelabel.Text = "label2";
            // 
            // Omschrijvinglabel
            // 
            this.Omschrijvinglabel.AutoSize = true;
            this.Omschrijvinglabel.Location = new System.Drawing.Point(398, 54);
            this.Omschrijvinglabel.Name = "Omschrijvinglabel";
            this.Omschrijvinglabel.Size = new System.Drawing.Size(50, 20);
            this.Omschrijvinglabel.TabIndex = 47;
            this.Omschrijvinglabel.Text = "label3";
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 482);
            this.Controls.Add(this.Omschrijvinglabel);
            this.Controls.Add(this.Wherelabel);
            this.Controls.Add(this.uitkomstlabel);
            this.Controls.Add(this.Lengtelabel);
            this.Controls.Add(this.Titellabel);
            this.Controls.Add(this.fotobox);
            this.Controls.Add(this.ratedkiezen);
            this.Controls.Add(this.categoriekiezen);
            this.Controls.Add(this.omschrijving);
            this.Controls.Add(this.Uitkomst);
            this.Controls.Add(this.Categorie);
            this.Controls.Add(this.Lengte);
            this.Controls.Add(this.Where);
            this.Controls.Add(this.Rated);
            this.Controls.Add(this.Cijfer);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.cijferkiezen);
            this.Controls.Add(this.stoppen);
            this.Controls.Add(this.label1);
            this.Name = "view";
            this.Text = "view";
            this.Load += new System.EventHandler(this.view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fotobox;
        private System.Windows.Forms.ComboBox ratedkiezen;
        private System.Windows.Forms.ComboBox categoriekiezen;
        private System.Windows.Forms.Label omschrijving;
        private System.Windows.Forms.Label Uitkomst;
        private System.Windows.Forms.Label Categorie;
        private System.Windows.Forms.Label Lengte;
        private System.Windows.Forms.Label Where;
        private System.Windows.Forms.Label Rated;
        private System.Windows.Forms.Label Cijfer;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.ComboBox cijferkiezen;
        private System.Windows.Forms.Button stoppen;
        private System.Windows.Forms.Label Titellabel;
        private System.Windows.Forms.Label Lengtelabel;
        private System.Windows.Forms.Label uitkomstlabel;
        private System.Windows.Forms.Label Wherelabel;
        private System.Windows.Forms.Label Omschrijvinglabel;
    }
}