#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties</summary>
[CppInclude("EditNormalsTool.h")]
public partial class UEditNormalsToolProperties : UInteractiveToolPropertySet {
	///<summary>Recompute all mesh normals</summary>
	public bool bRecomputeNormals;
	///<summary>Choose the method for computing vertex normals</summary>
	public ENormalCalculationMethod NormalCalculationMethod;
	///<summary>For meshes with inconsistent triangle orientations/normals, flip as needed to make the normals consistent</summary>
	public bool bFixInconsistentNormals;
	///<summary>Invert (flip) all mesh normals and associated triangle orientations</summary>
	public bool bInvertNormals;
	///<summary>Control whether and how the topology of the normals is recomputed, e.g. to create sharp edges where face normals change by a large amount or where face group IDs change.  Normals will always be recomputed unless SplitNormal Method is UseExistingTopology.</summary>
	public ESplitNormalMethod SplitNormalMethod;
	///<summary>Threshold on angle of change in face normals across an edge, above which we create a sharp edge if bSplitNormals is true</summary>
	public float SharpEdgeAngleThreshold;
	///<summary>Assign separate normals at &#39;sharp&#39; vertices, for example, at the tip of a cone</summary>
	public bool bAllowSharpVertices;
}
