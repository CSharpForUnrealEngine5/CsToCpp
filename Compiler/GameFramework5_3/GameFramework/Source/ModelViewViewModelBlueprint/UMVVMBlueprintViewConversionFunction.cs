namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintViewConversionFunction.h")]
public partial class UMVVMBlueprintViewConversionFunction : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The conversion UFunction when simple or when it&#39;s complex.</summary>
	public FMemberReference FunctionReference;
	///<summary>The conversion K2Node the graph is generated for.</summary>
	public UClass FunctionNode;
	///<summary>Name of the generated graph if a wrapper is needed.</summary>
	public FName GraphName;
	///<summary>The pin that are modified and we saved data.</summary>
	public TArray<FMVVMBlueprintPin> SavedPins;
	///<summary>bWrapperGraphTransient</summary>
	public bool bWrapperGraphTransient;
	///<summary>CachedWrapperGraph</summary>
	public UEdGraph CachedWrapperGraph;
	///<summary>CachedWrapperNode</summary>
	public UK2Node CachedWrapperNode;
}
