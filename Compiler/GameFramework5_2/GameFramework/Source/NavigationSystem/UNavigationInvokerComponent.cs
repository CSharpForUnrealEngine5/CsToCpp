#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavigationInvokerComponent.h")]
public partial class UNavigationInvokerComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>TileGenerationRadius</summary>
	public float TileGenerationRadius;
	///<summary>TileRemovalRadius</summary>
	public float TileRemovalRadius;
	///<summary>restrict navigation generation to specific agents</summary>
	public FNavAgentSelector SupportedAgents;
}
