#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshMaterialsTool.h")]
public partial class UEditMeshMaterialsToolProperties : UInteractiveToolPropertySet {
// EditMeshMaterialsToolProperties
	public string ActiveMaterial;
	public TArray<string> GetMaterialNamesFunc() { return default; }
	public TArray<string> MaterialNamesList;
	public TArray<UMaterialInterface> Materials;
}
