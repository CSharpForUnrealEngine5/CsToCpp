#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPUIBase.h")]
public partial class UVPUIBase : UEditorUtilityWidget {
// VPUIBase
	public AActor SelectedActor;
	public  void AppendVirtualProductionLog(string NewMessage) {}
	public  string GetLastVirtualProductionLogMessage() { return default; }
	public  void OnVirtualProductionLogUpdated() {}
	public  void OnSelectedActorChanged() {}
	public  void OnBookmarkCreated(UVPBookmark Created) {}
	public  void OnBookmarkDestroyed(UVPBookmark Destroyed) {}
	public  void OnBookmarkCleared(UVPBookmark Cleared) {}
	public  void OnMapChanged() {}
	public  void OnSelectedActorPropertyChanged() {}
	public  void OnFlightModeChanged(bool WasEntered) {}
	public TArray<string> VirtualProductionLog;
}
