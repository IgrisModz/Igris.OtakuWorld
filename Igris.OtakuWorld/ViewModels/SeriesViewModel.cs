using Igris.Mvvm;
using Igris.OtakuWorld.Creation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igris.OtakuWorld.Creation.ViewModels
{
    internal class SeriesViewModel : ViewModelBase
    {
        public List<Serie> Series { get; set; }

        public DelegateCommand NewCommand { get; }
        public DelegateCommand OpenCommand { get; }
        public DelegateCommand ModifyCommand { get; }
        public DelegateCommand DeleteCommand { get; }

        public SeriesViewModel()
        {
            Series = new List<Serie>
            {
                new Serie
                {
                    Id = 1,
                    Name = "Test",
                    Author= "Moi",
                    Description = "Ceci est une description"
                }
            };
        }
    }
}
