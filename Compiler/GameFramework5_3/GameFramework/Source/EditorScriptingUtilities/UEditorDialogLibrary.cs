namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class to create simple pop-up dialogs to notify the user of task completion,</summary>
[CppInclude("EditorDialogLibrary.h")]
public partial class UEditorDialogLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Open a modal message box dialog with the given message. If running in &quot;-unattended&quot; mode it will immediately</summary>
	public static EAppReturnType ShowMessage(FText Title,FText Message,EAppMsgType MessageType,EAppReturnType DefaultValue/*=EAppReturnType.Type.No*/,EAppMsgCategory MessageCategory/*=EAppMsgCategory.Warning*/) { return default; }
	///<summary>Open a modal suppressable warning window, if suppressed will return the default value</summary>
	public static bool ShowSuppressableWarningDialog(FText Title,FText Message,string InIniSettingName,string InIniSettingFileNameOverride/*=TEXT("")*/,bool bDefaultValue/*=true*/) { return default; }
	///<summary>Open a modal message box dialog containing a details view for inspecting / modifying a UObject.</summary>
	public static bool ShowObjectDetailsView(FText Title,UObject InOutObject,FEditorDialogLibraryObjectDetailsViewOptions Options/*=new FEditorDialogLibraryObjectDetailsViewOptions()*/) { return default; }
	///<summary>Open a modal message box dialog containing a details view for inspecting / modifying multiples UObjects.</summary>
	public static bool ShowObjectsDetailsView(FText Title,TArray<UObject> InOutObjects,FEditorDialogLibraryObjectDetailsViewOptions Options/*=new FEditorDialogLibraryObjectDetailsViewOptions()*/) { return default; }
}
