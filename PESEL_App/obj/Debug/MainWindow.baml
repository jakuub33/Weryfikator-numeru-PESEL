   M S B A M L   `   `   `  ����D  @PESEL_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PESEL_App	PESEL_App  5   	       PESEL_App.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PESEL_App     5   	     � Title$  Sprawdź numer PESEL��5   	   $	��400��6%   $	��600��61    � 
ResizeMode$ CanMinimize=�6>    � Icon$ person_icon.png��6W   .��5
      � ���	#FF313131.+�5   
   �� $
��Left=�6   $��	65,34,0,0q�6/   $
��Wrap=�6B   $��Wprowadź numer PESEL��6V   $	��Top=�6r   
�������$��24(�6�   �� 5   
   -   5         ��Name$ txtPesel��5      $
��Left=�6$   $��37��6?   $��
102,80,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��155��6�   $��24(�6�    �� 	MaxLength$ 11��6�   ��5   g   Z� �� 5   
   $
��Left=�6   $��
85,150,0,0q�6/   $
��Wrap=�6C   $��Podaj datę urodzenia��6W   $	��Top=�6s   
�������$��24(�6�   �� 5   
   $
��Left=�6   $��125,249,0,0q�6/   $
��Wrap=�6D   $��Wybierz płeć��6X   $	��Top=�6l   
�������$��24(�6�   	� 5   
   -   5         	�Name$	 rbK��5      $��
65,296,0,0q�6#    � Cursor$
 Hand��67   
�������$��19��6X   $	��105��6d   $��16(�6p   $
��Left=�6~   $	��Top=�6�   $��Kobieta��6�   	� 5   
   -   5        $	 rbM��5      $��220,296,0,0q�6#   $
 Hand��68   
�������$��19��6Y   $	��102��6e   $��16(�6q   $
��Left=�6   $	��Top=�6�   $��Mężczyzna��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpDateBirth��5      $
��Left=�6*   $��142,197,0,0q�6E   $	��Top=�6Z   $��14(�6�   $
 Hand��6�   ��6r   Z� 6�   �� 5   
   -   5        	 ��Name$	 btnCheckPesel��5      $��Sprawdź numer PESEL��6(   $
��Left=�6F   $��
65,358,0,0q�6a   $	��Top=�6u   $	��257��6�   $��22(�6�   
�������$��2q�5      
����������	#FF1D1D1D$
 Hand��6l   �� 5   
   -   5        $	 btnCheckDate��5      $��Sprawdź datę urodzenia��6'   $
��Left=�6H   $��
65,419,0,0q�6c   $	��Top=�6w   $	��257��6�   $��22(�6�   
�������$��2q�5      
����������	#FF1D1D1D$
 Hand��6k   �� 5   
   -   5        $	 btnCheckGender��5      $��Sprawdź płeć��6)   $
��Left=�6@   $��
65,482,0,0q�6[   $	��Top=�6o   $	��257��6�   $��22(�6�   
�������$��2q�5      
����������	#FF1D1D1D$
 Hand��6m   �� 5   
   -   5        $��X��5      $
��Left=�6   $��
257,80,0,0q�68   $	��Top=�6L   $��33��6d   $��37��6o   
�������$��25(�6�   ��6�   Z� 6�   �� 5   
   -	   5        
 ��Name$
 tbMinLength��5      $
��Left=�6)   $��
97,117,0,0q�6D   $
��Wrap=�6X   $	��Top=�6l   ���	#FFF30000$��14(�6�   5      5      