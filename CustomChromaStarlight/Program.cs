using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using ColoreColor = Corale.Colore.Core.Color;
namespace CustomChromaStarlight
{
    class Program
    {
        static void Main(string[] args)
        {




            Random rand = new Random();
            while (true)
            {
                // Select random key, set it to random color etc.
                for (int i = 0; i < rand.Next(1, 5); i++)
                {
                    try
                    {
                        Chroma.Instance.Keyboard[rand.Next(0, Constants.MaxRows), rand.Next(0, Constants.MaxColumns)] = new ColoreColor(rand.Next(1, 255), rand.Next(1, 255), rand.Next(1, 255));
                    }
                    catch (Exception e)
                    {

                    }

                }
                Thread.Sleep(500);

                //Keyboard.Instance.SetAll(new Color(0, 255, 0));
                Keyboard.Instance.SetAll(new Color(0, 0, 0));

            }
        }
    }
}
