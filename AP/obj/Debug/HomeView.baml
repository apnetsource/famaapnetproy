   M S B A M L   `   `   `  ����O  KFAMA.AP.Desktop.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:FAMA.AP.Desktop.ViewFAMA.AP.Desktop.View  5   	   #    FAMA.AP.Desktop.View.HomeView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:FAMA.AP.Desktop.View     5   	     � Title$+  %Administrador de Procesos AP.NET v1.0��5   	    � 
ResizeMode$ NoResize=�67    � WindowState$ 	Maximized=�6M   $��1564.216��6e   .��5	      � $��0,0,0,-1q�6   $	��Top=�6   ��5
   
   �� 5       j� TileMode$ FlipY=�6    j� Stretch$
 Fill=�6*    j� 
AlignmentY$	 Top=�69    �� ImageSource$ img/Commons/fondo2.png��6J   .+�5   
   �� $y�Visible=�6   $��8q�6&   
������� �� CornerRadius$ 1��6N   $��0,0,0,0q�6_   ._�5      �� $��0,1,0,0q�6   ��5      �� 5      .+�5      �� $��25��6   $��        |          | ��6%   
�������
����  �$��0,0,0,0q�6o   �� 5      $��0��6   �� 5      -   5         ��Name$ myHeader��5      $��90��6/   5      �� 5      -   5        $ spnlMenu��5      $	��590��6/   $
��Left=�6<   $y�Hidden=�6W   $	��167��6k   .+�5      �� -   5        	 ��Name$	 
btnAlarmas��5      $��ALARMAS��61   ���	#FF2B89E06\   �� 5      -   5        $	 	btnConfig��5      $��CONFIGURACION��60   ���	#FF2B89E06`   �� 5      -   5        $ spnlMenuConfiguracion��5   !   $y�Hidden=�6A   .+�5      �� -   5        $	 btnCambMoldura��5   !   $��CAMBIO MOLDURA��69   ���	#FF5DAFE6$��0��6i   �� 5      -   5        $	 btnLinea��5   !   $��LINEA��63   ���	#FF5DAFE6$��0��6Z   6e   �� 5      -   5        $	 btnCeis��5   !   $
��CEIS��62   ���	#FF5DAFE6$��0��6X   6c   �� 5      -	   5        $	 btnProcCiclo��5   !   $��PROCESOS Y CICLO��67   ���	#FF5DAFE6$��0��6i   �� 5      -
   5        $	 
btnSenales��5   !   $��SEÑALES��65   ���	#FF5DAFE6$��0��6^   �� 5       -   5        $	 
btnSiervos��5    !   $��SIERVOS��65   ���	#FF5DAFE6$��0��6^   �� 5!      -   5        $	 btnTipoPros��5!   !   $��TIPO PROCESO��66   ���	#FF5DAFE6$��0��6d   6o   �� 5"      -   5        $	 btnUsuarios��5"   !   $��USUARIOS��66   ���	#FF5DAFE6$��0��6z   �� 5#      -   5        $	 
btnCliente��5#   !   $��CLIENTE��65   ���	#FF5DAFE6$��0��6x   5%      �� 5&      -   5        $	 
btnGrafica��5&      $��GRAFICAS��61   ���	#FF2B89E06]   �� 5'      -   5        $	 
btnProceso��5'      $��PROCESOS��61   ���	#FF2B89E06]   �� 5(      -   5        $ spnlMenuProcesos��5(   !   $y�Hidden=�6<   .+�5)      �� -   5        $	 btnTiemposOperacion��5)   !   $��TIEMPOS DE OPERACION��6>   ���	#FF5DAFE66t   �� 5*      -   5        $	 btnCicloCeramico��5*   !   $��CICLO CERAMICO��6;   ���	#FF5DAFE66T   �� 5+      -   5        $	 btnContrapresion��5+   !   $��CONTRAPRESION��6;   ���	#FF5DAFE66S   �� 5,      -   5        $	 btnRelMecanicas��5,   !   $��REL.MECANICAS��6:   ���	#FF5DAFE66R   �� 5-      -   5        $	 btnTipoOperacion��5-   !   $��TIPO OPERACION��6;   ���	#FF5DAFE66T   �� 5.      5/      �� 50      -   5        $	 	btnCerrar��50      $��CERRAR��60   ���	#FF2B89E06Y   51      53      54      �� 55   
   -   5        $	 btnMenu��55      $�� ��6"   $
��Left=�6-   $��7,8,0,0q�6H   $	��Top=�6Y   $��26��6q   $��26��6�   
���������56      �� 57      $ FlipXY=�6   $ UniformToFill=�6/   $ img/menuBurger.png��6G   59      �� 5:   
   -   5        $	 btnHome��5:      $�� ��6"   $
��Left=�6-   $��35,8,0,0q�6H   $	��Top=�6Z   $��26��6r   $��26��6�   
����  ���5;      �� 5<      $ FlipXY=�6   $ UniformToFill=�6/   $ img/Home.png��6G   5>      � 5@   
   $��187,132,0,0q�6   
 � RowDefinitions
 5A      �� 5B      $	��100 �6    �� 5C      $
��400* �6    .+�5F      �� -   5        $ myStack��5F      $��0,1,0,0q�6*   $��2��6;   5H      5I      5K      5L      