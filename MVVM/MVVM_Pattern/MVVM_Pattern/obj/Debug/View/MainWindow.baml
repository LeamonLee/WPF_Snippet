   M S B A M L   `   `   `  ����G  CMVVM_Pattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MVVM_PatternMVVM_Pattern  5   	   ?$clr-namespace:MVVM_Pattern.ConverterMVVM_Pattern.Converter  5   	       MVVM_Pattern.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MVVM_Pattern     5   	   3cv$clr-namespace:MVVM_Pattern.Converter     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)    � 	Resources 5      *   $MVVM_Pattern.Converter.DateConverter   dteConverter �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%�   &	        '��        5   
   6   �� 5   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 60   �� #	 Z $2
 ,(Validation.Errors).CurrentItem.ErrorContent�5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $��* �6    � ColumnDefinitions 5$   
   �� 5%      $
��auto �6   �� 5&      $��* �6   .+�5)   
   �� $��0��6   $��0��6!   $��	FirstName��61   $��Center=�6B   �� 5*   
   $��0��6   $��1��6   $	��100��6/   $��Center=�6;   ��6X   �� $
 OPerson.StrFirstName� �� Mode$ TwoWay=� �� ValidatesOnDataErrors . �� 5+   
   $��1��6   $��0��6!   $��LastName��61   $��Center=�6A   �� 5,   
   $��1��6   $��1��6   $	��100��6/   $��Center=�6;   ��6X   �� *OPerson.StrLastName+$ TwoWay=� . �� 5-   
   $��2��6   $��0��6   $��Submit��6.   $��Center=�6?   ��6\   �� *	SubmitCmd+�� 5/   
   $��3��6   $��1��6    $
��Auto��60   ��6=   �� *
LstPersons+ �� View 50      �� 51      .P�52      �� $��	FirstName��6%    �� Width$
 Auto��6f    �� DisplayMemberBinding 68   �� *StrFirstName+6f   �� 53      $��LastName��6%   $
 Auto��6d    67   �� *StrLastName+6d   �� 54      $��FullNmae��6%   $
 Auto��6d    67   �� *StrFullName+6d   �� 55      $
��Date��6%   $
 Auto��6�    63   �� *
DteToday+ �� 	Converter# [  6�   56      58      59      5:      