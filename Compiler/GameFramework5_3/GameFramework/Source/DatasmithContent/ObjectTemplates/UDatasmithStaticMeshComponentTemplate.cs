namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithStaticMeshComponentTemplate.h")]
public partial class UDatasmithStaticMeshComponentTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>StaticMesh</summary>
	public UStaticMesh StaticMesh;
	///<summary>OverrideMaterials</summary>
	public TArray<UMaterialInterface> OverrideMaterials;
}
