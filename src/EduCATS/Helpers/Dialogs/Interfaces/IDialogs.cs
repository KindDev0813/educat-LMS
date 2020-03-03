﻿using System.Threading.Tasks;

namespace EduCATS.Helpers.Dialogs.Interfaces
{
	public interface IDialogs
	{
		Task ShowMessage(string title, string message);
		Task ShowError(string message);
		void ShowLoading();
		void ShowLoading(string message);
		void HideLoading();
	}
}