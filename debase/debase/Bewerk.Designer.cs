
namespace debase
{
    partial class Bewerk
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
            this.uitkomstbpl = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.fotobox = new System.Windows.Forms.PictureBox();
            this.watchinvoer = new System.Windows.Forms.TextBox();
            this.ratedkiezen = new System.Windows.Forms.ComboBox();
            this.lengteinvoer = new System.Windows.Forms.TextBox();
            this.categoriekiezen = new System.Windows.Forms.ComboBox();
            this.omschrijvinginvoer = new System.Windows.Forms.TextBox();
            this.titelinvoer = new System.Windows.Forms.TextBox();
            this.omschrijving = new System.Windows.Forms.Label();
            this.Uitkomst = new System.Windows.Forms.Label();
            this.Categorie = new System.Windows.Forms.Label();
            this.Lengte = new System.Windows.Forms.Label();
            this.Where = new System.Windows.Forms.Label();
            this.Rated = new System.Windows.Forms.Label();
            this.Cijfer = new System.Windows.Forms.Label();
            this.Titel = new System.Windows.Forms.Label();
            this.cijferkiezen = new System.Windows.Forms.ComboBox();
            this.voegtoe = new System.Windows.Forms.Button();
            this.stoppen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotobox)).BeginInit();
            this.SuspendLayout();
            // 
            // uitkomstbpl
            // 
            this.uitkomstbpl.Location = new System.Drawing.Point(161, 219);
            this.uitkomstbpl.Name = "uitkomstbpl";
            this.uitkomstbpl.Size = new System.Drawing.Size(254, 27);
            this.uitkomstbpl.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 39;
            this.button1.Text = "Kies een foto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fotobox
            // 
            this.fotobox.Location = new System.Drawing.Point(656, 55);
            this.fotobox.Name = "fotobox";
            this.fotobox.Size = new System.Drawing.Size(163, 197);
            this.fotobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotobox.TabIndex = 38;
            this.fotobox.TabStop = false;
            // 
            // watchinvoer
            // 
            this.watchinvoer.Location = new System.Drawing.Point(161, 316);
            this.watchinvoer.Name = "watchinvoer";
            this.watchinvoer.PlaceholderText = "type...";
            this.watchinvoer.Size = new System.Drawing.Size(151, 27);
            this.watchinvoer.TabIndex = 37;
            this.watchinvoer.TextChanged += new System.EventHandler(this.watchinvoer_TextChanged);
            // 
            // ratedkiezen
            // 
            this.ratedkiezen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratedkiezen.FormattingEnabled = true;
            this.ratedkiezen.Items.AddRange(new object[] {
            "G General Audiences",
            "PG",
            "PG13",
            "R"});
            this.ratedkiezen.Location = new System.Drawing.Point(161, 270);
            this.ratedkiezen.Name = "ratedkiezen";
            this.ratedkiezen.Size = new System.Drawing.Size(151, 28);
            this.ratedkiezen.TabIndex = 36;
            // 
            // lengteinvoer
            // 
            this.lengteinvoer.Location = new System.Drawing.Point(161, 127);
            this.lengteinvoer.Name = "lengteinvoer";
            this.lengteinvoer.PlaceholderText = "type...";
            this.lengteinvoer.Size = new System.Drawing.Size(151, 27);
            this.lengteinvoer.TabIndex = 35;
            // 
            // categoriekiezen
            // 
            this.categoriekiezen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.categoriekiezen.TabIndex = 34;
            this.categoriekiezen.SelectedIndexChanged += new System.EventHandler(this.categoriekiezen_SelectedIndexChanged);
            // 
            // omschrijvinginvoer
            // 
            this.omschrijvinginvoer.Location = new System.Drawing.Point(358, 54);
            this.omschrijvinginvoer.Multiline = true;
            this.omschrijvinginvoer.Name = "omschrijvinginvoer";
            this.omschrijvinginvoer.PlaceholderText = "Maximaal 125 woorden...";
            this.omschrijvinginvoer.Size = new System.Drawing.Size(228, 141);
            this.omschrijvinginvoer.TabIndex = 33;
            // 
            // titelinvoer
            // 
            this.titelinvoer.Location = new System.Drawing.Point(161, 29);
            this.titelinvoer.Name = "titelinvoer";
            this.titelinvoer.PlaceholderText = "type...";
            this.titelinvoer.Size = new System.Drawing.Size(151, 27);
            this.titelinvoer.TabIndex = 32;
            // 
            // omschrijving
            // 
            this.omschrijving.AutoSize = true;
            this.omschrijving.Location = new System.Drawing.Point(398, 16);
            this.omschrijving.Name = "omschrijving";
            this.omschrijving.Size = new System.Drawing.Size(141, 20);
            this.omschrijving.TabIndex = 31;
            this.omschrijving.Text = "Kleine omschrijving:";
            // 
            // Uitkomst
            // 
            this.Uitkomst.AutoSize = true;
            this.Uitkomst.Location = new System.Drawing.Point(7, 224);
            this.Uitkomst.Name = "Uitkomst";
            this.Uitkomst.Size = new System.Drawing.Size(125, 20);
            this.Uitkomst.TabIndex = 30;
            this.Uitkomst.Text = "Tijd van uitkomst:";
            // 
            // Categorie
            // 
            this.Categorie.AutoSize = true;
            this.Categorie.Location = new System.Drawing.Point(11, 182);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(77, 20);
            this.Categorie.TabIndex = 29;
            this.Categorie.Text = "Categorie:";
            // 
            // Lengte
            // 
            this.Lengte.AutoSize = true;
            this.Lengte.Location = new System.Drawing.Point(11, 127);
            this.Lengte.Name = "Lengte";
            this.Lengte.Size = new System.Drawing.Size(135, 20);
            this.Lengte.TabIndex = 28;
            this.Lengte.Text = "Lengte van de film:";
            // 
            // Where
            // 
            this.Where.AutoSize = true;
            this.Where.Location = new System.Drawing.Point(7, 316);
            this.Where.Name = "Where";
            this.Where.Size = new System.Drawing.Size(116, 20);
            this.Where.TabIndex = 27;
            this.Where.Text = "Where to watch:";
            // 
            // Rated
            // 
            this.Rated.AutoSize = true;
            this.Rated.Location = new System.Drawing.Point(11, 270);
            this.Rated.Name = "Rated";
            this.Rated.Size = new System.Drawing.Size(51, 20);
            this.Rated.TabIndex = 26;
            this.Rated.Text = "Rated:";
            // 
            // Cijfer
            // 
            this.Cijfer.AutoSize = true;
            this.Cijfer.Location = new System.Drawing.Point(11, 83);
            this.Cijfer.Name = "Cijfer";
            this.Cijfer.Size = new System.Drawing.Size(47, 20);
            this.Cijfer.TabIndex = 25;
            this.Cijfer.Text = "Cijfer:";
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Location = new System.Drawing.Point(11, 32);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(41, 20);
            this.Titel.TabIndex = 24;
            this.Titel.Text = "Titel:";
            // 
            // cijferkiezen
            // 
            this.cijferkiezen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cijferkiezen.TabIndex = 23;
            // 
            // voegtoe
            // 
            this.voegtoe.BackColor = System.Drawing.Color.DarkSalmon;
            this.voegtoe.BackgroundImage = global::debase.Properties.Resources.buttontoevoegknip;
            this.voegtoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voegtoe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.voegtoe.Location = new System.Drawing.Point(347, 357);
            this.voegtoe.Name = "voegtoe";
            this.voegtoe.Size = new System.Drawing.Size(136, 70);
            this.voegtoe.TabIndex = 22;
            this.voegtoe.Text = "Pas aan!";
            this.voegtoe.UseVisualStyleBackColor = false;
            this.voegtoe.Click += new System.EventHandler(this.voegtoe_Click);
            // 
            // stoppen
            // 
            this.stoppen.BackColor = System.Drawing.Color.PeachPuff;
            this.stoppen.Location = new System.Drawing.Point(715, 408);
            this.stoppen.Name = "stoppen";
            this.stoppen.Size = new System.Drawing.Size(128, 59);
            this.stoppen.TabIndex = 21;
            this.stoppen.Text = "Stoppen";
            this.stoppen.UseVisualStyleBackColor = false;
            this.stoppen.Click += new System.EventHandler(this.stoppen_Click);
            // 
            // Bewerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::debase.Properties.Resources.toevoeg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 482);
            this.Controls.Add(this.uitkomstbpl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotobox);
            this.Controls.Add(this.watchinvoer);
            this.Controls.Add(this.ratedkiezen);
            this.Controls.Add(this.lengteinvoer);
            this.Controls.Add(this.categoriekiezen);
            this.Controls.Add(this.omschrijvinginvoer);
            this.Controls.Add(this.titelinvoer);
            this.Controls.Add(this.omschrijving);
            this.Controls.Add(this.Uitkomst);
            this.Controls.Add(this.Categorie);
            this.Controls.Add(this.Lengte);
            this.Controls.Add(this.Where);
            this.Controls.Add(this.Rated);
            this.Controls.Add(this.Cijfer);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.cijferkiezen);
            this.Controls.Add(this.voegtoe);
            this.Controls.Add(this.stoppen);
            this.Name = "Bewerk";
            this.Text = "Bewerk";
            this.Load += new System.EventHandler(this.Bewerk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uitkomstbpl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox fotobox;
        private System.Windows.Forms.TextBox watchinvoer;
        private System.Windows.Forms.ComboBox ratedkiezen;
        private System.Windows.Forms.TextBox lengteinvoer;
        private System.Windows.Forms.ComboBox categoriekiezen;
        private System.Windows.Forms.TextBox omschrijvinginvoer;
        private System.Windows.Forms.TextBox titelinvoer;
        private System.Windows.Forms.Label omschrijving;
        private System.Windows.Forms.Label Uitkomst;
        private System.Windows.Forms.Label Categorie;
        private System.Windows.Forms.Label Lengte;
        private System.Windows.Forms.Label Where;
        private System.Windows.Forms.Label Rated;
        private System.Windows.Forms.Label Cijfer;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.ComboBox cijferkiezen;
        private System.Windows.Forms.Button voegtoe;
        private System.Windows.Forms.Button stoppen;
    }
}