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
    class ExpenseOutPackageViewModel : ObservableObject
    {
        // Properties : Datas needed to be binded/registered in the view ExpenseInPackagesViewModel
        private List<ExpenseOutPackage> _expenseOutPackages;

        // Getters and Setters only for the datas 
        public List<ExpenseOutPackage> ExpenseOutPackages
        {
            get
            {
                return _expenseOutPackages;
            }
            set { this.SetProperty(ref _expenseOutPackages, value); }
        }
        // Constructor
        public ExpenseOutPackageViewModel()
        {
            Console.WriteLine("ExpenseOutPackagesViewModel - Constructor");

            // Get the datas for the view
            this.ExpenseOutPackages = Models.ExpenseOutPackage.All();
        }
    }
}