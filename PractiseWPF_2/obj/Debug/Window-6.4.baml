   M S B A M L   `   `   `  ����H  DPractiseWPF_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PractiseWPF_2PractiseWPF_2  5   	       PractiseWPF_2.Window_6   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PractiseWPF_2     5   	     � Title$3  -Window-6.4-Binding对数据的转换与校验��5   	   $	��450��6-   $	��400��6:    � 	Resources 5	      -   'PractiseWPF_2.CatagoryToSourceConverter   cts0   *PractiseWPF_2.StateToNullableBoolConverter  stnb��%:   &	        &	        5
   
   6*     5   
   6-   5      .��5      � .+�5   
   �� $��0��6   
�������.+�5      �� $��binding的数据校验��6   .��5      �� .+�5      �� -   5         ��Name$ txtBox_valid1��5      $��5q�65   �� 5      -   5         ��Name$ slider_valid1��5       � Minimum$	 -10Q�64    � Maximum$	 100Q�6B   $��5q�6P   �� 5      $��Tooltip演示��6    � ToolTip 5      _� 5      .��5   "   �� .+�5   &   �� $��Heavy"�60   两个TextBlock6P   �� 5   &   ?=简要介绍：Tooltip是一个十分强大的功能组件！6K   5   #   5      5      5      5       �� 5"      $��Binding的数据转换��6   $��10q�6-   .��5#      �� 
����ح�.+�5$      �� -   5         ��Name$ listBoxPlane��5$      $	��160��64   $��5q�6A   ��5%      �� 5&      .R�5'   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5(   &   �� $��20��6,   $��20��67   ��6C   �� 	 �� Path$	 Catagory�
 �� 	Converter#
 [  �� 5)   &   $��60��6K   $
��80,0q�6V   ��60   �� $
	 Name�6V   �� 5*   &    d� IsThreeState .  d� 	IsChecked 6C   �� $	 State�#
 [ 5+   #   5,      5.      �� 5/      -   5         ��Name$ btnLoad��5/      $
��load��6.   $��25��6=   $	��5,0q�6I   6V   �� 50      -   5        $ btnSave��50      $
��save��6.   $��25��6=   $	��5,0q�6I   6V   51      52      53      56      57      