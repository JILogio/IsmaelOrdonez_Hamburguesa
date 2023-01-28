using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Models;

namespace IsmaelOrdonez_Hamburguesa.Views;

[QueryProperty(nameof(J_pass), "Pass")]
public partial class BurgerItemPage : ContentPage
{
    JOBurger Item = new JOBurger();
    JOBurger Pass = new JOBurger();
    bool _flag;

    public BurgerItemPage()
    {
        InitializeComponent();
    }

    public JOBurger J_pass
	{
		get => Pass;
		set
		{
			Pass = value;
		}
	}

	private async void JO_Save(object sender, EventArgs e)
	{
		Item = Pass;
		Item.Name = nameB.Text;
		Item.Description = descB.Text;
		Item.WithExtraCheese = _flag;

		if (string.IsNullOrEmpty(Item.Name) || string.IsNullOrEmpty(Item.Description))
		{
			return;
		}
		App.BurgerRepo.AddNewBurger(Item);
		await Shell.Current.GoToAsync("..");
	}

	private async void JO_Cancel(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}

	private void JO_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		_flag = e.Value;
	}

	private async void JO_Delete(object sender, EventArgs e)
	{
		Item = Pass;
		App.BurgerRepo.DeleteBurger(Item);
		await Shell.Current.GoToAsync("..");
	}
}
