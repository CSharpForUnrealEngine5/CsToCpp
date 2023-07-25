#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/NavLinkProxy.h")]
///<summary>ANavLinkProxy connects areas of Navmesh that don't have a direct navigation path.</summary>
public partial class ANavLinkProxy : AActor {
// NavLinkProxy
	public TArray<FNavigationLink> PointLinks;
	public TArray<FNavigationSegmentLink> SegmentLinks;
	public UNavLinkCustomComponent SmartLinkComp;
	public bool bSmartLinkIsRelevant;
	public UNavLinkRenderingComponent EdRenderComp;
	public UBillboardComponent SpriteComponent;
	public void ReceiveSmartLinkReached(UObject Agent,FVector Destination) {}
	public void ResumePathFollowing(UObject Agent) {}
	public bool IsSmartLinkEnabled() { return default; }
	public void SetSmartLinkEnabled(bool bEnabled) {}
	public bool HasMovingAgents() { return default; }
	public void CopyEndPointsFromSimpleLinkToSmartLink() {}
	public FSmartLinkReachedSignature OnSmartLinkReached;
}
