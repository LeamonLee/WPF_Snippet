   M S B A M L   `   `   `  ����E  AmyDataGrid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:myDataGrid
myDataGrid  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   5clr-namespace:myDataGrid.ModelsmyDataGrid.Models  5   	       myDataGrid.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:myDataGrid     5   	   5ns&clr-namespace:System;assembly=mscorlib     5   	   2modelsclr-namespace:myDataGrid.Models     5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)    � 	Resources 5         myEnumDataProvider S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%u   &	        S� 5   
   $ 
GetValuess��68   "  6P    5      M� 5      $ models:Gender��6   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
myDataGrid��5       $��0��6   6      5   
   -   5        $��myDataGrid2��5       $��1��6      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	StudentId��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 68   �� *nID+  5      $
	 Name��6%   
 63   �� *	strName+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $	 IsSoccerPlayer��6)   
 6A   �� *bIsSoccerPlayer+4  .System.Windows.Controls.DataGridComboBoxColumn  5      $	 Gender��6)      SelectedItemBinding 69   �� *
emGender+   ItemsSource 6b   ��  �� Source# [  5!      5"      5#      