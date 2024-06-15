using JogoGourmetDotNetObjectiveRenan.Model;
using JogoGourmetDotNetObjectiveRenan.Models;
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
        private IFoodRepository _foodRepository;
        private ITipsRepository _tipsRepository;
        private List<int> _usedTipsIndex = new List<int>();
        private List<FoodGuess> _foodGuesses = new List<FoodGuess>();
        private List<int> _rightTipsIndex = new List<int>();
        private int rounds = 0;
        private Model.FoodGuess _foodGuess = new() { Id = 0, Name = "", Tips = new (){} };

        public FoodGuessPresenter(
            IFoodGuessView view, 
            IFoodRepository repository,
            ITipsRepository tipsRepository)
        {
            _view = view;
            _foodRepository = repository;
            _tipsRepository = tipsRepository;
            _view.NewGuess += SearchNewTip;
            _view.FoodGuessed += HandleYes;
            _view.InitGame += InitGame;
            _view.Show();
            _view.InitView();
        }

        private void InitGame(object? sender, EventArgs e)
        {
            rounds = 0;
            _usedTipsIndex.Clear();
            _rightTipsIndex.Clear();
            HandleNewTip();
            _view.RestartView();
        }

        private int LoadTotalNumberOfTips()
        {
            var tips = _tipsRepository.GetAll();
            return tips.Count();
        }

        private void HandleYes(object? sender, EventArgs e)
        {
            if(_view.GuessText != null)
            {
                _view.ShowFinishMessage(false);
                return;
            }
            _rightTipsIndex.Add(_view.TipIndexInUse);
            var guessFood = _foodRepository.GetBySimilarityTips(_rightTipsIndex);
            _view.SetNewGuess(guessFood.Name);
        }

        private void HandleNewTip()
        {
            int TotalTips = LoadTotalNumberOfTips();

            if (_usedTipsIndex.Count() == TotalTips)
            {
                _view.ShowFinishMessage(true);
                return;
            }

            GenerateNewTip(TotalTips);
        }

        private void GenerateNewTip(int TotalTips)
        {
            Random random = new Random();
            while (true)
            {
                int randomIndex = random.Next(1, TotalTips);
                bool neverUsedIndex = _usedTipsIndex.IndexOf(randomIndex) == -1;
                if (neverUsedIndex)
                {
                    Tip newTip = _tipsRepository.Get(randomIndex);
                    _view.SetNewTip(newTip.Name);
                    _usedTipsIndex.Add(randomIndex);
                    rounds++;
                    break;
                }
            }
        }

        private void SearchNewTip(object? sender, EventArgs e)
        {
            rounds++;
            if (rounds == _usedTipsIndex.Count())
            {
                _view.ShowFinishMessage(true);
                return;
            }
            HandleNewTip();
        }
    }
}
