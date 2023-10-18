namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug actor to visually test zone graph.</summary>
[CppInclude("ZoneGraphTestingActor.h")]
public partial class AZoneGraphTestingActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Allow custom tests to be notified when lane location is updated.</summary>
	public void EnableCustomTests() {}
	///<summary>Prevent custom tests to be notified when lane location is updated. Currently active tests will get notified with an invalid location.</summary>
	public void DisableCustomTests() {}
	///<summary>DebugComp</summary>
	public UZoneGraphTestingComponent DebugComp;
}
