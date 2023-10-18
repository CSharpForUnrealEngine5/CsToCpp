namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes the context data and allowed world conditions for a specific use case.</summary>
[CppInclude("WorldConditionSchema.h")]
public partial class UWorldConditionSchema : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>All context data descriptors.</summary>
	public TArray<FWorldConditionContextDataDesc> ContextDataDescs;
}
