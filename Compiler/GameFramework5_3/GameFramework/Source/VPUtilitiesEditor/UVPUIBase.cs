namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPUIBase.h")]
public partial class UVPUIBase : UEditorUtilityWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SelectedActor</summary>
	public AActor SelectedActor;
	///<summary>AppendVirtualProductionLog</summary>
	public void AppendVirtualProductionLog(string NewMessage) {}
	///<summary>Log</summary>
	public string GetLastVirtualProductionLogMessage() { return default; }
	///<summary>OnVirtualProductionLogUpdated</summary>
	public void OnVirtualProductionLogUpdated() {}
	///<summary>Bookmarks</summary>
	public void OnSelectedActorChanged() {}
	///<summary>OnBookmarkCreated</summary>
	public void OnBookmarkCreated(UVPBookmark Created) {}
	///<summary>OnBookmarkDestroyed</summary>
	public void OnBookmarkDestroyed(UVPBookmark Destroyed) {}
	///<summary>OnBookmarkCleared</summary>
	public void OnBookmarkCleared(UVPBookmark Cleared) {}
	///<summary>OnMapChanged</summary>
	public void OnMapChanged() {}
	///<summary>UI subscribes to this to know when the property window for SelectedActor should be refreshed</summary>
	public void OnSelectedActorPropertyChanged() {}
	///<summary>Fires whenever flight mode changes. True if enabled, false is disengaged</summary>
	public void OnFlightModeChanged(bool WasEntered) {}
	///<summary>VirtualProductionLog</summary>
	public TArray<string> VirtualProductionLog;
}
