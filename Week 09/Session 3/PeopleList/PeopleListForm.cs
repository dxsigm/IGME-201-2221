using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleAppGlobals;
using PeopleLib;
using EditPerson;

namespace WindowsPeopleApp
{
    public partial class PeopleListForm : Form
    {
        public PeopleListForm()
        {
            InitializeComponent();

            Globals.AddPeopleSampleData();

            this.peopleListView.KeyDown += new KeyEventHandler(PeopleListView__KeyDown);
            this.peopleListView.ItemActivate += new EventHandler(PeopleListView__ItemActivate);

            this.addBtn.Click += new EventHandler(AddBtn__Click);
            this.removeBtn.Click += new EventHandler(RemoveBtn__Click);
            this.exitBtn.Click += new EventHandler(ExitBtn__Click);

            PaintListView(null);
        }

        private void PeopleListView__KeyDown(object sender, KeyEventArgs e)
        {
            ListView lv = (ListView)sender;

            if( e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string email = lv.SelectedItems[0].Tag.ToString();

                Person person = null;

                person = Globals.people[email];

                this.Enabled = false;

                new PersonEditForm(person);
            }

        }

        private void PeopleListView__ItemActivate(object sender, EventArgs e)
        {

        }

        private void AddBtn__Click(object sender, EventArgs e)
        {

        }

        private void RemoveBtn__Click(object sender, EventArgs e)
        {

        }

        void ExitBtn__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void PaintListView(string firstEmail)
        {

        }
    }

}
