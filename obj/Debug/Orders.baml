   M S B A M L   `   `   `  ����H  DDataSetPrakt1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DataSetPrakt1DataSetPrakt1  5   	       DataSetPrakt1.Orders   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DataSetPrakt1     5   	     � Title$  Orders��5   	   $	��450��6   $	��800��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      $��90 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� 
���   �$��2q�6%   $��3��69   ._�5      �� -   5         ��Name$ tekstik��5      $#��Таблица заказов��6)   
�������$��22(�6Z    �� TextAlignment$ Center=�6h   5      �� 5   
   -   5         ��Name$
 exit��5      $��3��6   $��
Выход��6/   
�������6M   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ GridDataOrders��5   %      
IsReadOnly . $��1��6=   $��3��6J   $��4��6[   
�������6�   �� 5   
   -   5        $��3��5      $+��%Управление таблицой��61    � 5   
   -   5          �Name$ 
RedakOrder��5      $��4��6$   $��4��65   5      5      