import "@typespec/rest";
import "@typespec/http";
import "@typespec/versioning";
import "@azure-tools/typespec-azure-core";

using TypeSpec.Http;
using TypeSpec.Rest;
using TypeSpec.Versioning;
using Azure.Core;

// NOTE: These features are missing:
// - Security definition for apiKey

@server(
  "{Endpoint}",
  "Polymorphism Service",
  {
    Endpoint: Endpoint,
  }
)

@service(
    {
        title: "Microsoft Polymorphism Service",
        version: "2022-05-15-preview"
    }
)
namespace PolymorphismOperation;

@doc("The endpoint to use.")
scalar Endpoint extends string;

// Model types
@doc("This is base model for polymorphic multiple levels inheritance with a discriminator.")
@discriminator("kind")
model Fish {
  age: int32;
}

@doc("The second level model in polymorphic multiple levels inheritance and it defines a new discriminator.")
@discriminator("sharktype")
model Shark extends Fish {
  kind: "shark";
}

@doc("The second level model in polymorphic multiple levels inheritance which contains references to other polymorphic instances.")
model Salmon extends Fish {
  kind: "salmon";
  friends?: Fish[];
  hate?: Record<Fish>;
  partner?: Fish;
}

@doc("The third level model SawShark in polymorphic multiple levels inheritance.")
model SawShark extends Shark {
  sharktype: "saw";
}

@doc("The third level model GoblinShark in polymorphic multiple levels inheritance.")
model GoblinShark extends Shark {
  sharktype: "goblin";
}

@route("/discriminated")
interface Discriminated {
  @route("/model")
  @doc("Generate and receive polymorphic model in multiple levels inheritance with 2 discriminators.")
  @put
  putModel(@body input: Fish): OkResponse;

  @route("/recursivemodel")
  @doc("Generate and receive polymorphic models has collection and dictionary properties referring to other polymorphic models.")
  @get
  getRecursiveModel(): Fish;

  @route("/recursivemodel")
  @doc("Generate and send polymorphic models has collection and dictionary properties referring to other polymorphic models.")
  @put
  putRecursiveModel(@body input: Fish): OkResponse;

  @route("/missingdiscriminator")
  @doc("Get a model omitting the discriminator.")
  @get
  getMissingDiscriminator(): Fish;

  @route("/wrongdiscriminator")
  @doc("Get a model containing discriminator value never defined.")
  @get
  getWrongDiscriminator(): Fish;
}