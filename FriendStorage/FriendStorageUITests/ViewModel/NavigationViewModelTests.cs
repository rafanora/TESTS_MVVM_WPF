using FriendStorage.UI.DataProvider;
using FriendStorage.UI.ViewModel;
using System.Collections.Generic;
using Xunit;
using FriendStorage.Model;
using Moq;

namespace FriendStorageUITests.ViewModel
{
    public class NavigationViewModelTests
    {
        private NavigationViewModel _viewModel;

        public NavigationViewModelTests()
        {
            var navigationDataProviderMock = new Mock<INavigationDataProvider>();
            navigationDataProviderMock.Setup(dp => dp.GetAllFriends())
                .Returns(new List<LookupItem>()
                {
                    new LookupItem { Id = 1, DisplayMember = "Julia" },
                    new LookupItem { Id = 2, DisplayMember = "Thomas" }
                });
            _viewModel = new NavigationViewModel(navigationDataProviderMock.Object);
        }

        [Fact]
        public void ShouldLoadFrieds()
        {
            //var viewModel = new NavigationViewModel(new NavigationDataProviderMock());
            _viewModel.Load();

            Assert.Equal(2, _viewModel.Friends.Count);
        }

        [Fact]
        public void ShouldLoadFriedsOnlyOnce()
        {
            //var viewModel = new NavigationViewModel(new NavigationDataProviderMock());
            _viewModel.Load();
            _viewModel.Load();
            Assert.Equal(2, _viewModel.Friends.Count);
        }

    }

    //MOCK
    //public class NavigationDataProviderMock : INavigationDataProvider
    //{
    //    public IEnumerable<LookupItem> GetAllFriends()
    //    {
    //        yield return new LookupItem { Id = 1, DisplayMember = "Julia" };
    //        yield return new LookupItem { Id = 2, DisplayMember = "Thomas" };
    //    }
    //}
}
