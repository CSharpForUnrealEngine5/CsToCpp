#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug actor to visually test zone graph.</summary>
[CppInclude("MassNavigationTestingActor.h")]
public partial class AMassNavigationTestingActor : AActor {
	///<summary>PinLane</summary>
	public  void PinLane() {}
	///<summary>ClearPinnedLane</summary>
	public  void ClearPinnedLane() {}
	///<summary>DebugComp</summary>
	public UMassNavigationTestingComponent DebugComp;
}
