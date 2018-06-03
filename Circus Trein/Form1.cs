using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circus_Trein
{
    public partial class Form1 : Form
    {
        List<Animal> animals = new List<Animal>();


        public Form1()
        {
            InitializeComponent();
            animals.Add(new Animal("Carnivoor", "Small"));
            animals.Add(new Animal("Herbivorous", "Large"));
            animals.Add(new Animal("Carnivoor", "Small"));
            animals.Add(new Animal("Herbivorousr", "Medium"));
            animals.Add(new Animal("Herbivorous", "Medium"));
            animals.Add(new Animal("Carnivoor", "Small"));
            animals.Add(new Animal("Herbivorous", "Large"));
            animals.Add(new Animal("Carnivoor", "Large"));
            animals.Add(new Animal("Herbivorous", "Small"));
            animals.Add(new Animal("Carnivoor", "Medium"));
            animals.Add(new Animal("Carnivoor", "Small"));
            animals.Add(new Animal("Herbivorous", "Large"));
            animals.Add(new Animal("Carnivoor", "Large"));

            foreach (Animal animal in animals)
            {
                listBox1.Items.Add(animal.AnimalType + ", " + animal.AnimalSize);
            }
        }

        private void Updatelist()
        {
            listBox1.Items.Clear();
            foreach (Animal animal in animals)
            {
                listBox1.Items.Add(animal.AnimalType + ", " + animal.AnimalSize);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            var checkedRadio = new[] { groupBox1, groupBox2 }
                   .SelectMany(g => g.Controls.OfType<RadioButton>()
                                            .Where(r => r.Checked));
            var animal = checkedRadio.ToList();

            animals.Add(new Animal(animal[0].Text, animal[1].Text));
            Updatelist();
        }



        //private void AnimalType(object sender, EventArgs e)
        //{
        //    animals.Add(new Animal());
        //}
    }
}
