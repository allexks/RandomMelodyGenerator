using MvvmCross;
using MvvmCross.ViewModels;
using RandomMelodyGenerator.Core.Services;
using RandomMelodyGenerator.Core.Services.Interfaces;
using RandomMelodyGenerator.Core.ViewModels;

namespace RandomMelodyGenerator.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IGeneratorService, GeneratorService>();

            RegisterAppStart<MainViewModel>();
        }
    }
}
