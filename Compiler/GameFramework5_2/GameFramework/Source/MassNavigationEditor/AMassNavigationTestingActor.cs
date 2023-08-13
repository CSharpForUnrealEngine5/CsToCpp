namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug actor to visually test zone graph.</summary>
[CppInclude("MassNavigationTestingActor.h")]
public partial class AMassNavigationTestingActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>PinLane</summary>
	public void PinLane() {}
	///<summary>ClearPinnedLane</summary>
	public void ClearPinnedLane() {}
	///<summary>DebugComp</summary>
	public UMassNavigationTestingComponent DebugComp;
}
