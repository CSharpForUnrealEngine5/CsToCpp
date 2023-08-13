namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystem that tracks mass entities that are wandering on the zone graph.</summary>
[CppInclude("MassCrowdSubsystem.h")]
public partial class UMassCrowdSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>ZoneGraphSubsystem</summary>
	public UZoneGraphSubsystem ZoneGraphSubsystem;
	///<summary>ZoneGraphAnnotationSubsystem</summary>
	public UZoneGraphAnnotationSubsystem ZoneGraphAnnotationSubsystem;
	///<summary>MassCrowdSettings</summary>
	public UMassCrowdSettings MassCrowdSettings;
}
