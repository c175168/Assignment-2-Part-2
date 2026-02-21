using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Color = Microsoft.Xna.Framework.Color;
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
 
        private int _numclick;
        private Texture2D _buttonTexture;
        private Color _buttonColor;
        private bool _pressed;
        private SpriteFont _buttonFont;

        // constructer
        public Button (int numclickIn, Texture2D buttonTextureIn, Color buttonColorIn, SpriteFont buttonFont)
        {

            _numclick = numclickIn;
            _buttonTexture = buttonTextureIn;
            _buttonColor = buttonColorIn;
            Click();
            _buttonFont = buttonFont;
        }

        public void Click()
        {

            Random _rng = new Random();
            _numclick = _rng.Next(5, 11);
        }
        // accessor 
        public int GetButtonClick() { return _numclick; }

        public void Update()
        {
            Random _rng = new Random();
            if (_numclick > 0)
            {
                if (Mouse.GetState().LeftButton == ButtonState.Pressed && _pressed == true)
                {
                    _pressed = false;
                    _numclick--;
                    _buttonColor = new Color(_rng.Next(0, 129), _rng.Next(0, 129), _rng.Next(0, 129));
                }
                else if (Mouse.GetState().LeftButton == ButtonState.Released && _pressed == false)
                {
                    _pressed = true;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(_buttonTexture, new Vector2(50, 50), _buttonColor);

            if (_numclick > 0)
            {
                spriteBatch.DrawString(_buttonFont, "Clicks left: " + _numclick, new Vector2(500, 100), Color.Black);
            }
            else
            {
                spriteBatch.DrawString(_buttonFont, "you have no clicks left", new Vector2(500, 100), Color.Black);
            }

            spriteBatch.End();
        }

    }
} 