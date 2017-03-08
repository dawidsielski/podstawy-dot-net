using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Form1 : Form
    {
        interface IAccelerate
        {
            int Accelerate(int change);
        }
        interface IDive
        {
            int Dive(int change);
        }
        interface IRise
        {
            int Rise(int change);
        }

        class Car
        {

        }
        class Submarine
        {

        }
        class Plane
        {

        }
        class Computer
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
