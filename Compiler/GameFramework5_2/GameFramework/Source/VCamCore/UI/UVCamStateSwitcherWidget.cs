#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A widget that has a set of states you can switch between using SetCurrentState.</summary>
[CppInclude("UI/Switcher/VCamStateSwitcherWidget.h")]
public partial class UVCamStateSwitcherWidget : UVCamWidget {
	///<summary>K2_SetCurrentState</summary>
	public  void K2_SetCurrentState(string NewState) {}
	///<summary>Switches to given state - if the state transition is valid, UpdateConnectionTargets will be called.</summary>
	public  bool SetCurrentState(string NewState,bool bForceUpdate/*=false*/,bool bReinitializeConnections/*=true*/) { return default; }
	///<summary>GetCurrentState</summary>
	public  string GetCurrentState() { return default; }
	///<summary>GetStates</summary>
	public  TArray<string> GetStates() { return default; }
	///<summary>GetStateInfo</summary>
	public  bool GetStateInfo(string State,FVCamWidgetConnectionState OutStateInfo) { return default; }
	///<summary>Executes when the state is about to be changed</summary>
	public FChangeConnectionStateEvent OnPreStateChanged;
	///<summary>Executes when after the state has been changed</summary>
	public FChangeConnectionStateEvent OnPostStateChanged;
	///<summary>The states</summary>
	public TMap<string,FVCamWidgetConnectionState> States;
	///<summary>CurrentState</summary>
	public string CurrentState;
}
