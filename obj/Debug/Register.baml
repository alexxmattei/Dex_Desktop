   M S B A M L   `   `   `  ����E  ADexDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DexDesktop
DexDesktop  5   	   'clr-namespace:DexDesktop
DexDesktop  5   	       DexDesktop.Register   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,contextclr-namespace:DexDesktop     5   	   *localclr-namespace:DexDesktop     5   	     � Title$  Register��5	   	   $	��700��5
   	   $
��1200��6    � WindowStyle$
 None=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   
���   �.��5      � $	��680��6   $
��1180��5      ���#181735.+�5   
   �� -   5        $��textBlockHeading��5      $��54��5      $	��180��5      
�������$��Center=�5      $��515,79,485,547q�5      $��Registration��5      $��Center=�5      $��32(�5      $��Fonts/#Dosis)�5       �� 5"   
   -   5        $��1100, 5, 12, 600q�5"      $��Login��5#       � Cursor$
 Hand��5$      
�������$��24(�5&      $��Fonts/#Dosis)�5'      ��5)      �� 5*       �� 
TargetType" ��6"   .R�5+      �� $��	Underline{�6    �� 5,      5-      5.      ��50      �� 51       �� 
TargetType" ��6   .�52      ��  �� Property � �� �� Value
 ��  �63    �� Triggers 53      P� 54      	 P� Property	 �@J�IsMouseOver
 P� Value
 . . �55      ��  � ��
 �  ��6;   56      58      5:      �� 5<   
   ���#425b96 �� CornerRadius$ 50,50,50,50��5=      $��10,10,10,10q�5>      $��100, 50, 100, 50q�5?      ._�5A      � $��41.4,95.4,42.4,29.4q�6   ���#3DDDC2 � ColumnDefinitions 5C      �� 5D      $	��99* �6'   �� 5E      $
��267* �6'   �� 5F      $
��554* �6'    � RowDefinitions 5H      �� 5I      $
��252* �6$   .+�5L      �� -   5         ��Name$ errormessage��5L   U   $��20��6   $
��Left=�6(   $��67,0,0,0q�6C   $	��Top=�6k   $	��250��6�    J� OpacityMask
 �<�����	#FFE5572C$��2��6�   �� 5M      -   5        $��textBlockFirstname��5M   V   $��25��6   $
��Left=�6(   $��	67,20,0,0q�6C   $��First Name: ��6p   $	��Top=�6�   $	��110��6�   $��2��6�   �� 5N      -   5        $��textBlockLastname��5N   V   $��25��6   $
��Left=�6(   $��	67,50,0,0q�6C   $��Last Name: ��6o   $	��Top=�6�   $	��110��6�   $��2��6�   �� 5O      -   5        $��textBlockEmailId��5O   V   $��25��6   $
��Left=�6(   $��	67,80,0,0q�6C   $��Email: ��6n   $	��Top=�6}   $	��110��6�   $��2��6�   �� 5P      -   5        $��textBlockPassword��5P   W   $��25��6   $
��Left=�6(   $��
67,110,0,0q�6C   $��
Password: ��6p   $	��Top=�6�   $	��110��6�   $��2��6�   �� 5Q      -   5        $��textBlockConfirmPwd��5Q   W   $��25��6   $
��Left=�6(   $��
67,140,0,0q�6C   $��Confirm Password: ��6r   $	��Top=�6�   $	��110��6�   $��2��6�   �� 5R      -	   5        $��textBlockAddress��5R   W   $��25��6   $
��Left=�6(   $��
67,170,0,0q�6C   $��	Address: ��6o   $	��Top=�6�   $	��110��6�   �� 5T      -
   5        $��textBoxFirstname��5T   U   $��25��6   $
��Left=�6&   $��
104,15,0,0q�6A   $	��Top=�6�   $	��388��6�   $��2��6�   $��1��6�   ��6m   ��  �� Path$ 	Firstname� �� Mode$ TwoWay=�6�   �� 5U      -   5        $��textBoxLastname��5U   U   $��25��6   $
��Left=�6&   $��
104,45,0,0q�6A   $	��Top=�6�   $	��388��6�   $��2��6�   $��1��6�   ��6m   �� $ Lastname�$ TwoWay=�6�   �� 5V      -   5        $��textBoxEmail��5V   U   $��25��6   $
��Left=�6&   $��
104,75,0,0q�6A   $	��Top=�6�   $	��388��6�   $��2��6�   $��1��6�   ��6i   �� $ Email�$ TwoWay=�6�   G� 5W      -   5        $��passwordBox1��5W   Z   $��25��6   $
��Left=�6*   $��104,105,0,0q�6E   $	��Top=�6o   $	��388��6�   $��2��6�   $��1��6�   G� 5Y      -   5        $��passwordBoxConfirm��5Y   \   $��25��6   $
��Left=�6*   $��103.6,135,0,0q�6E   $	��Top=�6v   $	��388��6�   $��2��6�   $��1��6�   �� 5Z      -   5        $��textBoxAddress��5Z   Z   $��25��6   $
��Left=�6&   $��103.6,165,0,246q�6A   $��Bottom=�6�   $	��388��6�   $��2��6�   $��1��6�   ��6p   �� $ Address�$ TwoWay=�6�   �� 5[      -   5        $��Submit��5[   h   $��Submit��6   $��25��6*   $
��Left=�66   $��313.6,279,0,0q�6Q   $	��Top=�6v   $��70��6�   $��2��6�   �� 5\      -   5        $��button2��5\   g   $��Reset��6   $��25��6)   $
��Left=�65   $��238.2,279,0,0q�6P   $	��Top=�6v   $��70��6�   $��2��6�   �� 5]      -   5        $��button3��5]   h   $��Cancel��6   $��25��6*   $��Right=�66   $��0,279,67.2,0q�6R   $	��Top=�6w   $��70��6�   $��2��6�   5^      5_      5`      5b      