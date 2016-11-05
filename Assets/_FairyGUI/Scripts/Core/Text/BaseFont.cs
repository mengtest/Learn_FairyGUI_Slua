﻿using UnityEngine;

namespace FairyGUI
{
	/// <summary>
	/// Base class for all kind of fonts. 
	/// </summary>
	public class BaseFont
	{
		/// <summary>
		/// The name of this font object.
		/// </summary>
		public string name { get; protected set; }

		/// <summary>
		/// The texture of this font object.
		/// </summary>
		public NTexture mainTexture;

		/// <summary>
		///  Can this font be tinted? Will be true for dynamic font and fonts generated by BMFont.
		/// </summary>
		public bool canTint;

		/// <summary>
		/// Can this font be lighted? 
		/// </summary>
		/// <seealso cref="UIConfig.renderingTextBrighterOnDesktop"/>
		public bool canLight;

		/// <summary>
		/// Can this font be stroked? Will be false for Bitmap fonts.
		/// </summary>
		public bool canOutline;

		/// <summary>
		/// Font generated by BMFont use channels.
		/// </summary>
		public bool hasChannel;

		/// <summary>
		/// If true, it will use extra vertices to enhance bold effect
		/// </summary>
		public bool customBold;

		/// <summary>
		/// If true, it will use extra vertices to enhance bold effect ONLY when it is in italic style.
		/// </summary>
		public bool customBoldAndItalic;

		/// <summary>
		/// The shader for this font object.
		/// </summary>
		public string shader;

		public PackageItem packageItem;

		virtual public void SetFormat(TextFormat format, float fontSizeScale)
		{
		}

		virtual public void PrepareCharacters(string text)
		{
		}

		virtual public bool GetGlyphSize(char ch, out int width, out int height)
		{
			width = 0;
			height = 0;
			return false;
		}

		virtual public bool GetGlyph(char ch, GlyphInfo glyph)
		{
			return false;
		}

		public BaseFont()
		{
		}
	}

	/// <summary>
	/// Character info.
	/// </summary>
	public class GlyphInfo
	{
		public Rect vert;
		public Vector2 uvBottomLeft;
		public Vector2 uvBottomRight;
		public Vector2 uvTopLeft;
		public Vector2 uvTopRight;
		public int width;
		public int height;
		public int channel;
	}
}
