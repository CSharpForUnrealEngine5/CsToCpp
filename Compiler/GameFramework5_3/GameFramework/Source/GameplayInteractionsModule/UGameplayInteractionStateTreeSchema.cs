namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayInteractionStateTreeSchema.h")]
public partial class UGameplayInteractionStateTreeSchema : UStateTreeSchema {
	public static UClass StaticClass() {return default;}
	///<summary>Actor class the StateTree is expected to run on. Allows to bind to specific Actor class&#39; properties.</summary>
	public UClass ContextActorClass;
	///<summary>Actor class of the SmartObject the StateTree is expected to run with. Allows to bind to specific Actor class&#39; properties.</summary>
	public UClass SmartObjectActorClass;
	///<summary>List of named external data required by schema and provided to the state tree through the execution context.</summary>
	public TArray<FStateTreeExternalDataDesc> ContextDataDescs;
}
