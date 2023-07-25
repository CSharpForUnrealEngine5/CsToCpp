#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ShotgridEngine.h")]
///<summary>Wrapper for the Python Shotgrid Engine</summary>
public partial class UShotgridEngine : UObject {
// ShotgridEngine
	public UObject GetInstance() { return default; }
	public void OnEngineInitialized() {}
	public TArray<FShotgridMenuItem> GetShotgridMenuItems() { return default; }
	public void ExecuteCommand(string CommandName) {}
	public void Shutdown() {}
	public TArray<UObject> GetReferencedAssets(UObject Actor) { return default; }
	public string GetShotgridWorkDir() { return default; }
	public TArray<FAssetData> SelectedAssets;
	public TArray<AActor> SelectedActors;
	public TArray<UObject> GetSelectedActors() { return default; }
}
