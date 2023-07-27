#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorDialogLibrary.h")]
///<summary>Utility class to create simple pop-up dialogs to notify the user of task completion,</summary>
public partial class UEditorDialogLibrary : UBlueprintFunctionLibrary {
// EditorDialogLibrary
	public static EAppReturnType ShowMessage(string Title,string Message,EAppMsgType MessageType,EAppReturnType DefaultValue/*=EAppReturnType.Type.No*/) { return default; }
	public static bool ShowSuppressableWarningDialog(string Title,string Message,string InIniSettingName,string InIniSettingFileNameOverride/*=TEXT("")*/,bool bDefaultValue/*=true*/) { return default; }
	public static bool ShowObjectDetailsView(string Title,UObject InOutObject,FEditorDialogLibraryObjectDetailsViewOptions Options/*=new FEditorDialogLibraryObjectDetailsViewOptions()*/) { return default; }
	public static bool ShowObjectsDetailsView(string Title,TArray<UObject> InOutObjects,FEditorDialogLibraryObjectDetailsViewOptions Options/*=new FEditorDialogLibraryObjectDetailsViewOptions()*/) { return default; }
}
