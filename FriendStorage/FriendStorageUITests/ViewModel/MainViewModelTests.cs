using FriendStorage.UI.ViewModel;
using Xunit;

namespace FriendStorageUITests.ViewModel
{
    public class MainViewModelTests
    {
        [Fact]
        public void ShouldCallTheLoadMethodOfTheNavigationViewModel()
        {
            var navigationViewModelMock = new MainViewModelMock();
            var viewModel = new MainViewModel(navigationViewModelMock);
            viewModel.Load();

            Assert.True(navigationViewModelMock.LoadHasBeenCalled);
        }
    }

    public class MainViewModelMock : INavigationViewModel
    {
        public bool LoadHasBeenCalled { get; set; }
        public void Load()
        {
            LoadHasBeenCalled = true;
        }
    }
}

