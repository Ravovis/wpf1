   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  
Punch Club��5   	   $	��400��6   $	��550��6)   .��5	      � -   5         �Name$ 
LayoutRoot��5	      
�������.+�5
   
   �� -   5         ��Name$ 
KickButton��5
      $	��100��5      $��30��6   $��JUST KICK HIM!��6%   6N   �� 5   
   $
��Left=�6   $��Bottom=�6+   $	��100��5      $��30��6   $��Attack��6%   $��110,0,0,110q�66   6M   	� 5   
   -   5         	�Name$ HeadAttackButton��5       	� 	GroupName$ Attack��5      $
��Left=�6,   $��Bottom=�6G   $	��100��5      $��30��6"   $��
110,0,0,80q�6.   $
��Head��6B   	� 5   
   -   5        $ BodyAttackButton��5      $ Attack��5      $
��Left=�6*   $��Bottom=�6E   $	��100��5      $��30��6"   $��
110,0,0,45q�6.   $
��Body��6B   	� 5   
   -   5        $ LegsAttackButton��5      $ Attack��5      $
��Left=�6*   $��Bottom=�6E   $	��100��5      $��30��6"   $��
110,0,0,10q�6.   $
��Legs��6B   �� 5   
   $
��Left=�6   $��Bottom=�6+   $	��100��5      $��30��6   $��Defence��6%   $��
10,0,0,110q�67   6N   	� 5   
   -   5        $ HeadDefenceButton��5      $ Defence��5      $
��Left=�6+   $��Bottom=�6F   $	��100��5      $��30��6"   $��	10,0,0,80q�6.   $
��Head��6A   6S   	� 5   
   -   5        $ BodyDefenceButton��5      $ Defence��5       $
��Left=�6+   $��Bottom=�6F   $	��100��5!      $��30��6"   $��	10,0,0,45q�6.   $
��Body��6A   6S   	� 5"   
   -   5        $ LegsDefenceButton��5"      $ Defence��5#      $
��Left=�6+   $��Bottom=�6F   $	��100��5$      $��30��6"   $��	10,0,0,10q�6.   $
��Legs��6A   6S   �� 5'   
   -	   5         ��Name$ 	PlayerBox��5'      $��Right=�6&   $��Bottom=�6B   $	��100��5(      $��30��6   {�.  $��
0,0,173,10q�6<   6R   �� 5)   
   -
   5        $ EnemyBox��5)      $��Right=�6&   $��Bottom=�6B   $	��100��5*      $��30��6   {�.  $��	0,0,54,10q�6<   6Q   �� 5+   
   $��Right=�6   $��Bottom=�6-   $	��100��5,      $��30��6   $��Player��6%   $��
0,0,149,40q�66   6L   �� 5-   
   $��Right=�6   $��Bottom=�6-   $	��100��5.      $��30��6   $��Enemy��6%   $��	0,0,32,40q�65   6K   �� 50   
   -   5         ��Name$ 	InfoLabel��50      $��18(�51      $��Italic$�6   $��Right=�62   $��Bottom=�6N   $	��300��52      $��90��6   $�� ��6(   $��	0,0,10,65q�63   6I   53      54      