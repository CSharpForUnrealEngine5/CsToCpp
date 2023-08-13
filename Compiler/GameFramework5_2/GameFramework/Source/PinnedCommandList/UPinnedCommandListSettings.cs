namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A persistent set of pinned commands</summary>
[CppInclude("PinnedCommandListSettings.h")]
public partial class UPinnedCommandListSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Persistent pinned command contexts</summary>
	public TArray<FPinnedCommandListContext> Contexts;
}
