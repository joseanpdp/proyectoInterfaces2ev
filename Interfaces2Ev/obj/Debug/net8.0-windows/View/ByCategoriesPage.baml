   M S B A M L   `   `   `  ����H  DInterfaces2Ev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Interfaces2Ev.ViewInterfaces2Ev.View  5      )    #Interfaces2Ev.View.ByCategoriesPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Interfaces2Ev.View     5        N� Title$  ByCategories��5	       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /RD/ViewRD.xaml?�6%   %    5      .��5      �    Grid#���   6   .+�5   
   �� $��Center=�6   $��Center=�61   $��132,28,433,396q�6L   $��Choose a category:��6d   
�������$��16(�6�   �� 5   
   -   5         ��Name$ 
categories��5        Combobox#���  6'   $��295,31,290,399q�6J   .@�5      ��   ComboBoxItem#���  6   $��*��69   �� 5      #���  6   $��	Beverages��6B   �� 5      #���  6   $��
Condiments��6B   �� 5      #���  6   $��Confections��6B   �� 5      #���  6   $��Dairy Products��6B   �� 5      #���  6   $��Grains/Cereals��6B   �� 5      #���  6   $��Meat/Poultry��6B   �� 5      #���  6   $��Produce��6B   �� 5       #���  6   $��Seafood��6B   5!      �� 5#   
   -   5         
 Button#���  5#      $��Search��62   $��455,26,165,394q�6C   6[   &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$$ productsWithCategoriesDatagrid��5%   6     DataGrid#���  6   $	��650��6^   $	��350��6j   $��25,80,25,20q�6w      AutoGenerateColumns$ False��6�      Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Product Name��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 1.1* 6;   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6H   ��  �� Path$ ProductName�  5(      $ Category��6%   $	 * 67   
 6A   �� $ CategoryName�  5)      $ Quantity per unit��6%   $	 * 6@   
 6J   �� $ QuantityPerUnit�  5*      $ Price��6%   $	 * 64   
 6>   �� $ 	UnitPrice�  5+      $ Stock��6%   $	 * 64   
 6>   �� $ UnitsInStock�5-      5/      50      