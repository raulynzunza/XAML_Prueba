   M S B A M L   `   `   `  ����F  BXAML_Prueba, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:XAML_Prueba.HelpersXAML_Prueba.Helpers  5      5clr-namespace:XAML_Prueba.ViewsXAML_Prueba.Views  5      ?$clr-namespace:XAML_Prueba.ViewModelsXAML_Prueba.ViewModels  5	      $    XAML_Prueba.Views.RegistroView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5helpers!clr-namespace:XAML_Prueba.Helpers     5      1localclr-namespace:XAML_Prueba.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ;
viewmodels$clr-namespace:XAML_Prueba.ViewModels     5	        N� Title$  RegistroView��5
       � 	Resources 5      +   %XAML_Prueba.ViewModels.UsersViewModel 	  users%   XAML_Prueba.Helpers.Validations  
validation��%:   &	        &	        5   
   6$     5   
   6   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $��0��5      $
��0,10q�5      $��Center=�5      $��
Bahnscrift)�5       $��17(�5!      $
��Bold"�5"      $��	Registrar��5#      �� 5%   
   $��1��5&      $��0��5'      $	��360��5(       �� Padding$ 10q�5)      $��Center=�5*      
�������
���   �$��1q�5-      ._�5.      ��  �� Orientation$ Vertical=�6   .+�5/      �� $��Nombre:��6   �� 50      -   5        $	��300��51      $	��5,0q�52      $
��Left=�53      ��55      �� *User.Nombre+ �� Mode$ TwoWay=��� 56      $��Apellido Paterno:��6   �� 57      -   5        $	��300��58      $	��5,0q�59      $
��Left=�5:      ��5<      �� *User.Apellido_P+$ TwoWay=��� 5=      $��Apellido Materno:��6   �� 5>      -   5        $	��300��5?      $	��5,0q�5@      $
��Left=�5A      ��5C      �� *User.Apellido_M+$ TwoWay=��� 5D      $��Edad:��6   �� 5E      -   5        $	��300��5F      $	��5,0q�5G      $
��Left=�5H      ��5J      �� *	User.Edad+$ TwoWay=��� 5M      $��Email:��6   �� 5N      $	��300��5O      $	��5,0q�5P      $
��Left=�5Q      ��5R      �� *
User.Email+$ TwoWay=��� 5S      $��Admin:��6   �� 5T      $	��300��5U      $	��5,0q�5V      $
��Left=�5W      	 d� 	IsChecked	 5X      �� *
User.Admin+$ TwoWay=�5Y      5Z      �� 5\   
   $��2��5]      $��0��5^      $	��400��5_      $ Vertical=�5`      .+�5a      � $��0,0,0,10q�6   .+�5b      �� $��	0,10,10,0q�5c      $
��10,3q�5d      
����  �$��0q�5f      $��Agregar��5h      
���������5g      �� *
AddCommand+5i      �� 5j      -   5        $��	0,10,10,0q�5k      $
��10,3q�5l      
���  ��$��0q�5n      $#��Cancelar y regresar al inicio��5p      
�������5q      5r      5t      5v      5w      