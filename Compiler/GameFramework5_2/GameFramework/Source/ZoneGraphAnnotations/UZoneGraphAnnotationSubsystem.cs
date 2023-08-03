#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem managing Zonegraph Annotations.</summary>
[CppInclude("ZoneGraphAnnotationSubsystem.h")]
public partial class UZoneGraphAnnotationSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Array of registered components.</summary>
	public TArray<FRegisteredZoneGraphAnnotation> RegisteredComponents;
	///<summary>Stream of events to be processed, double buffered.</summary>
	public FInstancedStructContainer Events;
	///<summary>Lookup table from tag index to Annotation</summary>
	public TArray<UZoneGraphAnnotationComponent> TagToAnnotationLookup;
}
