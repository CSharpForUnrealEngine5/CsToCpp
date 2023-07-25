#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Info for glow when using depth field rendering</summary>
public partial struct FDepthFieldGlowInfo {
// DepthFieldGlowInfo
	public bool bEnableGlow;
	public FLinearColor GlowColor;
	public FVector2D GlowOuterRadius;
	public FVector2D GlowInnerRadius;
}
