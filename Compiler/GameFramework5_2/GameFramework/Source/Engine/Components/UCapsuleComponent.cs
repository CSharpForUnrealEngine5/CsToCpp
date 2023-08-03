#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A capsule generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
[CppInclude("Components/CapsuleComponent.h")]
public partial class UCapsuleComponent : UShapeComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Half-height, from center of capsule to the end of top or bottom hemisphere.</summary>
	public float CapsuleHalfHeight;
	///<summary>Radius of cap hemispheres and center cylinder.</summary>
	public float CapsuleRadius;
	///<summary>CapsuleHeight_DEPRECATED</summary>
	public float CapsuleHeight_DEPRECATED;
	///<summary>Change the capsule size. This is the unscaled size, before component scale is applied.</summary>
	public  void SetCapsuleSize(float InRadius,float InHalfHeight,bool bUpdateOverlaps/*=true*/) {}
	///<summary>Set the capsule radius. This is the unscaled radius, before component scale is applied.</summary>
	public  void SetCapsuleRadius(float Radius,bool bUpdateOverlaps/*=true*/) {}
	///<summary>Set the capsule half-height. This is the unscaled half-height, before component scale is applied.</summary>
	public  void SetCapsuleHalfHeight(float HalfHeight,bool bUpdateOverlaps/*=true*/) {}
	///<summary>Returns the capsule radius scaled by the component scale.</summary>
	public  float GetScaledCapsuleRadius() { return default; }
	///<summary>Returns the capsule half-height scaled by the component scale. This includes both the cylinder and hemisphere cap.</summary>
	public  float GetScaledCapsuleHalfHeight() { return default; }
	///<summary>Returns the capsule half-height minus radius (to exclude the hemisphere), scaled by the component scale.</summary>
	public  float GetScaledCapsuleHalfHeight_WithoutHemisphere() { return default; }
	///<summary>Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap.</summary>
	public  void GetScaledCapsuleSize(float OutRadius,float OutHalfHeight) {}
	///<summary>Returns the capsule radius and half-height scaled by the component scale. Half-height excludes the hemisphere end cap.</summary>
	public  void GetScaledCapsuleSize_WithoutHemisphere(float OutRadius,float OutHalfHeightWithoutHemisphere) {}
	///<summary>Returns the capsule radius, ignoring component scaling.</summary>
	public  float GetUnscaledCapsuleRadius() { return default; }
	///<summary>Returns the capsule half-height, ignoring component scaling. This includes the hemisphere end cap.</summary>
	public  float GetUnscaledCapsuleHalfHeight() { return default; }
	///<summary>Returns the capsule half-height minus radius (to exclude the hemisphere), ignoring component scaling. This excludes the hemisphere end cap.</summary>
	public  float GetUnscaledCapsuleHalfHeight_WithoutHemisphere() { return default; }
	///<summary>Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap.</summary>
	public  void GetUnscaledCapsuleSize(float OutRadius,float OutHalfHeight) {}
	///<summary>Returns the capsule radius and half-height, ignoring component scaling. Half-height excludes the hemisphere end cap.</summary>
	public  void GetUnscaledCapsuleSize_WithoutHemisphere(float OutRadius,float OutHalfHeightWithoutHemisphere) {}
	///<summary>Get the scale used by this shape. This is a uniform scale that is the minimum of any non-uniform scaling.</summary>
	public  float GetShapeScale() { return default; }
}
