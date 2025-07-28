using System;
using System.Collections.Generic;
using UnityEngine;

public class ServiceManager
{
    private static readonly ServiceManager _instance = new();
    public static ServiceManager Instance => _instance;

    private readonly Dictionary<Type, object> _services = new();

    public ServiceManager RegisterByType<TServiceType>(object implementation)
    {
        _services.Add(typeof(TServiceType), implementation);
        return this;
    }
    
    //private void TryAddService(Type serviceType)
}
