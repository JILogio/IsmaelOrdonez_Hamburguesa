using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Models;

namespace IsmaelOrdonez_Hamburguesa.Views;

public partial class BurgerItemPage : ContentPage
{
	Burger Item = new Burger();
	bool _flag;
	public BurgerItemPage()
	{
		InitializeComponent();
	}

	private void OnSaveClicked(object sender, EventArgs e)
	{
		Item.Name = nameB.Text;
		Item.Description = descB.Text;
		Item.WithExtraCheese = _flag;
		App.BurgerRepo.AddNewBurger(Item);
		Shell.Current.GoToAsync("Main");
    }

	private void OnCancelClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("Main");
	}

	private void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		_flag = e.Value;
	}

	private void OnDeleteClicked(object sender, EventArgs e)
	{
		/*Item = BindingContext.Burger;
		App.BurgerRepo.DeleteBurger();
        Shell.Current.GoToAsync("Main");*/
    }
}