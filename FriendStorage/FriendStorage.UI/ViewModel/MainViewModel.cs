using FriendStorage.UI.DataProvider;
using FriendStorage.DataAccess;
using System;

namespace FriendStorage.UI.ViewModel
{
  public class MainViewModel : ViewModelBase
  {
        public INavigationViewModel NavigationViewModel { get; private set; }

        /// <summary>
        /// Faz com que o Navigation view model implemente o componente filho.
        /// </summary>
        public MainViewModel(INavigationViewModel navigationViewModel)
        {
            /*
            * DEPENDÊNCIA QUE DEVE SER ELIMINDA!!
            *Criando uma interface da classe implementada e fazendo com que o objeto antes diretamente carregado 
            *receba uma interface, que vai ser usada pelos testes.
            *NavigationViewModel = new NavigationViewModel(
            *    new NavigationDataProvider(
            *        ()=> new FileDataService()
            *    )
            *); */

            NavigationViewModel = navigationViewModel;
        }

        public void Load()
        {
            NavigationViewModel.Load();
        }
    }
}
