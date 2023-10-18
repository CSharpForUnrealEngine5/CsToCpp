namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A sphere generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
[CppInclude("Components/SphereComponent.h")]
public partial class USphereComponent : UShapeComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The radius of the sphere *</summary>
	public float SphereRadius;
	///<summary>Change the sphere radius. This is the unscaled radius, before component scale is applied.</summary>
	public void SetSphereRadius(float InSphereRadius,bool bUpdateOverlaps/*=true*/) {}
	///<summary>@return the radius of the sphere, with component scale applied.</summary>
	public float GetScaledSphereRadius() { return default; }
	///<summary>@return the radius of the sphere, ignoring component scale.</summary>
	public float GetUnscaledSphereRadius() { return default; }
	///<summary>Get the scale used by this shape. This is a uniform scale that is the minimum of any non-uniform scaling.</summary>
	public float GetShapeScale() { return default; }
}
