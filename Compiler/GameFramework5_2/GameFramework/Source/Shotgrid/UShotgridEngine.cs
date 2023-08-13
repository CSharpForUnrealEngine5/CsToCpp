namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper for the Python Shotgrid Engine</summary>
[CppInclude("ShotgridEngine.h")]
public partial class UShotgridEngine : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the instance of the Python Shotgrid Engine</summary>
	public static UShotgridEngine GetInstance() { return default; }
	///<summary>Callback for when the Python Shotgrid Engine has finished initialization</summary>
	public void OnEngineInitialized() {}
	///<summary>Get the available Shotgrid commands from the Python Shotgrid Engine</summary>
	public TArray<FShotgridMenuItem> GetShotgridMenuItems() { return default; }
	///<summary>Execute a Shotgrid command by name in the Python Shotgrid Engine</summary>
	public void ExecuteCommand(string CommandName) {}
	///<summary>Shut down the Python Shotgrid Engine</summary>
	public void Shutdown() {}
	///<summary>Get the assets that are referenced by the given Actor</summary>
	public TArray<UObject> GetReferencedAssets(AActor Actor) { return default; }
	///<summary>Get the root path for the Shotgrid work area</summary>
	public static string GetShotgridWorkDir() { return default; }
	///<summary>Selected assets to be used for Shotgrid commands</summary>
	public TArray<FAssetData> SelectedAssets;
	///<summary>SelectedActors</summary>
	public TArray<AActor> SelectedActors;
	///<summary>Selected actors to be used for Shotgrid commands</summary>
	public TArray<AActor> GetSelectedActors() { return default; }
}
