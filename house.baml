   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.house   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  house��5   	   $	��450��6   $	��800��6$   .��5	      � ���	#FF0084D0.+�5
   
   �� $��Loan amount��6   $
��Left=�6&   $��	29,95,0,0q�6A   $	��Top=�6T   �� 5   
   $��Number of Years��6   $
��Left=�6*   $��
29,121,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Deposit��6   $
��Left=�6"   $��
29,152,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Interest rate��6   $
��Left=�6(   $��
29,183,0,0q�6C   $	��Top=�6W   �� 5   
   -   5         ��Name$ btnCalculateHouse��5      $��	Calculate��6,   $
��Left=�6@   $��
25,229,0,0q�6[   $	��Top=�6o   $��75��6�   6�   �� 5   
   -   5        $ btnClearhouse��5      $��Clear��6(   $
��Left=�68   $��148,229,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ btnExit��5      $
��Exit��6"   $
��Left=�61   $��260,229,0,0q�6L   $	��Top=�6a   $��75��6y   6�   �� 5   
   -   5         ��Name$ txtLoanHouse��5      $
��Left=�6(   $��23��6C   $��
183,95,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ txtLoanYearsHouse��5      $
��Left=�6-   $��23��6H   $��183,125,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ txtDepositHouse��5      $
��Left=�6+   $��23��6F   $��183,152,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ txtInterestHouse��5      $
��Left=�6,   $��23��6G   $��183,183,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   -   5         ��Name$ listView��5      $
��Left=�6%   $	��284��6@   $��
368,13,0,0q�6M   $	��Top=�6a   $	��343��6y    �� View 5      �� 5      .P�5      �� 5      5      (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$
 date��5      $
��Left=�6#   $��
183,61,0,0q�6>   $	��Top=�6R   $	��120��6j   �� 5   
   -
   5        $ btnHome��5      $
��Home��6"   $
��Left=�61   $��0,10,0,0q�6L   $	��Top=�6^   $��75��6v   6�   �� 5   
   $
��Date��6   $
��Left=�6   $��	37,61,0,0q�6:   $	��Top=�6M   5       5!      