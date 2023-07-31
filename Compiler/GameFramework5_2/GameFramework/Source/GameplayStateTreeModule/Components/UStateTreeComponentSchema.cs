#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>StateTree for Actors with StateTree component.</summary>
[CppInclude("Components/StateTreeComponentSchema.h")]
public partial class UStateTreeComponentSchema : UStateTreeSchema {
	///<summary>Actor class the StateTree is expected to run on. Allows to bind to specific Actor class&#39; properties.</summary>
	public UClass ContextActorClass;
	///<summary>ContextActorDataDesc</summary>
	public FStateTreeExternalDataDesc ContextActorDataDesc;
}
