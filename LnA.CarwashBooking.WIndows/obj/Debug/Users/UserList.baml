   M S B A M L   `   `   `  ����U  QLnA.CarwashBooking.WIndows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:LnA.CarwashBooking.WIndows.Users LnA.CarwashBooking.WIndows.Users  5   	   /    )LnA.CarwashBooking.WIndows.Users.UserList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:LnA.CarwashBooking.WIndows.Users     5   	     � Title$  UserList��5   	   $	��450��6   $	��800��6'   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgUsers��5      $
��Left=�6$   $	��214��6?   $��	35,78,0,0q�6L   $	��Top=�6_   $	��704��6w      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   5   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *	FirstName+65     5      $ 	Last Name��6%   $ * 5   4    6   �� *
LastName+64     5      $ Email Address��6%   $ * 5   1    6   �� *Email+61     5      $ Contact Number��6%   $ * 5   9    6   �� *ContactNumber+69     5      $ Gender��6%   $ * 5   2    6   �� *Gender+62     5      $
 Role��6%   $ * 5   0    6   �� *Role+60   5      �� 5   
   -   5         ��Name$ btnFirst��5      $��First��6#   $
��Left=�63   $	��Top=�6N   $��75��6f   $��18��6q   $��
35,316,0,0q�6}   6�   �� 5   
   -   5        $ btnLast��5      $
��Last��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��275,316,0,0q�6{   6�   �� 5   
   -   5        $ btnNext��5      $
��Next��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��195,316,0,0q�6{   	 J� RenderTransformOrigin$	 0.615,2.311&�6�   6�   �� 5   
   -   5        $ btnPrevious��5      $��Previous��6&   $
��Left=�69   $	��Top=�6T   $��75��6l   $��18��6w   $��115,316,0,0q�6�   6�   �� 5   
   -   5        
 ��Name$
 txtPageSize��5      $��5��6'   $
��Left=�60   $��23��6K    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $��75��6�   $��115,339,0,0q�6�   6�   �� 5    
   -   5         ��Name$ lblPageSize��5       $��	Page Size��6%   $
��Left=�69   $	��Top=�6T   $��
35,339,0,0q�6l   �� 5!   
   -   5        $ 
lblFilters��5!      $��Filters��6$   $
��Left=�66   $��29��6Q   $��	35,44,0,0q�6]   $	��Top=�6p   $��87��6�   $	 0.783,0.576&�6�   �� 5"   
   -	   5        $
 
txtKeyword��5"      $
��Left=�6&   $��23��6A   $��	89,43,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��363��6�   6�   �� 5#   
   -
   5        $ btnAdd��5#      $��Add New��6!   $
��Left=�63   $	��Top=�6N   $��75��6f   $��18��6q   $��662,316,0,0q�6}   6�   5$      5%      