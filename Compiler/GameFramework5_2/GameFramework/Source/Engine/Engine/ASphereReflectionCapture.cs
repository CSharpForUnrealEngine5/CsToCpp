#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor used to capture the scene for reflection in a sphere shape.</summary>
[CppInclude("Engine/SphereReflectionCapture.h")]
public partial class ASphereReflectionCapture : AReflectionCapture {
	public static UClass StaticClass() {return default;}
	///<summary>Sphere component used to visualize the capture radius</summary>
	public UDrawSphereComponent DrawCaptureRadius;
}
