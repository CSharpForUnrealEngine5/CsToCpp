#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilitySubsystem.h")]
public partial class UEditorUtilitySubsystem : UEditorSubsystem {
// EditorUtilitySubsystem
	public TArray<FSoftObjectPath> LoadedUIs;
	public TArray<FSoftObjectPath> StartupObjects;
	public  void ReleaseInstanceOfAsset(UObject Asset) {}
	public  bool TryRun(UObject Asset) { return default; }
	public  bool CanRun(UObject Asset) { return default; }
	public  UEditorUtilityWidget SpawnAndRegisterTabAndGetID(UEditorUtilityWidgetBlueprint InBlueprint,string NewTabID) { return default; }
	public  UEditorUtilityWidget SpawnAndRegisterTab(UEditorUtilityWidgetBlueprint InBlueprint) { return default; }
	public  UEditorUtilityWidget SpawnAndRegisterTabWithId(UEditorUtilityWidgetBlueprint InBlueprint,string InTabID) { return default; }
	public  void RegisterTabAndGetID(UEditorUtilityWidgetBlueprint InBlueprint,string NewTabID) {}
	public  bool SpawnRegisteredTabByID(string NewTabID) { return default; }
	public  bool DoesTabExist(string NewTabID) { return default; }
	public  bool CloseTabByID(string NewTabID) { return default; }
	public  bool UnregisterTabByID(string TabID) { return default; }
	public  UEditorUtilityWidget FindUtilityWidgetFromBlueprint(UEditorUtilityWidgetBlueprint InBlueprint) { return default; }
	public  void RegisterAndExecuteTask(UEditorUtilityTask NewTask,UEditorUtilityTask OptionalParentTask/*=nullptr*/) {}
	public FOnEditorUtilityPIEEvent OnBeginPIE;
	public FOnEditorUtilityPIEEvent OnEndPIE;
	public TMap<UObject,UObject> ObjectInstances;
	public TArray<UEditorUtilityTask> ActiveTaskStack;
	public TSet<UObject> ReferencedObjects;
}
