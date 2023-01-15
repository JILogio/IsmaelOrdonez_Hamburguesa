using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Models;

namespace IsmaelOrdonez_Hamburguesa.Views;

[QueryProperty(nameof(J_pass),"pass")]
public partial class BurgerItemPage : ContentPage
{
	Burger Item = new Burger();
	Burger pass;
    bool _flag;

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
		BindingContext = this;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
	{
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
		Item = pass;
		App.BurgerRepo.DeleteBurger(Item);
		await Shell.Current.GoToAsync("Main");
	}
}
