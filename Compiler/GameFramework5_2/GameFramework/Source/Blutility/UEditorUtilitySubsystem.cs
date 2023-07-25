#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilitySubsystem.h")]
public partial class UEditorUtilitySubsystem : UEditorSubsystem {
// EditorUtilitySubsystem
	public TArray<FSoftObjectPath> LoadedUIs;
	public TArray<FSoftObjectPath> StartupObjects;
	public void ReleaseInstanceOfAsset(UObject Asset) {}
	public bool TryRun(UObject Asset) { return default; }
	public bool CanRun(UObject Asset) { return default; }
	public UObject SpawnAndRegisterTabAndGetID(UObject InBlueprint,string NewTabID) { return default; }
	public UObject SpawnAndRegisterTab(UObject InBlueprint) { return default; }
	public UObject SpawnAndRegisterTabWithId(UObject InBlueprint,string InTabID) { return default; }
	public void RegisterTabAndGetID(UObject InBlueprint,string NewTabID) {}
	public bool SpawnRegisteredTabByID(string NewTabID) { return default; }
	public bool DoesTabExist(string NewTabID) { return default; }
	public bool CloseTabByID(string NewTabID) { return default; }
	public bool UnregisterTabByID(string TabID) { return default; }
	public UObject FindUtilityWidgetFromBlueprint(UObject InBlueprint) { return default; }
	public void RegisterAndExecuteTask(UObject NewTask,UObject OptionalParentTask/*=nullptr*/) {}
	public FOnEditorUtilityPIEEvent OnBeginPIE;
	public FOnEditorUtilityPIEEvent OnEndPIE;
	public TMap<UObject,UObject> ObjectInstances;
	public TArray<UEditorUtilityTask> ActiveTaskStack;
	public TSet<UObject> ReferencedObjects;
}
