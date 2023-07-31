#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A box generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
[CppInclude("Components/BoxComponent.h")]
public partial class UBoxComponent : UShapeComponent {
	///<summary>The extents (radii dimensions) of the box *</summary>
	public FVector BoxExtent;
	///<summary>Used to control the line thickness when rendering</summary>
	public float LineThickness;
	///<summary>Change the box extent size. This is the unscaled size, before component scale is applied.</summary>
	public  void SetBoxExtent(FVector InBoxExtent,bool bUpdateOverlaps/*=true*/) {}
	///<summary>Set the LineThickness</summary>
	public  void SetLineThickness(float Thickness) {}
	///<summary>@return the box extent, scaled by the component scale.</summary>
	public  FVector GetScaledBoxExtent() { return default; }
	///<summary>@return the box extent, ignoring component scale.</summary>
	public  FVector GetUnscaledBoxExtent() { return default; }
}
