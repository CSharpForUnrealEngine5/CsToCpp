namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/LODManagerTool.h")]
public partial class ULODManagerMaterialActions : ULODManagerActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Discard any Materials that are not referenced by any LOD</summary>
	public void CleanMaterials() {}
}
