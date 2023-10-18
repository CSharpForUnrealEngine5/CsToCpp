namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for Ethernet barrier based media synchronization policies.</summary>
[CppInclude("Synchronization/DisplayClusterMediaOutputSynchronizationPolicyEthernetBarrierBase.h")]
public partial class UDisplayClusterMediaOutputSynchronizationPolicyEthernetBarrierBase : UDisplayClusterMediaOutputSynchronizationPolicy {
	public static UClass StaticClass() {return default;}
	///<summary>Barrier timeout (ms)</summary>
	public int BarrierTimeoutMs;
}
