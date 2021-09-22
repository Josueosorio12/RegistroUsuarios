using RegistroUsuarios.DLL;
using RegistroUsuarios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RegistroUsuarios.UI.Registro
{
    /// <summary>
    /// Interaction logic for rRegistro.xaml
    /// </summary>
    public partial class rRegistro : Window
    {
        private RegistroEntidades usuario = new RegistroEntidades();
        public rRegistro()
        {
            InitializeComponent();
            this.DataContext = usuario;
        }

        private void Buscar_Click(object sender, RoutedEventArgs e)
        {
            var encontradoo = UsuariosBLL.Buscar(Utilidades.ToInt(RegistroTextBox.Text));

            if (encontradoo != null)
                this.usuario = encontradoo;
            else
                this.usuario = new RegistroEntidades();

            this.DataContext = this.usuario;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }


        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            Limpiar();
            bool paso = UsuariosBLL.Guardar(this.usuario);

            

            if (paso)
            {
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsuariosBLL.Eliminar(Utilidades.ToInt(RegistroTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("No Fue Posible Eliminar el Registro! :(", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Limpiar()
        {
            this.usuario = new RegistroEntidades();
            this.DataContext = this.usuario;
        }
        private bool Validar()
        {
            bool esValido = true;

            if (AliasTecBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor de llenar todo los campo", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (NombresTexBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor de llenar todo los campo", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (EmailTexBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor de llenar todo los campo", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (ClaveTexBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor de llenar todo los campo", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        private void RegistroTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
 
}
                 
            
