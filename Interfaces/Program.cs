using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    public class Car : IAccelerate, IRise
    {
        int acceleration;
        int rise;
        public void Accelerate(int change)
        {
            acceleration = change;
        }
        public void Rise(int change)
        {
            rise = change;
        }
    }
    public class Submarine : IDive, IAccelerate
    {
        int dive;
        int accelerate;
        public void Dive( int change)
        {
            dive = change;
        }
        public void Accelerate(int change)
        {
            accelerate = change;
        }
    }
    public class Plane: IRise, IDive
    {
        int rise;
        int dive;
        public void Rise(int change)
        {
            rise = change;
        }
        public void Dive(int change)
        {
            dive = change;
        }
    }
    public class Computer
    {

    }



    public interface IAccelerate
    {
        void Accelerate(int change);
    }

    public interface IDive
    {
        void Dive(int change);
    }

    public interface IRise
    {
        void Rise(int change);
    }
}
