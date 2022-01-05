using System.Collections.ObjectModel;

namespace PetProject.Client.Wpf.Base;

internal class TreeViewModel : ViewModelBase
{
    private ObservableCollection<NodeViewModel> _root;

    public TreeViewModel()
    {
        _root = new ObservableCollection<NodeViewModel>();
    }

    public ObservableCollection<NodeViewModel> Root
    {
        get => _root;
        set
        {
            _root = value;
            OnPropertyChanged(nameof(Root));
        }
    }
}