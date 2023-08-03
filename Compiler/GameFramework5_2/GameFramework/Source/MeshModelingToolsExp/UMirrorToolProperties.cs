#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MirrorTool.h")]
public partial class UMirrorToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Mode of operation.</summary>
	public EMirrorOperationMode OperationMode;
	///<summary>Cut off everything on the back side of the mirror plane before mirroring.</summary>
	public bool bCropAlongMirrorPlaneFirst;
	///<summary>Weld vertices that lie on the mirror plane. Vertices will not be welded if doing so would give an edge more than two faces, or if they are part of a face in the plane.</summary>
	public bool bWeldVerticesOnMirrorPlane;
	///<summary>Distance (in unscaled mesh space) to allow a point to be from the plane and still consider it &quot;on the mirror plane&quot;.</summary>
	public double PlaneTolerance;
	///<summary>When welding, whether to allow bowtie vertices to be created, or to duplicate the vertex.</summary>
	public bool bAllowBowtieVertexCreation;
	///<summary>What Ctrl + clicking does to the mirror plane.</summary>
	public EMirrorCtrlClickBehavior CtrlClickBehavior;
	///<summary>If true the &quot;Preset Mirror Directions&quot; buttons only change the plane orientation, not location.</summary>
	public bool bButtonsOnlyChangeOrientation;
	///<summary>Whether to show the preview.</summary>
	public bool bShowPreview;
	///<summary>How to save the result.</summary>
	public EMirrorSaveMode SaveMode;
}
