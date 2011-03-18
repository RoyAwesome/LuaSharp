// 
// LuaScripts.cs
//  
// Author:
//       Jonathan Dickinson <jonathan@dickinsons.co.za>
// 
// Copyright (c) 2011 Copyright (c) 2011 Grounded Games
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.IO;

namespace LuaSharp.Tests
{
	/// <summary>
	/// Represents helpers for getting the Lua scripts.
	/// </summary>
	public static class LuaScripts
	{
		/// <summary>
		/// Gets a script from the assembly.
		/// </summary>
		/// <returns>
		/// The script stream.
		/// </returns>
		/// <param name='name'>
		/// The name of the script.
		/// </param>
		public static Stream GetScriptStream( string name )
		{
			name = string.Format( "{0}.lua", name );
			name = Path.Combine( Path.GetDirectoryName( typeof( LuaScripts ).Assembly.Location ), Path.Combine( "Scripts", name ) );
			return new FileStream( name, FileMode.Open );
		}
		
		/// <summary>
		/// Gets a script from the assembly.
		/// </summary>
		/// <returns>
		/// The script body.
		/// </returns>
		/// <param name='name'>
		/// The name of the script.
		/// </param>
		public static String GetScriptString( string name )
		{
			using( var stream = GetScriptStream( name ) )
			using( var reader = new StreamReader( stream ) )
			{
				return reader.ReadToEnd( );
			}
		}
	}
}

