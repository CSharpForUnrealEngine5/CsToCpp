#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HLODBuilderMeshSimplify.h")]
public partial class UHLODBuilderMeshSimplifySettings : UHLODBuilderSettings {
	///<summary>Simplified mesh generation settings</summary>
	public FMeshProxySettings MeshSimplifySettings;
	///<summary>Material that will be used by the generated HLOD static mesh</summary>
	public TSoftObjectPtr<UMaterialInterface> HLODMaterial;
}
