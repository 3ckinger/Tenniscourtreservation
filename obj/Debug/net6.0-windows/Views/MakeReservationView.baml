   M S B A M L   `   `   `  ����Q  MTenniscourtreservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tenniscourtreservation.ViewsTenniscourtreservation.Views  5      6    0Tenniscourtreservation.Views.MakeReservationView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Tenniscourtreservation.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5
      �   � IsSharedSizeScope$
  True��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    
  Header#��[  6!   $��Reservierung erstellen��6A   � 5   
   $��1��6   $��0 25 0 0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��Spielername:��6%   �� 5      $��1��6   $��0 10 0 0q�6#   ��65   �� *
Playername+ �� UpdateSourceTrigger$ PropertyChanged=�5!      � 5$   
   $��2��6   $��0 10 0 0q�6    5&      �� 5'      $
��auto �6    �� 5(      $
��auto �6     � ColumnDefinitions 5*      �� 5+      $
��auto �6#    z� SharedSizeGroup$ FirstColumn��60   �� 5,      $
��auto �6#   $ SecoundColumn��60   .+�5/      �� $��0��6   $��0��50      $��0 5 0 0q�51      $��Platz:��52      �� 54      $��0��6   $��1��55      $��10 5 0 0q�56      $��Seite:��57      �� 59      $��1��6   $��0��5:      $��0 5 0 0q�5;      ��5<      �� *CourtNumber+$ PropertyChanged=��� 5?      $��1��6   $��1��5@      $��10 5 0 0q�5A      ��5B      �� *	CourtSide+$ PropertyChanged=�5E      � 5G   
   $��3��6   $��0 10 0 0q�6    5I      �� 5J      $
��auto �6    �� 5K      $
��auto �6     5M      �� 5N      $
��auto �6#   $ FirstColumn��60   �� 5O      $
��auto �6#   $ SecoundColumn��60   .+�5R      �� $��0��6   $��0��5S      $��0 5 0 0q�5T      $��Start:��5U      �� 5W      $��0��6   $��1��5X      $��10 5 0 0q�5Y      $��Ende:��5Z      (  "System.Windows.Controls.DatePicker  5\      $��1��6   $��0��5]      $��0 5 0 0q�5^         SelectedDate 5_      �� *	StartTime+$ PropertyChanged=�  5b      $��1��6   $��1��5c      $��10 5 0 0q�5d       5e      �� *	EndTime+$ PropertyChanged=�5h      �� 5j   
   $��4��6   $��0 25 0 0q�6"    �� Orientation$ 
Horizontal=�64   .+�5l      �� $��Bestätigen��6[   ��6   �� *SumitCommand+$ PropertyChanged=�6[   �� 5m      $��5 0 0 0q�6   $��	Abbrechen��6H   ��6&   �� *CancelCommand+6H   5o      5q      5r      