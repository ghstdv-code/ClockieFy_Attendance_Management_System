   M S B A M L   `   `   `  ????  ClockiFyAMS%    ClockiFyAMS.Modals.EmployeeList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        ? 	Resources  5
      *  $System.Windows.Controls.DataGridCell ?? 
TargetType   MaterialDesignDataGridCell ?? BasedOn ?? Triggers P? Property P? Value ?? Property ?? Value??%?   '        7   ?? 5   
   "  6   8    5      P? 5       ?@ 
IsSelected . . ?5      ??  ? ??
 ???? 64   5      P? 5       ?@J?IsMouseOver . . ?5      ??  ? ??
 ???? 64   5      5      5      .??5      #  MaterialDesignThemes.Wpf.Card  $??10q?6   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=?5      .??5   
   ? 	 ? RowDefinitions	 5      ?? 5      $??2* ?6    ?? 5      $	??14* ?6    .+?5!      ?? $??Employee List??5"      $	??Top=?5#      $
??15 5q?5$       $  MaterialDesignHeadline6TextBlock#??[ 5%      
???????$??0??5'      ?? 5)      
 ?? Orientation$
 
Horizontal=?6   $??0??5*      $??Right=?6&   .+?5,      ?? -   5         ??Name$ 
tbx_Search??5-   J    ! MaterialDesignOutlinedTextBox#??[ 5,      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Input Queries ??5-      $??5q?6>    ?? TextAlignment$
 Left=?5.      $??Center=?6/   $	??180??5/      $??2q?6&   ???#6D4C416:   ?? 50      -   5         ??Name$ 
btn_Search??51   ,     MaterialDesignRaisedButton#??[ 50      $??	10 0 10 0q?51      .??52      ?? $
 
Horizontal=?6!   .+?53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountSearch=?6&   $??Center=?54   &   $??0 0 5 0q?55   &   ?? 56       " MaterialDesignCaptionTextBlock#??[ 6$   $??Search??57   $   58      59      ?? 5;      -   5        $ btn_Add??5?      #??[ 5;      ???#388E3C???#388E3C$??	10 0 10 0q?5>      .??5A      ?? $
 
Horizontal=?6!   .+?5B        $ AccountMultiplePlus=?6&   $??Center=?5C   &   $??0 0 5 0q?5D   &   ?? 5E      #??[ 6$   $??Add new Employee??5F   $   5G      5H      ?? 5J      -   5        $ refresh??5N      #??[ 5J      ???#388E3C???#388E3C$??0 0 15 0q?5M      .??5P      ?? $
 
Horizontal=?6!   .+?5Q        $ Refresh=?6&   $??Center=?5R   &   $??0 0 5 0q?5S   &   ?? 5T      #??[ 6$   $??Refresh??5U   $   5V      5W      5X        5Z      $??1??6   $??
15 5 15 15q?6#   .??5[      &   System.Windows.Controls.DataGrid  -   5          Name$ dgvPresentEnt??5c   '      CanUserAddRows .  $??5q?5[   2      AutoGenerateColumns .     HeadersVisibility$ Column=?5]   '      CanUserDeleteRows .     CanUserResizeRows .     CanUserReorderColumns .     CanUserResizeColumns .     SelectionMode$ Single=?5b   '      Columns 5f      4  .System.Windows.Controls.DataGridTemplateColumn  5h      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$	 UID??5i   1      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 100	 5j   1      CellTemplate 5k      ?? 5l   "   .R?5m   &   ?? #??[ 60   $??9(?5o   0   $
??Wrap=?5p   0   $??Center=?5q   0   ??5n   0   ?? *UID+5q   0   5r   #   5t        5v       . $ 	Full Name??5w   1   $	 200	 5x   1    5y      ?? 5z   "   .R?5{   &   ?? #??[ 60   $??13(?5}   0   $??Center=?5~   0   ??5|   0   ?? *
FullName+5~   0   5   #   5?        5?       . $ Job Description??5?   1   $	 200	 5?   1    5?      ?? 5?   "   .R?5?   &   ?? #??[ 60   $??13(?5?   0   $??Center=?5?   0   ??5?   0   ?? *JobDescription+5?   0   5?   #   5?        5?       . $ Gender??5?   1   $	 100	 5?   1    5?      ?? 5?   "   .R?5?   &   ?? #??[ 60   $??13(?5?   0   $??Center=?5?   0   ??5?   0   ?? *Gender+5?   0   5?   #   5?        5?       . $ Address??5?   1   $	 250	 5?   1    5?      ?? 5?   "   .R?5?   &   ?? #??[ 60   $??13(?5?   0   $??Center=?5?   0   ??5?   0   ?? *	Address+5?   0   5?   #   5?        5?       . $ Performance??5?   1   $	 200	 5?   1    5?      ?? 5?   "   .R?5?   &   ?? #??[ 60   $??13(?5?   0   $??Center=?5?   0   ??5?   0   ?? *Performance+5?   0   5?   #   5?        5?      $ Action??61    . $	 150	 5?   0    5?      ?? 5?   "   .R?5?   &   ?? $
 
Horizontal=?61   .+?5?   *   ?? $ btn_View??61   -   5          SecondaryHueMidBrush#??[ 5?   -   #??[ 5?   -   $??0 0 10 0q?5?   -    # MaterialDesignRaisedLightButton#??[ 5?   -   .??5?   .     $ ArchiveEyeOutline=?6:   $??24??5?   -   $??20??69   
???????5?   -   5?   +   ?? 5?   *   ???#E53935???#E53935#??[ 5?   1   .??5?   .   '
  !MaterialDesignThemes.Wpf.PopupBox
   
 Name$ PopupBox??5?   2    
  	StaysOpen .  $??Center=?5?   2   $??Center=?5?   2     
  PlacementMode$  BottomAndAlignCentres=?5?   2   $	??0 3q?5?   D   ! 
  PopupContent.! 5?   2   ?? $??10q?6=   .+?5?   6   ? 	 5?   :   ?? 5?   >   $
??auto ?6L   ?? 5?   >   $
??auto ?6L   " ? ColumnDefinitions" 5?   :   ?? 5?   >   $??* ?6O   ?? 5?   >   $??5 ?6O   ?? 5?   >   $??* ?6O   .+?5?   :   ?? #??[ 6D   
???????# ?? TextAlignment$# Center=?5?   D   $??0??5?   D   $??3??5?   D   $)??#Are you sure to delete this record???5?   D   $??0 0 0 10q?5?   D   ?? 5?   :   $??0??6A   $??1??5?   A   $??No??5?   A   #??[ 5?   A   ?? 5?   :   $ 	btnDelete??5?   A   -   5        $??2??5?   A   $??1??5?   A   $	??Yes??5?   A   #??[ 5?   A   5?   7   5?   3   $ 
  ToggleContent$ 5?   2     5?   6   $ DeleteOutline=?6B   $??20??5?   F   $??20??5?   F   
???????5?   F   5?   /   5?   +   5?   '   5?   #   5?      5?      5      5     5     5     