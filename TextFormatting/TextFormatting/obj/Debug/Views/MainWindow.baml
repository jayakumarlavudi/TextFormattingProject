   M S B A M L   `   `   `  ����I  ETextFormatting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TextFormattingTextFormatting  5   	   3    -TextFormatting.DesktopClient.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TextFormatting     5   	     � Title$  Text Format Application��5   	   $	��400��6)   $	��600��66   .��5
      � $��0,0,2,-1q�6    � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   $��27��6*   �� 5      $
��Auto �6   $��20��6*    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $��5��6,   �� 5      $
��Auto �6   $��35��6,   �� 5      $
��Auto �6   $��35��6,   �� 5      $
��Auto �6   $��35��6,   �� 5      $
��Auto �6   $��35��6,   �� 5      $	��196��6   �� 5      $
��Auto �6   $��50��6,   �� 5      $
��Auto �6   $	��127��6,   .+�5   
   �� -   5         ��Name$ rtb_UserText��5      $
��Left=�6,   $
��Auto��6G   $
��Auto��6U   $��0��5      $��1��6#   $��7��63    �� IsReadOnlyCaretVisible .  � 	Resources 5       �� 
TargetType �� Property �� Value��%X   'J�       �� 5      " J�6   .�5       ��  �@��Margin$ 0q�6/   5!      5"      5%      �� 5(   
   -   5        	 ��Name$	 btnImage��5(      $��1��6#   $��1��60   
�������$
��Bold"�6S   .��5)      �� 
 �� Orientation$
 
Horizontal=�6   .+�5*      �� $��30��6   $��30��6'   ��5+      �� 5,       �� ImageSource$ /images/Photo.JPG��6%    j� Stretch$ Uniform=�6E   5.      5/      50      �� 51   
   -   5        $	 btnGif��51      $��1��6!   $��2��6.   
�������$
��Bold"�6Q   .��52      �� $
 
Horizontal=�6   .+�53      �� $��30��6   $��30��6'   ��54      �� 55      $ /images/Gif.JPG��6%   57      58      59      �� 5:   
   -   5        $	 btnPoll��5:      $��1��6"   $��3��6/   
�������$
��Bold"�6R   .��5;      �� $
 
Horizontal=�6   .+�5<      �� $��30��6   $��30��6'   ��5=      �� 5>      $ /images/Poll.JPG��6%   5@      5A      5B      �� 5C   
   -   5        $	 btnLocation��5C      $��1��6&   $��4��63   $
��Bold"�6C   
����������	#FFE5F2F8.��5D      �� $
 
Horizontal=�6   .+�5E      �� $��30��6   $��30��6'   ��5F      �� 5G      $ /images/Location.JPG��6%   5I      5J      5K      �� 5L   
   -   5         ��Name$ 	txtLength��5L       �� TextWrapping$
 Wrap=�6%   $��6��69   $��1��6J    �� 
IsReadOnly . 6W   �� 5M   
   -   5        $	 button��5M      $��1��6!   $��7��6.   .��5N      �� $
 
Horizontal=�6   .+�5O      �� $��20��6   $��20��6'   ��5P      �� 5Q      $ /images/button.JPG��6%   5S      �� 5T      
�������$
��Bold"�6+   .��6=   Tweet6D   5U      5X      5Y      5Z      