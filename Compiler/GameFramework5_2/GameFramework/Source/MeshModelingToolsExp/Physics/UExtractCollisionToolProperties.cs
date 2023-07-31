#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/ExtractCollisionGeometryTool.h")]
public partial class UExtractCollisionToolProperties : UInteractiveToolPropertySet {
	///<summary>Type of collision geometry to convert to Mesh</summary>
	public EExtractCollisionOutputType CollisionType;
	///<summary>Whether or not to weld coincident border edges of the Complex Collision Mesh (if possible)</summary>
	public bool bWeldEdges;
	///<summary>Whether or not to generate a seperate Mesh Object for each Simple Collision Shape</summary>
	public bool bOutputSeparateMeshes;
	///<summary>Show/Hide a preview of the generated mesh (overlaps source mesh)</summary>
	public bool bShowPreview;
	///<summary>Show/Hide input mesh</summary>
	public bool bShowInputMesh;
}
