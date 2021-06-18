using Coalitie.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coalitie
{
    public partial class Form1 : Form
    {
        Election election = new Election();
        private string selectedPartyName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //voeg party toe aan verkiezing
            election.AddParty(PartijNaam.Text, (int)StemmenPartij.Value);
            VerkiezingsPartijen.Items.Add(PartijNaam.Text);

            //nieuwe partij erbij == button2 en 3 weer weg
            button2.Visible = false;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //voeg party toe aan coalitie
            selectedPartyName = VerkiezingsPartijen.SelectedItem.ToString();

            if (election.AddPartyToCoalition(selectedPartyName))
            {
                Coalition.Items.Add(selectedPartyName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bereken meerderheid
            if (election.CalculateMajority((int)MaxZetels.Value))
            {
                Meerderheid.Text = "Er is een meerderheid behaald";
            }
            else
            {
                Meerderheid.Text = "Er is geen meerderheid behaald";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //bereken zetel verdeling
            election.CalculateSeats((int)MaxZetels.Value, (int)Threshold.Value);
            election.CalculateRestSeats((int)MaxZetels.Value);

            button2.Visible = true;
            button1.Visible= true;
        }
    }
}
