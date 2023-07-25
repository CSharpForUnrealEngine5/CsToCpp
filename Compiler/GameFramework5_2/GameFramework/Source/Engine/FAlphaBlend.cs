#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AlphaBlend.h")]
///<summary>Alpha Blend class that supports different blend options as well as custom curves</summary>
public partial struct FAlphaBlend {
// AlphaBlend
	public UCurveFloat CustomCurve;
	public float BlendTime;
	public EAlphaBlendOption BlendOption;
}
