using System.ComponentModel;
using System.Runtime.CompilerServices;
using PetProject.Client.Wpf.Annotations;

namespace PetProject.Client.Wpf.Base;

internal class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}