using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SafiRepay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafiRepay.ViewModels
{
    class ExpanseSettingViewModel : ObservableObject
    {
        // Properties : Datas needed to be binded/registered in the view ExpenseSettingView
        private List<ExpensePackageType> _expensePackageTypes;

        // Properties and Getters/Setters: Action commands needed to be binded/registered to interact with the view ExpenseSettingView
        public RelayCommand<object> ExpensePackageTypesAmountUpdateCommand { get; private set; }

        // Getters and Setters only for the datas 
        public List<ExpensePackageType> ExpensePackageTypes
        {
            get
            {
                return _expensePackageTypes;
            }
            set { this.SetProperty(ref _expensePackageTypes, value); }
        }
        // Constructor
        public ExpanseSettingViewModel()
        {
            Console.WriteLine("ExpanseSettingViewModel - Constructor");

            // init the relay commands
            this.ExpensePackageTypesAmountUpdateCommand = new RelayCommand<object>(ExpensePackageTypesAmountUpdateAction);

            // Get the datas for the view
            this.ExpensePackageTypes = ExpensePackageType.All();
        }

        // Object methods that interact with the actions commands

        private void ExpensePackageTypesAmountUpdateAction(object SelectedItem)
        {
            Console.WriteLine("ExpenseSettingViewModel - ExpensePackageTypesAmountUpdateAction");

            Console.WriteLine(((ExpensePackageType)SelectedItem).Id);

            ExpensePackageType.Update(((ExpensePackageType)SelectedItem).Id,Convert.ToDecimal(((ExpensePackageType)SelectedItem).Amount));
        }
    }
}
