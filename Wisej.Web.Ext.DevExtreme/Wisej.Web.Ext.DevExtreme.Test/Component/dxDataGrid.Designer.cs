﻿namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxDataGrid
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxDataGrid));
            Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
            this.dxDataGrid1 = new Wisej.Web.Ext.DevExtreme.dxDataGrid();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.buttonLoad = new Wisej.Web.Upload();
            this.buttonExport = new Wisej.Web.Button();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.checkBox6 = new Wisej.Web.CheckBox();
            this.checkBox7 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/DataGrid/Overview/";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Size = new System.Drawing.Size(250, 580);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox6, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox7, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 496);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxDataGrid1);
            this.panel.Size = new System.Drawing.Size(455, 580);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/DataGrid/SimpleArray/jQuery/L" +
    "ight/";
            // 
            // dxDataGrid1
            // 
            this.dxDataGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxDataGrid1.Location = new System.Drawing.Point(23, 18);
            this.dxDataGrid1.Name = "dxDataGrid1";
            this.dxDataGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxDataGrid1.Options"))));
            this.dxDataGrid1.Size = new System.Drawing.Size(406, 541);
            this.dxDataGrid1.TabIndex = 0;
            this.dxDataGrid1.Text = "dxDataGrid1";
            widgetFunction1.Name = "discountCellTemplate";
            widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
            this.dxDataGrid1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(28, 93);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Allow Column Resizing";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Allow Column Reordering";
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(28, 435);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 7;
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
            this.buttonExport.Location = new System.Drawing.Point(76, 435);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(28, 150);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 38);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Auto Navigate to Focused Row";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(28, 207);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(195, 38);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Cell Hint Enabled";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(28, 264);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(195, 38);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Column Auto Width";
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox6.AutoSize = false;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.Location = new System.Drawing.Point(28, 321);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(195, 38);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Column Hiding Enabled";
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox7.AutoSize = false;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox7.Location = new System.Drawing.Point(28, 378);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(195, 38);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Word Wrap Enabled";
            // 
            // dxDataGrid
            // 
            this.Name = "dxDataGrid";
            this.Size = new System.Drawing.Size(864, 770);
            this.Load += new System.EventHandler(this.dxDataGrid_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxDataGrid dxDataGrid1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private Upload buttonLoad;
		private Button buttonExport;
		private CheckBox checkBox3;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox7;
		private CheckBox checkBox6;
	}
}
