#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes the context data and allowed world conditions for a specific use case.</summary>
[CppInclude("WorldConditionSchema.h")]
public partial class UWorldConditionSchema : UObject {
	///<summary>All context data descriptors.</summary>
	public TArray<FWorldConditionContextDataDesc> ContextDataDescs;
}
