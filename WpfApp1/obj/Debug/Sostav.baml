   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Sostav   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  Sostav??5   	   $
??1080??6   $
??1920??6&    ? WindowState$ 	Maximized=?63    ? WindowStartupLocation$ CenterScreen=?6K    ? 
ResizeMode$ NoResize=?6p    ? ShowInTaskbar .   ? 	Resources 5	         FocusVisual ?? Property ?? Value J? SnapsToDevicePixels	 ?? StrokeDashArray  Button.Static.Background
 ?? Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 
CornerButt ?? 
TargetType ?? 
TargetType ??Name ?? CornerRadius ??Name ?? Triggers P? Property P? Value ?? 
TargetName??%o  &	        &	 ?     &	 ?     &	 ?     &	     &	 6    &	 Y    &	 |    &	 ?    &		 ?    &	
 ?    7   7  7  7  7  7 	 ?? 5
   
   .?5      ??  ? ?? 5      ?? 5      .R?5      ?? $??2q?6$    . #??? ??6J   $??1??6?   $		 1 2R?6?   5      5      5      ?? 5   
   $
 	#FFDDDDDD??6;   ?? 5   
   $
 	#FF707070??67   ?? 5   
   $
 	#FFBEE6FD??6>   ?? 5   
   $
 	#FF3C7FB1??6:   ?? 5   
   $
 	#FFC4E5F6??6<   ?? 5   
   $
 	#FF2C628B??68   ?? 5   
   $
 	#FFF4F4F4??6=   ?? 5   
   $
 	#FFADB2B5??69   ?? 5   
   $
 	#FF838383??6=   ?? 5   
   " ??6#   .?5      ??  ?@?FocusVisualStyle8   61   ?? 5       ? ??8  6+   ?? 5       ? ??8  6,   ?? 5        ? ??# ? ??6+   ?? 5!       ? ??$ 0q?60   ?? 5"       ? ??$ Center=?6;   ?? 5#       ? ??$ Center=?69   ?? 5$       ? ??$ 1q?6(   ?? 5%       ? ?? 5&      ?? 5'      " ??6&   .R?5(      ?? $ border??6!   $ 20??61   #??z??6C   #??z??6o   ???	#FF599927 . ._?5)      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  5*       5+      P? 5,       ?@??IsDefaulted . . ?5-   "   ?? $ border??6@   # ? ??6T    ? ??5.      P? 5/       ?@J?IsMouseOver . . ?50   "   ?? $ border??6?    ? ?? ?	#FF5999276S   ?? 51   "   $ border??6@    ? ?? ?	#FF5999276T   52      P? 53       ? ?? . . ?54   "   ?? $ border??6?    ? ?? ?	#FF11440C6S   ?? 55   "   $ border??6@    ? ?? ?	#FF11440C6T   56      P? 57       ? {? .  . ?58   "   ?? $ border??6?   8   ? ??6S   ?? 59   "   $ border??6@   8   ? ??6T   ?? 5:   "   $ contentPresenter??6K   8   ? ??6i   5;      5=      5?      5@      5A      .??5B      ? .+?5C   
   ?? -   5        $??/Sourse/exit.png??5C      $??1834,27,31,978q?6*   $
??Fill=?6B    K? ZIndex$ 3??6Q   6b   ?? 5D   
   $??/Sourse/Фон1.png??6   $
??Fill=?6*   ?? 5E   
   $??/Sourse/слон.png??6   $??940,567,328,10q?6*   ?? 5F   
   $??/Sourse/облако.png??6   $??1199,140,66,399q?6,   ?? 5G   
   -   5         ??Name$ 
textoblako??5G       J? Opacity$ 1Q?6(    ?? TextAlignment$ Center=?64   
????  ?$??30(?6a   $??Times new roman)?6o   $????Ты уже много знаешь о химии. Помоги мне расставить количество атомов в молекуле указанного вещества. Вводить можно только цифры от 1 до 9.??6?   $
??Wrap=?6  $??1249,311,116,601q?62  ?? 5H   
   -   5        $ 	textoprav??5H      $ 0Q?6'   $ Center=?63   
????  ?$??70(?6`   $??Times new roman)?6n   $??Правильно!??6?   $
??Wrap=?6?   $??1249,336,116,621q?6?   ?? 5I   
   -   5        $ textoneprav??5I      $ 0Q?6)   $ Center=?66   
????  ?$??70(?6c   $??Times new roman)?6q   $"??Проверь ещё раз??6?   $
??Wrap=?6?   $??1249,336,116,621q?6?   ?? 5K   
   $??/Sourse/доска.jpg??6   $??-35,58,756,259q?6+   ?? 5L   
   $??H   O??6   $ Center=?6!   $	??110??68   $??131,89,0,850q?6E   $
??Left=?6[   
???????$	??110(?6?   $??Times new roman)?6?   6?   ?? 5M   
   $??CO??6   $ Center=?6   $	??110??65   $??131,217,0,722q?6B   $
??Left=?6Y   
???????$	??110(?6?   $??Times new roman)?6?   6?   ?? 5N   
   $??H   SO??6   $ Center=?6"   $	??110??69   $??131,338,0,607q?6F   $
??Left=?6]   
???????$	??110(?6?   $??Times new roman)?6?   6?   ?? 5O   
   $??NH??6   $ Center=?6   $	??110??65   $??131,605,0,339q?6B   $
??Left=?6Y   
???????$	??110(?6?   $??Times new roman)?6?   6?   ?? 5P   
   $??207,152,1622,813q?6   
?????? $??2q?6E    ?? 
IsReadOnly . 6m   ?? 5Q   
   -   5         ??Name$ T1??5Q       ?? 	MaxLength$ 1??6   $??207,120,1575,813q?6W   
?????? 
???????$??0q?6?   $	??Top=?5R       ?? TextWrapping$
 Wrap=?62    ?? AcceptsReturn . $	??100(?6]    ?? 
CaretBrush
 ???? 6?   ?? 5S   
   $??284,271,1545,694q?6   
?????? $??2q?6E    . 6m   ?? 5T   
   -   5        $ T2??5T      $ 1??6   $??284,241,1498,692q?6W   
?????? 
???????$??0q?6?   $	??Top=?5U      $
 Wrap=?62    . $	??100(?6]   
 ???? 6?   ?? 5V   
   $??207,400,1622,565q?6   
?????? $??2q?6E    . 6m   ?? 5W   
   -   5        $ T3??5W      $ 1??6   $??207,368,1575,565q?6W   
?????? 
???????$??0q?6?   $	??Top=?5X      $
 Wrap=?62    . $	??100(?6]   
 ???? 6?   ?? 5Y   
   $??290,665,1539,300q?6   
?????? $??2q?6E    . 6m   ?? 5Z   
   -   5        $ T7??5Z      $ 1??6   $??290,633,1492,300q?6W   
?????? 
???????$??0q?6?   $	??Top=?5[      $
 Wrap=?62    . $	??100(?6]   
 ???? 6?   ?? 5\   
   -	   5        #??? 
 5\      ???	#FF599927$??167,799,1478,151q?6N   ???	#FF11440C.??5]      ?? $??35??6   $ Center=?6$   
???????$??35(?6N   $??Times new roman)?6\   $??ПРОВЕРИТЬ??6y   $
??Wrap=?6?   $	??254??6?   5^      ?? 5_   
   -
   5        #??? 
 5_      ???	#FF599927$??680,799,958,151q?6N   .??5`      ?? $??40??6   $ Center=?6$   
???????$??35(?6N   $??Times new roman)?6\   $??
НАЗАД??6y   $
??Wrap=?6?   $	??253??6?   5a      ?? 5b   
   $??434,400,1395,565q?6   
?????? $??2q?6E    . 6Y   ?? 5c   
   -   5        $ T4??5c      $ 1??6   $??434,368,1348,565q?6W   
?????? 
???????$??0q?6?   $	??Top=?5d      $
 Wrap=?6-    . $	??100(?6X   
 ???? 6?   ?? 5e   
   $??H   SO??6   $ Center=?6"   $	??110??69   $??131,470,0,469q?6F   $
??Left=?6]   
???????$	??110(?6?   $??Times new roman)?6?   ?? 5f   
   $??207,531,1622,434q?6   
?????? $??2q?6E    . 6Y   ?? 5g   
   -   5        $ T5??5g      $ 1??6   $??207,499,1575,434q?6W   
?????? 
???????$??0q?6?   $	??Top=?5h      $
 Wrap=?6-    . $	??100(?6X   
 ???? 6?   ?? 5i   
   $??434,531,1395,434q?6   
?????? $??2q?6E    . 6Y   ?? 5j   
   -   5        $ T6??5j      $ 1??6   $??439,499,1343,434q?6W   
?????? 
???????$??0q?6?   $	??Top=?5k      $
 Wrap=?6-    . $	??100(?6X   
 ???? 6?   ?? 5l   
   $??
- вода??6   $ Center=?6"   $	??110??69   $??377,96,0,843q?6F   $
??Left=?6\   
???????$??80(?6?   $??Times new roman)?6?   ?? 5m   
   $#??- углекислый газ??6   $ Center=?6,   $	??110??6C   $??377,223,0,716q?6P   $
??Left=?6g   
???????$??80(?6?   $??Times new roman)?6?   ?? 5n   
   $#??- серная кислота??6   $ Center=?6,   $	??110??6C   $??522,360,0,579q?6P   $
??Left=?6g   
???????$??73(?6?   $??Times new roman)?6?   ?? 5o   
   $)??#- сернистая кислота??6   $ Center=?6/   $	??110??6F   $??517,489,0,450q?6S   $
??Left=?6j   
???????$??60(?6?   $??Times new roman)?6?   ?? 5p   
   $??- аммиак??6   $ Center=?6$   $	??110??6;   $??439,620,0,319q?6H   $
??Left=?6_   
???????$??75(?6?   $??Times new roman)?6?   5r      5s      