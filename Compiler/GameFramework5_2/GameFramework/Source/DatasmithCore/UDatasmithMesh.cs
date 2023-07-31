#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithMeshUObject.h")]
public partial class UDatasmithMesh : UObject {
	///<summary>MeshName</summary>
	public string MeshName;
	///<summary>bIsCollisionMesh</summary>
	public bool bIsCollisionMesh;
	///<summary>SourceModels</summary>
	public TArray<FDatasmithMeshSourceModel> SourceModels;
}
