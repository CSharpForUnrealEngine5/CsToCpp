#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, setup the settings to enable lightmap UVs generation and compute the lightmap resolution.</summary>
[CppInclude("DatasmithDataprepOperation.h")]
public partial class UDataprepSetupStaticLightingOperation : UDataprepOperation {
	///<summary>Enable the lightmap UV generation.</summary>
	public bool bEnableLightmapUVGeneration;
	///<summary>The ratio used to compute the resolution of the lightmap.</summary>
	public float LightmapResolutionIdealRatio;
}
