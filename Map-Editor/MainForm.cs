/*
 * Created by SharpDevelop.
 * User: Muhammet
 * Date: 1/5/2014
 * Time: 20:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

namespace Map_Editor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		#region Tiles
		static int 
			TileSize = 25,
			MaxX	 = 50,
			MaxY	 = 35;
		int [] 
		TilesX = new int[MaxX],
		TilesY = new int[MaxY];
		#endregion
		
		#region Draw Rectangle
		internal List<Rectangle> listRec = new List<Rectangle>();
		Rectangle rect = new Rectangle(0,0,TileSize,TileSize);
		#endregion
		
		
		Map m = new Map();
		//color
		SolidBrush color = new SolidBrush(Color.Gray);
		SolidBrush Eraser = new SolidBrush(Color.LightGray);
		
		public int mx,my;
		internal List<String> ClippedCoords = new List<string>();
		Bitmap Background;
		Graphics gBackground;
		Bitmap EditMap;
		Graphics gEditMap;

		
		#region Main Contructor
		public MainForm()
		{
			InitializeComponent();
			msPaint.Size = new Size(TileSize * MaxX + 1, TileSize * MaxY + 1);
			LSTDebug.Size = new Size(181,TileSize * MaxY + 1);
			LSTDebug.Location = new Point(msPaint.Width +1,30);
			this.Size = new Size(msPaint.Width + 6, msPaint.Height + 51);
			EditMap = new Bitmap(msPaint.ClientSize.Width,msPaint.ClientSize.Height,PixelFormat.Format32bppArgb);
			Background = new Bitmap(msPaint.ClientSize.Width,msPaint.ClientSize.Height,PixelFormat.Format32bppArgb);
			gEditMap = Graphics.FromImage(EditMap);
			gBackground = Graphics.FromImage(Background);
			PaintTiles();
			TileType.SelectedIndex = 0;
		}
		#endregion
		
		void PaintTiles()
		{
			bool LoadTiles = false;
			if (!LoadTiles){
			for(int x = 0; x < TilesX.Length; x++)
			{
				rect.X = x * rect.Width;
			for(int y = 0; y < TilesY.Length; y++)
			{
				rect.Y = y * rect.Height;
				listRec.Add(rect);
				if (y == TilesY.Length)
					break;
			}
				if (x == TilesX.Length)
					break;
			}
			
				foreach (Rectangle rec in listRec)
        		{
					gBackground.DrawRectangle(new Pen(Color.White),rec);
					int x = rec.X / TileSize;
					int y = rec.Y / TileSize;
					gBackground.DrawString("X:" + x.ToString() + "\r\nY:"+ y.ToString(),new Font("Arial",8,FontStyle.Italic | FontStyle.Regular),new SolidBrush(Color.Black),rec.X,rec.Y);
					if(x == MaxX-1 && y == MaxY-1)
						LoadTiles = true;
				}
			}
		}

		void MsPaintPaint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawImage(EditMap, 0, 0, EditMap.Width,EditMap.Height);
			e.Graphics.DrawImage(Background, 0, 0, EditMap.Width,EditMap.Height);
			LSTDebug.DataSource = ClippedCoords.Distinct().ToList();
			LSTDebug.Update();
		}
			
		void MsPaintMouseDown(object sender, MouseEventArgs e)
		{
			//
			mx = e.X /TileSize;
			my = e.Y /TileSize;
			coord.Text = "X[" + mx +"] Y[" + my + "]";
				switch(e.Button)
				{	
					case MouseButtons.Left:
						if(mx < 0 || my < 0 || mx > MaxX-1 || my > MaxY-1)
						{	
						} else {
							checkShit();
							lock (syncRoot)
							gEditMap.FillRectangle(color, mx * TileSize,my * TileSize,TileSize,TileSize);
							ClippedCoords.Add("[" + TileType.SelectedIndex +  "](" + mx + "," + my + ")");
							msPaint.Invalidate();
						}
						break;
					case MouseButtons.Right:
							checkShit();
							lock (syncRoot)
							gEditMap.FillRectangle(Eraser, mx * TileSize,my * TileSize,TileSize,TileSize);
							msPaint.Invalidate();
						break;
						
				}
		}
		void checkShit()
		{
			var CheckList = ClippedCoords.RemoveAll(delegate(string s) { 
			return s.Contains("(" + mx + "," + my + ")");});
		}

		void MsPaintMouseMove(object sender, MouseEventArgs e)
		{
			mx = e.X /TileSize;
			my = e.Y /TileSize;
			coord.Text = "X[" + mx +"] Y[" + my + "]";

				switch(e.Button)
				{
					case MouseButtons.Left:
						if(mx < 0 || my < 0 || mx > MaxX-1 || my > MaxY-1)
						{	
						} else {
							checkShit();
							lock (syncRoot)
							gEditMap.FillRectangle(color, mx * TileSize,my * TileSize,TileSize,TileSize);
							ClippedCoords.Add("[" + TileType.SelectedIndex +  "](" + mx + "," + my + ")");
							msPaint.Invalidate();
						}
						break;
					case MouseButtons.Right:
						if(mx < 0 || my < 0 || mx > MaxX-1 || my > MaxY-1)
						{	
						} else {
							checkShit();
							lock (syncRoot)
							gEditMap.FillRectangle(Eraser, mx * TileSize,my * TileSize,TileSize,TileSize);
							msPaint.Invalidate();
						}
						break;
				}
		}
		/*
 		* Wall
		* Grass
		* Water
		* Lava
		* Earth
		*/
		
		void TileTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			TileColor(TileType.SelectedIndex);
		}
		
		
		void TileColor(int i)
		{
			switch(i)
			{
				case 0:
					color = new SolidBrush(Color.LightSlateGray);
					break;
				case 1:
					color = new SolidBrush(Color.LightGreen);
					break;
				case 2:
					color = new SolidBrush(Color.LightSkyBlue);
					break;
				case 3:
					color = new SolidBrush(Color.Orange);
					break;
				case 4:
					color = new SolidBrush(Color.SaddleBrown);
					break;
			}
		}
		
		List<int> temp = new List<int>();
		
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog Open = new OpenFileDialog();
			Open.Title = "Open Map File";
			Open.Filter = "Map File|*.dat";
			if (Open.ShowDialog(this) == DialogResult.OK)
			{
				ClippedCoords.AddRange(m.LoadMap(Open.FileName));
				LoadTheMap();
				LSTDebug.DataSource = ClippedCoords.Distinct().ToList();
				LSTDebug.Update();	
				
			} else {
				
			}
		}
		
		private static object syncRoot = new Object();
		void LoadTheMap()
		{
				for (int i = 0; i < ClippedCoords.Count; i++)
				{				
					string MapData = ClippedCoords[i];
                    string TiType = MapData;
                    if(MapData == null)
                    	break;
                    if(TiType == null)
                    	break;
					TiType = TiType.Substring(1,1);
					MapData = MapData.Substring(4,MapData.Length -5);
					string[] ClipMap = MapData.Split(',');
						foreach (string Clip in ClipMap)
						{
							temp.Add(Convert.ToInt32(TiType));
							temp.Add(Convert.ToInt32(Clip));
						}
				}
					for (int b = 0; b < temp.Count -1; b+=4)
            		{					
							TileColor(temp[b]);
							lock (syncRoot)
							gEditMap.FillRectangle(color, temp[b+1] * TileSize,temp[b+3] * TileSize,TileSize,TileSize);
							msPaint.Invalidate();
							TileColor(TileType.SelectedIndex);
					}
		}
		
		void SaveToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			SaveFileDialog Save = new SaveFileDialog();
			Save.Title = "Save Map As";
			Save.Filter = "Map File|*.dat";
			if (Save.ShowDialog(this) == DialogResult.OK)
			{
				ClippedCoords.Distinct();
				ClippedCoords.Sort();
				m.SaveMap(Save.FileName, ClippedCoords.ToArray());
			} else {
				
			}
		}
		
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			ClippedCoords.Clear();
			LSTDebug.DataSource = ClippedCoords.Distinct().ToList();
			LSTDebug.Update();	
			gEditMap.Clear(Color.LightGray);
			msPaint.Invalidate();
			
		}
		
		void ShowDebugToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (showDebugToolStripMenuItem.Checked)
			{
				LSTDebug.Visible = true;
				this.Size = new Size(msPaint.Width + LSTDebug.Width + 6, msPaint.Height + 51);
				showDebugToolStripMenuItem.Text = "Hide Debugger";
			} else {
				LSTDebug.Visible = false;
				this.Size = new Size(msPaint.Width + 6, msPaint.Height + 51);
				showDebugToolStripMenuItem.Text = "Show Debugger";
			}
		}
	}
}