using Microsoft.Extensions.DependencyInjection;
using Bookinist.ViewsModels;

namespace Bookinist.ViewModels
{
    class ViewModelLocator
    {
        // Запрашиваем главную модель главного окна
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
