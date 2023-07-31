#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystem that tracks mass entities that are wandering on the zone graph.</summary>
[CppInclude("MassCrowdSubsystem.h")]
public partial class UMassCrowdSubsystem : UWorldSubsystem {
	///<summary>ZoneGraphSubsystem</summary>
	public UZoneGraphSubsystem ZoneGraphSubsystem;
	///<summary>ZoneGraphAnnotationSubsystem</summary>
	public UZoneGraphAnnotationSubsystem ZoneGraphAnnotationSubsystem;
	///<summary>MassCrowdSettings</summary>
	public UMassCrowdSettings MassCrowdSettings;
}
