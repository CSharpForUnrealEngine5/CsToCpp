#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavLinkCustomComponent.h")]
///<summary>Encapsulates NavLinkCustomInterface interface, can be used with Actors not relevant for navigation</summary>
public partial class UNavLinkCustomComponent : UNavRelevantComponent {
// NavLinkCustomComponent
	public uint NavLinkUserId;
	public UClass EnabledAreaClass;
	public UClass DisabledAreaClass;
	public FNavAgentSelector SupportedAgents;
	public FVector LinkRelativeStart;
	public FVector LinkRelativeEnd;
	public byte LinkDirection;
	public bool bLinkEnabled;
	public bool bNotifyWhenEnabled;
	public bool bNotifyWhenDisabled;
	public bool bCreateBoxObstacle;
	public FVector ObstacleOffset;
	public FVector ObstacleExtent;
	public UClass ObstacleAreaClass;
	public float BroadcastRadius;
	public float BroadcastInterval;
	public byte BroadcastChannel;
}
