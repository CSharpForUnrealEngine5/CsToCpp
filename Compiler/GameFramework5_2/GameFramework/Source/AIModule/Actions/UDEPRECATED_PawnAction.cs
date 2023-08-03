#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Things to remember:</summary>
[CppInclude("Actions/PawnAction.h")]
public partial class UDEPRECATED_PawnAction : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Current child node executing on top of this Action</summary>
	public UDEPRECATED_PawnAction ChildAction_DEPRECATED;
	///<summary>ParentAction_DEPRECATED</summary>
	public UDEPRECATED_PawnAction ParentAction_DEPRECATED;
	///<summary>Extra reference to the component this action is being governed by</summary>
	public UDEPRECATED_PawnActionsComponent OwnerComponent_DEPRECATED;
	///<summary>indicates an object that caused this action. Used for mass removal of actions</summary>
	public UObject Instigator;
	///<summary>@Note: THIS IS HERE _ONLY_ BECAUSE OF THE WAY AI MESSAGING IS CURRENTLY IMPLEMENTED. WILL GO AWAY!</summary>
	public UBrainComponent BrainComp;
	///<summary>if this is FALSE and we&#39;re trying to push a new instance of a given class,</summary>
	public bool bAllowNewSameClassInstance;
	///<summary>if this is TRUE, when we try to push a new instance of an action who has the</summary>
	public bool bReplaceActiveSameClassInstance;
	///<summary>this is a temporary solution to allow having movement action running in background while there&#39;s</summary>
	public bool bShouldPauseMovement;
	///<summary>if set, action will call OnFinished notify even when ending as FailedToStart</summary>
	public bool bAlwaysNotifyOnFinished;
	///<summary>Blueprint interface</summary>
	public  EAIRequestPriority GetActionPriority() { return default; }
	///<summary>CreateActionInstance</summary>
	public static UDEPRECATED_PawnAction CreateActionInstance(UObject WorldContextObject,UClass ActionClass) { return default; }
	///<summary>Finish</summary>
	public  void Finish(EPawnActionResult WithResult) {}
}
