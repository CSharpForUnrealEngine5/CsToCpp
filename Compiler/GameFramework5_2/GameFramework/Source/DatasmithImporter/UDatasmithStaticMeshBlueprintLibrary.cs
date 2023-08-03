#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithBlueprintLibrary.h")]
public partial class UDatasmithStaticMeshBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the proper lightmap resolution to get the desired lightmap density ratio</summary>
	public static void ComputeLightmapResolution(TArray<UObject> Objects,bool bApplyChanges,float IdealRatio/*=0.2f*/) {}
	///<summary>Setup the Lightmap UVs settings to enable or disable the lightmap generation on the static meshes found in the Assets list</summary>
	public static void SetupStaticLighting(TArray<UObject> Objects,bool bApplyChanges,bool bGenerateLightmapUVs,float LightmapResolutionIdealRatio/*=0.2f*/) {}
}
