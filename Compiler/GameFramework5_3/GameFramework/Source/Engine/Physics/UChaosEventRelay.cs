namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An object managing events</summary>
[CppInclude("Physics/Experimental/ChaosEventRelay.h")]
public partial class UChaosEventRelay : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OnCollisionEvent</summary>
	public FCollisionEventSignature OnCollisionEvent;
	///<summary>OnBreakEvent</summary>
	public FBreakEventSignature OnBreakEvent;
	///<summary>OnRemovalEvent</summary>
	public FRemovalEventSignature OnRemovalEvent;
	///<summary>OnCrumblingEvent</summary>
	public FCrumblingEventSignature OnCrumblingEvent;
}
