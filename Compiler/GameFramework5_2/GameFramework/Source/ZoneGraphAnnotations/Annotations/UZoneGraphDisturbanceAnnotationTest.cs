#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test for Disturbance Annotation</summary>
[CppInclude("Annotations/ZoneGraphDisturbanceAnnotation.h")]
public partial class UZoneGraphDisturbanceAnnotationTest : UZoneGraphAnnotationTest {
	public static UClass StaticClass() {return default;}
	///<summary>Offset</summary>
	public FVector Offset;
	///<summary>Duration</summary>
	public float Duration;
	///<summary>DangerRadius</summary>
	public float DangerRadius;
}
