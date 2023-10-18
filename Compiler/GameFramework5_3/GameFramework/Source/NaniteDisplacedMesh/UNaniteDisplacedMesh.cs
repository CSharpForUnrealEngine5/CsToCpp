namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NaniteDisplacedMesh.h")]
public partial class UNaniteDisplacedMesh : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Parameters</summary>
	public FNaniteDisplacedMeshParams Parameters;
	///<summary>Was this asset created by a procedural tool?</summary>
	public bool bIsEditable;
}
