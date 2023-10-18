namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintView.h")]
public partial class UMVVMBlueprintViewSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Auto initialize the view sources when the Widget is constructed.</summary>
	public bool bInitializeSourcesOnConstruct;
	///<summary>Auto initialize the view bindings when the Widget is constructed.</summary>
	public bool bInitializeBindingsOnConstruct;
}
