#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug component to test Mass ZoneGraph Annotations. Handles tests and rendering.</summary>
[CppInclude("ZoneGraphAnnotationTestingActor.h")]
public partial class UZoneGraphAnnotationTestingComponent : UDebugDrawComponent {
	///<summary>Tests</summary>
	public TArray<UZoneGraphAnnotationTest> Tests;
}
