   M S B A M L   `   `   `  ????F  BClockiFyAMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ClockiFyAMS.ModalsClockiFyAMS.Modals  5           ClockiFyAMS.Modals.Records   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ClockiFyAMS.Modals     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5        ? 	Resources  5
      *  $System.Windows.Controls.DataGridCell ?? 
TargetType   MaterialDesignDataGridCell ?? BasedOn ?? Triggers P? Property P? Value ?? Property ?? Value??%?   '        7   ?? 5   
   "  6   8    5      P? 5       ?@ 
IsSelected . . ?5      ??  ? ??
 ???? 64   5      P? 5       ?@J?IsMouseOver . . ?5      ??  ? ??
 ???? 64   5      5      5      .??5      #  MaterialDesignThemes.Wpf.Card  $??10q?6   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=?5      .??5   
   ? 	 ? RowDefinitions	 5      ?? 5      $??2* ?6    ?? 5      $	??14* ?6    .+?5!      ?? $??Attendance Log??5"      $	??Top=?5#      $
??15 5q?5$       $  MaterialDesignHeadline6TextBlock#??[ 5%      
???????$??0??5'      ?? 5)      
 ?? Orientation$
 
Horizontal=?6   $??0??5*      $??Right=?6&   .+?5,      (  "System.Windows.Controls.DatePicker  -   5          Name$	 dtp??5,      $	??200??5-      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Pick Date??5.         
HelperText$ Input date to filter??5/       $  MaterialDesignOutlinedDatePicker#??[ 50      $??6q?51      $??2q?52      ???#6D4C41   SelectedDateFormat$ Short=?53   -   ?? 55      -   5         ??Name$ filter??56   ,     MaterialDesignRaisedButton#??[ 55      $??	10 0 10 0q?56      .??57      ?? $
 
Horizontal=?6!   .+?58      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ FilterMultiple=?6&   $??Center=?59   &   $??0 0 5 0q?5:   &   ?? 5;       " MaterialDesignCaptionTextBlock#??[ 6$   $??Filter??5<   $   5=      5>      ?? 5@      -   5        $ launchQr??5C   ,   #??[ 5@      ???#388E3C???#388E3C$??	10 0 10 0q?5C      .??5D      ?? $
 
Horizontal=?6!   .+?5E        $ 
QrcodeScan=?6&   $??Center=?5F   &   $??0 0 5 0q?5G   &   ?? 5H      #??[ 6$   $??Launch QR Scanner??5I   $   5J      5K      ?? 5M      -   5        $ refresh??5P   +   #??[ 5M      ???#388E3C???#388E3C$??0 0 15 0q?5P      .??5Q      ?? $
 
Horizontal=?6!   .+?5R        $ Refresh=?6&   $??Center=?5S   &   $??0 0 5 0q?5T   &   ?? 5U      #??[ 6$   $??Refresh??5V   $   5W      5X      5Y        5[      $??1??6   $??
15 5 15 15q?6#   .??5\      &   System.Windows.Controls.DataGrid  -   5          Name$ dgvPresentEnt??5d   '      CanUserAddRows .  $??5q?5\   2      AutoGenerateColumns .     HeadersVisibility$ Column=?5^   '      CanUserDeleteRows .     CanUserResizeRows .     CanUserReorderColumns .     CanUserResizeColumns .     SelectionMode$ Single=?5c   '      Columns 5g      4  .System.Windows.Controls.DataGridTemplateColumn  5i      ,	  &System.Windows.Controls.DataGridColumn 	  
IsReadOnly .  	  Header$	 UID??5j   1    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	 150
 5k   1      CellTemplate 5l      ?? 5m   "   .R?5n   &   ?? #??[ 60   $??9(?5p   0   $
??Wrap=?5q   0   $??Center=?5r   0   ??5o   0   ?? *UID+5r   0   5s   #   5u        5w       . $ 	Full Name??5x   1   $	 200
 5y   1    5z      ?? 5{   "   .R?5|   &   ?? #??[ 60   $??13(?5~   0   $??Center=?5   0   ??5}   0   ?? *
FullName+5   0   5?   #   5?        5?       . $
 Date??5?   1   $	 200
 5?   1    5?      ?? 5?   "   .R?5?   &   ?? #??[ 60   $??13(?5?   0   $??Center=?5?   0   ??5?   0   ?? *	AttDate+5?   0   5?   #   5?        5?       . $ Time In??5?   1   $	 200
 5?   1    5?      ?? 5?   "   .R?5?   &   ?? #??[ 60   $??13(?5?   0   $??Center=?5?   0   ??5?   0   ?? *TimeIn+5?   0   5?   #   5?        5?       . $ Time Out??5?   1   $	 200
 5?   1    5?      ?? 5?   "   .R?5?   &   ?? #??[ 60   $??13(?5?   0   $??Center=?5?   0   ??5?   0   ?? *	Timeout+5?   0   5?   #   5?        5?       . $ Hours??5?   1   $	 100
 5?   1    5?      ?? 5?   "   .R?5?   &   ?? #??[ 60   $??13(?5?   0   $??Center=?5?   0   ??5?   0   ?? *
TImeWorked+5?   0   5?   #   5?        5?      $ Action??61    . $	 150
 5?   0    5?      ?? 5?   "   .R?5?   &   ?? $
 
Horizontal=?61   .+?5?   *   ?? ???#E53935???#E53935 # MaterialDesignRaisedLightButton#??[ 5?   1   .??5?   .   '  !MaterialDesignThemes.Wpf.PopupBox    Name$ PopupBox??5?   2       	StaysOpen  .  $??Center=?5?   2   $??Center=?5?   2   !   PlacementMode$! BottomAndAlignCentres=?5?   2   $	??0 3q?5?   D   "   PopupContent." 5?   2   ?? $??10q?6=   .+?5?   6   ? 	 5?   :   ?? 5?   >   $
??auto ?6L   ?? 5?   >   $
??auto ?6L   # ? ColumnDefinitions# 5?   :   ?? 5?   >   $??* ?6O   ?? 5?   >   $??5 ?6O   ?? 5?   >   $??* ?6O   .+?5?   :   ?? #??[ 6D   
???????$ ?? TextAlignment$$ Center=?5?   D   $??0??5?   D   $??3??5?   D   $)??#Are you sure to delete this record???5?   D   $??0 0 0 10q?5?   D   ?? 5?   :   $??0??6A   $??1??5?   A   $??No??5?   A   #??[ 5?   A   ?? 5?   :   $ 	btnDelete??5?   A   -   5        $??2??5?   A   $??1??5?   A   $	??Yes??5?   A   #??[ 5?   A   5?   7   5?   3   %   ToggleContent% 5?   2     5?   6   $ DeleteOutline=?6B   $??20??5?   F   $??20??5?   F   
???????5?   F   5?   /   5?   +   5?   '   5?   #   5?      5      5     5     5     5     