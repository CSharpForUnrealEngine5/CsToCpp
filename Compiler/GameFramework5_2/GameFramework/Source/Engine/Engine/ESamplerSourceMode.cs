#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Controls where the sampler for different texture lookups comes from</summary>
public enum ESamplerSourceMode {
	SSM_FromTextureAsset=0,
	SSM_Wrap_WorldGroupSettings=1,
	SSM_Clamp_WorldGroupSettings=2,
	SSM_TerrainWeightmapGroupSettings=3,
}
