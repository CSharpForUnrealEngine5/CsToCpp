#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines settings for UV behavior for a UV channel on ribbons.</summary>
[CppInclude("NiagaraRibbonRendererProperties.h")]
public partial struct FNiagaraRibbonUVSettings {
	public ENiagaraRibbonUVDistributionMode DistributionMode;
	public ENiagaraRibbonUVEdgeMode LeadingEdgeMode;
	public ENiagaraRibbonUVEdgeMode TrailingEdgeMode;
	public float TilingLength;
	public FVector2D Offset;
	public FVector2D Scale;
	public bool bEnablePerParticleUOverride;
	public bool bEnablePerParticleVRangeOverride;
}
