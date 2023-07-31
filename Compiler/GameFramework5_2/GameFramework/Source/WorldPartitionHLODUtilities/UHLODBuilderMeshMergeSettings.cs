#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HLODBuilderMeshMerge.h")]
public partial class UHLODBuilderMeshMergeSettings : UHLODBuilderSettings {
	///<summary>Merged mesh generation settings</summary>
	public FMeshMergingSettings MeshMergeSettings;
	///<summary>Material that will be used by the generated HLOD static mesh</summary>
	public TSoftObjectPtr<UMaterialInterface> HLODMaterial;
}
