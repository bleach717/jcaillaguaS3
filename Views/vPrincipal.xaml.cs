namespace jcaillaguaS3.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario, string contrasena)
	{
		InitializeComponent();
		txtUsaurio.Text = "El usaurio es "+usuario;
		txtContrasena.Text = "La contrase�a es "+contrasena;
	}
}