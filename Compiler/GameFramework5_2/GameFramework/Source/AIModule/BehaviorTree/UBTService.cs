namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Behavior Tree service nodes is designed to perform &quot;background&quot; tasks that update AI&#39;s knowledge.</summary>
[CppInclude("BehaviorTree/BTService.h")]
public partial class UBTService : UBTAuxiliaryNode {
	public static UClass StaticClass() {return default;}
	///<summary>defines time span between subsequent ticks of the service</summary>
	public float Interval;
	///<summary>adds random range to service&#39;s Interval</summary>
	public float RandomDeviation;
	///<summary>call Tick event when task search enters this node (SearchStart will be called as well)</summary>
	public bool bCallTickOnSearchStart;
	///<summary>if set, next tick time will be always reset to service&#39;s interval when node is activated</summary>
	public bool bRestartTimerOnEachActivation;
}
