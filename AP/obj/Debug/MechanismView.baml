   M S B A M L   `   `   `  ����L  HFAMA.AP.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:FAMA.AP.ViewModel;assembly=FAMA.AP.ViewModelFAMA.AP.ViewModel  5   	    FAMA.AP.Desktop.View(   "FAMA.AP.Desktop.View.MechanismView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Ivm:clr-namespace:FAMA.AP.ViewModel;assembly=FAMA.AP.ViewModel     5   	   $
��1095��6O     � 	Resources  5      -   'FAMA.AP.ViewModel.ProcessValueViewModel   	ViewModel��%   &	          5   
   6#   5      .��5	      � $��	-53,0,0,0q�6E    � DataContext 6   ��  �� Source# [   � RowDefinitions 5
   
   �� 5      $	��116 �6   6+   �� 5      $��46 �6   6*   �� 5      $	��292 �6   6+   �� 5      $��9 �6   6)   �� 5      $	��154 �6   6+    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $	��117��6,   �� 5      $��170.708 �6   �� 5      $��55.693 �6   �� 5      $��95 �6   �� 5      $��46 �6   �� 5      $	��192 �6   �� 5      $
��Auto �6   $	��230��6,   �� 5      $
��Auto �6   $	��535��6,   .+�5   
   �� -   5         ��Name$ barra��5      $��/img/barra.png��6   $��6��67   $
��Left=�6G   $��58��6b   $��87.599,0,0,0q�6n   $��4��6�   $��Bottom=�6�   $	��334��6�   $��2��6�   &   System.Windows.Controls.DataGrid  5    
   -   5        $��grdMechanism��5    �      AutoGenerateColumns .     CanUserAddRows .     AlternatingRowBackground
 �����$	��375��6�   $��2��6�   $��1��6�   	   HorizontalGridLinesBrush	 �	#FFDEDBDB
   VerticalGridLinesBrush
 �	#FFDEDBDB$��4��63  $��82,67,0,138q�6G  $��3��6\  $	��250��6m  ��6   �� *ProcessValues+   ColumnHeaderStyle 5!      �� 5"       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5#      ��  �� Property � �� �� Value$
 Bold"�63   �� 5$       � ��$ 17(�61   �� 5%       � ��$ Arial)�63   �� 5&       � ��
 �����63   �� 5'       � ��$ 50��6/   �� 5(       � ��$	 200��6.   �� 5)       � �� 5*      �� 5+       �� ImageSource$ /img/rectanguloDos.png��6)    j� Stretch$ UniformToFill=�6N   5-      �� 5.       � ��$
 Left=�6C   5/         RowStyle 51      �� 52      )  #System.Windows.Controls.DataGridRow"  6   .�53      ��  � ��$ 12(�61   �� 54       � ��$ Arial)�63   �� 55       � ��
 �   �63   �� 56       � ��
 �����63   �� 57       � ��$ 30��6/   58         Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Señales��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 210 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	tmpName+6R     5<      $ Eventos��6%   $ 65 6Q      
IsReadOnly .  66   �� *fTotEv+6\     5=      $ Totales��6%   $ 65 6R    .  66   �� *	fTotals+6]   5?      �� 5A   
   -   5         ��Name$ btnEdit��5A      $��6��6"   $
��Left=�62   $��122.599,93,0,9q�6M   $��4��6e   $��54��6r   ���	#00000000���	#FF287FC1.��5B      ��  �� Orientation$ 
Horizontal=�6   .+�5C      ��   Edit#���  6   $��43��6C   $��49��6O   5D      5E      5F      5G      