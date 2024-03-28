using EmployeeApp.ViewModels;

namespace EmployeeApp.Views;

public partial class EmployeesList : ContentPage
{
	public EmployeesList(EmployeesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}