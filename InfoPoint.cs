﻿// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace MacOSApp_Game_2
{
	public partial class InfoPoint : NSViewController
	{
		string _currentText;
		int _charIndex;
		
		public InfoPoint(IntPtr handle) : base(handle)
		{
		}
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			// Make the corners rounded
			text_info_point.WantsLayer = true;
			if (text_info_point.Layer != null)
			{
				text_info_point.Layer.CornerRadius = 10f;

				var textColor = NSColor.White;
				text_info_point.TextColor = textColor;

				// Change the text field color
				var textFieldColor =
					NSColor.FromRgba(0x55 / 255f, 0xB0 / 255f, 0xFF / 255f, 1f); // Set the desired color
				text_info_point.BackgroundColor = textFieldColor;
				//55b0ff

				// Update the text field appearance
				text_info_point.Layer.BackgroundColor = textFieldColor.CGColor;
				text_info_point.Layer.BorderColor = textFieldColor.CGColor;
				text_info_point.Layer.BorderWidth = 1f;
			}

			// Set the font size to 14sp
			var fontSize = 14f;
			var font = NSFont.SystemFontOfSize(fontSize, NSFontWeight.Regular);
			text_info_point.Font = font;
		}
		
		readonly string[] _array121 = {"Чудово! Натиснувши на екран монітору, ти можеш дізнатись інформацію по " +
		                               "кожній зі спеціальностей, а також про університети, де їх викладають."};
		
		private int _click;
		
		partial void submit_dialog (NSButton sender)
		{
			if (_click < 1)
			{
				text_info_point.StringValue = "";
				_currentText = _array121[_click];
				_charIndex = 0;
				NSTimer.CreateRepeatingScheduledTimer(TimeSpan.FromMilliseconds(20), TimerAction);
				//dialog_121.StringValue = array_121[i];
				_click++;
			}
			if (_click >= 1)
			{
				sender.Enabled = false; // Disables the button
			}
		}
		void TimerAction(NSTimer timer)
		{
			if (_charIndex < _currentText.Length)
			{
				InvokeOnMainThread(() => {
					text_info_point.StringValue += _currentText[_charIndex];
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
