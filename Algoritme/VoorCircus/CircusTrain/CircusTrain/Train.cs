using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using CircusTrain.classes;

namespace CircusTrain
{
    public partial class Train : Form
    {
        private List<Animal> Animals { get; } = new List<Animal>();

        public Train()
        {
            InitializeComponent();
        }

        private void AddAnimalBTN_Click(object sender, EventArgs e)
        {
            var sizeButton = AnimalSizeGB.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var dietButton = AnimalDietGB.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            Diet dietName = (Diet)Diet.Parse(typeof(Diet), dietButton.Text);
            classes.Size animalSize = (classes.Size)Enum.Parse(typeof(classes.Size), sizeButton.Text);
            
            Animal animal = new Animal(animalSize, dietName);
            AnimalLB.Items.Add($"Animal size: {animal.AnimalSize} and diet: {animal.Diet}");
            Animals.Add(animal);
        }

        private void DivdeAnimalsBTN_Click(object sender, EventArgs e)
        {
            classes.Train train = new classes.Train();
            var divdeResult = train.PlaceAnimals(Animals);
        }
    }
}
