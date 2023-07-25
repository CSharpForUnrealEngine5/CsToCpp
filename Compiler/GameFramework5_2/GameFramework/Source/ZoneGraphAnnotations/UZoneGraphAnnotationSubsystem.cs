#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphAnnotationSubsystem.h")]
///<summary>A subsystem managing Zonegraph Annotations.</summary>
public partial class UZoneGraphAnnotationSubsystem : UTickableWorldSubsystem {
// ZoneGraphAnnotationSubsystem
	public TArray<FRegisteredZoneGraphAnnotation> RegisteredComponents;
	public FInstancedStructContainer Events;
	public TArray<UZoneGraphAnnotationComponent> TagToAnnotationLookup;
}
