using MvvmCross.Platforms.Ios.Views;
using RandomMelodyGenerator.Core.ViewModels;

namespace RandomMelodyGenerator.iOS.ViewControllers
{
    public class MainViewController: MvxViewController<MainViewModel>
    {
        public static readonly string ViewNibName = "MainView";

        public MainViewController() : base(ViewNibName, null) { }
    }
}