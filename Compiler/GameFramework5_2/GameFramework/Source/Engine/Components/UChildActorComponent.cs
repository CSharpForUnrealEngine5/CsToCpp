#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ChildActorComponent.h")]
///<summary>A component that spawns an Actor when registered, and destroys it when unregistered.</summary>
public partial class UChildActorComponent : USceneComponent {
// ChildActorComponent
	public  void SetChildActorClass(UClass InClass) {}
	public UClass ChildActorClass;
	public AActor ChildActor;
	public AActor ChildActorTemplate;
	public EChildActorComponentTreeViewVisualizationMode EditorTreeViewVisualizationMode;
	public  void OnChildActorDestroyed(AActor DestroyedActor) {}
}
