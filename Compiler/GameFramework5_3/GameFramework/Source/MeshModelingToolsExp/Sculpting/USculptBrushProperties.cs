namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSculptToolBase.h")]
public partial class USculptBrushProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>BrushSize</summary>
	public FBrushToolRadius BrushSize;
	///<summary>Amount of falloff to apply (0.0 - 1.0)</summary>
	public float BrushFalloffAmount;
	///<summary>If false, then BrushFalloffAmount will not be shown in DetailsView panels (otherwise no effect)</summary>
	public bool bShowFalloff;
	///<summary>Depth of Brush into surface along view ray or surface normal, depending on the Active Brush Type</summary>
	public float Depth;
	///<summary>Allow the Brush to hit the back-side of the mesh</summary>
	public bool bHitBackFaces;
	///<summary>Brush stamps are applied at this time interval. 0 for a single stamp, 1 for continuous stamps, 0.5 is a stamp every half-second</summary>
	public float FlowRate;
	///<summary>Space out stamp centers at distances Spacing*BrushDiameter along the stroke (so Spacing of 1 means that stamps will be adjacent but non-overlapping). Zero spacing means continuous stamps.</summary>
	public float Spacing;
	///<summary>Lazy brush smooths out the brush path by averaging the cursor positions</summary>
	public float Lazyness;
	///<summary>bShowPerBrushProps</summary>
	public bool bShowPerBrushProps;
	///<summary>bShowLazyness</summary>
	public bool bShowLazyness;
	///<summary>bShowFlowRate</summary>
	public bool bShowFlowRate;
	///<summary>bShowSpacing</summary>
	public bool bShowSpacing;
}
