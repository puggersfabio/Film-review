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
    public partial class Bewerk : Form
    {
        /*   zorgt ervoor dat de geselecteerde item de id naar voren brengt   */

        private int id;
        defilms itemverwijder;
        filmDB db = new filmDB();
        public Bewerk(int _id)
        {
            id = _id;

            InitializeComponent();
        }

        private void Bewerk_Load(object sender, EventArgs e)
        {
            /*   deze functie zorgt ervoor dat alles geselecteerde items inladen   */


            var verwijder =
                from film in db.defilms
                where film.id == id
                select film;

            itemverwijder = verwijder.FirstOrDefault();

            if (itemverwijder == null)
            {
                Close();
                return;
            }

            titelinvoer.Text = itemverwijder.naam;
            uitkomstbpl.Text = itemverwijder.uitkomst;
            lengteinvoer.Text = itemverwijder.lengte;
            omschrijvinginvoer.Text = itemverwijder.krtomschrijving;
            watchinvoer.Text = itemverwijder.place;
            ratedkiezen.SelectedIndex = (int)itemverwijder.rated;
            categoriekiezen.SelectedIndex = (int)itemverwijder.categorie;
            cijferkiezen.SelectedIndex = (int)itemverwijder.cijfer;
        }

        private void stoppen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void voegtoe_Click(object sender, EventArgs e)
        {

            /*   zorgt ervoor dat alles wat is ingevoerd aanpast in de database   */

            itemverwijder.naam = titelinvoer.Text;
            itemverwijder.uitkomst = uitkomstbpl.Text;
            itemverwijder.lengte = lengteinvoer.Text;
            itemverwijder.krtomschrijving = omschrijvinginvoer.Text;
            itemverwijder.place = watchinvoer.Text;
            itemverwijder.rated = (Ratedenum)ratedkiezen.SelectedIndex;
            itemverwijder.categorie = (Categorieenum)categoriekiezen.SelectedIndex;
            itemverwijder.cijfer = (Cijferenum)cijferkiezen.SelectedIndex;

          await  db.SaveChangesAsync();

            Close();

        }

        private void watchinvoer_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoriekiezen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
