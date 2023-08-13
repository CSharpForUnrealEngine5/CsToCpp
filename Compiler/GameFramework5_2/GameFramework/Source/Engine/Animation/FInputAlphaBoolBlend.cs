namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/InputScaleBias.h")]
public partial struct FInputAlphaBoolBlend {
	public float BlendInTime;
	public float BlendOutTime;
	public EAlphaBlendOption BlendOption;
	public bool bInitialized;
	public UCurveFloat CustomCurve;
	public FAlphaBlend AlphaBlend;
}
