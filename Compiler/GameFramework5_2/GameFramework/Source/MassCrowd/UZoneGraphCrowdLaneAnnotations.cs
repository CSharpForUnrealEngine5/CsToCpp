#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphCrowdLaneAnnotations.h")]
///<summary>Zone graph blocking behavior</summary>
public partial class UZoneGraphCrowdLaneAnnotations : UZoneGraphAnnotationComponent {
// ZoneGraphCrowdLaneAnnotations
	public FZoneGraphTag CloseLaneTag;
	public FZoneGraphTag WaitingLaneTag;
	public bool bDisplayTags;
	public UMassCrowdSubsystem CrowdSubsystem;
}
