namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UModelingObjectsCreationAPI is a base interface for functions that can be used to</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial class UModelingObjectsCreationAPI : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new mesh object based on the data in CreateMeshParams</summary>
	public virtual FCreateMeshObjectResult CreateMeshObject(FCreateMeshObjectParams CreateMeshParams) { return default; }
	///<summary>Create a new texture object based on the data in CreateTexParams</summary>
	public virtual FCreateTextureObjectResult CreateTextureObject(FCreateTextureObjectParams CreateTexParams) { return default; }
}
