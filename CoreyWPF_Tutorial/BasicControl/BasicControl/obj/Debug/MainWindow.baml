   M S B A M L   `   `   `  ����G  CBasicControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BasicControlBasicControl  5   	       BasicControl.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BasicControl     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��36(�61   $��WPF Demo��5      $��3��6$   $��0,0,0,10q�68   �� 5    
   $��1��6   $��2��6$   $��SemiBold"�61   $��
First Name��5!      $��Segoe UI)�6&   �� 5#   
   -   5         ��Name$ txtFirstName��5#      $��2��6(   $��2��68   $	��150��6E   $��10q�6Q   �� 5%   
   -   5         ��Name$ 
myComboBox��5%      $��1��6'   $��3��67   $��2��6D   $��10q�6X   ��5&      �� 5'      .R�5*      ��  �� Orientation$ 
Horizontal=�6!   .+�5+      �� $"��./assets/images/headshot.png��6    $��20��6F   $��20��6R   �� 5,      ��6$   �� *strFirstName+�� 5-      $�� ��6$   �� 5.      ��6$   �� *strLastName+5/      51      53      �� 55   
   -   5         ��Name$ submitButton��55      $��Submit��6'   $��1��68   $��2��6H   $��4��56      $��10q�6   �� 5H   
   $��1��6   $��4��6$   $��6��64   .��5I      �� $ Vertical=�6   .+�5J      �� $	��200��6   $	��200��6(   $"��./assets/images/headshot.png��67   �� 5K      $	��200��6   $	��200��6(   $"��./assets/images/headshot.png��67   �� 5L      $	��200��6   $	��200��6(   $"��./assets/images/headshot.png��67   5M      5N      5P      5Q      