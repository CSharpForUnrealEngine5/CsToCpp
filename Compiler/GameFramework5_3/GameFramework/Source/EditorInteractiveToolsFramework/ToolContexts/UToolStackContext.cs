namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Context needed to support tool stacks, add this to your ContextObjectStore if you want to use tool stacks</summary>
[CppInclude("ToolContexts/ToolStackContext.h")]
public partial class UToolStackContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>EdMode owning the tools referenced by this stack</summary>
	public TWeakObjectPtr<UEdMode> EdMode;
	///<summary>Current set of named ToolStacks</summary>
	public TMap<string,FInteractiveToolStack> ToolStacks;
}
