   M S B A M L   `   `   `  ����I  EFlightTracking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FlightTrackingFlightTracking  5      !    FlightTracking.FlightInfoUC   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:FlightTracking     5      -   5          >�Name$  	AirportUC��5      .��5
      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$	 img��5      $��2��6   $
��Left=�61   $	��117��6L   $��0,60,-0.4,0q�6Y   $��2��6n   $	��Top=�6   $	��250��6�   $.��(https://www.jetphotos.com/photo/10347730��6�   �� 5   
   -   5         ��Name$ originAirport��5      $��originAirport��6+   $
��Left=�6@   $��
10,9.8,0,0q�6[   $��1��6o   $	��Top=�6|   $��28��6�   $	��105��6�   �� 5   
   -   5        $ 
originCity��5      $��
originCity��6(   $
��Left=�6:   $��10,42.8,0,0q�6U   $��1��6j   $	��Top=�6w   $��28��6�   $	��105��6�   �� 5   
   -   5        $ destinationAiport��5      $��destinationAiport��6/   $
��Left=�6H   $��10.2,9.8,0,0q�6c   $��1��6y   $	��Top=�6�   $��28��6�   $	��105��6�   $��1��6�   �� 5   
   -   5        $ destinationCity��5      $��destinationCity��6-   $
��Left=�6D   $��10.2,42.8,0,0q�6_   $��1��6v   $	��Top=�6�   $��28��6�   $	��105��6�   $��1��6�   �� 5   
   -   5        $ 
flightCode��5      $��2��6)   $��
flightCode��6=   $
��Left=�6O   $��	10,10,0,0q�6j   $	��Top=�6}   $��27��6�   $	��230��6�   �� 5   
   -   5        $ airline��5      $��2��6&   $��originAirport��6:   $
��Left=�6O   $��	10,33,0,0q�6j   $	��Top=�6}   $��27��6�   $	��230��6�   �� 5   
   -	   5        $ schDep��5      $��ScheduledDeparture��6$   $
��Left=�6>   $��
10,9.8,0,0q�6Y   $��2��6m   $	��Top=�6z   $��28��6�   $	��105��6�   �� 5   
   -
   5        $ realDep��5      $��RealDepartue��6%   $
��Left=�69   $��10,48.8,0,0q�6T   $��2��6i   $	��Top=�6v   $��28��6�   $	��105��6�   �� 5   
   -   5        $ schArr��5      $��ScheduledArrival��6$   $
��Left=�6<   $��10.2,9.8,0,0q�6W   $��2��6m   $	��Top=�6z   $��28��6�   $	��105��6�   $��1��6�   �� 5   
   -   5        $ realArr��5      $��RealArrival��6%   $
��Left=�68   $��10.2,48.8,0,0q�6S   $��2��6j   $	��Top=�6w   $��28��6�   $	��105��6�   $��1��6�   5      5       