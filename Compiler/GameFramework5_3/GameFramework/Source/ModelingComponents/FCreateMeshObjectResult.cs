namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCreateMeshObjectResult is returned by UModelingObjectsCreationAPI::CreateMeshObject()</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial struct FCreateMeshObjectResult {
	public ECreateModelingObjectResult ResultCode;
	public AActor NewActor;
	public UPrimitiveComponent NewComponent;
	public UObject NewAsset;
}
