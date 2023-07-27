#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockRootMotionComponent.h")]
///<summary>This component acts as the Driver for the FMockRootMotionSimulation</summary>
public partial class UMockRootMotionComponent : UBaseMovementComponent {
// MockRootMotionComponent
	public  UMockRootMotionSource CreateRootMotionSource(UClass Source) { return default; }
	public  void Input_PlayRootMotionSource(UMockRootMotionSource Source) {}
	public  void Input_PlayRootMotionSourceByClass(UClass Source) {}
	public  void PlayRootMotionSource(UMockRootMotionSource Source) {}
	public  void PlayRootMotionSourceByClass(UClass Source) {}
	public FRootMotionSourceCache RootMotionSourceCache;
}
