   M S B A M L   `   `   `  ����F  BChatBubbles, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ChatBubblesChatBubbles  5   	       ChatBubbles.FriendsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ChatBubbles     5   	     � Title$  FriendsWindow��5   	   $	��225��6   $	��400��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��158* �6   �� 5      $	��39* �6   .+�5   
   �� $
��Left=�6   $��27��6+   $	��Top=�67   $��28��6O   $��	255,5,0,0q�6Z   $��/Pictures/profile.png��6m   �� 5   
   -   5         ��Name$ NickNameTxtBox��5      $
��Left=�6,   $
��Wrap=�6G   $��NickName��6[   $��286,4,0,166.2q�6k   $��2��6�   $��89��6�   �� 5   
   -   5        $ StatusTxtBox��5      $
��Left=�6*   $
��Wrap=�6E   $��Status��6Y   $��287,26,0,144.2q�6g   $��10(�6   $��2��6�   $��52��6�   �� 5   
   -   5         ��Name$ addfriendbutton��5      $
��Left=�6+   $	��Top=�6F   $��21��6^    J� RenderTransformOrigin$ 1.659,3.052&�6i   $��	10,13,0,0q�6�   $��22��6�   ��5      �� 5       �� ImageSource$ /Pictures/addfriend.png��6   5      �� 5   
   -   5         ��Name$ SearchFriendTextBox��5      $
��Left=�6/   $��19��6J    �� TextWrapping$
 Wrap=�6V   $��TextBox��6j   $	��Top=�6y   $	��120��6�   $��	36,17,0,0q�6�   �� 5   
   -   5        $��Search��5      $
��Left=�6"   $	��Top=�6=   $��75��6U   $��
170,17,0,0q�6`   6t   R� 5   
   -   5         R�Name$ FriendsTree_View��5      $
��Left=�6-   $	��100��6H   $	��Top=�6U   $	��209��6m   $��	36,53,0,0q�6y   .@�5      Q� $��Online��6   .@�5      Q� $��User1��6   60   Q� 5      $��User2��6   60   Q� 5      $��User3��6   60   5      Q� 5      $��Offline��6   .@�5      Q� $��User4��6   60   Q� 5       $��User5��6   60   5!      5"      5#      5$      