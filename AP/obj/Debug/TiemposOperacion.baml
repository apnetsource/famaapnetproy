   M S B A M L   `   `   `  ����O  KFAMA.AP.Desktop.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:FAMA.AP.Desktop.ViewFAMA.AP.Desktop.View  5   	   +    %FAMA.AP.Desktop.View.TiemposOperacion   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:FAMA.AP.Desktop.View     5   	     � Title$+  %Administrador de Procesos AP.NET v1.0��5   	    � 
ResizeMode$ NoResize=�67    � WindowState$ 	Maximized=�6M   $��1564.216��6e   .��5	      � $��0,0,0,-1q�6   $	��Top=�6   ��5
   
   �� 5       j� TileMode$ FlipY=�6    j� Stretch$
 Fill=�6*    j� 
AlignmentY$	 Top=�69    �� ImageSource$ img/Commons/fondo2.png��6J   .+�5   
   �� $y�Visible=�6   $��8q�6&   
������� �� CornerRadius$ 1��6N   $��0,0,0,0q�6_   ._�5      �� $��0,1,0,0q�6   ��5      �� 5      .+�5      �� $��25��6   $��        |          | ��6%   
�������
����  �$��0,0,0,0q�6o   �� 5      $��0��6   �� 5      -   5         ��Name$ myHeader��5      $��90��6/   5      �� 5      -   5        $ spnlMenu��5      $	��590��6/   $
��Left=�6<   $y�Hidden=�6W   $	��167��6k   5      5      5      �� 5   
   -   5        	 ��Name$	 btnMenu��5      $�� ��6"   $
��Left=�6-   $��7,8,0,0q�6H   $	��Top=�6Y   $��26��6q   $��26��6�   
���������5      �� 5      $ FlipXY=�6   $ UniformToFill=�6/   $ img/menuBurger.png��6G   5       �� 5!   
   -   5        $	 btnHome��5!      $�� ��6"   $
��Left=�6-   $��35,8,0,0q�6H   $	��Top=�6Z   $��26��6r   $��26��6�   
����  ���5"      �� 5#      $ FlipXY=�6   $ UniformToFill=�6/   $ img/Home.png��6G   5%      � 5'   
   $��187,132,0,0q�6   
 � RowDefinitions
 5(      �� 5)      $	��100 �6    �� 5*      $
��400* �6    .+�5-      �� -   5        $ myStack��5-      $��0,1,0,0q�6*   $��2��6;   5/      50      52      53      