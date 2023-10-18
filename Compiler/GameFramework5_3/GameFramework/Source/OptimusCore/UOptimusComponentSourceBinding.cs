namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusComponentSource.h")]
public partial class UOptimusComponentSourceBinding : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name to give the binding, to disambiguate it from other bindings of same component type.</summary>
	public FName BindingName;
	///<summary>The component type that this binding applies to</summary>
	public UClass ComponentType;
	///<summary>Component tags to automatically bind this component binding to.</summary>
	public TArray<FName> ComponentTags;
	///<summary>bIsPrimaryBinding</summary>
	public bool bIsPrimaryBinding;
}
