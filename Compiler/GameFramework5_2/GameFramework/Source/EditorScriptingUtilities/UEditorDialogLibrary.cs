#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class to create simple pop-up dialogs to notify the user of task completion,</summary>
[CppInclude("EditorDialogLibrary.h")]
public partial class UEditorDialogLibrary : UBlueprintFunctionLibrary {
	///<summary>Open a modal message box dialog with the given message. If running in &quot;-unattended&quot; mode it will immediately</summary>
	public static EAppReturnType ShowMessage(string Title,string Message,EAppMsgType MessageType,EAppReturnType DefaultValue/*=EAppReturnType.Type.No*/) { return default; }
	///<summary>Open a modal suppressable warning window, if suppressed will return the default value</summary>
	public static bool ShowSuppressableWarningDialog(string Title,string Message,string InIniSettingName,string InIniSettingFileNameOverride/*=TEXT("")*/,bool bDefaultValue/*=true*/) { return default; }
	///<summary>Open a modal message box dialog containing a details view for inspecting / modifying a UObject.</summary>
	public static bool ShowObjectDetailsView(string Title,UObject InOutObject,FEditorDialogLibraryObjectDetailsViewOptions Options/*=new FEditorDialogLibraryObjectDetailsViewOptions()*/) { return default; }
	///<summary>Open a modal message box dialog containing a details view for inspecting / modifying multiples UObjects.</summary>
	public static bool ShowObjectsDetailsView(string Title,TArray<UObject> InOutObjects,FEditorDialogLibraryObjectDetailsViewOptions Options/*=new FEditorDialogLibraryObjectDetailsViewOptions()*/) { return default; }
}
