#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/RootMotionSource.h")]
///<summary>ConstantForce applies a fixed force to the target</summary>
public partial struct FRootMotionSource_ConstantForce {
// RootMotionSource_ConstantForce
	public FVector Force;
	public UCurveFloat StrengthOverTime;
}
