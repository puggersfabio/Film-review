using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debase
{
    public partial class toevoegen : Form
    {
        public string fileContent;
        public string filePath;
        public toevoegen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toevoegen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void omschrijving_TextChanged(object sender, EventArgs e)
        {
            omschrijvinginvoer.MaxLength = 125;
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            try
            {
                /*   allemaal expesies voor als een bepaalde vlak niet is ingevuld   */

                if (string.IsNullOrWhiteSpace(titelinvoer.Text))
                {
                    MessageBox.Show("Voer de titel van uw film in A.U.B.!");
                    return;
                }
                if(cijferkiezen.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecteer een cijfer voor uw film A.U.B.!");
                    return;
                }
                if (categoriekiezen.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecteer een categorie voor de film A.U.B.!");
                    return;
                }
                if (ratedkiezen.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecteer de Rating van de film A.U.B.!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(lengteinvoer.Text))
                {
                    MessageBox.Show("Voer de lengte van uw film in A.U.B.!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(uitkomstbpl.Text))
                {
                    MessageBox.Show("Voer de tijd van uitkomst van uw film in A.U.B.!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(omschrijvinginvoer.Text))
                {
                    MessageBox.Show("Voert u A.U.B. een kleine omschrijving van de film toe!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(watchinvoer.Text))
                {
                    MessageBox.Show("Voer de duur tijd van uw film in A.U.B.!");
                    return;
                }
              //        if (string)
               //      {
              //          MessageBox.Show("Voer de duur tijd van uw film in A.U.B.!");
               //         return;
                //    }


                /*   maakt connectie met de database   */

                filmDB db = new filmDB();

                defilms a = new defilms();

                /*   maakt de ingevoerde items naar een text en zet die dan in de database   */

                a.naam = titelinvoer.Text;
                a.uitkomst = uitkomstbpl.Text;
                a.lengte = lengteinvoer.Text;
                a.krtomschrijving = omschrijvinginvoer.Text;
                a.place = watchinvoer.Text;
                a.rated = (Ratedenum)ratedkiezen.SelectedIndex;
                a.categorie = (Categorieenum)categoriekiezen.SelectedIndex;
                a.cijfer = (Cijferenum)cijferkiezen.SelectedIndex;

                Guid uid = Guid.NewGuid();
                /*   deze functie zorgt ervoor dat de foto word opgeslagen in de database   */

                string bestandsnaam = uid.ToString() + ".jpg" + ".png";
                string bestandspad = @"c:\filmfotos\" + bestandsnaam;
                System.IO.File.Copy(filePath, bestandspad);

                a.image_url = bestandspad;

                db.defilms.Add(a);

               await db.SaveChangesAsync();

                var list = db.defilms.ToList();

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void omschrijving_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*   deze functie zorgt ervoor dat je in je bestanden kan kijken een JPG kan selecteren   */

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
               // openFileDialog.FilterIndex = 2;
               // openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    fotobox.Image = new Bitmap(filePath);

                    //  var image = Image.FromFile(selectedimage);


                    //   fotobox.Image = image;
                }
            }
        }

        private void fotobox_Click(object sender, EventArgs e)
        {

        }

        private void ratedkiezen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cijferkiezen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lengte_Click(object sender, EventArgs e)
        {

        }

        private void lengteinvoer_TextChanged(object sender, EventArgs e)
        {

        }

        private void titelinvoer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uitkomst_Click(object sender, EventArgs e)
        {

        }

        private void Where_Click(object sender, EventArgs e)
        {

        }

        private void watchinvoer_TextChanged(object sender, EventArgs e)
        {

        }

        private void uitkomstbpl_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
