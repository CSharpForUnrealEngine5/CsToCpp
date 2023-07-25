#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectZoneAnnotations.h")]
///<summary>ZoneGraph annotations for smart objects</summary>
public partial class USmartObjectZoneAnnotations : UZoneGraphAnnotationComponent {
// SmartObjectZoneAnnotations
	public FZoneGraphTagFilter AffectedLaneTags;
	public TArray<FSmartObjectAnnotationData> SmartObjectAnnotationDataArray;
	public FZoneGraphTag BehaviorTag;
	public USmartObjectSubsystem SmartObjectSubsystem;
}
