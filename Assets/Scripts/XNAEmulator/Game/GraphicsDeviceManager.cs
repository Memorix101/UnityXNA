using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
    class GraphicsDeviceManager
    {
        private Game game;

        private int _preferredBackBufferHeight;
        private int _preferredBackBufferWidth;

        public GraphicsDevice GraphicsDevice
        {
            get
            {
                return game.GraphicsDevice;
            }
        }

        public GraphicsDeviceManager(Game game)
        {
            // TODO: Complete member initialization
            this.game = game;
        }

        public int PreferredBackBufferWidth
        {
            get
            {
                return _preferredBackBufferWidth;
            }
            set
            {
                //_shouldApplyChanges = true;
                _preferredBackBufferWidth = value;
            }
        }

        public int PreferredBackBufferHeight
        {
            get
            {
                return _preferredBackBufferHeight;
            }
            set
            {
                //_shouldApplyChanges = true;
                _preferredBackBufferHeight = value;
            }
        }
    }
}
