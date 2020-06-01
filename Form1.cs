using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Collections.ObjectModel;



using System.Windows.Forms;

namespace matchingpairs6
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k","k",
            "b","b","v","v","w","w","z","z"
        };
        private object tableLayoutPane11;

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();


        }

        private void AssignIconsToSquares()
        {

            foreach (Control control in tableLayoutPane11.Controls)
            {

                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);

                }
            }

        }

    }

}