#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimMontage.h")]
///<summary>AnimNotifies marked as BranchingPoints will create these markers on their Begin/End times.</summary>
public partial struct FBranchingPointMarker {
// BranchingPointMarker
	public int NotifyIndex;
	public float TriggerTime;
	public byte NotifyEventType;
}
