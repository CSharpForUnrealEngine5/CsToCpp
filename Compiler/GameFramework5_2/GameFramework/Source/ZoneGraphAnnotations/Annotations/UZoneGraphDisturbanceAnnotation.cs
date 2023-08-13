namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ZoneGraph Disturbance Annotation</summary>
[CppInclude("Annotations/ZoneGraphDisturbanceAnnotation.h")]
public partial class UZoneGraphDisturbanceAnnotation : UZoneGraphAnnotationComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Tag to mark the lanes that should be fled.</summary>
	public FZoneGraphTag DangerAnnotationTag;
	///<summary>Tag to mark the lanes influenced by an obstacle.</summary>
	public FZoneGraphTag ObstacleAnnotationTag;
	///<summary>Filter specifying which lanes the Annotation is applied to.</summary>
	public FZoneGraphTagFilter AffectedLaneTags;
	///<summary>Filter specifying which lanes can be used during Disturbance.</summary>
	public FZoneGraphTagFilter EscapeLaneTags;
	///<summary>Ideal span length for lane subdivision. Each lane will have between 2 and 8 spans.</summary>
	public float IdealSpanLength;
	///<summary>Cached ZoneGraphSubsystem</summary>
	public UZoneGraphSubsystem ZoneGraphSubsystem;
}
