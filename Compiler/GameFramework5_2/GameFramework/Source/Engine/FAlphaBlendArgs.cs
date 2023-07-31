#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Alpha Blend construction arguments. Used for creation of an AlphaBlend.</summary>
[CppInclude("AlphaBlend.h")]
public partial struct FAlphaBlendArgs {
	public UCurveFloat CustomCurve;
	public float BlendTime;
	public EAlphaBlendOption BlendOption;
}
