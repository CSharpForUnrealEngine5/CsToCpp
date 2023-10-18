namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawSplineTool.h")]
public partial class UDrawSplineTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UDrawSplineToolProperties Settings;
	///<summary>ClickOrDragBehavior</summary>
	public USingleClickOrDragInputBehavior ClickOrDragBehavior;
	///<summary>PlaneMechanic</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
	///<summary>PreviewRootActor either holds WorkingSpline inside it directly, or has some preview actor</summary>
	public APreviewGeometryActor PreviewRootActor;
	///<summary>The preview actor may be a duplicate of some target blueprint actor so that we can see the</summary>
	public AActor PreviewActor;
	///<summary>Used to restore visibility of previous actor when switching to a different one</summary>
	public AActor PreviousTargetActor;
}
