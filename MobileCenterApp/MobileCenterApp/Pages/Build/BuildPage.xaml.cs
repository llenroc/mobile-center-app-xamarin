﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileCenterApp
{
	public partial class BuildPage : BasePage
	{
		public BuildPage()
		{
			InitializeComponent();
		}
		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			((ListView)sender).SelectedItem = null;
			var item = e.SelectedItem as Branch;
			if (item == null)
				return;
			await (BindingContext as BuildViewModel)?.BranchSelected(item);
		}
	}
}
