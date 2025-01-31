﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class DrawStringCall
{
    private SpriteFont font;
    private string value;
    private Vector2 position;
    private Vector4 color;
    private Viewport viewport;

    public SpriteFont Font {
		get {
			return this.font;
		}
	}

	public Vector2 Position {
		get {
			return this.position;
		}
	}

	public string Value {
		get {
			return this.value;
		}
	}

	public Vector4 Color {
		get {
			return this.color;
		}
	}

    public Viewport Viewport
    {
        get
        {
            return this.viewport;
        }
    }

    public DrawStringCall(SpriteFont font, string value, Vector2 position, Vector4 color, Viewport viewport)
    {
        this.font = font;
        this.value = value;
        this.position = position;
        this.color = color;
        this.viewport = viewport;
    }

}