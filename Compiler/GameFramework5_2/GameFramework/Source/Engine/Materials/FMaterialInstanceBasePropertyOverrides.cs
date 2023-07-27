#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstanceBasePropertyOverrides.h")]
///<summary>Properties from the base material that can be overridden in material instances.</summary>
public partial struct FMaterialInstanceBasePropertyOverrides {
// MaterialInstanceBasePropertyOverrides
	public bool bOverride_OpacityMaskClipValue;
	public bool bOverride_BlendMode;
	public bool bOverride_ShadingModel;
	public bool bOverride_DitheredLODTransition;
	public bool bOverride_CastDynamicShadowAsMasked;
	public bool bOverride_TwoSided;
	public bool bOverride_bIsThinSurface;
	public bool bOverride_OutputTranslucentVelocity;
	public bool bOverride_MaxWorldPositionOffsetDisplacement;
	public bool TwoSided;
	public bool bIsThinSurface;
	public bool DitheredLODTransition;
	public bool bCastDynamicShadowAsMasked;
	public bool bOutputTranslucentVelocity;
	public EBlendMode BlendMode;
	public EMaterialShadingModel ShadingModel;
	public float OpacityMaskClipValue;
	public float MaxWorldPositionOffsetDisplacement;
}
