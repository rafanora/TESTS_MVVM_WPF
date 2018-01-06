using FriendStorage.DataAccess;
using FriendStorage.UI.DataProvider;
using FriendStorage.UI.Startup;
using FriendStorage.UI.View;
using FriendStorage.UI.ViewModel;
using System.Windows;
using Autofac;

namespace FriendStorage.UI
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //Injeção de dependência
            #region INJEÇÃO DE DEPENDÊNCIA
            var bootStrapper = new BootStrapper();
            var container = bootStrapper.BootStrap();

            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
            #endregion

            //V1: sem injeção de dependências 
            //var mainWindow = new MainWindow(new MainViewModel(
            //    new NavigationViewModel(
            //    new NavigationDataProvider(
            //        () => new FileDataService()
            //    )
            //)));
            //mainWindow.Show();
        }
    }
}
