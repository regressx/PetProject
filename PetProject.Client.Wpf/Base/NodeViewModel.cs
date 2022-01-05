using System.Collections.ObjectModel;

namespace PetProject.Client.Wpf.Base;

internal class NodeViewModel : ViewModelBase
{
    private ObservableCollection<NodeViewModel> _children;

    public NodeViewModel()
    {
        _children = new ObservableCollection<NodeViewModel>();
    }

    private ObservableCollection<NodeViewModel> Children
    {
        get => _children;
        set
        {
            _children = value;
            OnPropertyChanged(nameof(Children));
        }
    }
}