using MvvmCross.ViewModels;
using RandomMelodyGenerator.Core.Services.Interfaces;

namespace RandomMelodyGenerator.Core.ViewModels
{
    public class MainViewModel: MvxViewModel
    {
        private IGeneratorService generatorService;

        public MainViewModel(IGeneratorService generatorService):
            base()
        {
            this.generatorService = generatorService;
        }
    }
}
