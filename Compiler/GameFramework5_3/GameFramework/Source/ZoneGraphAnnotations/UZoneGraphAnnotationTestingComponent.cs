namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug component to test Mass ZoneGraph Annotations. Handles tests and rendering.</summary>
[CppInclude("ZoneGraphAnnotationTestingActor.h")]
public partial class UZoneGraphAnnotationTestingComponent : UDebugDrawComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Tests</summary>
	public TArray<UZoneGraphAnnotationTest> Tests;
}
