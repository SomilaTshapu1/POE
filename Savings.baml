   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Savings   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Savings��5   	   $	��450��6   $	��800��6&   .��5	      � ���	#FF3649BB.+�5
   
   �� $��Savings Goal��6   $
��Left=�6'   $��	83,89,0,0q�6B   $	��Top=�6U   �� 5   
   $��Interest��6   $
��Left=�6#   $��
83,126,0,0q�6>   $	��Top=�6R   �� 5   
   $��Period��6   $
��Left=�6!   $��
83,157,0,0q�6<   $	��Top=�6P   �� 5   
   -   5         ��Name$ txtGoal��5      $
��Left=�6#   $��23��6>   $��
216,89,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ txtInnterest��5      $
��Left=�6(   $��23��6C   $��216,129,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txtYears��5      $
��Left=�6$   $��23��6?   $��216,157,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5         ��Name$ bbtnCalculate��5      $��	Calculate��6(   $
��Left=�6<   $��
85,188,0,0q�6W   $	��Top=�6k   $��75��6�   6�   �� 5   
   -   5         ��Name$ listView��5      $
��Left=�6%   $	��241��6@   $��
366,36,0,0q�6M   $	��Top=�6a   $	��327��6y    �� View 5      �� 5      .P�5      �� 5      5      �� 5   
   -   5        $ btnHome��5      $
��Home��6"   $
��Left=�61   $��	10,10,0,0q�6L   $	��Top=�6_   $��75��6w   6�   5      5      