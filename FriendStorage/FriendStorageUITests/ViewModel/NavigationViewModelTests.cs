using FriendStorage.UI.DataProvider;
using FriendStorage.UI.ViewModel;
using System.Collections.Generic;
using Xunit;
using FriendStorage.Model;

namespace FriendStorageUITests.ViewModel
{
    public class NavigationViewModelTests
    {
        [Fact]
        public void ShouldLoadFrieds()
        {
            var viewModel = new NavigationViewModel(new NavigationDataProviderMock());
            viewModel.Load();

            Assert.Equal(2, viewModel.Friends.Count);
        }

        [Fact]
        public void ShouldLoadFriedsOnlyOnce()
        {
            var viewModel = new NavigationViewModel(new NavigationDataProviderMock());
            viewModel.Load();
            viewModel.Load();
            Assert.Equal(2, viewModel.Friends.Count);
        }

    }

    //MOCK
    public class NavigationDataProviderMock : INavigationDataProvider
    {
        public IEnumerable<LookupItem> GetAllFriends()
        {
            yield return new LookupItem { Id = 1, DisplayMember = "Julia" };
            yield return new LookupItem { Id = 2, DisplayMember = "Thomas" };
        }
    }
}
