namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class to allow to copy bindings into clipboard.</summary>
[CppInclude("StateTreeViewModel.h")]
public partial class UStateTreeClipboardBindings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Bindings</summary>
	public TArray<FStateTreePropertyPathBinding> Bindings;
}
