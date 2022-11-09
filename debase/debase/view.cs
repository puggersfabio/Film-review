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

    
    public partial class view : Form
    {
        filmDB db = new filmDB();
        private int id;
        defilms itemverwijder;

        public string fileContent;
        public string filePath;
        public view(int _id)
        {
            id = _id;

            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {

            /*   deze functie zorgt ervoor dat je in groot en een aparte box alle items groot en goed ziet zonder te kunnen aanpassen   */

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

            
            Titellabel.Text = itemverwijder.naam;
            uitkomstlabel.Text = itemverwijder.uitkomst;
            Lengtelabel.Text = itemverwijder.lengte;
            Omschrijvinglabel.Text = itemverwijder.krtomschrijving;
            Wherelabel.Text = itemverwijder.place;                
            ratedkiezen.SelectedIndex = (int)itemverwijder.rated;
            categoriekiezen.SelectedIndex = (int)itemverwijder.categorie;
            cijferkiezen.SelectedIndex = (int)itemverwijder.cijfer;
            fotobox.Image = new Bitmap(itemverwijder.image_url.ToString());


        }

        private void stoppen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fotobox_Click(object sender, EventArgs e)
        {

        }
    }
}
