#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SphereComponent.h")]
///<summary>A sphere generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
public partial class USphereComponent : UShapeComponent {
// SphereComponent
	public float SphereRadius;
	public  void SetSphereRadius(float InSphereRadius,bool bUpdateOverlaps/*=true*/) {}
	public  float GetScaledSphereRadius() { return default; }
	public  float GetUnscaledSphereRadius() { return default; }
	public  float GetShapeScale() { return default; }
}
