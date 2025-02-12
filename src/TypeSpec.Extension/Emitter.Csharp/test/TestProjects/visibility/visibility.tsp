import "@typespec/rest";
import "@typespec/http";

using TypeSpec.Http;

@service(
    {
        title: "VisibilityClient",
        version: "1.0.0"
    }
)
@server("http://localhost:3000", "TestServer endpoint")
@doc("Illustrates read, write and read/write properties.")

namespace TypeSpec.visibility;

model Dog {
  // the service will generate an ID, so you dont need to send it.
  @visibility("read") id: int32;
  // the service will store this secret name, but won't ever return it
  @visibility("write") secretName: string;
  // no flags are like specifying all flags at once, so in this case
  // equivalent to @visibility("read", "write")
  name: string;
}

@doc("ErrorResponse")
@error
model ErrorResponse {
  code: int32;
  message: string;
}

@route("/visibility")
@post
op sendVisibilityPropertyModel(@body input: Dog): Response<200>|ErrorResponse ;