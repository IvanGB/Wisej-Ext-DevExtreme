﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxGallery : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxGallery()
		{
			InitializeComponent();

			this.dxGallery1.Widget.itemClick += new WidgetEventHandler(dxGallery1_WidgetEvent);
		}

		private void dxGallery1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}