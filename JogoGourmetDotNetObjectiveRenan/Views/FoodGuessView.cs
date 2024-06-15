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
        } 

        public string GuessText { get => "A comida escolhida é " + FoodName; }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public string FoodName { get ; set; }

        public event EventHandler FoodGuessed;
        public event EventHandler NewGuess;

        public void SetFoodGuessBindingSource(string newName)//BindingSource food)
        {
            FoodName = newName;
            mainLabel.Text = GuessText;
        }

    }
}
