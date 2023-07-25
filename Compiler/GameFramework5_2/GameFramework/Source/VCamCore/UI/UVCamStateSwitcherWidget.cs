#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/Switcher/VCamStateSwitcherWidget.h")]
///<summary>A widget that has a set of states you can switch between using SetCurrentState.</summary>
public partial class UVCamStateSwitcherWidget : UVCamWidget {
// VCamStateSwitcherWidget
	public void K2_SetCurrentState(string NewState) {}
	public bool SetCurrentState(string NewState,bool bForceUpdate/*=false*/,bool bReinitializeConnections/*=true*/) { return default; }
	public string GetCurrentState() { return default; }
	public TArray<string> GetStates() { return default; }
	public bool GetStateInfo(string State,FVCamWidgetConnectionState OutStateInfo) { return default; }
	public FChangeConnectionStateEvent OnPreStateChanged;
	public FChangeConnectionStateEvent OnPostStateChanged;
	public TMap<string,FVCamWidgetConnectionState> States;
	public string CurrentState;
}
