#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFactories/ActorFactory.h")]
public partial class UActorFactory : UObject {
	///<summary>Name used as basis for &#39;New Actor&#39; menu.</summary>
	public string DisplayName;
	///<summary>Indicates how far up the menu item should be. The higher the number, the higher up the list.</summary>
	public int MenuPriority;
	///<summary>name of actor subclass this actorfactory creates - dynamically loaded.  Overrides NewActorClass.</summary>
	public string NewActorClassName;
	///<summary>AActor  subclass this ActorFactory creates.</summary>
	public UClass NewActorClass;
	///<summary>Whether to appear in the editor add actor quick menu</summary>
	public bool bShowInEditorQuickMenu;
	///<summary>bUseSurfaceOrientation</summary>
	public bool bUseSurfaceOrientation;
	///<summary>bUsePlacementExtent</summary>
	public bool bUsePlacementExtent;
	///<summary>Translation applied to the spawn position.</summary>
	public FVector SpawnPositionOffset;
}
