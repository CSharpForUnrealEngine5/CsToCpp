namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PointFromMesh creates a single point at the origin with an attribute containing a SoftObjectPath to the selected UStaticMesh</summary>
[CppInclude("Elements/PCGPointFromMeshElement.h")]
public partial class UPCGPointFromMeshSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>StaticMesh</summary>
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	///<summary>Name of the string attribute to be created and hold a SoftObjectPath to the StaticMesh</summary>
	public FName MeshPathAttributeName;
}
