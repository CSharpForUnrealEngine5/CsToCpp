#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>The blending mode for materials</summary>
public enum EBlendMode {
	BLEND_Opaque=0,
	BLEND_Masked=1,
	BLEND_Translucent=2,
	BLEND_Additive=3,
	BLEND_Modulate=4,
	BLEND_AlphaComposite=5,
	BLEND_AlphaHoldout=6,
	BLEND_TranslucentColoredTransmittance=7,
	BLEND_MAX=8,
	BLEND_TranslucentGreyTransmittance=-1,
	BLEND_ColoredTransmittanceOnly=-1,
}
