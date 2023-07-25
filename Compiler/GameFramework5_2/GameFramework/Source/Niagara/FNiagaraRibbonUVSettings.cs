#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraRibbonRendererProperties.h")]
///<summary>Defines settings for UV behavior for a UV channel on ribbons.</summary>
public partial struct FNiagaraRibbonUVSettings {
// NiagaraRibbonUVSettings
	public ENiagaraRibbonUVDistributionMode DistributionMode;
	public ENiagaraRibbonUVEdgeMode LeadingEdgeMode;
	public ENiagaraRibbonUVEdgeMode TrailingEdgeMode;
	public float TilingLength;
	public FVector2D Offset;
	public FVector2D Scale;
	public bool bEnablePerParticleUOverride;
	public bool bEnablePerParticleVRangeOverride;
}
