   M S B A M L   `   `   `  ����H  DInterfaces2Ev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Interfaces2Ev.ViewInterfaces2Ev.View  5      #    Interfaces2Ev.View.QuerysPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Interfaces2Ev.View     5        N� Title$  
QuerysPage��5	       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /RD/ViewRD.xaml?�6%   %    5      .��5      �    Grid#���   6   $��Center=�6*   $��Center=�6E   .+�5   
   ��   	TextBlock#���  6   $��Product Name:��68   $��107,87,260,336q�6M   $��20(�6e   �� 5   
   -   5         ��Name$ productName��5        TextBox#���  6'   $��
249,87,0,0q�6I   $��24��6]   $	��Top=�6i   $
��Left=�6�   $	��126��6�   $��20(�6�   �� 5   
   #���  6   $��	Category:��68   $��153,128,260,291q�6I   $��16(�6b   �� 5   
   -   5         ��Name$ 
categories��5        Combobox#���  6'   $��247,131,0,0q�6J   $��16(�6_   $
��Left=�6m   $	��170��6�   $��28��6�   $	��Top=�6�   .@�5      ��   ComboBoxItem#���  6   $��	Beverages��6B   �� 5      #���  6   $��
Condiments��6B   �� 5      #���  6   $��Confections��6B   �� 5      #���  6   $��Dairy Products��6B   �� 5      #���  6   $��Grains/Cereals��6B   �� 5      #���  6   $��Meat/Poultry��6B   �� 5       #���  6   $��Produce��6B   �� 5!      #���  6   $��Seafood��6B   5"      �� 5$   
   #���  6   $��Quantity per unit:��68   $��83,165,260,255q�6R   $��20(�6j   $
��auto��6x   $
��auto��6�   �� 5%   
   -   5        $ quantityPerUnit��5%      #���  6+   $��247,165,0,0q�6M   $	��128��6b   $��20(�6n   $
��Left=�6|   $��26��6�   $	��Top=�6�   �� 5'   
   #���  6   $��Price:��68   $��191,210,258,213q�6F   $��20(�6_   �� 5(   
   -   5        $ price��5(      #���  6!   $��249,210,0,0q�6C   $��20(�6X   $
��Left=�6f   $	��126��6�   $��24��6�   $	��Top=�6�   �� 5*   
   #���  6   $��Stock:��68   $��187,248,0,175q�6F   $��20(�6]   $
��Left=�6k   $��52��6�   �� 5+   
   -   5        $ stock��5+      #���  6!   $��249,248,0,0q�6C   $��20(�6X   $
��Left=�6f   $	��126��6�   $��24��6�   $	��Top=�6�   �� 5-   
   -   5         
 Button#���  5-      $��Create��62   $��	0,315,0,0q�6C   $��20(�6l   $��Center=�6z   $	��100��6�   $��35��6�   $	��Top=�6�   5/      50      