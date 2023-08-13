namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UBrushStampIndicator is a simple 3D brush indicator.</summary>
[CppInclude("BaseGizmos/BrushStampIndicator.h")]
public partial class UBrushStampIndicator : UInteractiveGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>Controls whether Gizmo will draw visual elements. Does not currently affect AttachedComponent.</summary>
	public bool bVisible;
	///<summary>BrushRadius</summary>
	public float BrushRadius;
	///<summary>BrushFalloff</summary>
	public float BrushFalloff;
	///<summary>BrushPosition</summary>
	public FVector BrushPosition;
	///<summary>BrushNormal</summary>
	public FVector BrushNormal;
	///<summary>bDrawIndicatorLines</summary>
	public bool bDrawIndicatorLines;
	///<summary>bDrawRadiusCircle</summary>
	public bool bDrawRadiusCircle;
	///<summary>SampleStepCount</summary>
	public int SampleStepCount;
	///<summary>LineColor</summary>
	public FLinearColor LineColor;
	///<summary>LineThickness</summary>
	public float LineThickness;
	///<summary>bDepthTested</summary>
	public bool bDepthTested;
	///<summary>bDrawSecondaryLines</summary>
	public bool bDrawSecondaryLines;
	///<summary>SecondaryLineThickness</summary>
	public float SecondaryLineThickness;
	///<summary>SecondaryLineColor</summary>
	public FLinearColor SecondaryLineColor;
	///<summary>Optional Component that will be transformed such that it tracks the Radius/Position/Normal</summary>
	public UPrimitiveComponent AttachedComponent;
}
