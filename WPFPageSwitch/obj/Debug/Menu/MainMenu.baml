   M S B A M L   `   `   `  ����  JagoanFisika    WPFPageSwitch.MainMenu   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8x,http://schemas.microsoft.com/winfx/2006/xaml    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5        � 	Resources  5	         ComPorts � XPath � Source  ComSpeed  loginMouseEnter g� 	BeginTime �� 
TargetName �� TargetProperty O� KeyTime O� Value  registerMouseEnter  loginMouseLeave  registerMouseLeave��%�  &	        &	 ?     &	 }     &	 Q    &	 +    &	 ]    � 5
   
   $ /Comms/Ports��6+   $ CommsData.xml?�6@   � 5   
   $ CommsData.xml?�6+   $ /Comms/Baud��6B   �� 5   
   .��5      U� $ 00:00:00X�6,   $ loginTextBlock��6A   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6h   .\�5      �� $ 00:00:00.2000000��6'   $	 1.2Q�6B   5      U� 5      $ 00:00:00X�6,   $ loginTextBlock��6A   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6h   .\�5      �� $ 00:00:00.2000000��6'   $	 1.2Q�6B   5      5      �� 5   
   .��5      U� $ 00:00:00X�6,   $ registerTextBlock��6A   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6k   .\�5      �� $ 00:00:00.2000000��6'   $	 1.2Q�6B   5      U� 5      $ 00:00:00X�6,   $ registerTextBlock��6A   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6k   .\�5      �� $ 00:00:00.2000000��6'   $	 1.2Q�6B   5      5      �� 5   
   .��5      U� $ 00:00:00X�6,   $ loginTextBlock��6A   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6h   .\�5      �� $ 00:00:00��6'   $	 1.2Q�6:   �� 5      $ 00:00:00.2000000��6'   $ 1Q�6B   5       U� 5!      $ 00:00:00X�6,   $ loginTextBlock��6A   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6h   .\�5"      �� $ 00:00:00��6'   $	 1.2Q�6:   �� 5#      $ 00:00:00.2000000��6'   $ 1Q�6B   5$      5%      �� 5&   
   .��5'      U� $ 00:00:00X�6,   $ registerTextBlock��6A   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6k   .\�5(      �� $ 00:00:00��6'   $	 1.2Q�6:   �� 5)      $ 00:00:00.2000000��6'   $ 1Q�6B   5*      U� 5+      $ 00:00:00X�6,   $ registerTextBlock��6A   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6k   .\�5,      �� $ 00:00:00��6'   $	 1.2Q�6:   �� 5-      $ 00:00:00.2000000��6'   $ 1Q�6B   5.      5/      50       � Triggers 51      :� 52   
   	 :� RoutedEvent$	 Mouse.MouseEnter��6   
 :� 
SourceName$
 loginTextBlock��66   .[�53      �� #��[ 6   54      :� 55   
   $	 Mouse.MouseEnter��6   $
 registerTextBlock��66   .[�56      �� -   5         ��Name$( "registerMouseEnter_BeginStoryboard��56      #��[ 6J   57      :� 58   
   $	 Mouse.MouseLeave��6   $
 loginTextBlock��66   .[�59      �� -   5        $% loginMouseLeave_BeginStoryboard��59      #��[ 6G   5:      :� 5;   
   $	 Mouse.MouseLeave��6   $
 registerTextBlock��66   .[�5<      �� -   5        $( "registerMouseLeave_BeginStoryboard��5<      #��[ 6J   5=      .��5?      � -   5         �Name$ mainMenuLayoutRoot��5?      
�������.+�5@   
   �� -   5         ��Name$ newGameButton��5@      $
��Left=�6(   $��120,0,0,218q�6C   $��Bottom=�6X   $	��200��6s   $��New Game��6   $��40��6�   $��21.333(�6�   6�   �� 5A   
   -   5        $ loadGameButton��5A      $��40��6)   $
��Left=�65   $��120,0,0,170q�6P   $��Bottom=�6e   $	��200��6�   $��21.333(�6�   $��	Load Game��6�   6�   �� 5B   
   -   5        $ optionButton��5B      $��40��6'   $
��Left=�63   $��120,0,0,122q�6N   $��Bottom=�6c   $	��200��6~   $��21.333(�6�   $��Option��6�   6�   �� 5C   
   -   5         ��Name$ registerTextBlock��5C      $��Right=�6/   $��	0,52,20,0q�6K   $	��Top=�6^   $��Register��6v   $
��Wrap=�6�   $��16(�6�   $	��100��6�   $��25��6�    �� TextAlignment$ Right=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5D      V� 5E      .~�5F      �� �� 5G      �� 5H      T� 5I      5J      5L      �� 5M   
   -	   5        $ loginTextBlock��5M      $��25��6,   $��Right=�68   $��	0,20,20,0q�6T   $	��Top=�6g   $	��100��6   $��16(�6�   $��Login��6�   $
��Wrap=�6�   $ Right=�6�   $ 0.5,0.5&�6�   z�5N      V� 5O      .~�5P      �� �� 5Q      �� 5R      T� 5S      5T      5V      �� 5X      -
   5         ��Name$ Comm_Port_Names��5X      $
��Left=�6/   $��120,11.5,0,0q�6J   $	��Top=�6`   $	��120��6x   �� 5Y   
   -   5        $ 
Baud_Rates��5Y      $
��Left=�6`   $��120,40.5,0,0q�6{   $	��Top=�6�   $	��120��6�   $ 	0.1,-0.41&�6�   ��6'   ��  �� Source# [ 6�   �� 5Z   
   -   5        $ Connect_btn��5Z      $��Connect��6&   $
��Left=�6N   $��
120,72,0,0q�6i   $	��Top=�6}   $	��200��6�   $��40��6�   $��21.333(�6�   �� 5[   
   -   5         ��Name$ Commdata��5[      $	��161��6(   $��358.5,20,173.5,0q�65   $	��Top=�6O   . �5\      /� 5]      �� 5^   
   -   5         ��Name$ 
SerialData��5^      $
��Left=�6&   $��23��6A   $��120,148.5,0,0q�6M    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��200��6�   �� 5_   
   -   5        $
��Send��5_      $
��Left=�63   $��120,181,0,0q�6N   $	��Top=�6c   $	��200��6|   $��40��6�   $��21.333(�6�   5`      5a      