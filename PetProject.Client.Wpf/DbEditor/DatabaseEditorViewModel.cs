using PetProject.Client.Wpf.Base;

namespace PetProject.Client.Wpf.DbEditor;

internal class DatabaseEditorViewModel : ViewModelBase
{
    private TypesViewModel _typesViewModel;
    private TypePropertiesViewModel _typePropertiesViewModel;

    public TypesViewModel TypesViewModel
    {
        get => _typesViewModel;
        set
        {
            _typesViewModel = value;
            OnPropertyChanged(nameof(TypesViewModel));
        }
    }

    public TypePropertiesViewModel TypePropertiesViewModel
    {
        get => _typePropertiesViewModel;
        set
        {
            _typePropertiesViewModel = value;
            OnPropertyChanged(nameof(TypesViewModel));
        }
    }
}