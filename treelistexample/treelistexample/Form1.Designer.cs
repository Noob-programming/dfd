﻿namespace treelistexample
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.treeList1 = new DevExpress.XtraTreeList.TreeList();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeList1
			// 
			this.treeList1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.treeList1.Location = new System.Drawing.Point(0, 220);
			this.treeList1.Name = "treeList1";
			this.treeList1.Size = new System.Drawing.Size(828, 244);
			this.treeList1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 464);
			this.Controls.Add(this.treeList1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTreeList.TreeList treeList1;
	}
}

