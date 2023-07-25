#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComponentVisualizer.h")]
///<summary>Describes a chain of properties from the parent actor of a given component, to the component itself.</summary>
public partial struct FComponentPropertyPath {
// ComponentPropertyPath
	public TWeakObjectPtr<AActor> ParentOwningActor;
	public TWeakObjectPtr<UActorComponent> LastResortComponentPtr;
	public TArray<FPropertyNameAndIndex> PropertyChain;
}
