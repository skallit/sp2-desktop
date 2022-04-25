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
    class ExpenseSheetValidationViewModel : ObservableObject
    {
        // Properties : Datas needed to be binded/registered in the view ExpenseSheetValidationViewModel
        private List<ExpenseSheet> _expenseSheets;

        // Getters and Setters only for the datas 
        public List<ExpenseSheet> ExpenseSheets
        {
            get
            {
                return _expenseSheets;
            }
            set { this.SetProperty(ref _expenseSheets, value); }
        }
        // Constructor
        public ExpenseSheetValidationViewModel()
        {
            Console.WriteLine("ExpenseSheetValidationViewModel - Constructor");

            // Get the datas for the view
            this.ExpenseSheets = ExpenseSheet.All();
        }
    }
}
