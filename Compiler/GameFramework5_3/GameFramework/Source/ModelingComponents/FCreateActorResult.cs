namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCreateActorResult is returned by UModelingObjectsCreationAPI::FCreateActorParams()</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial struct FCreateActorResult {
	public ECreateModelingObjectResult ResultCode;
	public AActor NewActor;
}
