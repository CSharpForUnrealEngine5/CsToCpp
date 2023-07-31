#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Info for glow when using depth field rendering</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FDepthFieldGlowInfo {
	public bool bEnableGlow;
	public FLinearColor GlowColor;
	public FVector2D GlowOuterRadius;
	public FVector2D GlowInnerRadius;
}
