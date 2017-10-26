using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;


namespace X_Projection
{
    public partial class MainPage : UserControl
    {
		private double RotateIncrement = 60;
		private double RotateDistance;
		
		
        public MainPage()
        {
            InitializeComponent();
			
			RotateDistance = RotateIncrement;
			btnRotateUp.Click +=new System.Windows.RoutedEventHandler(btnRotateUp_Click);
			btnRotateDown.Click +=new System.Windows.RoutedEventHandler(btnRotateDown_Click);
        }

        private void btnRotateUp_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			
			Banner0_Rotate.To -= RotateDistance;
			Banner00_Rotate.To -= RotateDistance;
			Banner1_Rotate.To -= RotateDistance;
			Banner11_Rotate.To -= RotateDistance;
			Banner2_Rotate.To -= RotateDistance;
			Banner22_Rotate.To -= RotateDistance;
			Banner3_Rotate.To -= RotateDistance;
			Banner33_Rotate.To -= RotateDistance;
			Banner4_Rotate.To -= RotateDistance;
			Banner44_Rotate.To -= RotateDistance;
			Banner5_Rotate.To -= RotateDistance;
			Banner55_Rotate.To -= RotateDistance;
			
			
			Rotate.Begin();

			
        }

        private void btnRotateDown_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			
			Banner0_Rotate.To += RotateDistance;
			Banner00_Rotate.To += RotateDistance;
			Banner1_Rotate.To += RotateDistance;
			Banner11_Rotate.To += RotateDistance;
			Banner2_Rotate.To += RotateDistance;
			Banner22_Rotate.To += RotateDistance;
			Banner3_Rotate.To += RotateDistance;
			Banner33_Rotate.To += RotateDistance;
			Banner4_Rotate.To += RotateDistance;
			Banner44_Rotate.To += RotateDistance;
			Banner5_Rotate.To += RotateDistance;
			Banner55_Rotate.To += RotateDistance;
			
			
			Rotate.Begin();
			
			
        }
    }
}
