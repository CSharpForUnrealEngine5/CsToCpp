namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ConstantForce applies a fixed force to the target</summary>
[CppInclude("GameFramework/RootMotionSource.h")]
public partial struct FRootMotionSource_ConstantForce {
	public FVector Force;
	public UCurveFloat StrengthOverTime;
}
