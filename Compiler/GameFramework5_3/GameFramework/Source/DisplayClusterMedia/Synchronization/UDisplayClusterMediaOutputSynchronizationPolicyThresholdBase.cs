namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for threshold based media synchronization policies.</summary>
[CppInclude("Synchronization/DisplayClusterMediaOutputSynchronizationPolicyThresholdBase.h")]
public partial class UDisplayClusterMediaOutputSynchronizationPolicyThresholdBase : UDisplayClusterMediaOutputSynchronizationPolicyEthernetBarrierBase {
	public static UClass StaticClass() {return default;}
	///<summary>Synchronization margin (ms)</summary>
	public int MarginMs;
}
