using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Models;

namespace IsmaelOrdonez_Hamburguesa.Views;

[QueryProperty(nameof(J_pass), "pass")]
public partial class BurgerItemPage : ContentPage
{
	Burger Item = new Burger();
	bool _flag;
    Burger pass = new Burger();
    public Burger J_pass
    {
        get => pass;
        set
        {
            pass = value;
        }
    }

    public BurgerItemPage()
	{
		InitializeComponent();
	}

	private async void OnSaveClicked(object sender, EventArgs e)
	{
		Item.Name = nameB.Text;
		Item.Description = descB.Text;
		Item.WithExtraCheese = _flag;
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

	private void OnDeleteClicked(object sender, EventArgs e)
	{
		Item = pass;
		App.BurgerRepo.DeleteBurger(Item);
		Shell.Current.GoToAsync("Main");
	}
}
