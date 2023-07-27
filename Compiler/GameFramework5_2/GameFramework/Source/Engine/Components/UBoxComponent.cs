#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BoxComponent.h")]
///<summary>A box generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
public partial class UBoxComponent : UShapeComponent {
// BoxComponent
	public FVector BoxExtent;
	public float LineThickness;
	public  void SetBoxExtent(FVector InBoxExtent,bool bUpdateOverlaps/*=true*/) {}
	public  void SetLineThickness(float Thickness) {}
	public  FVector GetScaledBoxExtent() { return default; }
	public  FVector GetUnscaledBoxExtent() { return default; }
}
