   M S B A M L   `   `   `  ����I  EFactoryStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FactoryStorage.ViewFactoryStorage.View  5   	   (    "FactoryStorage.View.CriticalNumber   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:FactoryStorage.View     5   	     � Title$)  #Критични стойности��5   	   $	��500��6$   $	��600��61    � WindowStartupLocation$ CenterScreen=�5	   	   ��5
      �� 5   
    �� ImageSource$0 */Resources/Picture/FactoryStorageImage.jpg��6   6P   .��5      � .+�5   
   �� -   5         ��Name$ labelheading��5      $)��#Критични стойности��6&   $��Center=�6C   $��180,27,180,0q�6`   $	��Top=�6v   $��20(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ textBoxMinNumber��5      $
��Left=�6,   $��312,365,0,0q�6G    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $��62��6�   $��24��6�   �� 5   
   -   5         ��Name$ buttonChange��5      $��Промени��6'   $
��Left=�69   $��254,412,0,0q�6T   $	��Top=�6i   $��29��6�   $��86��6�   6�   �� 5   
   -   5        $ labelMinNumber��5      $=��7Критична стойност на елемента��6(   $
��Left=�6P   $��
79,363,0,0q�6k   $	��Top=�6   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $ 
buttonExit��5      $��
Назад��6%   $
��Left=�65   $��390,412,0,0q�6P   $	��Top=�6e   $��29��6}   $��86��6�   $��14(�6�   6�   �� 5   
   -   5         ��Name$ listBoxCriticalElement��5      $
��Left=�62   $	��Top=�6M   $��	92,69,0,0q�6e   $	��270��6x   $	��414��6�   6�   �� 5   
   -   5        $ buttonSavePdf��5      $��Запази��6(   $
��Left=�69   $��121,412,0,0q�6T   $	��Top=�6i   $��29��6�   $��86��6�   $��14(�6�   6�   5      5      