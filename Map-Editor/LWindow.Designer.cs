/*
 * Created by SharpDevelop.
 * User: Muhammet
 * Date: 1/5/2014
 * Time: 20:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Map_Editor
{
partial class LWindow
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
			this.lstDATA = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lstDATA
			// 
			this.lstDATA.BackColor = System.Drawing.Color.LightGray;
			this.lstDATA.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstDATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstDATA.ForeColor = System.Drawing.Color.Black;
			this.lstDATA.FormattingEnabled = true;
			this.lstDATA.ItemHeight = 16;
			this.lstDATA.Location = new System.Drawing.Point(12, 12);
			this.lstDATA.Name = "lstDATA";
			this.lstDATA.Size = new System.Drawing.Size(243, 224);
			this.lstDATA.Sorted = true;
			this.lstDATA.TabIndex = 1;
			// 
			// LWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(269, 246);
			this.Controls.Add(this.lstDATA);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "RawData";
			this.TopMost = true;
			this.ResumeLayout(false);
		}
		internal System.Windows.Forms.ListBox lstDATA;
	}
}
