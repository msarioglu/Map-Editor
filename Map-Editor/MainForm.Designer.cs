/*
 * Created by SharpDevelop.
 * User: Muhammet
 * Date: 1/5/2014
 * Time: 20:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Map_Editor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.msPaint = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TileType = new System.Windows.Forms.ToolStripComboBox();
			this.coord = new System.Windows.Forms.ToolStripMenuItem();
			this.showDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LSTDebug = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.msPaint)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// msPaint
			// 
			this.msPaint.BackColor = System.Drawing.Color.LightGray;
			this.msPaint.Location = new System.Drawing.Point(0, 27);
			this.msPaint.Name = "msPaint";
			this.msPaint.Size = new System.Drawing.Size(1067, 690);
			this.msPaint.TabIndex = 0;
			this.msPaint.TabStop = false;
			this.msPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.MsPaintPaint);
			this.msPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MsPaintMouseDown);
			this.msPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MsPaintMouseMove);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.TileType,
									this.coord,
									this.showDebugToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1249, 27);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.openToolStripMenuItem,
									this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.openToolStripMenuItem.Text = "Open As";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.saveToolStripMenuItem.Text = "Save As";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// TileType
			// 
			this.TileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TileType.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.TileType.Items.AddRange(new object[] {
									"Wall",
									"Grass",
									"Water",
									"Lava",
									"Earth"});
			this.TileType.Name = "TileType";
			this.TileType.Size = new System.Drawing.Size(121, 23);
			this.TileType.SelectedIndexChanged += new System.EventHandler(this.TileTypeSelectedIndexChanged);
			// 
			// coord
			// 
			this.coord.Name = "coord";
			this.coord.Size = new System.Drawing.Size(64, 23);
			this.coord.Text = "X[0] Y[0]";
			// 
			// showDebugToolStripMenuItem
			// 
			this.showDebugToolStripMenuItem.CheckOnClick = true;
			this.showDebugToolStripMenuItem.Name = "showDebugToolStripMenuItem";
			this.showDebugToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
			this.showDebugToolStripMenuItem.Text = "Show Debugger";
			this.showDebugToolStripMenuItem.Click += new System.EventHandler(this.ShowDebugToolStripMenuItemClick);
			// 
			// LSTDebug
			// 
			this.LSTDebug.BackColor = System.Drawing.Color.LightGray;
			this.LSTDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LSTDebug.FormattingEnabled = true;
			this.LSTDebug.Location = new System.Drawing.Point(1068, 27);
			this.LSTDebug.Name = "LSTDebug";
			this.LSTDebug.Size = new System.Drawing.Size(181, 689);
			this.LSTDebug.Sorted = true;
			this.LSTDebug.TabIndex = 4;
			this.LSTDebug.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(1249, 717);
			this.Controls.Add(this.LSTDebug);
			this.Controls.Add(this.msPaint);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Snake - Map Editor";
			((System.ComponentModel.ISupportInitialize)(this.msPaint)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem showDebugToolStripMenuItem;
		private System.Windows.Forms.ListBox LSTDebug;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem coord;
		private System.Windows.Forms.ToolStripComboBox TileType;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.PictureBox msPaint;
		
	}
}