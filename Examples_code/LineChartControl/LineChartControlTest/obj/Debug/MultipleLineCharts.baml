   M S B A M L   `   `   `  ����K  GLineChartControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:LineChartControl;assembly=LineChartControlLineChartControl  5       LineChartControlTest-   'LineChartControlTest.MultipleLineCharts   5   	   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Hlocal8clr-namespace:LineChartControl;assembly=LineChartControl    5        � Title$  Multiple Charts��5      $	��500��6   $	��500��6*   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      �� 5	       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   � -   5         �Name$ grid1��5      $��0��6>   $��0��6N   .+�5      *   $LineChartControl.LineChartControlLib  -   5          Name$ myLineChart1��5   (      Xmin$ 0Q�6>      Xmax$ 7Q�6G      XTick$ 1Q�6P      Ymin$
 -1.5Q�6Z   	   Ymax$	 2Q�6f   
   YTick$	
 0.5Q�6o      Title$ 	Chart One��5   %      GridlinePattern$
 Dash=�67      GridlineColor
 �����6N   5      � 5   
   -   5        $ grid2��5      $��1��6>   $��0��6N   .+�5        -   5        $ myLineChart2��5   (   $ 0Q�6>   $ 7Q�6G   $ 1Q�6P   $
 -1.5Q�6Z   $	 2Q�6f   $	
 0.5Q�6o   $ 	Chart Two��5   %   $ Solid=�67   
 �����6O   5      � 5   
   -   5        $ grid3��5      $��0��6>   $��1��6N   .+�5        -   5        $ myLineChart3��5   (   $ 0Q�6>   $ 7Q�6G   $ 1Q�6P   $
 -1.5Q�6Z   $	 2Q�6f   $	
 0.5Q�6o   $ Chart Three��5   %   $
 Dash=�69   
 ��ح�6P   5      � 5   
   -   5        $ grid4��5      $��1��6>   $��1��6N   .+�5         -   5        $ myLineChart4��5    (   $ 0Q�6>   $ 7Q�6G   $ 1Q�6P   $
 -1.5Q�6Z   $	 2Q�6f   $	
 0.5Q�6o   $ 
Chart Four��5!   %   $ Solid=�68   
 ��ح�6P   5"      5$      5%      