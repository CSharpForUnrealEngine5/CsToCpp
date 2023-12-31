namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A container class that owns component source bindings. This is used to ensure we don&#39;t end up</summary>
[CppInclude("OptimusDeformer.h")]
public partial class UOptimusComponentSourceBindingContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Bindings</summary>
	public TArray<UOptimusComponentSourceBinding> Bindings;
}
