#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTService.h")]
///<summary>Behavior Tree service nodes is designed to perform "background" tasks that update AI's knowledge.</summary>
public partial class UBTService : UBTAuxiliaryNode {
// BTService
	public float Interval;
	public float RandomDeviation;
	public bool bCallTickOnSearchStart;
	public bool bRestartTimerOnEachActivation;
}
