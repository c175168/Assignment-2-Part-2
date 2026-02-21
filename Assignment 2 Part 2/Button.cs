using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_2_Part_2
{
    internal class Button
    {
        // atributes
        private string _buttonText;
        private int _numclick;
        private Random _rng;


        // constructer
        public Button (string buttonTextIn, int numclickIn)
        {
            
            _buttonText = buttonTextIn;
            _numclick = numclickIn;
            

        }



    }
} 