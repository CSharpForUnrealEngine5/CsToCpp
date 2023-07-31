#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIType.h")]
///<summary>Schema type allows same name but different Schema types, ie. both a service and model with the name &quot;Pet&quot;.</summary>
public enum EWebAPISchemaType {
	Model=0,
	Service=1,
	Operation=2,
	Property=3,
	Parameter=4,
	Unspecified=128,
}
