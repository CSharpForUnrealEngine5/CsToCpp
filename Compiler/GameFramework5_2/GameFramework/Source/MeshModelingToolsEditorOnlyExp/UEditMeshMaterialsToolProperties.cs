#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshMaterialsTool.h")]
public partial class UEditMeshMaterialsToolProperties : UInteractiveToolPropertySet {
	///<summary>ActiveMaterial</summary>
	public string ActiveMaterial;
	///<summary>GetMaterialNamesFunc</summary>
	public  TArray<string> GetMaterialNamesFunc() { return default; }
	///<summary>MaterialNamesList</summary>
	public TArray<string> MaterialNamesList;
	///<summary>Materials</summary>
	public TArray<UMaterialInterface> Materials;
}
