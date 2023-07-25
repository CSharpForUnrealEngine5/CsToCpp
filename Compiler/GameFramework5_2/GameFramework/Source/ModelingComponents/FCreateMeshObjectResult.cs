#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingObjectsCreationAPI.h")]
///<summary>FCreateMeshObjectResult is returned by UModelingObjectsCreationAPI::CreateMeshObject()</summary>
public partial struct FCreateMeshObjectResult {
// CreateMeshObjectResult
	public ECreateModelingObjectResult ResultCode;
	public AActor NewActor;
	public UPrimitiveComponent NewComponent;
	public UObject NewAsset;
}
