﻿namespace Xamarin.Forms
{
	public class LinearGradientBrush : GradientBrush
	{
		public static readonly BindableProperty StartPointProperty = BindableProperty.Create(
			nameof(StartPoint), typeof(Point), typeof(LinearGradientBrush), new Point(0, 0));

		public Point StartPoint
		{
			get => (Point)GetValue(StartPointProperty);
			set => SetValue(StartPointProperty, value);
		}

		public static readonly BindableProperty EndPointProperty = BindableProperty.Create(
			nameof(EndPoint), typeof(Point), typeof(LinearGradientBrush), new Point(1, 0));

		public Point EndPoint
		{
			get => (Point)GetValue(EndPointProperty);
			set => SetValue(EndPointProperty, value);
		}
	}
}