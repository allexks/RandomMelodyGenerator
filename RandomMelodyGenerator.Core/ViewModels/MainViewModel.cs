using MvvmCross.ViewModels;
using RandomMelodyGenerator.Core.Services.Interfaces;

namespace RandomMelodyGenerator.Core.ViewModels
{
    class MainViewModel: MvxViewModel
    {
        private IGeneratorService generatorService;

        MainViewModel(IGeneratorService generatorService):
            base()
        {
            this.generatorService = generatorService;
        }
    }
}
