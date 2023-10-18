namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolMeshCut.h")]
public partial class UFractureToolMeshCut : UFractureToolCutterBase {
	public static UClass StaticClass() {return default;}
	///<summary>Slicing</summary>
	public UFractureMeshCutSettings MeshCutSettings;
}
