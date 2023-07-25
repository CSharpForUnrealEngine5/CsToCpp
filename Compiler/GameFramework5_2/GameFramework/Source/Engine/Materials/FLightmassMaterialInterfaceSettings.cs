#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInterface.h")]
///<summary>UMaterial interface settings for Lightmass</summary>
public partial struct FLightmassMaterialInterfaceSettings {
// LightmassMaterialInterfaceSettings
	public float EmissiveBoost;
	public float DiffuseBoost;
	public float ExportResolutionScale;
	public bool bCastShadowAsMasked;
	public bool bOverrideCastShadowAsMasked;
	public bool bOverrideEmissiveBoost;
	public bool bOverrideDiffuseBoost;
	public bool bOverrideExportResolutionScale;
}
