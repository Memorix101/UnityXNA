using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Microsoft.Xna.Framework.Input
{
    public static class Keyboard
    {
		static UnityEngine.InputSystem.Key[] keyMapping;

		static Keyboard()
		{
			keyMapping = new UnityEngine.InputSystem.Key[256];
			
			// Alphabet
			keyMapping[(int)Keys.A] = UnityEngine.InputSystem.Key.A;
			keyMapping[(int)Keys.B] = UnityEngine.InputSystem.Key.B;
			keyMapping[(int)Keys.C] = UnityEngine.InputSystem.Key.C;
			keyMapping[(int)Keys.D] = UnityEngine.InputSystem.Key.D;
			keyMapping[(int)Keys.E] = UnityEngine.InputSystem.Key.E;
			keyMapping[(int)Keys.F] = UnityEngine.InputSystem.Key.F;
			keyMapping[(int)Keys.G] = UnityEngine.InputSystem.Key.G;
			keyMapping[(int)Keys.H] = UnityEngine.InputSystem.Key.H;
			keyMapping[(int)Keys.I] = UnityEngine.InputSystem.Key.I;
			keyMapping[(int)Keys.J] = UnityEngine.InputSystem.Key.J;
			keyMapping[(int)Keys.K] = UnityEngine.InputSystem.Key.K;
			keyMapping[(int)Keys.L] = UnityEngine.InputSystem.Key.L;
			keyMapping[(int)Keys.M] = UnityEngine.InputSystem.Key.M;
			keyMapping[(int)Keys.N] = UnityEngine.InputSystem.Key.N;
			keyMapping[(int)Keys.O] = UnityEngine.InputSystem.Key.O;
			keyMapping[(int)Keys.P] = UnityEngine.InputSystem.Key.P;
			keyMapping[(int)Keys.Q] = UnityEngine.InputSystem.Key.Q;
			keyMapping[(int)Keys.R] = UnityEngine.InputSystem.Key.R;
			keyMapping[(int)Keys.S] = UnityEngine.InputSystem.Key.S;
			keyMapping[(int)Keys.T] = UnityEngine.InputSystem.Key.T;
			keyMapping[(int)Keys.U] = UnityEngine.InputSystem.Key.U;
			keyMapping[(int)Keys.V] = UnityEngine.InputSystem.Key.V;
			keyMapping[(int)Keys.W] = UnityEngine.InputSystem.Key.W;
			keyMapping[(int)Keys.X] = UnityEngine.InputSystem.Key.X;
			keyMapping[(int)Keys.Y] = UnityEngine.InputSystem.Key.Y;
			keyMapping[(int)Keys.Z] = UnityEngine.InputSystem.Key.Z;

			// Main number keys
			keyMapping[(int)Keys.D0] = UnityEngine.InputSystem.Key.Digit0;
			keyMapping[(int)Keys.D1] = UnityEngine.InputSystem.Key.Digit1;
			keyMapping[(int)Keys.D2] = UnityEngine.InputSystem.Key.Digit2;
			keyMapping[(int)Keys.D3] = UnityEngine.InputSystem.Key.Digit3;
			keyMapping[(int)Keys.D4] = UnityEngine.InputSystem.Key.Digit4;
			keyMapping[(int)Keys.D5] = UnityEngine.InputSystem.Key.Digit5;
			keyMapping[(int)Keys.D6] = UnityEngine.InputSystem.Key.Digit6;
			keyMapping[(int)Keys.D7] = UnityEngine.InputSystem.Key.Digit7;
			keyMapping[(int)Keys.D8] = UnityEngine.InputSystem.Key.Digit8;
			keyMapping[(int)Keys.D9] = UnityEngine.InputSystem.Key.Digit9;

			// Others
			keyMapping[(int)Keys.Enter] = UnityEngine.InputSystem.Key.Enter;
			keyMapping[(int)Keys.Delete] = UnityEngine.InputSystem.Key.Delete;
			keyMapping[(int)Keys.Space] = UnityEngine.InputSystem.Key.Space;
			keyMapping[(int)Keys.Left] = UnityEngine.InputSystem.Key.LeftArrow;
			keyMapping[(int)Keys.Right] = UnityEngine.InputSystem.Key.RightArrow;
			keyMapping[(int)Keys.Up] = UnityEngine.InputSystem.Key.UpArrow;
			keyMapping[(int)Keys.Down] = UnityEngine.InputSystem.Key.DownArrow;

            // TODO: More key code conversions
        }

		internal static KeyboardState GetState()
        {
			bool[] keyStates = new bool[256];
			
			for (int i = 0; i < keyStates.Length; i++)
			{
				if(keyMapping[i] != UnityEngine.InputSystem.Key.None)
				{
					//keyStates[i] = UnityEngine.Input.GetKey(keyMapping[i]);
                    keyStates[i] = UnityEngine.InputSystem.Keyboard.current[keyMapping[i]].isPressed;
                }
			}
			
            return new KeyboardState(keyStates);
        }
    }
}