namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AnimNotifies marked as BranchingPoints will create these markers on their Begin/End times.</summary>
[CppInclude("Animation/AnimMontage.h")]
public partial struct FBranchingPointMarker {
	public int NotifyIndex;
	public float TriggerTime;
	public EAnimNotifyEventType NotifyEventType;
}
