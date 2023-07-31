#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug actor to test Mass ZoneGraph Annotations.</summary>
[CppInclude("ZoneGraphAnnotationTestingActor.h")]
public partial class AZoneGraphAnnotationTestingActor : AActor {
	///<summary>Simple trigger function to trigger something on the tests.</summary>
	public  void Trigger() {}
	///<summary>TestingComp</summary>
	public UZoneGraphAnnotationTestingComponent TestingComp;
}
