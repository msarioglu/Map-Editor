/*
 * Created by SharpDevelop.
 * User: Muhammet
 * Date: 1/5/2014
 * Time: 20:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.Windows;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

namespace Map_Editor
{
	public class Map
	{
		
		internal string MapData(string RawMapData)
		{
			return RawMapData;
		}
		/*
		static readonly string PasswordHash = "@r3Y0uG@y?321f5a9eq7d26sSfFSq2#F";
		static readonly string SaltKey 		= "y3z8964fd8a9213aB@$g3%%$#$&DFRda";
		static readonly string VIKey 		= "@!Fx@g%&si0@#%&S";*/
		
		internal string[] LoadMap(string FILENAME)
		{		
			return File.ReadAllLines(FILENAME);
		}
		
		internal void SaveMap(string FILENAME, string[] Data)
		{
			File.WriteAllLines(FILENAME,Data);
		}
		
		internal void ArchiveCreator(string DATA, string FILENAME)
		{
			if (File.Exists(FILENAME)){
				File.Delete(FILENAME);
			}
				using(FileStream fs = new FileStream(FILENAME, FileMode.CreateNew,FileAccess.ReadWrite))
				{
					var BYTES = Encoding.UTF8.GetBytes(DATA);
					fs.Write(BYTES,0,BYTES.Length);
					fs.Flush();
					fs.Close();
				}
		}
	}
}
