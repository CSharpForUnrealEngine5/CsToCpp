#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PinnedCommandListSettings.h")]
///<summary>A pinned command list context, allowing us to persist a set of pinned commands</summary>
public partial struct FPinnedCommandListContext {
// PinnedCommandListContext
	public string Name;
	public TArray<FPinnedCommandListCommand> Commands;
}
