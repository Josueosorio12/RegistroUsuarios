   M S B A M L   `   `   `  ����K  GRegistroUsuarios, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:RegistroUsuarios.UIRegistroUsuarios.UI  5   	   #    RegistroUsuarios.UI.cConsulta   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:RegistroUsuarios.UI     5   	     � Title$  Registro de consulta��5   	   $	��450��6&   $	��800��63   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   $��	10,5,10,0q�6,   .+�5      �� $ 
Horizontal=�6   $��58��62   .+�5      �� $	��5,0q�6   .+�5      �� -   5         ��Name$ FiltroLabel��5      $��Filtro:��61   �� 5      -   5         ��Name$ FiltroComboBox��5      $	��100��67   $��25��6C   .@�5      �� -   5         ��Name$ ListadoComboBoxItem��5   '   $��Listado��6D   5      5      �� 5      -   5         ��Name$ BuscarButton��5      $��Buscar��6/   $��30��6@   $��85��6L   $��0,20,0,0q�6W   6i   5      �� 5      $
��Left=�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DatosDataGrid��5      $	��347��62   $	��499��6?      AutoGenerateColumns$ False��6K      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Registro Id:��6-   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6C   �� *
RegistroId+  5      $	 Fecha:��6-   
 6=   �� *FechaCreacion+  5      $	 Alias:��6-   
 6=   �� *Alias+  5      $	 Nombres:��6-   
 6?   �� *Nombre+  5      $	 Email:��6-   
 6=   �� *Email+  5      $	 Clave:��6-   
 6=   �� *Clave+  5       $	 Rol Id:��6-   
 6>   �� *RolID+  5!      $	 Activo:��6-   
 6>   �� *Activo+5#      5$      5%      5&      5'      