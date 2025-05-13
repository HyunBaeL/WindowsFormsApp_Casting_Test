using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Casting_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Animal dog = new Dog();
            dog.Name = "강아지";
            dog.Speak();
            ((Dog)dog).DogSound(); 

            Animal cat = new Cat();
            cat.Name = "고양이";
            cat.Speak();
            ((Cat)cat).CatSound();

            Animal Bird = new Bird();
            Bird.Name = "새";
            Bird.Speak();
            ((Bird)Bird).BirdSound();
        }
    }
}
