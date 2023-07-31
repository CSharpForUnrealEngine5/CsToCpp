#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UModelingObjectsCreationAPI is a base interface for functions that can be used to</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial class UModelingObjectsCreationAPI : UObject {
	///<summary>Create a new mesh object based on the data in CreateMeshParams</summary>
	public  FCreateMeshObjectResult CreateMeshObject(FCreateMeshObjectParams CreateMeshParams) { return default; }
	///<summary>Create a new texture object based on the data in CreateTexParams</summary>
	public  FCreateTextureObjectResult CreateTextureObject(FCreateTextureObjectParams CreateTexParams) { return default; }
}
