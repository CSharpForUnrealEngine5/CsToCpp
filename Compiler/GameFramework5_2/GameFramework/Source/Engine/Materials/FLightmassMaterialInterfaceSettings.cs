namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMaterial interface settings for Lightmass</summary>
[CppInclude("Materials/MaterialInterface.h")]
public partial struct FLightmassMaterialInterfaceSettings {
	public float EmissiveBoost;
	public float DiffuseBoost;
	public float ExportResolutionScale;
	public bool bCastShadowAsMasked;
	public bool bOverrideCastShadowAsMasked;
	public bool bOverrideEmissiveBoost;
	public bool bOverrideDiffuseBoost;
	public bool bOverrideExportResolutionScale;
}
