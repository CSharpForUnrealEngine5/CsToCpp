#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithDataprepOperation.h")]
///<summary>For each static mesh to process, setup the settings to enable lightmap UVs generation and compute the lightmap resolution.</summary>
public partial class UDataprepSetupStaticLightingOperation : UDataprepOperation {
// DataprepSetupStaticLightingOperation
	public bool bEnableLightmapUVGeneration;
	public float LightmapResolutionIdealRatio;
}
