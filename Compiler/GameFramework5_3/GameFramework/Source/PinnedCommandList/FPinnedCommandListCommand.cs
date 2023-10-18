namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A command and its context</summary>
[CppInclude("PinnedCommandListSettings.h")]
public partial struct FPinnedCommandListCommand {
	public FName Name;
	public FName Binding;
	public EPinnedCommandListType Type;
}
