namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawSplineTool.h")]
public partial class UDrawSplineToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Determines whether the created spline is a loop. This can be toggled using &quot;Closed Loop&quot; in</summary>
	public bool bLoop;
	///<summary>Determines how the resulting spline is emitted on tool accept.</summary>
	public EDrawSplineOutputMode OutputMode;
	///<summary>Actor to attach to when Output Mode is &quot;Existing Actor&quot;</summary>
	public TWeakObjectPtr<AActor> TargetActor;
	///<summary>Blueprint to create when Output Mode is &quot;Create Blueprint&quot;</summary>
	public TWeakObjectPtr<UBlueprint> BlueprintToCreate;
	///<summary>When attaching to an existing actor or creating a blueprint, controls whether the drawn</summary>
	public int ExistingSplineIndexToReplace;
	///<summary>How the spline is drawn in the tool.</summary>
	public EDrawSplineDrawMode DrawMode;
	///<summary>Point spacing when Draw Mode is &quot;Free Draw&quot;</summary>
	public double MinPointSpacing;
	///<summary>When nonzero, allows a visualization of the rotation of the spline. Can be controlled</summary>
	public double FrameVisualizationWidth;
	///<summary>How the spline rotation is set. It is suggested to use a nonzero FrameVisualizationWidth to</summary>
	public EDrawSplineUpVectorMode UpVectorMode;
	///<summary>When modifying existing actors, whether the result should be previewed using a copy</summary>
	public bool bPreviewUsingActorCopy;
	///<summary>bHitWorld</summary>
	public bool bHitWorld;
	///<summary>bHitCustomPlane</summary>
	public bool bHitCustomPlane;
	///<summary>bHitGroundPlanes</summary>
	public bool bHitGroundPlanes;
	///<summary>If modifying a blueprint actor, whether to run the construction script while dragging</summary>
	public bool bRerunConstructionScriptOnDrag;
}
