#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolContexts/ToolStackContext.h")]
///<summary>Context needed to support tool stacks, add this to your ContextObjectStore if you want to use tool stacks</summary>
public partial class UToolStackContext : UObject {
// ToolStackContext
	public TWeakObjectPtr<UEdMode> EdMode;
	public TMap<string,FInteractiveToolStack> ToolStacks;
}
