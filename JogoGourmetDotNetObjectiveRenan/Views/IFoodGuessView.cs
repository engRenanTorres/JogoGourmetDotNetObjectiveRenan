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
        string TipText { get; set; }
        int TipIndexInUse { get; set; }

        bool IsFinished {  get; set; }

        event EventHandler FoodGuessed;
        event EventHandler NewGuess;
        public event EventHandler InitGame;

        void SetNewTip(string newName);//BindingSource foodList);
        void SetNewGuess(string newGuess);
        void Show();

        void ShowFinishMessage(bool usersWon);
        void RestartView();

        void InitView();

    }
}
