   M S B A M L   `   `   `  ????F  BClockiFyAMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ClockiFyAMSClockiFyAMS  5   	       ClockiFyAMS.LogIn   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ClockiFyAMS     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? WindowStyle$
  None=?5	   	    ? 
ResizeMode$ NoResize=?5
   	    ? Title$ LogIn??5   	   $	??320??6   $	??350??6$   $	??350??5   	    ? WindowStartupLocation$ CenterScreen=?5   	   .??5      ? -   5         ?Name$ 	main_grid??5       ? RowDefinitions 5   
   ?? 5      $??40 ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5         ??Name$ 	btn_Close??5      $??Right=?5      $??0q?6-   $??0??5      $	??Top=?6      MaterialDesignFlatButton#??[  5      .??5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=?6   5      ?? 5   
    ?? Orientation$ Vertical=?6   .+?5      ?? $??ClockiFy AMS??6   	 ?? TextAlignment$
	 Left=?5       $??0??5!      $
??10 5q?5"      $	??Top=?5#      $
??Left=?5$       $  MaterialDesignHeadline5TextBlock#??[ 5%        PrimaryHueDarkBrush#???  5&      ?? 5(      -   5        
 ??Name$
 
lbl_status??5)      $??$errNo??5(      $??0??5*      $	 Center=?5+      ???#F44336
???????$??Bottom=?5.       ?? Padding$ 0q?5/      $??11(?50      $??18??51      52      ?? 54   
   $??1??6   $??10q?6      MaterialDesignCardGroupBox#??[ 55      ??56      ?? 57      .R?58      ?? $ 
Horizontal=?59      .+?5:        $
 User=?5;   !   $??32??5<   !   $??32??5=   !   $??Center=?5>   !   ?? 5?      $??8,0,0,0q?5@   '   $??Center=?5A   '   #??[ 5B   '   $??Sign In??5C   '   5D      5E      .??5H      ?? $ Vertical=?6   $??30 20q?60   .+?5I      ?  ? ColumnDefinitions 5J      ?? 5K      $??32 ?6+   ?? 5L      $??10 ?6+   ?? 5M      $??* ?6+    5P      ?? 5Q      ?? 5R      ?? 5S      .+?5X        $ ShieldAccount=?6"   
???????$??30??5Z   "   $??30??5[   "   $??0??5\   "   $??0??5]   "   $??0 0 0 20q?5^   "   ?? 5`      -   5         ??Name$ tb_uname??5f      $
??auto??5`      $??2??5a      $??0??5b      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username??5c      $??14(?5d      $??0 0 0 20q?5e      5g        5i      $ 
ShieldLock=?6"   
???????$??30??5k   "   $??30??5l   "   $??0??5m   "   $??1??5n   "   $??0 0 0 20q?5o   "   G? 5p      -   5         G?Name$ tb_pw??5v   "   $
??auto??5p   "   $??2??5q   "   $??1??5r   "   $ Password??5s   "   $??14(?5t   "   $??0 0 0 30q?5u   "   5w   "   ?? 5y      -   5        $ 	btn_Login??5~       $  MaterialDesignRaisedAccentButton#??[ 5y      $??2??5z      $??0q?5{      $??3??5|      $?? 0q?5}      .??5?      ?? $ 
Horizontal=?6%   .+?5?        $	 Key=?6*   $??20??5?   &   $??20??5?   &   $??0 0 10 0q?5?   *   ?? 5?       $  MaterialDesignSubtitle1TextBlock#??[ 6(   $??Login??5?   (   5?      5?      5?      5?      5?      5?      5?      