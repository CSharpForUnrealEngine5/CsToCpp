#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/RootMotionSource.h")]
///<summary>Group of Root Motion Sources that are applied</summary>
public partial struct FRootMotionSourceGroup {
// RootMotionSourceGroup
	public bool bHasAdditiveSources;
	public bool bHasOverrideSources;
	public bool bHasOverrideSourcesWithIgnoreZAccumulate;
	public bool bIsAdditiveVelocityApplied;
	public FRootMotionSourceSettings LastAccumulatedSettings;
	public FVector_NetQuantize10 LastPreAdditiveVelocity;
}
