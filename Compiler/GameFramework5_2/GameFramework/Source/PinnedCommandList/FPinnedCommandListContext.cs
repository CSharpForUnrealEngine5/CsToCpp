namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A pinned command list context, allowing us to persist a set of pinned commands</summary>
[CppInclude("PinnedCommandListSettings.h")]
public partial struct FPinnedCommandListContext {
	public string Name;
	public TArray<FPinnedCommandListCommand> Commands;
}
