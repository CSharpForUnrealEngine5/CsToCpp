#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCrowdSubsystem.h")]
///<summary>Subsystem that tracks mass entities that are wandering on the zone graph.</summary>
public partial class UMassCrowdSubsystem : UWorldSubsystem {
// MassCrowdSubsystem
	public UZoneGraphSubsystem ZoneGraphSubsystem;
	public UZoneGraphAnnotationSubsystem ZoneGraphAnnotationSubsystem;
	public UMassCrowdSettings MassCrowdSettings;
}
