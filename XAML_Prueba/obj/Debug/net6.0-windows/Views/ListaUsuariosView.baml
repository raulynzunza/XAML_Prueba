   M S B A M L   `   `   `  ����F  BXAML_Prueba, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:XAML_Prueba.ViewsXAML_Prueba.Views  5      ?$clr-namespace:XAML_Prueba.ViewModelsXAML_Prueba.ViewModels  5      )    #XAML_Prueba.Views.ListaUsuariosView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:XAML_Prueba.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ;
viewmodels$clr-namespace:XAML_Prueba.ViewModels     5        N� Title$  ListaUsuariosView��5	       � 	Resources 5      +   %XAML_Prueba.ViewModels.UsersViewModel 	  users��%   &	          5   
   6$   5      .��5      � $��Center=�5   	   $��Center=�5   	    � DataContext 5   	   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $	��500 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� -   5        $��lstUsers��5      $��0��5      ��5      �� *Users+ �� SelectedItem 5       �� *SelectedUser+ �� Mode$ TwoWay=� �� View 5!      �� 5"      .P�5#      �� $��Nombre��6%   	 �� CellTemplate	 5$      �� 5%      .R�5&   "   �� ��6,   �� *Nombre+5'      5)      �� 5*      $��
Apellido_P��6%   	 5+      �� 5,      .R�5-   "   �� ��6,   �� *
Apellido_P+5.      50      �� 51      $��
Apellido_M��6%   	 52      �� 53      .R�54   "   �� ��6,   �� *
Apellido_M+55      57      �� 58      $
��Edad��6%   	 59      �� 5:      .R�5;   "   �� ��6,   �� *Edad+5<      5>      �� 5?      $��Email��6%   	 5@      �� 5A      .R�5B   "   �� ��6,   �� *Email+5C      5E      �� 5F      $��Admin��6%   	 5G      �� 5H      .R�5I   "   �� ��6,   �� *Admin+5J      5L      5M      5O      � 5P   
   $��1��6   .+�5Q      �� $��	0,10,10,0q�5R      $
��10,3q�5S      
���  ��$��0q�5U      $��Eliminar��5W      
���������5V      �� *DeleteCommand+5X      �� 5Y      -   5        $��1��5Z      $��	0,10,10,0q�5[      $
��10,3q�5\      
���"�"�$��0q�5^      $��	Modificar��5`      
�������5a      �� 5b      -   5        $��	0,10,10,0q�5c      $
��10,3q�5d      
���  ��$��0q�5f      $#��Cancelar y regresar al inicio��5h      
�������5i      5j      5k      5l      