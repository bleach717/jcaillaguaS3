namespace jcaillaguaS3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuario = txtUsaurioRegistro.Text;
			string contrasena = txtContrasnaRegistro.Text;
			Navigation.PushAsync(new vLogin(usuario, contrasena));
			DisplayAlert("Alert", "SUaurio Registrado", "ok");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

    }
}