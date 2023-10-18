namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UEdModeInteractiveToolsContext is an UEditorInteractiveToolsContext intended for use/lifetime in the context of a UEdMode.</summary>
[CppInclude("EdModeInteractiveToolsContext.h")]
public partial class UEdModeInteractiveToolsContext : UEditorInteractiveToolsContext {
	public static UClass StaticClass() {return default;}
	///<summary>ParentModeManagerToolsContext</summary>
	public UModeManagerInteractiveToolsContext ParentModeManagerToolsContext;
}
