using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmetDotNetObjectiveRenan.View
{
    public partial class FoodGuessView : Form, IFoodGuessView
    {
        public FoodGuessView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            yesButton.Click += delegate { FoodGuessed?.Invoke(this, EventArgs.Empty); };
            noButton.Click += delegate { NewGuess?.Invoke(this, EventArgs.Empty); };
            initButton.Click += delegate { InitGame?.Invoke(this, EventArgs.Empty); };
        } 

        public string? GuessText { get; set; }

        public bool IsFinished { get; set; }
        public string? TipText { get ; set; }
        public int TipIndexInUse { get; set; }

        public event EventHandler FoodGuessed;
        public event EventHandler NewGuess;
        public event EventHandler InitGame;

        public void SetNewTip(string newName)//BindingSource food)
        {
            GuessText = null;
            TipText = "A comida escolhida é " + newName + "?";
            tipLabel.Visible = true;
            guessLabel.Visible = false;
            tipLabel.Text = TipText;
        }

        public void SetNewGuess(string newGuess)
        {
            TipText = null;
            GuessText = "A comida escolhida foi " + newGuess + "?";
            tipLabel.Visible = false;
            guessLabel.Visible = true;
            guessLabel.Text = GuessText;
        }

        public void ShowFinishMessage(bool userWon)
        {
            tipLabel.Text = 
                userWon? 
                "Ok, eu desisto! Não tenho mais palpites. =(":
                "Eu sempre adivinho! =D";
            tipLabel.Visible = true;
            InitView();
        }

        public void RestartView()
        {
            guessLabel.Visible = false;
            yesButton.Visible = true;
            noButton.Visible= true;
            initButton.Visible = false;
        }

        public void InitView()
        {
            guessLabel.Visible = false;
            yesButton.Visible = false;
            noButton.Visible = false;
            initButton.Visible = true;
        }

    }
}
