   M S B A M L   `   `   `  ����P  LSimplePasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:SimplePasswordManager.MVVM.ViewSimplePasswordManager.MVVM.View  5      [2clr-namespace:SimplePasswordManager.MVVM.ViewModel$SimplePasswordManager.MVVM.ViewModel  5      :    4SimplePasswordManager.MVVM.View.GeneratePasswordView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:SimplePasswordManager.MVVM.View     5      H	viewModel2clr-namespace:SimplePasswordManager.MVVM.ViewModel     5        � DataContext  5      C   =SimplePasswordManager.MVVM.ViewModel.GernatePasswordViewModel  5   
   .��5   
   � ���#15171e � RowDefinitions 5      �� 5      $��1* �6    �� 5      $	��10* �6    .+�5   
   �� .+�5      �� $��Generate password��6   
�������$��15(�5      $
��Bold"�5      $��Center=�5      $��4q�5      �� 5      
�������$��2��5      5      �� 5!   
   $��1��6   $��Center=�6"   $	��520��5"      .+�5%      �� ���#23252b$��36��5&       �� CornerRadius$ 4��5'      $��8,2,2,2q�5(      ._�5)      ��  �� Orientation$ 
Horizontal=�6   .+�5*      �� $��✏️ Passwordlength��6    $	��120��5+       $��Center=�5,       $��8,0,0,0q�5-       
�������5.       �� 5/      $��||��6    $��Center=�50       $��2,0,0,0q�51       
�������52       �� 53      $��28��6   $	��320��54      
������ $��0q�56      
�������$��11(�58      $��18,0,0,0q�59      $��Center=�5:      ��5;      �� *PasswordLength+ �� UpdateSourceTrigger$ PropertyChanged=�5=      5>      �� 5A      ���#23252b$��36��5B      $ 4��5C      $��8,2,2,2q�5D      ._�5E      �� $ 
Horizontal=�6   .+�5F      �� $��✏️ Uppercase��6    $	��120��5G       $��Center=�5H       $��8,0,0,0q�5I       
�������5J       �� 5K      $��||��6    $��Center=�5L       $��2,0,0,0q�5M       
�������5N       �� 5O      $��28��6   $	��320��5P      
������ $��0q�5R      
�������$��11(�5T      $��18,0,0,0q�5U      $��Center=�5V      ��5W      �� *PasswordUppercaseLetters+$ PropertyChanged=�5Y      5Z      �� 5\      ���#23252b$��36��5]      $ 4��5^      $��8,2,2,2q�5_      ._�5`      �� $ 
Horizontal=�6   .+�5a      �� $��✏️ SpecialCharacters��6    $	��120��5b       $��Center=�5c       $��8,0,0,0q�5d       
�������5e       �� 5f      $��||��6    $��Center=�5g       $��2,0,0,0q�5h       
�������5i       �� 5j      $��28��6   $	��320��5k      
������ $��0q�5m      
�������$��11(�5o      $��18,0,0,0q�5p      $��Center=�5q      ��5r      �� *PasswordSpecailChars+$ PropertyChanged=�5t      5u      �� 5w      $��2,32,2,2q�6   ._�5x      �� .+�5y      �� 
�������$��36��5z      $ 4��5{      $��8,2,2,2q�5|      ._�5}      �� $ 
Horizontal=�6%   .+�5~      �� $��✏️ Generated Password��6(   $	��140��5   (   $��Center=�5�   (   $��8,0,0,0q�5�   (   
�������5�   (   �� 5�      $��||��6(   $��Center=�5�   (   $��2,0,0,0q�5�   (   
�������5�   (   �� 5�      $��28��6&   $	��320��5�   &   
������ $��0q�5�   &   
�������$��13(�5�   &   $
��Bold"�5�   &   $��18,0,0,0q�5�   &   $��Center=�5�   &   ��5�   &   �� *GeneratedPassword+$ PropertyChanged=�5�      5�      �� 5�      $��generate random password��6   $��40��5�      $	��320��5�      $��6q�5�      ��5�      �� *GeneratePasswordCommand+5�      5�      5�      5�      5�      