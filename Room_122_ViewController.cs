﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using Foundation;
using AppKit;

namespace MacOSApp_Game_2
{
	public partial class Room_122_ViewController : NSViewController
	{
		string _currentText;
		int _charIndex;
		
		public Room_122_ViewController(IntPtr handle) : base(handle)
		{
		}
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Make the corners rounded
			dialog_122.WantsLayer = true;
			if (dialog_122.Layer != null)
			{
				dialog_122.Layer.CornerRadius = 10f;

				var textColor = NSColor.White;
				dialog_122.TextColor = textColor;

				// Change the text field color
				var textFieldColor =
					NSColor.FromRgba(0xF8 / 255f, 0x8B / 255f, 0xCD / 255f, 1f);
				dialog_122.BackgroundColor = textFieldColor;
				// ED96CB
				// f88bcd

				// Update the text field appearance
				dialog_122.Layer.BackgroundColor = textFieldColor.CGColor;
				dialog_122.Layer.BorderColor = textFieldColor.CGColor;
				dialog_122.Layer.BorderWidth = 1f;
			}

			// Set the font size to 14sp
			var fontSize = 14f;
			var font = NSFont.SystemFontOfSize(fontSize, NSFontWeight.Regular);
			dialog_122.Font = font;
		}

		private readonly string[] _array121 =
		{
			"Чудово! Твоя мета – відсортувати масив за зростанням, використовуючи сортування бульбашкою. " , 
			"Не хвилюйся, якщо ніколи не виконував таке сортування. Ти можеш натиснути на знак питання поряд із " +
			"завданням і побачити, як це все працює. "+
			"Готовий? Тоді натискай на екран ноутбука, що стоїть на столі. Ти впораєшся!"
		};
		
		private int _click;
		
		partial void button_122_text_change (NSButton sender)
		{
			if (_click < 2)
			{
				dialog_122.StringValue = "";
				_currentText = _array121[_click];
				_charIndex = 0;
				NSTimer.CreateRepeatingScheduledTimer(TimeSpan.FromMilliseconds(20), TimerAction);
				//dialog_121.StringValue = array_121[i];
				_click++;
			}
			if (_click >= 2)
			{
				sender.Enabled = false; // Disables the button
			}
		}
		void TimerAction(NSTimer timer)
		{
			if (_charIndex < _currentText.Length)
			{
				InvokeOnMainThread(() => {
					dialog_122.StringValue += _currentText[_charIndex];
				});
				_charIndex++;
			}
			else
			{
				timer.Invalidate();
			}
		}

	}
}
