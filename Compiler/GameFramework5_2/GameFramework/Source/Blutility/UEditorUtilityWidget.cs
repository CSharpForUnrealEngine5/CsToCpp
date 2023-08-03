#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityWidget.h")]
public partial class UEditorUtilityWidget : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The default action called when the widget is invoked if bAutoRunDefaultAction=true (it is never called otherwise)</summary>
	public  void Run() {}
	///<summary>The display name for tabs spawned with this widget</summary>
	public string TabDisplayName;
	///<summary>HelpText</summary>
	public string HelpText;
	///<summary>Should this widget always be re-added to the windows menu once it&#39;s opened</summary>
	public bool bAlwaysReregisterWithWindowsMenu;
	///<summary>Should this blueprint automatically run OnDefaultActionClicked, or should it open up a details panel to edit properties and/or offer multiple buttons</summary>
	public bool bAutoRunDefaultAction;
}
