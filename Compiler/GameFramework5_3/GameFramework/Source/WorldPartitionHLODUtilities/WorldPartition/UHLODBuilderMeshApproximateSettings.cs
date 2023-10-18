namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/Builders/HLODBuilderMeshApproximate.h")]
public partial class UHLODBuilderMeshApproximateSettings : UHLODBuilderSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Mesh approximation settings</summary>
	public FMeshApproximationSettings MeshApproximationSettings;
	///<summary>Material that will be used by the generated HLOD static mesh</summary>
	public TSoftObjectPtr<UMaterialInterface> HLODMaterial;
}
