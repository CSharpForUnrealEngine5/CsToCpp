#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SendEvent.h")]
///<summary>SendEvent is used to notify the engine / editor of a change that happend within the Control Rig.</summary>
public partial struct FRigUnit_SendEvent {
// RigUnit_SendEvent
	public ERigEvent Event;
	public FRigElementKey Item;
	public float OffsetInSeconds;
	public bool bEnable;
	public bool bOnlyDuringInteraction;
}
