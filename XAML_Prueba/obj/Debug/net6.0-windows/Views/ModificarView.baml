   M S B A M L   `   `   `  ����F  BXAML_Prueba, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:XAML_Prueba.HelpersXAML_Prueba.Helpers  5      5clr-namespace:XAML_Prueba.ViewsXAML_Prueba.Views  5      ?$clr-namespace:XAML_Prueba.ViewModelsXAML_Prueba.ViewModels  5	      %    XAML_Prueba.Views.ModificarView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5helpers!clr-namespace:XAML_Prueba.Helpers     5      1localclr-namespace:XAML_Prueba.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ;
viewmodels$clr-namespace:XAML_Prueba.ViewModels     5	        � Title$  ModificarView��5
      $	��800��5      $	��450��5       � 	Resources 5      +   %XAML_Prueba.ViewModels.UsersViewModel 	  users%   XAML_Prueba.Helpers.Validations  
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
��Bold"�5"      $��	Modificar��5#      �� 5$   
   $��1��5%      $��0��5&      $	��360��5'       �� Padding$ 10q�5(      $��Center=�5)      
�������
���   �$��1q�5,      ._�5-      ��  �� Orientation$ Vertical=�6   .+�5.      �� $��Nombre:��6   �� 5/      -   5         ��Name$
 name��50      $	��300��51      $	��5,0q�52      $
��Left=�53      ��55      �� *SelectedUser.Nombre+	 �� Mode$	 TwoWay=��� 56      $��Apellido Paterno:��6   �� 57      -   5        $ 
apellido_p��58      $	��300��59      $	��5,0q�5:      $
��Left=�5;      ��5=      �� *SelectedUser.Apellido_P+$	 TwoWay=��� 5>      $��Apellido Materno:��6   �� 5?      -   5        $ 
apellido_m��5@      $	��300��5A      $	��5,0q�5B      $
��Left=�5C      ��5E      �� *SelectedUser.Apellido_M+$	 TwoWay=��� 5F      $��Edad:��6   �� 5G      -   5        $
 edad��5H      $	��300��5I      $	��5,0q�5J      $
��Left=�5K      ��5M      �� *SelectedUser.Edad+$	 TwoWay=��� 5N      $��Email:��6   �� 5O      -   5        $ email��5P      $	��300��5Q      $	��5,0q�5R      $
��Left=�5S      ��5T      �� *SelectedUser.Email+$	 TwoWay=��� 5U      $��Admin:��6   �� 5V      -   5        
 ��Name$
 admin��5W      $	��300��5X      $	��5,0q�5Y      $
��Left=�5Z       d� 	IsChecked 5[      �� *SelectedUser.Admin+$	 TwoWay=�5\      5]      �� 5_   
   $��2��5`      $��0��5a      $	��400��5b      $ Vertical=�5c      .+�5d      � $��0,0,0,10q�6   .+�5e      �� -   5        $��	0,10,10,0q�5f      $
��10,3q�5g      
���"�"�$��0q�5i      $��	Modificar��5l      
���������5k      �� *EditCommand+5m      5n      5p      5r      5s      