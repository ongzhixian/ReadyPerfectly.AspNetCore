namespace ReadyPerfectly.AspNetCore;

public interface IApiEndpointMapper
{
    void MapApiEndpoints(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpointRouteBuilder);
}