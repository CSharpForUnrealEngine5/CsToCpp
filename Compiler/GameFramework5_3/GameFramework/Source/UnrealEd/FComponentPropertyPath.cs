namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a chain of properties from the parent actor of a given component, to the component itself.</summary>
[CppInclude("ComponentVisualizer.h")]
public partial struct FComponentPropertyPath {
	public TWeakObjectPtr<AActor> ParentOwningActor;
	public TWeakObjectPtr<UActorComponent> LastResortComponentPtr;
	public TArray<FPropertyNameAndIndex> PropertyChain;
}
