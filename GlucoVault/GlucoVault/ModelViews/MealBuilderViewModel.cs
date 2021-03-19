using GlucoVault.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GlucoVault.ModelViews
{
    public class MealBuilderViewModel : ViewModelBase
    {
        public ObservableCollection<DailyMealPlan> _dailymealplans;
        public ObservableCollection<DailyMealPlan> DailyMealPlans { get; set; }


    /*  public ICommand DeleteMonkeyCommand { get; set; }

        public EditMonkeysViewModel(INavigation navigation) : base(navigation)
        {
            Monkeys = new ObservableCollection<Monkey>(App.Database.GetMonkeys());

            DeleteMonkeyCommand = new Command<Monkey>(DeleteMonkey);
        }

        private void DeleteMonkey(Monkey monkey)
        {
            App.Database.DeleteMonkey(monkey.MonkeyId);
            Monkeys = new ObservableCollection<Monkey>(App.Database.GetMonkeys());

        }*/
    }
}
