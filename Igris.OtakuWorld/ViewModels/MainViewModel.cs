using Igris.Mvvm;
using Igris.OtakuWorld.Creation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igris.OtakuWorld.Creation.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public object Content { get => GetProperty(() => Content); set => SetProperty(() => Content, value); }

        public MainViewModel()
        {
            Content = new SeriesView();
        }
    }
}
