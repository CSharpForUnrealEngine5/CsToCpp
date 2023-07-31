#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SendEvent is used to notify the engine / editor of a change that happend within the Control Rig.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SendEvent.h")]
public partial struct FRigUnit_SendEvent {
	public ERigEvent Event;
	public FRigElementKey Item;
	public float OffsetInSeconds;
	public bool bEnable;
	public bool bOnlyDuringInteraction;
}
