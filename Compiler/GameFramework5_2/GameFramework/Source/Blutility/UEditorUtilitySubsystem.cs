namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilitySubsystem.h")]
public partial class UEditorUtilitySubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>LoadedUIs</summary>
	public TArray<FSoftObjectPath> LoadedUIs;
	///<summary>StartupObjects</summary>
	public TArray<FSoftObjectPath> StartupObjects;
	///<summary>Allow startup object to be garbage collected</summary>
	public void ReleaseInstanceOfAsset(UObject Asset) {}
	///<summary>TryRun</summary>
	public bool TryRun(UObject Asset) { return default; }
	///<summary>CanRun</summary>
	public bool CanRun(UObject Asset) { return default; }
	///<summary>SpawnAndRegisterTabAndGetID</summary>
	public UEditorUtilityWidget SpawnAndRegisterTabAndGetID(UEditorUtilityWidgetBlueprint InBlueprint,FName NewTabID) { return default; }
	///<summary>SpawnAndRegisterTab</summary>
	public UEditorUtilityWidget SpawnAndRegisterTab(UEditorUtilityWidgetBlueprint InBlueprint) { return default; }
	///<summary>Unlike SpawnAndRegisterTabAndGetID allows spawn tab while providing TabID from Python scripts or BP</summary>
	public UEditorUtilityWidget SpawnAndRegisterTabWithId(UEditorUtilityWidgetBlueprint InBlueprint,FName InTabID) { return default; }
	///<summary>RegisterTabAndGetID</summary>
	public void RegisterTabAndGetID(UEditorUtilityWidgetBlueprint InBlueprint,FName NewTabID) {}
	///<summary>Given an ID for a tab, try to find a tab spawner that matches, and then spawn a tab. Returns true if it was able to find a matching tab spawner</summary>
	public bool SpawnRegisteredTabByID(FName NewTabID) { return default; }
	///<summary>Given an ID for a tab, try to find an existing tab. Returns true if it found a tab.</summary>
	public bool DoesTabExist(FName NewTabID) { return default; }
	///<summary>Given an ID for a tab, try to find and close an existing tab. Returns true if it found a tab to close.</summary>
	public bool CloseTabByID(FName NewTabID) { return default; }
	///<summary>Given an ID for a tab, try to close and unregister a tab that was registered through this subsystem</summary>
	public bool UnregisterTabByID(FName TabID) { return default; }
	///<summary>Given an editor utility widget blueprint, get the widget it creates. This will return a null pointer if the widget is not currently in a tab.</summary>
	public UEditorUtilityWidget FindUtilityWidgetFromBlueprint(UEditorUtilityWidgetBlueprint InBlueprint) { return default; }
	///<summary>RegisterAndExecuteTask</summary>
	public void RegisterAndExecuteTask(UEditorUtilityTask NewTask,UEditorUtilityTask OptionalParentTask/*=nullptr*/) {}
	///<summary>Expose Begin PIE to blueprints.</summary>
	public FOnEditorUtilityPIEEvent OnBeginPIE;
	///<summary>Expose End PIE to blueprints.</summary>
	public FOnEditorUtilityPIEEvent OnEndPIE;
	///<summary>Instance</summary>
	public TMap<UObject,UObject> ObjectInstances;
	///<summary>ActiveTaskStack</summary>
	public TArray<UEditorUtilityTask> ActiveTaskStack;
	///<summary>List of objects that are being kept alive by this subsystem.</summary>
	public TSet<UObject> ReferencedObjects;
}
