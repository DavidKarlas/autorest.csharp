import "@typespec/rest";
import "@typespec/http";

@service(
    {
        title: "endpoint",
        version: "2015-06-18"
    }
)
@server(
    "{endpointServiceUrl}",
    "Endpoint Service",
    {
        endpointServiceUrl: string,
    }
)
namespace endpoint;

using TypeSpec.Http;

@route("/endpoint")
@doc("Path parameter is string with format")
@get
op genEndPoint(@path action: string): void;