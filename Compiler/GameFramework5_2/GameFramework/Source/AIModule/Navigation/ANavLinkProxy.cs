#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ANavLinkProxy connects areas of Navmesh that don&#39;t have a direct navigation path.</summary>
[CppInclude("Navigation/NavLinkProxy.h")]
public partial class ANavLinkProxy : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Navigation links (point to point) added to navigation data</summary>
	public TArray<FNavigationLink> PointLinks;
	///<summary>Navigation links (segment to segment) added to navigation data</summary>
	public TArray<FNavigationSegmentLink> SegmentLinks;
	///<summary>Smart link: can affect path following</summary>
	public UNavLinkCustomComponent SmartLinkComp;
	///<summary>Smart link: toggle relevancy</summary>
	public bool bSmartLinkIsRelevant;
	///<summary>Editor Preview</summary>
	public UNavLinkRenderingComponent EdRenderComp;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>called when agent reaches smart link during path following, use ResumePathFollowing() to give control back</summary>
	public  void ReceiveSmartLinkReached(AActor Agent,FVector Destination) {}
	///<summary>resume normal path following</summary>
	public  void ResumePathFollowing(AActor Agent) {}
	///<summary>check if smart link is enabled</summary>
	public  bool IsSmartLinkEnabled() { return default; }
	///<summary>change state of smart link</summary>
	public  void SetSmartLinkEnabled(bool bEnabled) {}
	///<summary>check if any agent is moving through smart link right now</summary>
	public  bool HasMovingAgents() { return default; }
	///<summary>Copies navlink end points from the first entry in PointLinks array. This</summary>
	public  void CopyEndPointsFromSimpleLinkToSmartLink() {}
	///<summary>OnSmartLinkReached</summary>
	public FSmartLinkReachedSignature OnSmartLinkReached;
}
