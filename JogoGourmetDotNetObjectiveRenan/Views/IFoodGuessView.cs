using JogoGourmetDotNetObjectiveRenan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNetObjectiveRenan.View
{
    public interface IFoodGuessView
    {
        string GuessText { get; }
        string FoodName { get; set; }

        bool IsSuccessful {  get; set; }
        string Message { get; }

        event EventHandler FoodGuessed;
        event EventHandler NewGuess;

        void SetFoodGuessBindingSource(string newName);//BindingSource foodList);
        void Show();

    }
}
