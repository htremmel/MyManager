using System;
using System.Windows;

namespace MyManager.Controller
{

    public class IController
    {

    }
	/// <summary>
	/// Description of Controllers.
	/// </summary>
	public class Controllers: DependencyObject
	{
        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(Database.Project), new PropertyMetadata(0));

        
		public Controllers()
		{
		}
	}
}
