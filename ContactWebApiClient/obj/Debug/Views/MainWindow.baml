   M S B A M L   `   `   `  ����N  JContactWebApiClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ContactWebApiClientContactWebApiClient  5   	   O,clr-namespace:ContactWebApiClient.ConvertersContactWebApiClient.Converters  5   	   *    $ContactWebApiClient.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ContactWebApiClient     5   	   B	converter,clr-namespace:ContactWebApiClient.Converters     5   	     � Title$  
MainWindow��5	   	   $	��700��6   $	��800��6)    � 	Resources 5
      B   <ContactWebApiClient.Converters.PhoneNumbersToStringConverter   PhoneNumber<   6ContactWebApiClient.Converters.EmailsToStringConverter 	 Email��%:   &	        &	        5   
   6H     5   
   6<   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��2* �6   6*   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridContacts��5   ]      
IsReadOnly .    CanUserAddRows .     AutoGenerateColumns .  $��0��6�   $��0��6�   ��6   �� *
Contacts+ �� SelectedItem 64   �� *SelectedContact+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
First Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	FirstName+6Y     5      $
 	Last Name��6%    68   �� *
LastName+6W     5      $
 Date of Birth��6%    6<   �� *DateOfBirth+6^     5      $
 Email��6%    64   �� *Emails+ �� 	Converter# [ 5        5      $
 Phone Number��6%    6;   �� *PhoneNumbers+# [  6�   5       � 5!   
   $��1��6   $��0��6    5"      �� 5#      6%   �� 5$      6%   �� 5%      6%    5'      �� 5(      $��10 �6    6.   �� 5)      $
��Auto �6    60   �� 5*      $��10 �6    6.   �� 5+      $
��Auto �6    60   �� 5,      $��10 �6    6.   �� 5-      $
��Auto �6    60   �� 5.      $��10 �6    6.   �� 5/      $
��Auto �6    60   �� 50      $��10 �6    6.   �� 51      $��70 �6    6.   �� 52      $��10 �6    6.   �� 53      $
��Auto �6    60   �� 54      $��10 �6    6.   �� 55      $��70 �6    6.   �� 56      $��10 �6    6.   �� 57      $
��Auto �6    60   �� 58      $��10 �6    6.   �� 59      $
��Auto �6    60   �� 5:      $��10 �6    6.   �� 5;      $��30 �6    6.   .+�5=      �� $��
First Name��6   $��0��6)   $��1��69   6H   �� 5>      -   5         ��Name$ TxtBxFirstName��5>      $��1��6~   $��1��6�   ��6.   �� *SelectedContact.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5@      $��	Last Name��6   $��0��6(   $��3��68   6G   �� 5A      -   5        $ TxtBxLastName��5A      $��1��6|   $��3��6�   ��6-   �� *SelectedContact.LastName+$ PropertyChanged=�6�   �� 5C      $��Date Of Birth��6   $��0��6,   $��5��6<   6K   (  "System.Windows.Controls.DatePicker  5D      -   5          Name$ 
DatePicker��5D      $��1��6b   $��5��6r      SelectedDate 6-   �� *SelectedContact.DateOfBirth+6�   �� 5F      $��Email��6   $��0��6$   $��7��64   6C   �� 5G      -   5        $ 
TxtBxEmail��5G      $��1��6f   $��7��6v   ��6*   �� *Email+$ PropertyChanged=�6�   � 5H      $��7��6   $��2��6     5I      �� 5J      $��* �6'   63   �� 5K      $��* �6'   63   .+�5N      �� -   5         ��Name$ AddEmail��5N   '   $	��Add��6   $	��100��6]   $��0��6i   $��0��6v   ��69   �� *AddEmailCommand+6�   5O      �� 5P      -   5         ��Name$ ListBoxEmails��5P      $��9��6�   $��1��6�    6-   �� *SelectedEmail+��6T   �� *SelectedContact.Emails+6�   �� 5R      $��Phone Number��6   $��0��6+   $��11��6;   6K   �� 5S      -   5        $ TxtBxPhoneNumber��5S      $��1��6r   $��11��6�   ��60   �� *PhoneNumber+$ PropertyChanged=�6�   � 5T      $��11��6   $��2��6!    5U      �� 5V      $��* �6'   63   �� 5W      $��* �6'   63   .+�5Y      �� -	   5        $ AddPhoneNumber��5Y   Q   $	��Add��6   $	��100��6i   $��0��6u   $��0��6�   ��6'   �� *AddPhoneNumberCommand+6�   5[      �� 5\      -
   5        $ ListBoxPhoneNumbers��5\   x   $��13��6�   $��1��6�    6   �� *SelectedPhoneNumber+��6C   �� *SelectedContact.PhoneNumbers+6�   � 5]      $��17��6   $��0��6!   $��3��61    5_      �� 5`      6)   �� 5a      6)   .+�5e      �� -   5        $ BtnSave��5e      $
��Save��6*   $��0��6Y   $��0��6f   $	��100��6v   ��69   �� *SaveCommand+6�   �� 5h      -   5        $ BtnClear��5h      $��Clear��6+   $��0��6;   $��1��6I   $	��100��6Y   ��6e   �� *ClearCommand+6�   5i      �� 5j      $��19��6   $��0��6&    �� Padding$ 20,0,0,0q�66   ��6I   �� *	Message+6d   5k      5l      5m      