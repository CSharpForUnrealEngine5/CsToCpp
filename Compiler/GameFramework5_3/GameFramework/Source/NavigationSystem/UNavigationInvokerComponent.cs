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
	///<summary>Experimental invocation priority. It will modify the order in which invoked tiles are being built if SortPendingTilesMethod is set to SortByPriority.</summary>
	public ENavigationInvokerPriority Priority;
}
