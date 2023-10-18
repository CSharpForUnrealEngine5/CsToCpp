namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_Inertialization.h")]
public partial struct FInertializationRequest {
	public float Duration;
	public UBlendProfile BlendProfile;
	public bool bUseBlendMode;
	public EAlphaBlendOption BlendMode;
	public UCurveFloat CustomBlendCurve;
	public FText Description;
	public int NodeId;
	public UObject AnimInstance;
}
