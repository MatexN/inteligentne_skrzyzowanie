   M S B A M L   `   `   `  ����I  EOkno_aplikacji, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Okno_aplikacjiOkno_aplikacji  5   	       Okno_aplikacji.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Okno_aplikacji     5   	     � Title$,  &Symulator Inteligentnego Skrzyżowania��5   	   $	��396��67   $	��591��6D   .��5	      � $��	0,0,2,-31q�6   .+�5
   
   �� -   5         ��Name$ 
Background��5
      $
��Left=�6$   $	��282��6?   $	��Top=�6L   $	��405��6d   $��	40,52,0,0q�6p   $��IMG/skrzyzowanie.png��6�   �� 5   
   -   5         ��Name$ V_down��5      $
��Left=�6$   $��204,217,0,0q�6?   $
��Wrap=�6T   $��	TextBlock��6h   $	��Top=�6y   
��� ���$y�Hidden=�6�   �� 5   
   -   5        $
 V_up��5      $
��Left=�6"   $��204,145,0,0q�6=   $
��Wrap=�6R   $��	TextBlock��6f   $	��Top=�6w   
��� ���$y�Hidden=�6�    J� RenderTransformOrigin$ 0.531,-0.562&�6�   �� 5   
   -   5        $ H_right��5      $
��Left=�6%   $��273,172,0,0q�6@   $
��Wrap=�6U   $��	TextBlock��6i   $	��Top=�6z   
��� ���$ 	3.51,0.75&�6�   $y�Hidden=�6�   �� 5   
   -   5        $ H_left��5      $
��Left=�6$   $��138,172,0,0q�6?   $
��Wrap=�6T   $��	TextBlock��6h   $	��Top=�6y   $ -0.082,0.812&�6�   
��� ���$y�Hidden=�6�   �� 5   
   -   5         ��Name$ label��5      $R��LIlość pojazdów oczekujących na przejazd przez inteligentne skrzyżowanie��6   $
��Left=�6q   $��	40,21,0,0q�6�   $	��Top=�6�   $	��405��6�   �� 5   
   -   5         ��Name$ Start_Button��5      $��Start��6'   $
��Left=�67   $��
471,66,0,0q�6R   $	��Top=�6f   $��75��6~   $ 
0.52,-1.15&�6�   {�. 6�   �� 5   
   -   5        $ Stop_Button��5      $
��Stop��6&   $
��Left=�65   $��471,112,0,0q�6P   $	��Top=�6e   $��75��6}   $ 
0.493,-0.8&�6�   {�.  6�   �� 5   
   -	   5        $��
Statystyki��5      $
��Left=�6&   $��471,295,0,0q�6A   $	��Top=�6V   $��75��6n   6y   � 5   
   -
   5         �Name$ 
TablePopup��5   T   $��Bottom=�6    � AllowsTransparency . $
��Fade=�6>    � VerticalOffset$
 -395��6h   	 � HorizontalOffset$		 590��6~   .��5      �� 
�������$	��299��60   .+�5      �� $��
Statystyki��6   $��Center=�6-   &   System.Windows.Controls.DataGrid  5      -   5        
  Name$
 
Statistics��5      $��Center=�6/   
���   �$	��292��6_      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nr Sesji��6-   -   5        ColumnSNumber��5   ?     5      $ 
Czas sesji��6-   -   5        ColumnSTime��5   A     5      $ L. Jednośladów��6-   -   5        ColumnSTrack��5   E     5      $ L. Aut��6-   -   5        	ColumnCar��5   =     5      $ 	L. Tirów��6-   -   5        ColumnTruck��5   ?   5      5       5!      5"      5#      