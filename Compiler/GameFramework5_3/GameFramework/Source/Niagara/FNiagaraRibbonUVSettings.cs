namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines settings for UV behavior for a UV channel on ribbons.</summary>
[CppInclude("NiagaraRibbonRendererProperties.h")]
public partial struct FNiagaraRibbonUVSettings {
	public ENiagaraRibbonUVDistributionMode DistributionMode;
	public ENiagaraRibbonUVEdgeMode LeadingEdgeMode;
	public ENiagaraRibbonUVEdgeMode TrailingEdgeMode;
	public bool bEnablePerParticleUOverride;
	public bool bEnablePerParticleVRangeOverride;
	public float TilingLength;
	public FVector2D Offset;
	public FVector2D Scale;
}
