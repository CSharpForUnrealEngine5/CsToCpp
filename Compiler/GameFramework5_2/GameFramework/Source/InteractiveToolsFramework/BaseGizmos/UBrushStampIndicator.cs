#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/BrushStampIndicator.h")]
///<summary>* UBrushStampIndicator is a simple 3D brush indicator.</summary>
public partial class UBrushStampIndicator : UInteractiveGizmo {
// BrushStampIndicator
	public bool bVisible;
	public float BrushRadius;
	public float BrushFalloff;
	public FVector BrushPosition;
	public FVector BrushNormal;
	public bool bDrawIndicatorLines;
	public bool bDrawRadiusCircle;
	public int SampleStepCount;
	public FLinearColor LineColor;
	public float LineThickness;
	public bool bDepthTested;
	public bool bDrawSecondaryLines;
	public float SecondaryLineThickness;
	public FLinearColor SecondaryLineColor;
	public UPrimitiveComponent AttachedComponent;
}
