using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> inventory = new List<Car>();
        Car newCar;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string year, make, colour, mileage;

            year = yearInput.Text;
            make = makeInput.Text;
            colour = colourInput.Text;
            mileage = mileageInput.Text;

            newCar = new Car(year, make, colour, mileage);
            inventory.Add(newCar);
            outputLabel.Text = "";



            for (int i = 0; i < inventory.Count(); i++)
            {
                outputLabel.Text += inventory[i].year + " "
                    + inventory[i].make + " "
                    + inventory[i].colour + " "
                    + inventory[i].mileage + "\n";
            }
        }
    }
}
