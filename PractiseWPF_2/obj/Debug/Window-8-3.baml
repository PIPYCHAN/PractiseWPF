   M S B A M L   `   `   `  ����H  DPractiseWPF_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PractiseWPF_2PractiseWPF_2  5   	       PractiseWPF_2.Window_8_3   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PractiseWPF_2     5   	     PractiseWPF_2.TimeButton    
ReportTime$  ReportTimeHandler��5   	    � Title$ Window_8_3_路由事件��5	   	   $	��300��6!   $	��600��6.   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��监听��6   $��0��6   .��5      � -   5         �Name$ gridRoot��5      
��� � �.+�5      � -   5        $ gridA��5      $��10q�6&   
����  � 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ 
canvasLeft��5      $��0��61   
���  ��$��10q�6R   .+�5      �� -   5         ��Name$ btnLeft��5   0   $
��left��6!   $��80��6A   $��40��6M   $��10q�6X   6f   5      �� 5      -   5        $ canvasRight��5      $��1��62   
��� ���$��10q�6V   .+�5      �� -   5        $ btnRight��5   1   $��right��6!   $��80��6C   $��40��6P   $��10q�6\   6j   5      5      5      5      �� 5"   
   $��自定义路由��6   $��1��6"   .��5$      �� 
����ح�.+�5%      � -   5        $ grid_1��5%      $  ReportTimeHandler��6'   .+�5'      � -   5        $ grid_2��5'      $  ReportTimeHandler��6+   .+�5(      � -	   5        $ grid_3��5(      $  ReportTimeHandler��6/   .+�5)      �� -
   5         ��Name$ stackPanel_1��5)   )   $  ReportTimeHandler��6?   .+�5*   "   �� -   5         ��Name$ listBox1��5*   *     PractiseWPF_2.TimeButton  5+   "   -   5          Name$ 
timeButton��5+   3   $  ReportTimeHandler��6k   $��80��6G   $��80��6R   $��报时��6^   6k   5,      5.      50      51      �� 52      -   5        $ btn_ClearList��52      $��清空��60   6=   55      56      �� 58   
   $��2��6   $��AttachEvent��6#   .��5;      � -   5        $ gridMain��5;      .+�5<      �� -   5        $ btn_AttachEvent��5<      $��ok��6.   $��80��6;   $��80��6F   6R   5=      5>      5?      5@      