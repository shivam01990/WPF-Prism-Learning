   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   F BWpfAppLearn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfAppLearn.HelperWpfAppLearn.Helper 5   b      WpfAppLearn.Views.LogOn   5      HControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   P LPrism.Wpf, Version=6.2.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  5   	   .helpers clr-namespace:WpfAppLearn.Helper  5   b   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  .  � Title$ LogIn��5   	   $	��220��6   $	��400��6$   (   "MahApps.Metro.Controls.MetroWindow   ShowMinButton .     ShowMaxRestoreButton .   � WindowStartupLocation$ CenterScreen=�5   <   %  WpfAppLearn.Helper.DialogCloser   DialogResult 6�   �� *Close+.��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $	��115 �6   �� 5      $	��285 �6   .+�5   
   �� $��	User Name��6   $
��Left=�6$   $	��Top=�6?   $��36,5,0,0q�6W    J� RenderTransformOrigin$ 0.872,1.417&�6i   $��1��6�   �� 5   
   $��Password��6   $
��Left=�6#   $	��Top=�6>   $��44,3,0,0q�6V   $ 0.872,1.417&�6h   $��2��6�   �� 5   
   -   5        $��txt_UserName��5      $
��Left=�6'   $��20��6�   	 �� TextWrapping$
	 Wrap=�6�   $	��Top=�6�   $	��155��6�   $��30,5,0,0q�6�   $��1��6�   $��1��6�   ��6B   �� *
UserName+
 �� Mode$
 TwoWay=� �� ValidatesOnDataErrors . 6�   G� 5   
   -   5        $��txt_Password��5   1   $
��Left=�6   $	��Top=�6F   $��20��6^   $��30,3,0,0q�6j   $	��155��6|   $��1��6�   $��2��6�   �� 5   
   $��Login��6   $
��Left=�6!   $	��Top=�6�   $��75��6�   $��1��6�   $��3��6�   $��
30,11,0,-5q�6�   ��6=   �� *LoginCommand+��6_   ��  �� ElementName$ txt_Password��6�   �� 5   
   $��Cancel��6   $
��Left=�6"   $	��Top=�6`   $��75��6x   $��1��6�   $��3��6�   $��125,12,0,-6q�6�   ��6?   �� *ClickCancel+6�   5      5      