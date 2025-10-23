namespace jcaillaguaS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = " ";
    string contrasena = " ";
	public vLogin()
	{
		InitializeComponent();
	}

    public vLogin( string usuarioregistro, string contrasenaregistro)
    {
        InitializeComponent();
        usuario = usuarioregistro;
        contrasena = contrasenaregistro;
    }



    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContrasena.Text;
            if (usuario == usuarioIngresado && contrasena == contrasenaIngresada)
            {
                Navigation.PushAsync(new vPrincipal(usuario, contrasena)); //Abre ventana Pricipal
            }
            else 
            {
                DisplayAlert("Alerta", "Usario/Contraseña incorrectos", "cerrar");
            }
        }
        catch (Exception)
        {
            throw;
        }
        
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());//Abre ventana registro
    }

}