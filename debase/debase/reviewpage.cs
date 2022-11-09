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
    public partial class reviewpage : UserControl
    {
        public reviewpage()
        {
            InitializeComponent();
        }

        private void reviewpage_Load(object sender, EventArgs e)
        {
            filmDB db = new filmDB();


             var list = db.defilms.ToList();

             pagereview.Items.Clear();

            foreach (var i in list)
            {
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
              i.naam,
              i.uitkomst,
              i.lengte,
              i.krtomschrijving,
              i.rated.ToString(),
              i.categorie.ToString(),
              i.place,
              i.cijfer.ToString()}, -1);
                /*   */

                listViewItem1.Tag = i.id;

                pagereview.Items.Add(listViewItem1); 


            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            toevoegen f = new toevoegen();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pagereview.SelectedItems.Count == 0)
            {
                button3.Visible = false;
                bewerkbttn.Visible = false;
                button4.Visible = false;
            }
            else
            {
                button3.Visible = true;
                bewerkbttn.Visible = true;
                button4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        public void Filter_Click(object sender, EventArgs e)
        {
            filmDB db = new filmDB();



           IQueryable<defilms> list = db.defilms;


            /*   zorgt ervoor dat je kan zoeken naar de titel van de film   */
            if (titelzoeken.Text.Length > 0)
            {
                list = from i in db.defilms where i.naam == titelzoeken.Text select i;
            }
            /*   zorgt ervoor dat je kan zoeken naar de categorie van de film   */
            if (categoriezoeken.SelectedIndex > 0)
            {
                list = from i in db.defilms where i.categorie == (Categorieenum)categoriezoeken.SelectedIndex select i;
            }
            /*   zorgt ervoor dat je kan zoeken naar de cijfer van de film   */
            if (cijferzoeken.SelectedIndex > 0)
            {
                list = from i in db.defilms where i.cijfer == (Cijferenum)cijferzoeken.SelectedIndex select i;
            }

            pagereview.Items.Clear();

            /*  hierdoor kan je in de listbox alle items zien   */
            foreach (var i in list)
            {
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
              i.naam,
              i.uitkomst,
              i.lengte,
              i.krtomschrijving,
              i.rated.ToString(),
              i.categorie.ToString(),
              i.place,
              i.cijfer.ToString()}, -1);
                /*   */

                listViewItem1.Tag = i.id;

                pagereview.Items.Add(listViewItem1);


            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            /*  deze functie maakt het dat je items kan verwijderen uit de database   */
            filmDB db = new filmDB();

            if (pagereview.SelectedItems.Count == 0)
            {
                return;
            }

            var item = pagereview.SelectedItems[0];

            long id = (int)item.Tag;

            var verwijder =
                from film in db.defilms
                where film.id == id
                select film;

            var itemverwijder = verwijder.FirstOrDefault();

            if (itemverwijder == null)
            {
                return;
            }

            db.defilms.Remove(itemverwijder);

            await db.SaveChangesAsync();

            pagereview.Items.Remove(item);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            /*  dit refreshed de listview voor als je een item toevoegt   */
            if (pagereview.SelectedItems.Count == 0)
            {
                return;
            }

            var item = pagereview.SelectedItems[0];

            int id = (int)item.Tag;

            Bewerk bf = new Bewerk(id);

            bf.ShowDialog();
        }

        public void button2_Click_2(object sender, EventArgs e)
        {
            Update();
        }

        private void zoeken_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*   deze functie zorgt dat de je de gegevens op groot kunt zien   */
            if (pagereview.SelectedItems.Count == 0)
            {
                return;
            }

            var item = pagereview.SelectedItems[0];

            int id = (int)item.Tag;

            view bf = new view(id);

            bf.ShowDialog();
        }

        public void button2_Click_3(object sender, EventArgs e)
        {

            filmDB db = new filmDB();

            var list = db.defilms.ToList();

            pagereview.Items.Clear();

            foreach (var i in list)
            {
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
              i.naam,
              i.uitkomst,
              i.lengte,
              i.krtomschrijving,
              i.rated.ToString(),
              i.categorie.ToString(),
              i.place,
              i.cijfer.ToString()}, -1);
                /*  deze functie maakt het dat alle items in de database worden laten zien op de click van de button */

                listViewItem1.Tag = i.id;

                pagereview.Items.Add(listViewItem1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titelzoeken_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        
