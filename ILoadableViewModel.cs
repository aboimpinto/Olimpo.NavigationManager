﻿namespace Olimpo;

public interface ILoadableViewModel
{
    Task LoadAsync(IDictionary<string, object>? parameters = null);
}
