
namespace debase
{
    partial class toevoegen
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
            this.stoppen = new System.Windows.Forms.Button();
            this.voegtoe = new System.Windows.Forms.Button();
            this.cijferkiezen = new System.Windows.Forms.ComboBox();
            this.Titel = new System.Windows.Forms.Label();
            this.Cijfer = new System.Windows.Forms.Label();
            this.Rated = new System.Windows.Forms.Label();
            this.Where = new System.Windows.Forms.Label();
            this.Lengte = new System.Windows.Forms.Label();
            this.Categorie = new System.Windows.Forms.Label();
            this.Uitkomst = new System.Windows.Forms.Label();
            this.omschrijving = new System.Windows.Forms.Label();
            this.titelinvoer = new System.Windows.Forms.TextBox();
            this.omschrijvinginvoer = new System.Windows.Forms.TextBox();
            this.categoriekiezen = new System.Windows.Forms.ComboBox();
            this.lengteinvoer = new System.Windows.Forms.TextBox();
            this.ratedkiezen = new System.Windows.Forms.ComboBox();
            this.watchinvoer = new System.Windows.Forms.TextBox();
            this.fotobox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uitkomstbpl = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.fotobox)).BeginInit();
            this.SuspendLayout();
            // 
            // stoppen
            // 
            this.stoppen.BackColor = System.Drawing.Color.PeachPuff;
            this.stoppen.Location = new System.Drawing.Point(720, 421);
            this.stoppen.Name = "stoppen";
            this.stoppen.Size = new System.Drawing.Size(128, 59);
            this.stoppen.TabIndex = 0;
            this.stoppen.Text = "Stoppen";
            this.stoppen.UseVisualStyleBackColor = false;
            this.stoppen.Click += new System.EventHandler(this.button1_Click);
            // 
            // voegtoe
            // 
            this.voegtoe.BackColor = System.Drawing.Color.DarkSalmon;
            this.voegtoe.BackgroundImage = global::debase.Properties.Resources.buttontoevoegknip;
            this.voegtoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voegtoe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.voegtoe.Location = new System.Drawing.Point(352, 370);
            this.voegtoe.Name = "voegtoe";
            this.voegtoe.Size = new System.Drawing.Size(136, 70);
            this.voegtoe.TabIndex = 1;
            this.voegtoe.Text = "Voeg toe!";
            this.voegtoe.UseVisualStyleBackColor = false;
            this.voegtoe.Click += new System.EventHandler(this.button2_Click);
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
            this.cijferkiezen.Location = new System.Drawing.Point(166, 93);
            this.cijferkiezen.Name = "cijferkiezen";
            this.cijferkiezen.Size = new System.Drawing.Size(151, 28);
            this.cijferkiezen.TabIndex = 2;
            this.cijferkiezen.SelectedIndexChanged += new System.EventHandler(this.cijferkiezen_SelectedIndexChanged);
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Location = new System.Drawing.Point(16, 45);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(41, 20);
            this.Titel.TabIndex = 3;
            this.Titel.Text = "Titel:";
            this.Titel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cijfer
            // 
            this.Cijfer.AutoSize = true;
            this.Cijfer.Location = new System.Drawing.Point(16, 96);
            this.Cijfer.Name = "Cijfer";
            this.Cijfer.Size = new System.Drawing.Size(47, 20);
            this.Cijfer.TabIndex = 4;
            this.Cijfer.Text = "Cijfer:";
            this.Cijfer.Click += new System.EventHandler(this.label2_Click);
            // 
            // Rated
            // 
            this.Rated.AutoSize = true;
            this.Rated.Location = new System.Drawing.Point(16, 283);
            this.Rated.Name = "Rated";
            this.Rated.Size = new System.Drawing.Size(51, 20);
            this.Rated.TabIndex = 5;
            this.Rated.Text = "Rated:";
            this.Rated.Click += new System.EventHandler(this.label3_Click);
            // 
            // Where
            // 
            this.Where.AutoSize = true;
            this.Where.Location = new System.Drawing.Point(12, 329);
            this.Where.Name = "Where";
            this.Where.Size = new System.Drawing.Size(116, 20);
            this.Where.TabIndex = 6;
            this.Where.Text = "Where to watch:";
            this.Where.Click += new System.EventHandler(this.Where_Click);
            // 
            // Lengte
            // 
            this.Lengte.AutoSize = true;
            this.Lengte.Location = new System.Drawing.Point(16, 140);
            this.Lengte.Name = "Lengte";
            this.Lengte.Size = new System.Drawing.Size(135, 20);
            this.Lengte.TabIndex = 7;
            this.Lengte.Text = "Lengte van de film:";
            this.Lengte.Click += new System.EventHandler(this.Lengte_Click);
            // 
            // Categorie
            // 
            this.Categorie.AutoSize = true;
            this.Categorie.Location = new System.Drawing.Point(16, 195);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(77, 20);
            this.Categorie.TabIndex = 8;
            this.Categorie.Text = "Categorie:";
            this.Categorie.Click += new System.EventHandler(this.label6_Click);
            // 
            // Uitkomst
            // 
            this.Uitkomst.AutoSize = true;
            this.Uitkomst.Location = new System.Drawing.Point(12, 237);
            this.Uitkomst.Name = "Uitkomst";
            this.Uitkomst.Size = new System.Drawing.Size(125, 20);
            this.Uitkomst.TabIndex = 9;
            this.Uitkomst.Text = "Tijd van uitkomst:";
            this.Uitkomst.Click += new System.EventHandler(this.Uitkomst_Click);
            // 
            // omschrijving
            // 
            this.omschrijving.AutoSize = true;
            this.omschrijving.Location = new System.Drawing.Point(403, 29);
            this.omschrijving.Name = "omschrijving";
            this.omschrijving.Size = new System.Drawing.Size(141, 20);
            this.omschrijving.TabIndex = 10;
            this.omschrijving.Text = "Kleine omschrijving:";
            this.omschrijving.Click += new System.EventHandler(this.omschrijving_Click);
            // 
            // titelinvoer
            // 
            this.titelinvoer.Location = new System.Drawing.Point(166, 42);
            this.titelinvoer.Name = "titelinvoer";
            this.titelinvoer.PlaceholderText = "type...";
            this.titelinvoer.Size = new System.Drawing.Size(151, 27);
            this.titelinvoer.TabIndex = 11;
            this.titelinvoer.TextChanged += new System.EventHandler(this.titelinvoer_TextChanged);
            // 
            // omschrijvinginvoer
            // 
            this.omschrijvinginvoer.Location = new System.Drawing.Point(363, 67);
            this.omschrijvinginvoer.Multiline = true;
            this.omschrijvinginvoer.Name = "omschrijvinginvoer";
            this.omschrijvinginvoer.PlaceholderText = "Maximaal 125 woorden...";
            this.omschrijvinginvoer.Size = new System.Drawing.Size(228, 141);
            this.omschrijvinginvoer.TabIndex = 12;
            this.omschrijvinginvoer.TextChanged += new System.EventHandler(this.omschrijving_TextChanged);
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
            this.categoriekiezen.Location = new System.Drawing.Point(166, 187);
            this.categoriekiezen.Name = "categoriekiezen";
            this.categoriekiezen.Size = new System.Drawing.Size(151, 28);
            this.categoriekiezen.TabIndex = 13;
            this.categoriekiezen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lengteinvoer
            // 
            this.lengteinvoer.Location = new System.Drawing.Point(166, 140);
            this.lengteinvoer.Name = "lengteinvoer";
            this.lengteinvoer.PlaceholderText = "type...";
            this.lengteinvoer.Size = new System.Drawing.Size(151, 27);
            this.lengteinvoer.TabIndex = 14;
            this.lengteinvoer.TextChanged += new System.EventHandler(this.lengteinvoer_TextChanged);
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
            this.ratedkiezen.Location = new System.Drawing.Point(166, 283);
            this.ratedkiezen.Name = "ratedkiezen";
            this.ratedkiezen.Size = new System.Drawing.Size(151, 28);
            this.ratedkiezen.TabIndex = 16;
            this.ratedkiezen.SelectedIndexChanged += new System.EventHandler(this.ratedkiezen_SelectedIndexChanged);
            // 
            // watchinvoer
            // 
            this.watchinvoer.Location = new System.Drawing.Point(166, 329);
            this.watchinvoer.Name = "watchinvoer";
            this.watchinvoer.PlaceholderText = "type...";
            this.watchinvoer.Size = new System.Drawing.Size(151, 27);
            this.watchinvoer.TabIndex = 17;
            this.watchinvoer.TextChanged += new System.EventHandler(this.watchinvoer_TextChanged);
            // 
            // fotobox
            // 
            this.fotobox.Location = new System.Drawing.Point(661, 68);
            this.fotobox.Name = "fotobox";
            this.fotobox.Size = new System.Drawing.Size(163, 197);
            this.fotobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotobox.TabIndex = 18;
            this.fotobox.TabStop = false;
            this.fotobox.Click += new System.EventHandler(this.fotobox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Kies een foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // uitkomstbpl
            // 
            this.uitkomstbpl.Location = new System.Drawing.Point(166, 232);
            this.uitkomstbpl.Name = "uitkomstbpl";
            this.uitkomstbpl.Size = new System.Drawing.Size(254, 27);
            this.uitkomstbpl.TabIndex = 20;
            this.uitkomstbpl.ValueChanged += new System.EventHandler(this.uitkomstbpl_ValueChanged);
            // 
            // toevoegen
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
            this.Name = "toevoegen";
            this.Text = "Toevoegen";
            this.Load += new System.EventHandler(this.toevoegen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stoppen;
        private System.Windows.Forms.Button voegtoe;
        private System.Windows.Forms.ComboBox cijferkiezen;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Label Cijfer;
        private System.Windows.Forms.Label Rated;
        private System.Windows.Forms.Label Where;
        private System.Windows.Forms.Label Lengte;
        private System.Windows.Forms.Label Categorie;
        private System.Windows.Forms.Label Uitkomst;
        private System.Windows.Forms.Label Omschrijving;
        private System.Windows.Forms.Label omschrijving;
        private System.Windows.Forms.TextBox titelinvoer;
        private System.Windows.Forms.TextBox omschrijvinginvoer;
        private System.Windows.Forms.ComboBox categoriekiezen;
        private System.Windows.Forms.TextBox lengteinvoer;
        private System.Windows.Forms.ComboBox ratedkiezen;
        private System.Windows.Forms.TextBox watchinvoer;
        private System.Windows.Forms.PictureBox fotobox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker uitkomstbpl;
    }
}