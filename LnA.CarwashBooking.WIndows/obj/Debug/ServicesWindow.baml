   M S B A M L   `   `   `  ����X  TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit  5   	   U QLnA.CarwashBooking.WIndows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:LnA.CarwashBooking.WIndowsLnA.CarwashBooking.WIndows 5   	   /   )LnA.CarwashBooking.WIndows.ServicesWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5   	   :local(clr-namespace:LnA.CarwashBooking.WIndows     5   	     � Title$  ServicesWindow��5	   	   $��895.714��6    $��940.357��61   .��5
      � $��0,0,-2,0q�6   ��5   
   �� 5       �� Color$ CornflowerBlue��6   .+�5   
   �� $�� ��6   $��44��6   $��Bottom=�6'    J� RenderTransformOrigin$ 0.501,0.938&�6B   $��
-1,0,0,821q�6f   $
��Left=�6z   $	��935��6�   ��5      �� 5      # � ��6"   5      �� 5   
   $
��Left=�6   $��97��6+   $	��Top=�67   $	��131��6O   $��Logo.png��6[   $��	82,31,0,0q�6m   $
��Fill=�6�   �� 5   
   $
��Left=�6   $	��169��6/   $��
268,44,0,0q�6<   $
��Wrap=�6Q   $��24(�6e   $	��Top=�6t   $	��474��6�    �� TextAlignment$ Center=�6�   
��� ����� 6�   $�L��6�    �� TextDecorations$ 	Underline{�6�   �� 6�   $� ��6�   �� 6�   
���   �$�&��6  $ 	Underline{�6   �� 6>  $� ��6B  �� 6M  $�A��6Q  $ 	Underline{�6Z  �� 6x  �� 6�  $%�Online Car Wash Booking WebApps��6�  $ 	Underline{�6�  6�  �� 5   
   $
��Home��6   
��� ���$��16(�61   $
��Left=�6?   $��40��6Z   $��151,128,0,0q�6f   $	��Top=�6{   $��62��6�   �� 5   
   $��About��6   
��� ���$��16(�62   $
��Left=�6@   $��40��6[   $��268,128,0,0q�6g   $	��Top=�6|   $��62��6�   �� 5   
   $��
My Profile��6   
��� ���$��16(�67   $
��Left=�6E   $��40��6`   $��541,128,0,0q�6l   $	��Top=�6�   $	��134��6�   �� 5   
   $��Services��6   
��� ���$��16(�65   $
��Left=�6C   $��40��6^   $��402,128,0,0q�6j   $	��Top=�6   $��85��6�   �� 5   
   $��Contact��6   
��� ���$��16(�64   $
��Left=�6B   $��40��6]   $��709,128,0,0q�6i   $	��Top=�6~   $��85��6�   �� 5   
   $
��Left=�6   $	��Top=�6.   $��78��6F   $��282,195,0,0q�6Q   $ 0.206,0.909&�6f   .@�5      �� $��7:00 AM��6   �� 5      $��8:00 AM��6   �� 5      $��9:00 AM��6   �� 5      $��10:00 AM��6   �� 5       $��11:00 AM��6   �� 5!      $��12:00 PM��6   �� 5"      $��01:00 PM��6   �� 5#      $��02:00 PM��6   �� 5$      $��03:00 PM��6   �� 5%      $��04:00 PM��6   �� 5&      $��05:00 PM��6   5'      �� 5(   
   $��Select Services :��6   
��� ���$��16(�6>   $
��Left=�6L   $��40��6g   $��
34,302,0,0q�6s   $	��Top=�6�   $	��132��6�   $ 0.712,0.375&�6�   &   System.Windows.Controls.DataGrid  5)   
   -   5          Name$ 
dgServices��5)      $
��Left=�6'   $	��196��6B   $	��Top=�6O   $	��323��6g   $��
37,342,0,0q�6s      AutoGenerateColumns .     
IsReadOnly .    CanUserAddRows .  	   Columns	 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Service��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5,   0   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *Name+60     5-      $
 Description��6%   $ * 5.   0    6   �� *Desc+60     5/      $
 Price��6%   $ * 50   1    6   �� *Price+61   4  .System.Windows.Controls.DataGridTemplateColumn  51         CellTemplate 52      �� 53      .R�54      ��  ��Name$ 	btnSelect��6%   -   5        .��54   P   +6S   55      57        58       59      �� 5:      .R�5;      �� $ btnSub��6%   -   5        .��5;   J   -6M   5<      5>      5@      �� 5A   
   $��Date :��6   
��� ���$
��Left=�63   $��40��6N   $��
40,173,0,0q�6Z   $	��Top=�6n   $	��132��6�   �� 5B   
   -   5        $��Book Now��5B      
�������$
��Left=�6F   $��49��6a   $��780,441,0,0q�6m   $	��Top=�6�   $	��132��6�   $��18(�6�   $
��Bold"�6�   �� 5C   
   -   5         ��Name$ txtbSelected��5C      $
��Left=�6*   $	��243��6E   $��383,347,0,0q�6R   $
��Wrap=�6g   $	��Top=�6{   $	��328��6�   �� 5D   
   -   5         ��Name$ lblTotal��5D      $��0 Pesos��6"   $
��Left=�64   $��780,360,0,0q�6O   $	��Top=�6d   $	��119��6|   $��40��6�   $
��Bold"�6�   $��20(�6�   (  "System.Windows.Controls.DatePicker  5E   
   -   5        $��dtPicker��5E      $
��Left=�6%   $��
44,196,0,0q�6@   $	��Top=�6T   $��24��6l   $	��186��6x   �� 5F   
   $��Time :��6   
��� ���$
��Left=�63   $��40��6N   $��282,173,0,0q�6Z   $	��Top=�6o   $	��132��6�   �� 5G   
   $��Total Price :��6   
��� ���$��16(�6:   $
��Left=�6H   $��40��6c   $��780,302,0,0q�6o   $	��Top=�6�   $	��105��6�   �� 5H   
   $��Avail Services :��6   
��� ���$��16(�6=   $
��Left=�6K   $��40��6f   $��379,302,0,0q�6r   $	��Top=�6�   $	��132��6�   �� 5I   
   $s��m      We will confirm your appointment with you by phone or e-mail within 24 hours of receiving your request.��6   
��� ���$��16(�6�   $
��Left=�6�   $��40��6�   $��
40,577,0,0q�6�   $	��Top=�6�   $	��875��6�   $
��Bold"�6  &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6  5J      5K      