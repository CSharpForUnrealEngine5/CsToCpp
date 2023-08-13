namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ComponentDelegateBinding.h")]
public partial class UComponentDelegateBinding : UDynamicBlueprintBinding {
	public static UClass StaticClass() {return default;}
	///<summary>ComponentDelegateBindings</summary>
	public TArray<FBlueprintComponentDelegateBinding> ComponentDelegateBindings;
}
