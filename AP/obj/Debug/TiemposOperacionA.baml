   M S B A M L   `   `   `  ����L  HFAMA.AP.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:FAMA.AP.ViewModel;assembly=FAMA.AP.ViewModelFAMA.AP.ViewModel  5   	   O KFAMA.AP.Desktop.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:FAMA.AP.Desktop.ViewFAMA.AP.Desktop.View 5   	   G(clr-namespace:FAMA.AP.Desktop.View.ADMINFAMA.AP.Desktop.View.ADMIN 5   	   ,   &FAMA.AP.Desktop.View.TiemposOperacionA   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Ivm:clr-namespace:FAMA.AP.ViewModel;assembly=FAMA.AP.ViewModel     5   	   9
myControls"clr-namespace:FAMA.AP.Desktop.View     5   	   CGraficaControl(clr-namespace:FAMA.AP.Desktop.View.ADMIN     5   	     � Title$+  %Administrador de Procesos AP.NET v1.0��5   	    � 
ResizeMode$ NoResize=�67    � WindowState$ 	Maximized=�6M   $
��1920��6e    � 	Resources 5      )   #FAMA.AP.ViewModel.SectionsViewModel   	ViewModel��%   &	          5	   
   6   5
      .��5      � $��0,0,0,-1q�6E   $	��Top=�6W    � DataContext 6   ��  �� Source# [  ��5   
   �� 5       j� TileMode$ FlipY=�6    j� Stretch$
 Fill=�6*    j� 
AlignmentY$	 Top=�69   	 �� ImageSource$	 img/Commons/fondo2.png��6J   .+�5   
   �� $y�Visible=�6   $��8q�6&   
�������
 �� CornerRadius$
 1��6N   $��0,0,0,0q�6_   ._�5      �� $��	-2,2,2,-1q�6   ��5      �� 5      .+�5      �� $��25��6   $��       |          | ��6%   
�������
����  �$��0,0,0,0q�6n   �� 5      $��0��6   �� 5      -   5         ��Name$ myHeader��5      $��90��6/   5      �� 5      -   5        $ spnlMenu��5      $	��590��6/   $
��Left=�6<   $y�Hidden=�6W   $	��167��6k   5      �� 5      -   5        $ 
sectionBar��5      $	��100��61   5      5      �� 5   
   -   5         ��Name$ btnMenu��5      $�� ��6"   $
��Left=�6-   $��7,8,0,0q�6H   $	��Top=�6Y   $��26��6q   $��26��6�   
���������5      �� 5      $ FlipXY=�6   $ UniformToFill=�6/   $	 img/menuBurger.png��6G   5!      �� 5"   
   -   5        $ btnHome��5"      $�� ��6"   $
��Left=�6-   $��38,8,0,0q�6H   $	��Top=�6Z   $��26��6r   $��26��6�   
����  � J� RenderTransformOrigin$ 1.282,0.423&�6�   ��5#      �� 5$      $ FlipXY=�6   $ UniformToFill=�6/   $	 img/Home.png��6G   5&      � 5(   
   .+�5)      (  "FAMA.AP.Desktop.View.MechanismView  $��
55,0,0,120q�6'   $
��Left=�6;   $��Center=�6W   5*      � 5+   
   $��187,132,0,0q�6   .+�5,      %  FAMA.AP.Desktop.View.EventsView  $��-104,249,0,209q�6$   $
��Left=�6<   $��Center=�6X   $	��136��6s   $	��448��6�   5-      � 5/   
   .+�50      *  $FAMA.AP.Desktop.View.ADMIN.BarSeries  $��500,150,0,146q�6'   $
��Left=�6>   $��Center=�6Z   $	��290��6u   $	��965��6�   6�   51      53      54      