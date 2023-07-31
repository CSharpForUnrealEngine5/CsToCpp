#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Alpha Blend class that supports different blend options as well as custom curves</summary>
[CppInclude("AlphaBlend.h")]
public partial struct FAlphaBlend {
	public UCurveFloat CustomCurve;
	public float BlendTime;
	public EAlphaBlendOption BlendOption;
}
