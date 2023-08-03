#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluates QoS metrics to determine the best datacenter under current conditions</summary>
[CppInclude("QosEvaluator.h")]
public partial class UQosEvaluator : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A QoS operation is in progress</summary>
	public bool bInProgress;
	///<summary>Should cancel occur at the next available opportunity</summary>
	public bool bCancelOperation;
	///<summary>Array of datacenters currently being evaluated</summary>
	public TArray<FDatacenterQosInstance> Datacenters;
}
