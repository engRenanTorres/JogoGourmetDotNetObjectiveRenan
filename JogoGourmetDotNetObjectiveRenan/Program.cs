using JogoGourmetDotNetObjectiveRenan.View;
using JogoGourmetDotNetObjectiveRenan.Model;
using JogoGourmetDotNetObjectiveRenan.Presenter;
using JogoGourmetDotNetObjectiveRenan.Repository;

namespace JogoGourmetDotNetObjectiveRenan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IFoodGuessView view = new FoodGuessView();
            IGuessRepository repository = new FoodRepository();
            new FoodGuessPresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}