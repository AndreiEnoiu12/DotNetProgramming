   M S B A M L   `   `   `  ����F  BAssignment6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment6Assignment6  5   	       Assignment6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment6     5   	     � Title$  GUI Media Window��5   	   $	��512��6"   $	��909��6/   $��Sitka Subheading)�6;   $��20(�6Y    � 	Resources 5	       �� 
TargetType �� Property �� Value �� Triggers :� RoutedEvent �� TargetProperty W� From		 W� To
 g� Duration g� AutoReverse g� FillBehavior��%�  '��       �� 5
   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 12q�6'   �� 5       �@J�RenderTransformOrigin$ 0.5 0.5&�66   �� 5       � z� 5      �� 5      5       5      :� 5      $ Button.Click��6   .[�5      �� .��5      �� $ RenderTransform.Angle�6%   .��5      W� $ 0X�5      $		 180X�6"   $
 0:0:0.20D�6+    . $
 Stop=�5      5      5      5      5      5       .��5!      � $��0,0,-8,0q�6    � RowDefinitions 5"   
   �� 5#      $
��214* �6   �� 5$      $	��48* �6   .+�5&   
   r� -   5        $��	FileMedia��5&   \    r� LoadedBehavior$ Manual=�6/   $��44,23,44,90q�6G   6\   �� 5(   
   -   5        
���   � J� RenderTransformOrigin$ 0.5,0.5&�5(   8   $��44,24,741,14q�6X   $��1��6n   $��75��6{   .��6�   Open6�   �� 5)   
   -   5        
���   �$��317,24,443,14q�5)   8   $��1��6O   $��75��6\   .��6g   Play6m   �� 5*   
   -   5        
���   �$��452,24,332,14q�5*   9   $��1��6P   $��75��6]   $��Sitka Subheading)�6h   .��6�   Pause6�   �� 5+   
   -   5        
���   �$��741,24,44,14q�5+   8   $��1��6N   $��75��6[   .��6f   Stop6l   �� 5,   
   -   5         ��Name$ FileName��5,      $��Media File Name��6"   $
��Left=�6<   $��141,354,0,0q�6W   $	��Top=�6l   $	��628��6�   $��39��6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   $��Italic$�6�   � 5-   
   -   5         �Name$ ProgressBar��5-      $
��Left=�6+   $��23��6F   $��
44,326,0,0q�6R   $	��Top=�6f   $	��821��6~   5/      50      