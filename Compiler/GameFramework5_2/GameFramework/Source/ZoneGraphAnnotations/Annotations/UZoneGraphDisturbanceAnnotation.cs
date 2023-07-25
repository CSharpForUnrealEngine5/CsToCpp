#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Annotations/ZoneGraphDisturbanceAnnotation.h")]
///<summary>ZoneGraph Disturbance Annotation</summary>
public partial class UZoneGraphDisturbanceAnnotation : UZoneGraphAnnotationComponent {
// ZoneGraphDisturbanceAnnotation
	public FZoneGraphTag DangerAnnotationTag;
	public FZoneGraphTag ObstacleAnnotationTag;
	public FZoneGraphTagFilter AffectedLaneTags;
	public FZoneGraphTagFilter EscapeLaneTags;
	public float IdealSpanLength;
	public UZoneGraphSubsystem ZoneGraphSubsystem;
}
