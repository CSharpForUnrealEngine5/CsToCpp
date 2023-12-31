namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UModeManagerInteractiveToolsContext extends UEditorInteractiveToolsContext with various functions for handling</summary>
[CppInclude("EdModeInteractiveToolsContext.h")]
public partial class UModeManagerInteractiveToolsContext : UEditorInteractiveToolsContext {
	public static UClass StaticClass() {return default;}
	///<summary>EdModeToolsContexts</summary>
	public TArray<UEdModeInteractiveToolsContext> EdModeToolsContexts;
}
