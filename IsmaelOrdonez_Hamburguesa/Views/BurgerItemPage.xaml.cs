using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Models;

namespace IsmaelOrdonez_Hamburguesa.Views;

[QueryProperty(nameof(J_pass), "Pass")]
public partial class BurgerItemPage : ContentPage
{
	Burger Item = new Burger();
    Burger Pass = new Burger();
    bool _flag;

    public BurgerItemPage()
    {
        InitializeComponent();
    }

    public Burger J_pass
	{
		get => Pass;
		set
		{
			Pass = value;
		}
	}

	private async void OnSaveClicked(object sender, EventArgs e)
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
		await Shell.Current.GoToAsync("Main");
	}

	private async void OnCancelClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("Main");
	}

	private void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		_flag = e.Value;
	}

	private async void OnDeleteClicked(object sender, EventArgs e)
	{
		Item = Pass;
		App.BurgerRepo.DeleteBurger(Item);
		await Shell.Current.GoToAsync("Main");
	}
}
