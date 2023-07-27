#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ShotgridEngine.h")]
///<summary>Wrapper for the Python Shotgrid Engine</summary>
public partial class UShotgridEngine : UObject {
// ShotgridEngine
	public static UShotgridEngine GetInstance() { return default; }
	public  void OnEngineInitialized() {}
	public  TArray<FShotgridMenuItem> GetShotgridMenuItems() { return default; }
	public  void ExecuteCommand(string CommandName) {}
	public  void Shutdown() {}
	public  TArray<UObject> GetReferencedAssets(AActor Actor) { return default; }
	public static string GetShotgridWorkDir() { return default; }
	public TArray<FAssetData> SelectedAssets;
	public TArray<AActor> SelectedActors;
	public  TArray<AActor> GetSelectedActors() { return default; }
}
