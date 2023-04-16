using System;
using UnityEngine;

namespace Microsoft.Xna.Framework
{
    class UnityGameWindow : GameWindow
    {
        public override bool AllowUserResizing
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public override void BeginScreenDeviceChange(bool willBeFullScreen)
        {
            throw new NotImplementedException();
        }
        public override Rectangle ClientBounds
        {
            //get { throw new NotImplementedException(); }
            get
            {
                if (!Application.isEditor)
                {
                   return new Rectangle(Screen.mainWindowPosition.x, Screen.mainWindowPosition.y, Screen.height, Screen.width);
                }
                else
                {
                   return new Rectangle(0, 0, Screen.height, Screen.width);
                }
            }
        }
        public override void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight)
        {
            throw new NotImplementedException();
        }
        public override IntPtr Handle
        {
            get { throw new NotImplementedException(); }
        }
        public override string ScreenDeviceName
        {
            get { throw new NotImplementedException(); }
        }
        protected override void SetTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
