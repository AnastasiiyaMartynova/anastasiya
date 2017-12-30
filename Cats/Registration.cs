using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cats
{
    public partial class Registration : Form
    {
        private List<Cat> cats;
        public Registration()
        {
            InitializeComponent();
            cats = new List<Cat>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(nameBox.TextLength < 1)
                return;
            cats.Add(CatsAPI.addCat(nameBox.Text, (CatsAPI.CatType)catTypeBox.SelectedIndex));
        }

        private void catsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatsAPI.Meow(catsList.TabIndex);
        }
    }
}
