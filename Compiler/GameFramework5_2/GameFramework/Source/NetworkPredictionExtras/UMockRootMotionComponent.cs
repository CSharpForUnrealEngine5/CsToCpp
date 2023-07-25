#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockRootMotionComponent.h")]
///<summary>This component acts as the Driver for the FMockRootMotionSimulation</summary>
public partial class UMockRootMotionComponent : UBaseMovementComponent {
// MockRootMotionComponent
	public UObject CreateRootMotionSource(UClass Source) { return default; }
	public void Input_PlayRootMotionSource(UObject Source) {}
	public void Input_PlayRootMotionSourceByClass(UClass Source) {}
	public void PlayRootMotionSource(UObject Source) {}
	public void PlayRootMotionSourceByClass(UClass Source) {}
	public FRootMotionSourceCache RootMotionSourceCache;
}
