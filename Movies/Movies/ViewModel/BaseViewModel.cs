using CommunityToolkit.Mvvm.ComponentModel;

namespace Movies.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    { 
    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(isNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool isNotBusy => !isBusy;
    
}
