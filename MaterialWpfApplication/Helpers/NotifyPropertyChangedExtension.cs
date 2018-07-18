using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MaterialWpfApplication.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class NotifyPropertyChangedExtension
    {
        public static void Mutateverbose<Tfield>(this INotifyPropertyChanged instance, ref Tfield field,
            Tfield newValue, Action<PropertyChangedEventArgs> raice, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<Tfield>.Default.Equals(field, newValue)) return;

            field = newValue;
            raice?.Invoke(new PropertyChangedEventArgs(propertyName));
        }
    }
}
