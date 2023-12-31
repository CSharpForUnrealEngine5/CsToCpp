namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityWidgetBlueprint.h")]
public partial class UEditorUtilityWidgetBlueprint : UWidgetBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>Should the widget be enabled when running PIE</summary>
	public bool bIsEnabledInPIE;
	///<summary>Should the widget be enabled when debugging BP</summary>
	public bool bIsEnabledInDebugging;
	///<summary>CreatedUMGWidget</summary>
	public UEditorUtilityWidget CreatedUMGWidget;
}
