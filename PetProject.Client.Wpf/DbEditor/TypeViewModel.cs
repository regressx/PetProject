using System;
using PetProject.Client.Wpf.Base;
using PetProject.CommonLogic.Metadata;

namespace PetProject.Client.Wpf.DbEditor;

internal class TypeViewModel : ViewModelBase
{
    private IDbType _model;

    public TypeViewModel(IDbType model)
    {
        _model = model;
    }

    public string Name
    {
        get => _model.Name;
        set
        {
            _model.Name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public int Id => _model.Id;

    public Guid Guid => _model.Guid;

    public bool IsAbstract
    {
        get => _model.IsAbstract;
        set
        {
            _model.IsAbstract = value;
            OnPropertyChanged(nameof(IsAbstract));
        }
    }
}