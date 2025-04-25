namespace Benlico.Maui.ScopedService.Services;
public class ServiceScopeManager
{
    private readonly IServiceProvider _serviceProvider;
    private IServiceScope? _scope;

    public ServiceScopeManager(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public T GetScopedService<T>()
    {
        if (_scope == null)
        {
            _scope = _serviceProvider.CreateScope();
        }
        return _scope.ServiceProvider.GetRequiredService<T>();
    }

    public void DisposeScope()
    {
        _scope?.Dispose();
        _scope = null;
    }
}