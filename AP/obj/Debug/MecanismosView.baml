   M S B A M L   `   `   `  ����L  HFAMA.AP.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:FAMA.AP.ViewModel;assembly=FAMA.AP.ViewModelFAMA.AP.ViewModel  5   	   O KFAMA.AP.Desktop.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:FAMA.AP.Desktop.ViewFAMA.AP.Desktop.View 5   	   ;"clr-namespace:FAMA.AP.Desktop.ViewFAMA.AP.Desktop.View 5   	   )   #FAMA.AP.Desktop.View.MecanismosView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Ivm:clr-namespace:FAMA.AP.ViewModel;assembly=FAMA.AP.ViewModel     5   	   9
myControls"clr-namespace:FAMA.AP.Desktop.View     5   	   =GraficaControl"clr-namespace:FAMA.AP.Desktop.View     5   	     � Title$+  %Administrador de Procesos AP.NET v1.0��5   	    � 
ResizeMode$ NoResize=�67    � WindowState$ 	Maximized=�6M   $
��1920��6e    � 	Resources 5      +   %FAMA.AP.ViewModel.MecanismosViewModel   	ViewModel��%   &	          5	   
   6!   5
      .��5      � $��0,0,0,-1q�6E   $	��Top=�6W    � DataContext 6   ��  �� Source# [  ��5   
   �� 5       j� TileMode$ FlipY=�6    j� Stretch$
 Fill=�6*    j� 
AlignmentY$	 Top=�69   	 �� ImageSource$	 img/Commons/fondo2.png��6J   .+�5   
   �� $y�Visible=�6   $��8q�6&   
�������
 �� CornerRadius$
 1��6N   $��0,0,0,0q�6_   ._�5      �� $��-12,2,12,-1q�6   ��5      �� 5      .+�5      �� $��25��6   $��       |          | ��6%   
�������
����  �$��0,0,0,0q�6n   �� 5      $��0��6   �� 5      -   5         ��Name$ myHeader��5      $��90��6/   5      �� 5      -   5        $ spnlMenu��5      $	��590��6/   $
��Left=�6<   $y�Hidden=�6W   $	��167��6k   5      �� 5      -   5        $ 
sectionBar��5      $	��100��61   �� 5      -   5         ��Name$ checkBox��5      $��CheckBox��6-   5      5      �� 5   
   -   5         ��Name$ btnMenu��5      $�� ��6"   $
��Left=�6-   $��7,8,0,0q�6H   $	��Top=�6Y   $��26��6q   $��26��6�   
���������5      �� 5       $ FlipXY=�6   $ UniformToFill=�6/   $	 img/menuBurger.png��6G   5"      �� 5#   
   -   5        $ btnHome��5#      $�� ��6"   $
��Left=�6-   $��38,8,0,0q�6H   $	��Top=�6Z   $��26��6r   $��26��6�   
����  � J� RenderTransformOrigin$ 1.282,0.423&�6�   ��5$      �� 5%      $ FlipXY=�6   $ UniformToFill=�6/   $	 img/Home.png��6G   5'      � 5,   
   $ 0.673,0.307&�6I   $��292,0,-366,0q�6m    6   �� # [   � RowDefinitions 5-      �� 5.      $��71 �6    6.   �� 5/      $��25 �6    �� 50      $��92 �6    �� 51      $
��Auto �6    $	��449��6.   6@    � ColumnDefinitions 56      �� 57      $��0 �6#   �� 58      $	��337 �6#   �� 59      $
��Auto �6#   $	��706��60   �� 5:      $
��146* �6#   �� 5;      $
��725* �6#   .+�5?      �� $��Maquina:��6   $��Right=�6(   $��Bottom=�6D   $��0,0,22,6q�6_   $��1��6q   $��16��6~   $��53��6�   $ 0.589,-0.906&�6�   $��2��6�   �� 5@      -   5         ��Name$ 
cmbMaquina��5@      $��
12,1,462,2q�6,   $��2��6@   $��1��6P    �� DisplayMemberPath$ vcName��6�    �� SelectedValuePath$ idMachineType��6�    �� SelectedIndex$ 0��6&  ��6]   �� *MaquinaList+ �� Mode$ OneWay=� �� SelectedValue 6�   �� *idMachineType+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 68  �� *SelectedProceso+�� 5B      -   5        $ 	cmbEstado��5B      $��11,0,462,70q�6+   $��2��6@   $ 0.5,0.5&�6P   $��2��6p   �� 5C      $��Proceso:��6   $��Right=�6(   $��Bottom=�6E   $��	0,0,24,76q�6`   $��16��6s   $��51��6   $ 	0.426,4.5&�6�   $��2��6�   $��2��6�   &   System.Windows.Controls.DataGrid  5E      -	   5        $��GridProcess��5E      $
��Left=�6M   $	��285��6h   $	��Top=�6u      AutoGenerateColumns .  $��3��6�   $��2��6�   $��
100,66,0,0q�6�      CanUserAddRows .  $	��860��6�   $��2��6  ��6*   �� *
Mecanismos+   Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6)      MaxWidth$ 0Q�6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Mecanismos.IdMecanismo+6^     5H      $ Nemotecnico��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6i    6>   �� *Mecanismos.Nemotecnico+6i     5I      $ 	Mecanismo��6)   $ * 6e    6<   �� *Mecanismos.Mecanismo+6e     5J      $ Tipo Valvula��6)   $ * 6j    6?   �� *Mecanismos.TipoValvula+6j   5L      �� 5N      -
   5          ��Name$  barra��5N      $��/img/barra.png��6#   $
��Left=�6;   $��
0,273,0,45q�6V   $��3��6j   $	��334��6w   $��2��6�   �� 5O      -   5        $ btn_edit��5O      $��2��6'   $
��Left=�67   $��30,287,0,105q�6R   $��3��6h   $��54��6u   ���	#00000000���	#FF287FC1.��5P      �� ! �� Orientation$! 
Horizontal=�6   .+�5Q      ��   Edit#���  6   $��43��6G   $��49��6S   5R      5S      �� 5T      -   5        $ btn_add��5T      $��2��6&   $
��Left=�66   $��100,287,0,105q�6Q   $��3��6h   $��54��6u   ���	#00000000���	#FF287FC1$ 1.519,0.293&�6�   .��5U      �� $! 
Horizontal=�6   .+�5V      ��   Save#���  6   $��43��6G   $��49��6S   5W      5X      �� 5Y      -   5        $ btn_Cancelar��5Y      $��2��6+   $
��Left=�6;   $��170,287,0,105q�6V   $��3��6m   $��54��6z   ���	#00000000���	#FF287FC1$ 1.519,0.293&�6�   .��5Z      �� $! 
Horizontal=�6   .+�5[      ��  
 Cancel#���  6   $��43��6I   $��49��6U   5\      5]      �� 5^      -   5        $ btn_Tranmistir��5^      $��2��6-   $
��Left=�6=   $��240,287,0,105q�6X   $��3��6o   $��54��6|   ���	#00000000���	#FF287FC1$ 1.519,0.293&�6�   .��5_      �� $! 
Horizontal=�6   .+�5`      �� #���  6   $��43��6G   $��49��6S   5a      5b      �� 5c      -   5        $ cmbConfiguracion��5c      $��11,24,462,46q�62   $��2��6H   $ 0.5,0.5&�6X   $��2��6x   �� 5d      $��Configuracion:��6   $��Right=�6.   $��Bottom=�6K   $��
0,0,702,52q�6f   $��16��6z   $��80��6�   $ 	0.426,4.5&�6�   $��2��6�   $��3��6�   5f      5i      5j      