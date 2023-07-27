#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnAction.h")]
///<summary>Things to remember:</summary>
public partial class UDEPRECATED_PawnAction : UObject {
// PawnAction
	public UDEPRECATED_PawnAction ChildAction_DEPRECATED;
	public UDEPRECATED_PawnAction ParentAction_DEPRECATED;
	public UDEPRECATED_PawnActionsComponent OwnerComponent_DEPRECATED;
	public UObject Instigator;
	public UBrainComponent BrainComp;
	public bool bAllowNewSameClassInstance;
	public bool bReplaceActiveSameClassInstance;
	public bool bShouldPauseMovement;
	public bool bAlwaysNotifyOnFinished;
	public  byte GetActionPriority() { return default; }
	public static UDEPRECATED_PawnAction CreateActionInstance(UObject WorldContextObject,UClass ActionClass) { return default; }
	public  void Finish(byte WithResult) {}
}
