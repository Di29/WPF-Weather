   M S B A M L   `   `   `  ����B  >WpfTEST, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfTESTWpfTEST  5   	   H DShowMeTheXAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAMLShowMeTheXAML 5   	       WpfTEST.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfTEST     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   =smtx2clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML  5   	   -   5           MaterialDesignBody#���   5
   	   $��Medium"�5   	   $��14(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	    � Title$ Weather��5   	    � WindowState$ 	Maximized=�6   $
��1000��6G    � Icon$ Resources/weather.png��6i   ��5      �� 5   
    �� ImageSource$ Resources/clouds.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��250* �6   �� 5      $
��250* �6   �� 5      $
��250* �6   �� 5      $
��250* �6   �� 5      $
��250* �6   �� 5      $
��250* �6   �� 5      $
��250* �6    � RowDefinitions 5    
   �� 5!      $	��400 �6   �� 5"      $	��400 �6   .+�5&   
   #  MaterialDesignThemes.Wpf.Card  -   5          Name$ card1��5&      $	��200��6-   $	��300��69   $��0��6F   $��1��6V   ��5'      �� 5(      	 �� Color$	 White��6"   
 �� Opacity$

 0.55Q�60   .��5*      �  5+      �� 5,      $	��110 �6$   �� 5-      $��* �6$   �� 5.      $
��Auto �6$   .+�50      �� -   5        $
��day1��50      $��Today��6(   $��0 5 0 0q�65   $��Center=�6F   6e   �� 51      -   5        $��icon1��51      $��64��6&   $��64��62   $��UniformToFill=�6=   �� 52      -   5        $��	condition��52      $�� ��6-   $��
0,92,0,102q�65   $��Center=�6I   $
��Bold"�6f   $��2��6x   6�   �� 54      $��1��6   $��8 8 8 0q�6*   .+�55      �  56      �� 57      $
��107* �6/   �� 58      $	��77* �6/    5:      �� 5;      $��22 �6,   �� 5<      $��22 �6,   �� 5=      $��22 �6,   �� 5>      $��22 �6,   �� 5?      $��22 �6,   �� 5@      $��22 �6,   �� 5A      $��22 �6,   �� 5B      $��22 �6,   .+�5E      �� $��0��6$   $��0��64   $��	0,5,0.2,0q�6A   $��Temperature °C��6T   6m   �� 5F      $��0��6$   $��1��64   $��	0,5,0.2,0q�6A   $��
Feels like��6T   6h   �� 5G      $��0��6$   $��2��64   $��	0,5,0.2,0q�6A   $��Humidity��6T   6g   �� 5H      $��0��6$   $��3��64   $��	0,5,0.2,0q�6A   $��
Wind speed��6T   6i   �� 5J      -   5        $��avgTemp��5J   A   $��1��6$   $��0��64   $��	0,5,0.2,0q�6P   $
��Left=�6c   6�   �� 5K      -   5        $��feels��5K   A   $��1��6$   $��1��64   $��	0,5,0.2,0q�6N   $
��Left=�6a   6~   �� 5L      -   5        $��humidity��5L   A   $��1��6$   $��2��64   $��	0,5,0.2,0q�6Q   $
��Left=�6d   6�   �� 5M      -	   5        $��	windSpeed��5M   A   $��1��6$   $��3��64   $��	0,5,0.2,0q�6R   $
��Left=�6e   6�   5N      5O      5P      5Q        5S   
   -
   5        $ card2��5S      $	��200��6-   $	��300��69   $��1��6F   $��1��6V   ��5T      �� 5U      $	 White��6"   $

 0.55Q�60   .��5W      �  5X      �� 5Y      $	��110 �6$   �� 5Z      $��* �6$   �� 5[      $
��Auto �6$   .+�5]      �� -   5        $
��day2��5]      $�� ��6(   $��0 5 0 0q�60   $��Center=�6A   $
��Bold"�6^   6r   �� 5^      -   5         ��Name$ icon2��5^      $��64��6(   $��64��64   $��UniformToFill=�6?   �� 5_      -   5        $��
condition2��5_      $�� ��6.   $��
0,92,0,102q�66   $��Center=�6J   $
��Bold"�6g   $��2��6y   6�   �� 5a      $��1��6   $��8 8 8 0q�6*   .+�5b      �  5c      �� 5d      $
��107* �6/   �� 5e      $	��77* �6/    5g      �� 5h      $��22 �6,   �� 5i      $��22 �6,   �� 5j      $��22 �6,   �� 5k      $��22 �6,   �� 5l      $��22 �6,   �� 5m      $��22 �6,   �� 5n      $��22 �6,   �� 5o      $��22 �6,   .+�5r      �� $��0��6$   $��0��64   $��	0,5,0.2,0q�6A   $��Temperature °C��6T   6m   �� 5s      $��0��6$   $��1��64   $��
0,5,0.2,21q�6A   $��Min temp��6U   $��2��6e   6y   �� 5t      $��0��6$   $��2��64   $��	0,5,0.2,0q�6A   $��Max temp��6T   6g   �� 5u      $��0��6$   $��3��64   $��	0,5,0.2,0q�6A   $��Humidity��6T   6g   �� 5v      $��0��6$   $��4��64   $��	0,5,0.2,0q�6A   $��
Wind speed��6T   6i   �� 5x      -   5        $��avgTemp2��5x   A   $��1��6$   $��0��64   $��	0,5,0.2,0q�6Q   $
��Left=�6d   6�   �� 5y      -   5        $��minTemp2��5y   A   $��1��6$   $��1��64   $��
0,5,0.2,21q�6Q   $��2��6e   $
��Left=�6v   6�   �� 5z      -   5        $��maxTemp2��5z   A   $��1��6$   $��2��64   $��	0,5,0.2,0q�6Q   $
��Left=�6e   6�   �� 5{      -   5        $��	humidity2��5{   A   $��1��6$   $��3��64   $��	0,5,0.2,0q�6R   $
��Left=�6e   6�   �� 5|      -   5        $��
windSpeed2��5|   A   $��1��6$   $��4��64   $��	0,5,0.2,0q�6S   $
��Left=�6f   6�   5}      5~      5      5�        5�   
   -   5        $ card3��5�      $	��200��6-   $	��300��69   $��2��6F   $��1��6V   ��5�      �� 5�      $	 White��6"   $

 0.55Q�60   .��5�      �  5�      �� 5�      $	��110 �6$   �� 5�      $��* �6$   �� 5�      $
��Auto �6$   .+�5�      �� -   5        $
��day3��5�      $�� ��6(   $��0 5 0 0q�60   $��Center=�6A   $
��Bold"�6^   6r   �� 5�      -   5        $ icon3��5�      $��64��6(   $��64��64   $��UniformToFill=�6?   �� 5�      -   5        $��
condition3��5�      $�� ��6.   $��
0,92,0,102q�66   $��Center=�6J   $
��Bold"�6g   $��2��6y   6�   �� 5�      $��1��6   $��8 8 8 0q�6*   .+�5�      �  5�      �� 5�      $
��107* �6/   �� 5�      $	��77* �6/    5�      �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   .+�5�      �� $��0��6$   $��0��64   $��	0,5,0.2,0q�6A   $��Temperature °C��6T   6m   �� 5�      $��0��6$   $��1��64   $��
0,5,0.2,21q�6A   $��Min temp��6U   $��2��6e   6y   �� 5�      $��0��6$   $��2��64   $��	0,5,0.2,0q�6A   $��Max temp��6T   6g   �� 5�      $��0��6$   $��3��64   $��	0,5,0.2,0q�6A   $��Humidity��6T   6g   �� 5�      $��0��6$   $��4��64   $��	0,5,0.2,0q�6A   $��
Wind speed��6T   6i   �� 5�      -   5        $��avgTemp3��5�   A   $��1��6$   $��0��64   $��	0,5,0.2,0q�6Q   $
��Left=�6d   6�   �� 5�      -   5        $��minTemp3��5�   A   $��1��6$   $��1��64   $��
0,5,0.2,21q�6Q   $��2��6e   $
��Left=�6v   6�   �� 5�      -   5        $��maxTemp3��5�   A   $��1��6$   $��2��64   $��	0,5,0.2,0q�6Q   $
��Left=�6e   6�   �� 5�      -   5        $��	humidity3��5�   A   $��1��6$   $��3��64   $��	0,5,0.2,0q�6R   $
��Left=�6e   6�   �� 5�      -   5        $��
windSpeed3��5�   A   $��1��6$   $��4��64   $��	0,5,0.2,0q�6S   $
��Left=�6f   6�   5�      5�      5�      5�        5�   
   -   5        $ card4��5�      $	��200��6-   $	��300��69   $��3��6F   $��1��6V   ��5�      �� 5�      $	 White��6"   $

 0.55Q�60   .��5�      �  5�      �� 5�      $	��110 �6$   �� 5�      $��* �6$   �� 5�      $
��Auto �6$   .+�5�      �� -   5        $
��day4��5�      $�� ��6(   $��0 5 0 0q�60   $��Center=�6A   $
��Bold"�6^   6r   �� 5�      -   5        $ icon4��5�      $��64��6(   $��64��64   $��UniformToFill=�6?   �� 5�      -   5        $��
condition4��5�      $�� ��6.   $��
0,92,0,102q�66   $��Center=�6J   $
��Bold"�6g   $��2��6y   6�   �� 5�      $��1��6   $��8 8 8 0q�6*   .+�5�      �  5�      �� 5�      $
��107* �6/   �� 5�      $	��77* �6/    5�      �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   .+�5�      �� $��0��6$   $��0��64   $��	0,5,0.2,0q�6A   $��Temperature °C��6T   6m   �� 5�      $��0��6$   $��1��64   $��
0,5,0.2,21q�6A   $��Min temp��6U   $��2��6e   6y   �� 5�      $��0��6$   $��2��64   $��	0,5,0.2,0q�6A   $��Max temp��6T   6g   �� 5�      $��0��6$   $��3��64   $��	0,5,0.2,0q�6A   $��Humidity��6T   6g   �� 5�      $��0��6$   $��4��64   $��	0,5,0.2,0q�6A   $��
Wind speed��6T   6i   �� 5�      -    5        $��avgTemp4��5�   A   $��1��6$   $��0��64   $��	0,5,0.2,0q�6Q   $
��Left=�6d   6�   �� 5�      -!   5        $��minTemp4��5�   A   $��1��6$   $��1��64   $��
0,5,0.2,21q�6Q   $��2��6e   $
��Left=�6v   6�   �� 5�      -"   5        $��maxTemp4��5�   A   $��1��6$   $��2��64   $��	0,5,0.2,0q�6Q   $
��Left=�6e   6�   �� 5�      -#   5        $��	humidity4��5�   A   $��1��6$   $��3��64   $��	0,5,0.2,0q�6R   $
��Left=�6e   6�   �� 5�      -$   5        $��
windSpeed4��5�   A   $��1��6$   $��4��64   $��	0,5,0.2,0q�6S   $
��Left=�6f   6�   5�      5�      5�      5�        5�   
   -%   5        $ card5��5�      $	��200��6-   $	��300��69   $��4��6F   $��1��6V   ��5�      �� 5�      $	 White��6"   $

 0.55Q�60   .��5�      �  5�      �� 5�      $	��110 �6$   �� 5�      $��* �6$   �� 5�      $
��Auto �6$   .+�5�      �� -&   5        $
��day5��5�      $�� ��6(   $��0 5 0 0q�60   $��Center=�6A   $
��Bold"�6^   6r   �� 5�      -'   5        $ icon5��5�      $��64��6(   $��64��64   $��UniformToFill=�6?   �� 5�      -(   5        $��
condition5��5�      $�� ��6.   $��
0,92,0,102q�66   $��Center=�6J   $
��Bold"�6g   $��2��6y   6�   �� 5�      $��1��6   $��8 8 8 0q�6*   .+�5�      �  5�      �� 5�      $
��107* �6/   �� 5�      $	��77* �6/    5�      �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   �� 5�      $��22 �6,   .+�5�      �� $��0��6$   $��0��64   $��	0,5,0.2,0q�6A   $��Temperature °C��6T   6m   �� 5      $��0��6$   $��1��64   $��
0,5,0.2,21q�6A   $��Min temp��6U   $��2��6e   6y   �� 5     $��0��6$   $��2��64   $��	0,5,0.2,0q�6A   $��Max temp��6T   6g   �� 5     $��0��6$   $��3��64   $��	0,5,0.2,0q�6A   $��Humidity��6T   6g   �� 5     $��0��6$   $��4��64   $��	0,5,0.2,0q�6A   $��
Wind speed��6T   6i   �� 5     -)   5        $��avgTemp5��5  A   $��1��6$   $��0��64   $��	0,5,0.2,0q�6Q   $
��Left=�6d   6�   �� 5     -*   5        $��minTemp5��5  A   $��1��6$   $��1��64   $��
0,5,0.2,21q�6Q   $��2��6e   $
��Left=�6v   6�   �� 5     -+   5        $��maxTemp5��5  A   $��1��6$   $��2��64   $��	0,5,0.2,0q�6Q   $
��Left=�6e   6�   �� 5     -,   5        $��	humidity5��5  A   $��1��6$   $��3��64   $��	0,5,0.2,0q�6R   $
��Left=�6e   6�   �� 5	     --   5        $��
windSpeed5��5	  A   $��1��6$   $��4��64   $��	0,5,0.2,0q�6S   $
��Left=�6f   6�   5
     5     5     5       5  
   -.   5        $ card6��5     $	��200��6-   $	��300��69   $��5��6F   $��1��6V   ��5     �� 5     $	 White��6"   $

 0.55Q�60   .��5     �  5     �� 5     $	��110 �6$   �� 5     $��* �6$   �� 5     $
��Auto �6$   .+�5     �� -/   5        $
��day6��5     $�� ��6(   $��0 5 0 0q�60   $��Center=�6A   $
��Bold"�6^   6r   �� 5     -0   5        $ icon6��5     $��64��6(   $��64��64   $��UniformToFill=�6?    J� Opacity$
 0.09Q�6W   �� 5     -1   5        $��
condition6��5     $�� ��6.   $��
0,92,0,102q�66   $��Center=�6J   $
��Bold"�6g   $��2��6y   6�   �� 5     $��1��6   $��8 8 8 0q�6*   .+�5     �  5     �� 5      $
��107* �6/   �� 5!     $	��77* �6/    5#     �� 5$     $��22 �6,   �� 5%     $��22 �6,   �� 5&     $��22 �6,   �� 5'     $��22 �6,   �� 5(     $��22 �6,   �� 5)     $��22 �6,   �� 5*     $��22 �6,   �� 5+     $��22 �6,   .+�5.     �� $��0��6$   $��0��64   $��	0,5,0.2,0q�6A   $��Temperature °C��6T   6m   �� 5/     $��0��6$   $��1��64   $��
0,5,0.2,21q�6A   $��Min temp��6U   $��2��6e   6y   �� 50     $��0��6$   $��2��64   $��	0,5,0.2,0q�6A   $��Max temp��6T   6g   �� 51     $��0��6$   $��3��64   $��	0,5,0.2,0q�6A   $��Humidity��6T   6g   �� 52     $��0��6$   $��4��64   $��	0,5,0.2,0q�6A   $��
Wind speed��6T   6i   �� 54     -2   5        $��avgTemp6��54  A   $��1��6$   $��0��64   $��	0,5,0.2,0q�6Q   $
��Left=�6d   6�   �� 55     -3   5        $��minTemp6��55  A   $��1��6$   $��1��64   $��
0,5,0.2,21q�6Q   $��2��6e   $
��Left=�6v   6�   �� 56     -4   5        $��maxTemp6��56  A   $��1��6$   $��2��64   $��	0,5,0.2,0q�6Q   $
��Left=�6e   6�   �� 57     -5   5        $��	humidity6��57  A   $��1��6$   $��3��64   $��	0,5,0.2,0q�6R   $
��Left=�6e   6�   �� 58     -6   5        $��
windSpeed6��58  A   $��1��6$   $��4��64   $��	0,5,0.2,0q�6S   $
��Left=�6f   6�   59     5:     5;     5<       5>  
   -7   5        $ card7��5>     $	��200��6-   $	��300��69   $��6��6F   $��1��6V   ��5?     �� 5@     $	 White��6"   $
 0.555Q�60   .��5B     �  5C     �� 5D     $	��110 �6$   �� 5E     $��* �6$   �� 5F     $
��Auto �6$   .+�5H     �� -8   5        $
��day7��5H     $�� ��6(   $��0 5 0 0q�60   $��Center=�6A   $
��Bold"�6^   6r   �� 5I     -9   5        $ icon7��5I     $��64��6(   $��64��64   $��UniformToFill=�6?   �� 5J     -:   5        $��
condition7��5J     $�� ��6.   $��
0,92,0,102q�66   $��Center=�6J   $
��Bold"�6g   $��2��6y   6�   �� 5L     $��1��6   $��8 8 8 0q�6*   .+�5M     �  5N     �� 5O     $
��107* �6/   �� 5P     $	��77* �6/    5R     �� 5S     $��22 �6,   �� 5T     $��22 �6,   �� 5U     $��22 �6,   �� 5V     $��22 �6,   �� 5W     $��22 �6,   �� 5X     $��22 �6,   �� 5Y     $��22 �6,   �� 5Z     $��22 �6,   .+�5]     �� $��0��6$   $��0��64   $��	0,5,0.2,0q�6A   $��Temperature °C��6T   6m   �� 5^     $��0��6$   $��1��64   $��
0,5,0.2,21q�6A   $��Min temp��6U   $��2��6e   6y   �� 5_     $��0��6$   $��2��64   $��	0,5,0.2,0q�6A   $��Max temp��6T   6g   �� 5`     $��0��6$   $��3��64   $��	0,5,0.2,0q�6A   $��Humidity��6T   6g   �� 5a     $��0��6$   $��4��64   $��	0,5,0.2,0q�6A   $��
Wind speed��6T   6i   �� 5c     -;   5        $��avgTemp7��5c  A   $��1��6$   $��0��64   $��	0,5,0.2,0q�6Q   $
��Left=�6d   6�   �� 5d     -<   5        $��minTemp7��5d  A   $��1��6$   $��1��64   $��
0,5,0.2,21q�6Q   $��2��6e   $
��Left=�6v   6�   �� 5e     -=   5        $��maxTemp7��5e  A   $��1��6$   $��2��64   $��	0,5,0.2,0q�6Q   $
��Left=�6e   6�   �� 5f     ->   5        $��	humidity7��5f  A   $��1��6$   $��3��64   $��	0,5,0.2,0q�6R   $
��Left=�6e   6�   �� 5g     -?   5        $��
windSpeed7��5g  A   $��1��6$   $��4��64   $��	0,5,0.2,0q�6S   $
��Left=�6f   6�   5h     5i     5j     5k       5m  
   $��7��6   $	��650��62   $	��250��6>   $ 0.588Q�6K   .��5n     �  5o     �� 5r     $
��Auto �6$   .+�5u     �� $��1��6   $��8 0 8 0q�6*   .+�5y     �� -@   5         ��Name$ 	searchBox��5y     )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Type city��5z      % !MaterialDesignFloatingHintTextBox#��[ 5{     $��42,0,41.6,0q�6x   �� 5~     -A   5        $
��bord��5~     $	��550��6)   $	��150��65   
���   �$��1q�6V   ._�5     �� -B   5        $��scroll��5  '   $
��Auto=�65   $��0 5 0 0q�6X   .��5�     �� -C   5         ��Name$ resultStack��5�  )   5�     5�     �� 5�     -D   5        $��press��5�      $��Center=�6-   $��15��6J   $�� ��6V   $��0 8 0 0q�6^   6q   5�     �� 5�     -E   5         ��Name$
 city��5�     $��Center=�6+   $��0,208,0,-78q�6I   $
��Bold"�6^   $��18(�6p   �� 5�     -F   5        $
 time��5�     $��Center=�6+   $��0,228,0,-78q�6I   $��14(�6_   5�     5�     5�     5�     