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
    class ExpenseInPackageViewModel : ObservableObject
    {
        // Properties : Datas needed to be binded/registered in the view ExpenseInPackagesViewModel
        private List<ExpenseInPackage> _expenseInPackages;

        // Getters and Setters only for the datas 
        public List<ExpenseInPackage> ExpenseInPackages
        {
            get
            {
                return _expenseInPackages;
            }
            set { this.SetProperty(ref _expenseInPackages, value); }
        }
        // Constructor
        public ExpenseInPackageViewModel()
        {
            Console.WriteLine("ExpenseInPackagesViewModel - Constructor");

            // Get the datas for the view
            this.ExpenseInPackages = Models.ExpenseInPackage.All();
        }
    }
}
