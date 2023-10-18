namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This component acts as the Driver for the FMockRootMotionSimulation</summary>
[CppInclude("MockRootMotionComponent.h")]
public partial class UMockRootMotionComponent : UBaseMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CreateRootMotionSource</summary>
	public UMockRootMotionSource CreateRootMotionSource(UClass Source) { return default; }
	///<summary>Input_PlayRootMotionSource</summary>
	public void Input_PlayRootMotionSource(UMockRootMotionSource Source) {}
	///<summary>Input_PlayRootMotionSourceByClass</summary>
	public void Input_PlayRootMotionSourceByClass(UClass Source) {}
	///<summary>Callable by authority. Plays &quot;out of band&quot; animation: e.g, directly sets the RootMotionSourceID on the sync state, rather than the pending InputCmd.</summary>
	public void PlayRootMotionSource(UMockRootMotionSource Source) {}
	///<summary>PlayRootMotionSourceByClass</summary>
	public void PlayRootMotionSourceByClass(UClass Source) {}
	///<summary>RootMotionSourceCache</summary>
	public FRootMotionSourceCache RootMotionSourceCache;
}
