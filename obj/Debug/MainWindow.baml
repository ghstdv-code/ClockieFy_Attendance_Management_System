   M S B A M L   `   `   `  ????U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	    ClockiFyAMS   ClockiFyAMS.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   -   5          ? WindowStyle$
  None=?5	   	    ? 
ResizeMode$ NoResize=?5
   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? Title$ 
MainWindow??5   	   $	??720??6   $
??1280??6)    ? 	Resources 5         	navButton ?? 
TargetType " MaterialDesignRaisedDarkButton ?? BasedOn ?? Property ?? Value  PrimaryHueDarkBrush??%?   &	        7  7  ?? 5   
   " ??6"   8   .?5      ??  ? ??$ 32??6'   ?? 5       ? ??$	 135??6&   ?? 5       ? ??$ 0 0 10 0q?6'   ?? 5       ? ??8  6+   5      5      .??5      )  #MaterialDesignThemes.Wpf.DialogHost  -   5        	  Name$	 RootDialogHost??5      
   
Identifier$
 RootDialogHostId??6,   .??5   
   ? ???#FBFBFB ? RowDefinitions 5      ?? 5      $	??120 ?6    ?? 5      $??* ?6    .+?5      ? $??0??6   .+?5      #  MaterialDesignThemes.Wpf.Card  +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=?6      ShadowEdges$ Bottom=?5       .??5"      ?  ? ColumnDefinitions 5#      ?? 5$      $??* ?6/   ?? 5%      $??* ?6/   .+?5(      ? $??0??6   .+?5)      ?  5*   "   ?? 5+   &   $??6* ?64   ?? 5,   &   $??4* ?64   .+?5/   "   ??  ?? Orientation$ 
Horizontal=?6-   $
??Left=?50   %   $	??Top=?51   %   $??	15 12 0 0q?52   %   $??0??68   .+?53   &   ?? $&?? \Resources\Images\timer_96px.bmp??6,   $??50??54   $   $??50??6/   $??Uniform=?55   $   ?? 56   &   $ Vertical=?61   $
??Left=?57   1   $??Center=?58   1   $??5 0 0 0q?59   1   .+?5:   *   ?? $??CLOCKiFY??64    $  MaterialDesignHeadline6TextBlock#??[ 5;   4   $
??Bold"?5<   4    ?? TextAlignment$
 Left=?5=   4   ?? 5>   *   $"??ATTENDANCE MANAGEMENT SYSTEM??64      MaterialDesignBody2TextBlock#??[ 5?   4   $
??Bold"?5@   4   $
 Left=?5A   4   ?? 5B   *   $(??"Developer: Gernel Esguerra © 2022??64   #??[ 5C   4   $??11(?5D   4   $??Italic$?5E   4   
???   ?$
 Left=?5G   4   5H   '   5I   #   ?? 5L   "   $ 
Horizontal=?6-   $??1??6F   $??15 0 0 0q?6S   .+?5M   &   ?? -   5         ??Name$ btn_home??5M   P   #??[  6-   .??5N   *   ?? $ 
Horizontal=?65   .+?5O   .   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=?6:   $??Center=?6F   $??0 0 5 0q?6a   ?? 5P   .   $
??Home??68   $??12(?6D   $??Center=?6R   5Q   +   5R   '   ?? 5S   &   -   5        $ 
btn_Emlist??5S   P   #??[  6-   .??5T   *   ?? $ 
Horizontal=?65   .+?5U   .     $ AccountGroup=?6:   $??Center=?6N   $??0 0 5 0q?6i   ?? 5V   .   $??	Employees??68   $??12(?6I   $??Center=?6W   5W   +   5X   '   ?? 5Y   &   -   5        $ btn_Records??5Y   P   #??[  6-   .??5Z   *   ?? $ 
Horizontal=?65   .+?5[   .     $ 
TableClock=?6:   $??Center=?6L   $??0 0 5 0q?6g   ?? 5\   .   $??Records??68   $??12(?6G   $??Center=?6U   5]   +   5^   '   ?? 5_   &   -   5        $ btn_Administration??5_   P   #??[  6-   .??5a   *   ?? $ 
Horizontal=?65   .+?5b   .     $	 Cog=?6:   $??Center=?6E   $??0 0 5 0q?6`   ?? 5c   .   $??Administration??68   $??12(?6N   $??Center=?6\   5d   +   5e   '   5f   #   5g      5h      ? 5j      $??1??6   .+?5k      ?? $ 
Horizontal=?6)   $	??Top=?6B   $??Right=?6Z   .+?5l   "   ??  ! MaterialDesignFlatLightButton#??[ 6)   $
??auto??6`   .??5m   &   '  !MaterialDesignThemes.Wpf.PopupBox  -   5          Name$ PopupBox??5q   2      	StaysOpen .  $??Center=?5n   2   $??Center=?5o   2      PlacementMode$ BottomAndAlignCentres=?5p   2   $	??0 3q?5q   D      PopupContent. 5r   *   ?? .@?5s   .   ?? -   5         ??Name$ 	btnLogout??5s   :    ? Cursor$
 Hand??5t   :   .??5u   2   ?? $ 
Horizontal=?6=   .+?5v   6     $ Power=?6B   $??0 0 5 0q?5w   B   
???????$??Center=?5y   B   ?? 5z   6   $??Logout??6@   #??[ 5{   @   5|   3   5}   /   ?? 5~   .   -	   5        $ btn_Info??5~   :   $
 Hand??6L   .??5   2   ?? $ 
Horizontal=?6=   .+?5?   6     $ InformationOutline=?6B   $??0 0 5 0q?5?   B   
???????$??Center=?5?   B   ?? 5?   6   $??Information??6@   #??[ 5?   @   5?   3   5?   /   5?   +      ToggleContent 5?   *   ?? 5?   .   $ 
Horizontal=?69   .+?5?   2     $ AccountCircle=?6>   $??5 0 2 0q?5?   >   
???????$??Center=?5?   >   ?? 5?   2   $??Administrator??6<   $??Center=?5?   <   
???????#??[ 5?   <   $
??Bold"?5?   <     5?   2   $ ChevronDown=?6>   $??2 0 5 0q?6Q   
???????5?   >   5?   /   5?   '   5?   #   5?      5?      5?      5?      5?      ? 5?      -
   5         ?Name$ 
root_Panel??5?      $??1??5?      $??1??5?      ???#CCCCCC5?      5?      5?      5?      