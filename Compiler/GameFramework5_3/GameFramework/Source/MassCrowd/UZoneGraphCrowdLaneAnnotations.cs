namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Zone graph blocking behavior</summary>
[CppInclude("ZoneGraphCrowdLaneAnnotations.h")]
public partial class UZoneGraphCrowdLaneAnnotations : UZoneGraphAnnotationComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Annotation Tag to mark a closed lane.</summary>
	public FZoneGraphTag CloseLaneTag;
	///<summary>Annotation Tag to mark a waiting lane.</summary>
	public FZoneGraphTag WaitingLaneTag;
	///<summary>bDisplayTags</summary>
	public bool bDisplayTags;
	///<summary>Cached ZoneGraphSubsystem</summary>
	public UMassCrowdSubsystem CrowdSubsystem;
}
