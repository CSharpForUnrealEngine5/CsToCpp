namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/Builders/HLODBuilderMeshSimplify.h")]
public partial class UHLODBuilderMeshSimplifySettings : UHLODBuilderSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Simplified mesh generation settings</summary>
	public FMeshProxySettings MeshSimplifySettings;
	///<summary>Material that will be used by the generated HLOD static mesh</summary>
	public TSoftObjectPtr<UMaterialInterface> HLODMaterial;
}
