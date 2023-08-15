namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A widget that has a set of states you can switch between using SetCurrentState.</summary>
[CppInclude("UI/Switcher/VCamStateSwitcherWidget.h")]
public partial class UVCamStateSwitcherWidget : UVCamWidget {
	public static UClass StaticClass() {return default;}
	///<summary>K2_SetCurrentState</summary>
	public void K2_SetCurrentState(FName NewState) {}
	///<summary>Switches to given state - if the state transition is valid, UpdateConnectionTargets will be called.</summary>
	public bool SetCurrentState(FName NewState,bool bForceUpdate/*=false*/,bool bReinitializeConnections/*=true*/) { return default; }
	///<summary>GetCurrentState</summary>
	public FName GetCurrentState() { return default; }
	///<summary>GetStates</summary>
	public TArray<FName> GetStates() { return default; }
	///<summary>GetStateInfo</summary>
	public bool GetStateInfo(FName State,FVCamWidgetConnectionState OutStateInfo) { return default; }
	///<summary>Executes when the state is about to be changed</summary>
	public FChangeConnectionStateEvent OnPreStateChanged;
	///<summary>Executes when after the state has been changed</summary>
	public FChangeConnectionStateEvent OnPostStateChanged;
	///<summary>The states</summary>
	public TMap<FName,FVCamWidgetConnectionState> States;
	///<summary>CurrentState</summary>
	public FName CurrentState;
}
