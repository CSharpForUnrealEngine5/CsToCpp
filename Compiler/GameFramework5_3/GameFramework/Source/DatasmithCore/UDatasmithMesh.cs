namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithMeshUObject.h")]
public partial class UDatasmithMesh : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>MeshName</summary>
	public string MeshName;
	///<summary>bIsCollisionMesh</summary>
	public bool bIsCollisionMesh;
	///<summary>SourceModels</summary>
	public TArray<FDatasmithMeshSourceModel> SourceModels;
}
