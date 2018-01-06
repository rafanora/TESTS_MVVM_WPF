using FriendStorage.DataAccess;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;
using System.Collections.ObjectModel;

namespace FriendStorage.UI.ViewModel
{
    public interface INavigationViewModel
    {
        void Load();
    }

    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        #region VERSÃO 2
        //Elimina a dependencia com o FileDataService.
        private INavigationDataProvider _dataProvider;

        //Necessita do ObservationCollection para monitorar a lista. 
        public ObservableCollection<LookupItem> Friends { get; private set; }

        public NavigationViewModel(INavigationDataProvider dataProvider) //Recebe a interface de parametro.
        {
            Friends = new ObservableCollection<LookupItem>(); 
            _dataProvider = dataProvider;
        }

        public void Load()
        {
            Friends.Clear();
            foreach (var friend in _dataProvider.GetAllFriends())
            {
                Friends.Add(friend);
            }
        }
        #endregion

        #region Versão 1
        //public NavigationViewModel()
        //{
        //    Friends = new ObservableCollection<Friend>();
        //}

        //public void Load()
        //{
        //    var dataService = new FileDataService();
        //    foreach (var friend in dataService.GetAllFriends())
        //    {
        //        Friends.Add(friend);
        //    }
        //}

        //public ObservableCollection<Friend> Friends { get; private set; }
        #endregion
    }
}
