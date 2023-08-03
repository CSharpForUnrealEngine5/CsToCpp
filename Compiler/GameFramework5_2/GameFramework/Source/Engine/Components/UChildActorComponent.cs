#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that spawns an Actor when registered, and destroys it when unregistered.</summary>
[CppInclude("Components/ChildActorComponent.h")]
public partial class UChildActorComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the class to use for the child actor.</summary>
	public  void SetChildActorClass(UClass InClass) {}
	///<summary>The class of Actor to spawn</summary>
	public UClass ChildActorClass;
	///<summary>The actor that we spawned and own</summary>
	public AActor ChildActor;
	///<summary>Property to point to the template child actor for details panel purposes</summary>
	public AActor ChildActorTemplate;
	///<summary>Indicates how this component will be visualized for editing in a tree view. Users can change this setting per instance via the context menu in the Blueprint/SCS editor.</summary>
	public EChildActorComponentTreeViewVisualizationMode EditorTreeViewVisualizationMode;
	///<summary>OnChildActorDestroyed</summary>
	public  void OnChildActorDestroyed(AActor DestroyedActor) {}
}
