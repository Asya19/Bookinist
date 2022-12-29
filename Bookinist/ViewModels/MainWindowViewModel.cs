using MathCore.WPF.ViewModels;

namespace Bookinist.ViewsModels
{
    class MainWindowViewModel : ViewModel
    {
        #region Title : string = Заголовок
        private string _Title = "Главное окно программы";

        public string Title { get => _Title; set => Set(ref _Title, value); }
        #endregion
    }
}
