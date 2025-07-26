using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.HealthChecks;

public class TestHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context, 
        CancellationToken cancellationToken = default)
    {
        var isHealthy = CheckApplicationHealth();
        
        return isHealthy 
            ? Task.FromResult(HealthCheckResult.Healthy("Test health check passed"))
            : Task.FromResult(HealthCheckResult.Unhealthy("Test health check failed"));
    }

    private bool CheckApplicationHealth()
    {
        return true;
    }
}