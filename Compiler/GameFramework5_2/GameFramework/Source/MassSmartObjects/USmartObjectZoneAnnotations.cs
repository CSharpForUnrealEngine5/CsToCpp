#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ZoneGraph annotations for smart objects</summary>
[CppInclude("SmartObjectZoneAnnotations.h")]
public partial class USmartObjectZoneAnnotations : UZoneGraphAnnotationComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Filter specifying which lanes the behavior is applied to.</summary>
	public FZoneGraphTagFilter AffectedLaneTags;
	///<summary>Entry points graph for each ZoneGraphData.</summary>
	public TArray<FSmartObjectAnnotationData> SmartObjectAnnotationDataArray;
	///<summary>Tag to mark the lanes that offers smart objects.</summary>
	public FZoneGraphTag BehaviorTag;
	///<summary>Cached SmartObjectSubsystem</summary>
	public USmartObjectSubsystem SmartObjectSubsystem;
}
