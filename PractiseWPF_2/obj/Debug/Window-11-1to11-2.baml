   M S B A M L   `   `   `  ����H  DPractiseWPF_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PractiseWPF_2.UseControlPractiseWPF_2.UseControl  5   	   -clr-namespace:PractiseWPF_2PractiseWPF_2  5   	       PractiseWPF_2.Window_11   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5uc&clr-namespace:PractiseWPF_2.UseControl     5   	   -localclr-namespace:PractiseWPF_2     5   	     � Title$  	Window_11��5	   	   $	��450��6   $
��1000��6(    � 	Resources 5
      0   *PractiseWPF_2.AutoMakerToLogoPathConverter   a2l,   &PractiseWPF_2.NameToPhotoPathConverter  n2p  carDetailViewTemplate �� CornerRadius �� 	Converter �� Orientation  carListItemViewTemplate��%�  &	        &	      &	 &     7  &	 1    7     5   
   6-     5   
   6)   �� 5   
   .R�5      �� 
���   �$��1q�6)   $ 6��6=   ._�5      �� $��5q�6   .+�5      �� $	��400��6S   $	��250��6_   ��6   �� *Name+8   6_   �� 5      $ 
Horizontal=�6!   $	��5,0q�6:   .+�5      �� $��Name:��6$   $
��Bold"�61   $��20(�6C   �� 5      $��20(�6:   $	��5,0q�6H   ��6$   �� *Name+6H   5      �� 5      $ 
Horizontal=�6!   .+�5      �� $��
Automaker:��6$   $
��Bold"�66   �� 5      $	��5,0q�6?   ��6$   �� *	AutoMaker+6?   �� 5      $��Year:��6$   $
��Bold"�61   �� 5      $	��5,0q�6:   ��6$   �� *Year+6:   �� 5      $��
Top Speed:��6$   $
��Bold"�66   �� 5      $	��5,0q�6>   ��6$   �� *
TopSpeed+6>   5      5      5       5!      �� 5$   
   .R�5%      � $��2q�6   .+�5&      �� $ 
Horizontal=�6   .+�5'      �� $��3��6X   $��64��6i   $��64��6t   ��6   �� *	Automaker+8   6t   �� 5(      $
��5,10q�6!   .+�5)      �� $��16(�6:   $
��Bold"�6H   ��6$   �� *Name+6H   �� 5*      $��14(�6:   ��6$   �� *Year+6:   5+      5,      5-      5.      5/      .��50      �  � ColumnDefinitions 51   
   �� 52      $��2* �6   �� 53       � RowDefinitions 55   
   �� 56      .+�59   
   �� $&�� 11-2-数据的外衣DataTemplate��6   .��5;      �� $ 
Horizontal=�6   $��5q�62   .+�5>      >� #��[ 6   ��6X   �� *SelectedItem+ �� ElementName$ listBoxCars���� 5?      -   5         ��Name$ listBoxCars��5?      $	��180��6/   $	��5,0q�6;   #��[ 6H   5@      5A      �� 5C   
   $(��"11-3控件的外衣ControlTemplate��6   $��1��65   5E      5F      5G      