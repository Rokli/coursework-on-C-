using Curs.Presenter.Class;
using Curs.View.Class;

namespace Curs
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            MainView view = new MainView();
            MainPesenter presenter = new MainPesenter(view);
            Application.Run(view);
        }
    }
}