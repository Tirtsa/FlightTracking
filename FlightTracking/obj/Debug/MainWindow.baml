   M S B A M L   `   `   `  ����I  EFlightTracking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FlightTrackingFlightTracking  5   	   d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 64       FlightTracking.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FlightTracking     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     64     � Title$  
MainWindow��5	   	   $	��700��6   $
��1400��6)    � 	Resources 5      '  !FlightTracking.SumFlightConverter   SumFlightConverter+  %Microsoft.Maps.MapControl.WPF.Pushpin �� 
TargetType  pushpinTemplate �� Property �� Value��%  &	        &	        5   
   6#   �� 5   
   "  6   .�5      ��  � �� 5      �� 5      pushpinControlTemplate��.R�5      �� $G��AC:\Users\tirts\source\repos\FlightTrackingNew\Images\airplane.png��6    5      5      5      5      .��5      � .+�5   
   '  !Microsoft.Maps.MapControl.WPF.Map  -   5          Name$ myMap��5      +  %Microsoft.Maps.MapControl.WPF.MapCore   Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$
 road 6      CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$r l8mfO2tXQwC9SsietmmVx~-TfhtpOy_Lyw8MrRYCCvLw~Ahwe66m1agNiuAbUg_zSfS1zWotIynZKHpdkzZeHF3bb8HiLvgfNh9h7CnZiYhHd 6+      Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 32.000454,34.870743 5      	   	ZoomLevel$		 5.0Q�61   
   AnimationLevel$

 None=�6A   $��250,75,9.6,10.4q�6W      Children. 5      3  -Microsoft.Maps.MapControl.WPF.MapItemsControl  -   5          Name$ pushpins��5       $��
0,0,-0.4,0q�6U   ��62   �� *
allFlights+��5      �� 5      .R�5          Name$ 	myPushpin��6$   #��[ 6U      Location 67   �� *
Location+5       5"      5$      5%      	   FlightTracking.AirportUC	  5&   
   -   5         	 Name$ MyAirportUC��5&      $
��Left=�6/   $	��425��6J   $��	10,75,0,0q�6W   $	��Top=�6j   $	��235��6�    � DataContext 5'      �� *SelectedFlight+�� 5)   
   -   5         ��Name$ 	isHoliday��5)      $
��Left=�6'   $��
1066,0,0,0q�6B   $
��Wrap=�6V   $	��Top=�6�   $	��157��6�   $��70��6�   ��6j   �� *	holiday+6�   5*      5+      