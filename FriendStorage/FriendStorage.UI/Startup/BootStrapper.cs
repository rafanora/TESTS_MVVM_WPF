using Autofac;
using FriendStorage.DataAccess;
using FriendStorage.UI.DataProvider;
using FriendStorage.UI.View;
using FriendStorage.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendStorage.UI.Startup
{
    public class BootStrapper
    {
        public IContainer BootStrap()
        {
            //Adicionando o Autofact podemos criar a injeção de dependências nos nossos modelos.
            var builder = new ContainerBuilder();

            //Inicializa a injeção sem a interface.
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            
            //Inicia a partir de uma interface.
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<NavigationDataProvider>().As<INavigationDataProvider>();
            builder.RegisterType<FileDataService>().As<IDataService>();

            return builder.Build(); 
        }
    }
}
