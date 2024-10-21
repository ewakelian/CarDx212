using RacingCarDx212.Classes;

namespace RacingCarDx212;
public partial class MainPage : ContentPage
{
	Car audi;
	Car nissan;
	bool isFinish = false;

	public MainPage()
	{
		InitializeComponent();
		audi = new Car("A1", 100, 50, 10);
		nissan = new Car("S1", 180, 60, 10);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

		if (!this.isFinish)
		{
			var screenWidth = Application.Current.MainPage.Width;
			this.audiRun(screenWidth);
			this.NissanRun(screenWidth);
			this.isFinish = true;
			this.myLabel.Text= audi.ShowInfo() + "\n" + nissan.ShowInfo();
		}
		else
		{
			ImageCar1.TranslateTo(0, 0, 0, Easing.Linear);

			ImageCar2.TranslateTo(0, 0, 0, Easing.Linear);
			this.isFinish = false;

		}
		audi.Run(10);
		nissan.Run(5);
		myLabel.Text = audi.ShowInfo() + nissan.ShowInfo();
	}
	private void audiRun(double distance)
	{
		var timeused = audi.TimeUsedForRun(distance);
		ImageCar1.TranslateTo(distance - 150, 0, timeused * 150, Easing.Linear);


	}
	private void NissanRun(double distance)
	{
		var timeused = nissan.TimeUsedForRun(distance);
		ImageCar2.TranslateTo(distance - 150, 0, timeused * 150, Easing.Linear);
	}

	//audi.Run(10);
	//nissan.Run(5);
	//myLabel.Text = audi.ShowInfo() + nissan.ShowInfo();
}



