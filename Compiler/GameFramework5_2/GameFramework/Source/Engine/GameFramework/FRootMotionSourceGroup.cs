namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Group of Root Motion Sources that are applied</summary>
[CppInclude("GameFramework/RootMotionSource.h")]
public partial struct FRootMotionSourceGroup {
	public bool bHasAdditiveSources;
	public bool bHasOverrideSources;
	public bool bHasOverrideSourcesWithIgnoreZAccumulate;
	public bool bIsAdditiveVelocityApplied;
	public FRootMotionSourceSettings LastAccumulatedSettings;
	public FVector_NetQuantize10 LastPreAdditiveVelocity;
}
