   M S B A M L   `   `   `  ����P  LSimplePasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SimplePasswordManagerSimplePasswordManager  5   	   &     SimplePasswordManager.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SimplePasswordManager     5   	     � Title$  
MainWindow��5   	   $	��840��5	   	   $
��1280��5
   	   .��5      �� ���#15171e._�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      $	��300 �6#   .+�5      ]� .+�5      �  � RowDefinitions 5      �� 5      $��40 �6(   �� 5      $��60 �6(   �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��Center=�5      $��	12,0,12,0q�5       .+�5,      �� $��Settings��6!      MenuBtnStyleText#��[  5-   !   5.      � 51      $��1��6    52      �� 53      $	��180 �6/   �� 54      .+�57      �� $��0��6!   ���#23252b$��	12,2,12,2q�59   !    �� CornerRadius$ 4��5:   !   ._�5<      �� $��Center=�6(   $��Center=�5=   (   $��🐧 SimplePM��5>   (   $
��Bold"�5?   (   
�������$��15(�5A   (   5C      �� 5D      $��1��6!   ���#23252b$��	12,2,12,2q�5F   !   $ 4��5G   !   ._�5I      �� $ 
Horizontal=�6)   .+�5K   "   �� $
��Menu��6,   
�������$��Center=�5M   ,   $
��Bold"�5N   ,   $��14(�5O   ,   $��12,0,0,0q�5P   ,   	� 5R   "   $
��Home��6.   $��32,0,0,0q�5T   .     RadioBtnMenuStyle#��[ 5U   .    d� 	IsChecked$
 TrueY�5V   .   ��5S   .   �� *NavigateToHomeCommand+ �� UpdateSourceTrigger$ PropertyChanged=�5V   .   	� 5X   "   $��generate password��6.   $��0,0,0,0q�5Z   .   #��[ 5[   .   ��5Y   .   �� *#!NavigateToGeneratePasswordCommand+5[   .   	� 5]   "   $��Manage passwords��6.   #��[ 5_   .   ��5^   .   �� *" NavigateToManagePasswordsCommand+5_   .   5`      5a      5b      �� 5e      $��2��6%   $��12q�5g   %   ��5f   %   �� *Navigation.CurrentView+5h      5j      5k      ]� 5n      $��1��6   .+�5o      � $��60��6   $	��Top=�6#   $��2,40,2,2q�5p       5r      �� 5s      $��80 �6+   �� 5t      .+�5w      �� ���#23252b$ 4��5x      ._�5y      �� 
������ $��4q�5z   $   $
��🧔��5{   $   $��Center=�5|   $   $��Center=�5}   $   
�������$��34(�5   $   5�      �� 5�      $��1��6!   $��Center=�5�   !   .+�5�      �  5�      �� 5�   "   �� 5�   "   .+�5�      �� $��	Demo-user��6(   $��
18,-14,0,0q�5�   (   $��Center=�5�   (   
�������$��15(�5�   (   �� 5�      $��1��6(   $��Location: Germany��5�   (   $��	18,12,0,0q�5�   (   $��Center=�5�   (   
�������5�   (   5�      5�      5�      �� 5�      $	��Top=�6   $'��!Search a Password manage template��5�      
�������$��	12,12,0,8q�5�      �� 5�      $	��Top=�6     	SearchBox#��[ 5�      $��0,2,6,12q�5�      �� 5�      
�������$��	12,4,12,4q�5�      $	��Top=�5�      �� 5�      $	��Top=�6   $'��!Select a Password manage template��5�      
�������$��	12,12,0,8q�5�      �� 5�      $	��Top=�6   $��0,2,0,2q�5�      
������ 
������ ��5�      �� *AllPasswordModels+5�      5�      5�      5�      5�      