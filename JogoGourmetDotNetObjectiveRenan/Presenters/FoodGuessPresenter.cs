using JogoGourmetDotNetObjectiveRenan.Model;
using JogoGourmetDotNetObjectiveRenan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNetObjectiveRenan.Presenter
{
    public class FoodGuessPresenter
    {
        private IFoodGuessView _view;
        private IGuessRepository _repository;
        private IEnumerable<Model.FoodGuess> _foodGuesses;
        private Model.FoodGuess _foodGuess;

        public FoodGuessPresenter(IFoodGuessView view, IGuessRepository repository)
        {
            _view = view;
            _repository = repository;
            _view.NewGuess += SearchNewFood;
            _view.FoodGuessed += CongratsResponse;
            LoadGuess();
            _view.Show();
        }

        private void LoadGuess()
        {
            _foodGuesses = _repository.GetAll();
        }

        private void CongratsResponse(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchNewFood(object? sender, EventArgs e)
        {
            _view.SetFoodGuessBindingSource("Macarrão");
        }
    }
}
