   M S B A M L   `   `   `  ����H  DInterfaces2Ev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Interfaces2Ev.ViewInterfaces2Ev.View  5      !    Interfaces2Ev.View.ReadPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Interfaces2Ev.View     5        N� Title$
  Read��5	       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /RD/ViewRD.xaml?�6%   %    5      .��5      �    Grid#���   6   $��Center=�6*   $	��450��6E   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ productsDatagrid��5   6     DataGrid#���  6   $��25,55,25,45q�6P      AutoGenerateColumns$ False��6e      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.3* 61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� 
 �� Path$
 	ProductID�  5      $ Product Name��6%   $ * 6;   	 6E   �� $
 ProductName�  5      $ Category��6%   $ * 67   	 6A   �� $
 CategoryName�  5      $ Quantity per unit��6%   $ * 6@   	 6J   �� $
 QuantityPerUnit�  5      $ Price��6%   $ * 64   	 6>   �� $
 	UnitPrice�  5      $ Stock��6%   $ * 64   	 6>   �� $
 UnitsInStock�5      �� 5    
     	TextBlock#���  6   $	��ID:��68   $��	31,33,0,0q�6C   $	��Top=�6V   $
��Left=�6n   $��15��6�   �� 5!   
   -   5         ��Name$ 	productId��5!        TextBox#���  6%   $��	48,29,0,0q�6G   $	��Top=�6Z   $
��Left=�6r   $��14��6�   �� 5#   
   #���  6   $��Product Name:��68   $��
113,33,0,0q�6M   $	��Top=�6a   $
��Left=�6y   �� 5$   
   -   5        $ newProductName��5$      #���  6*   $��
184,24,0,0q�6L   $	��Top=�6`   $
��Left=�6x   �� 5&   
   #���  6   $��	Category:��68   $��
249,33,0,0q�6I   $	��Top=�6]   $
��Left=�6u   �� 5'   
   -   5         ��Name$ 
categories��5'        Combobox#���  6'   $��296,29,424,401q�6J   .@�5(      ��   ComboBoxItem#���  6   $��	Beverages��6B   �� 5)      #���  6   $��
Condiments��6B   �� 5*      #���  6   $��Confections��6B   �� 5+      #���  6   $��Dairy Products��6B   �� 5,      #���  6   $��Grains/Cereals��6B   �� 5-      #���  6   $��Meat/Poultry��6B   �� 5.      #���  6   $��Produce��6B   �� 5/      #���  6   $��Seafood��6B   50      �� 52   
   #���  6   $��Quantity per unit:��68   $��380,33,340,401q�6R   $	��Top=�6j   $��Center=�6�   �� 53   
   -   5        $ quantityPerUnit��53      #���  6+   $��465,24,275,406q�6M   $	��Top=�6e   $��Center=�6}   �� 55   
   #���  6   $��Price:��68   $��530,33,245,401q�6F   $	��Top=�6^   $��Center=�6v   �� 56   
   -   5        $ price��56      #���  6!   $��560,24,180,406q�6C   $	��Top=�6[   $��Center=�6s   �� 58   
   #���  6   $��Stock:��68   $��625,33,145,400q�6F   $	��Top=�6^   $��Center=�6v   �� 59   
   -   5        $ stock��59      #���  6!   $��660,24,80,406q�6C   $	��Top=�6Z   $��Center=�6r   �� 5;   
   -   5         
 Button#���  5;      $��Update��62   $��725,10,25,420q�6Y   �� 5<   
   -	   5        #���  5<      $��Delete��62   $��725,33,25,397q�6Y   5>      5?      