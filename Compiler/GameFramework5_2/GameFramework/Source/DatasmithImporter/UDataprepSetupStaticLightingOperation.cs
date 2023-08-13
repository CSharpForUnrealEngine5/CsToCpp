namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, setup the settings to enable lightmap UVs generation and compute the lightmap resolution.</summary>
[CppInclude("DatasmithDataprepOperation.h")]
public partial class UDataprepSetupStaticLightingOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Enable the lightmap UV generation.</summary>
	public bool bEnableLightmapUVGeneration;
	///<summary>The ratio used to compute the resolution of the lightmap.</summary>
	public float LightmapResolutionIdealRatio;
}
