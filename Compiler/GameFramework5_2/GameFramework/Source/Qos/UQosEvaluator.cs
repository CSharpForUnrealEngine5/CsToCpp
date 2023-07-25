#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QosEvaluator.h")]
///<summary>Evaluates QoS metrics to determine the best datacenter under current conditions</summary>
public partial class UQosEvaluator : UObject {
// QosEvaluator
	public bool bInProgress;
	public bool bCancelOperation;
	public TArray<FDatacenterQosInstance> Datacenters;
}
