using System;
using System.Collections.Generic;
using System.ComponentModel;

public class ObservableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public new TValue this[TKey key]
    {
        get => base[key];
        set
        {
            base[key] = value;
            OnPropertyChanged(key.ToString());
        }
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
