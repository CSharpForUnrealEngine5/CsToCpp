#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshTangentsTool.h")]
public partial class UMeshTangentsToolProperties : UInteractiveToolPropertySet {
	///<summary>Method used for calculating the tangents</summary>
	public EMeshTangentsType CalculationMethod;
	///<summary>Display the mesh tangents</summary>
	public bool bShowTangents;
	///<summary>Display the mesh normals</summary>
	public bool bShowNormals;
	///<summary>Length of lines used for displaying tangents and/or normals</summary>
	public float LineLength;
	///<summary>Thickness of lines used for displaying tangents and/or normals</summary>
	public float LineThickness;
	///<summary>Display tangents and/or normals for degenerate triangles</summary>
	public bool bShowDegenerates;
	///<summary>Display difference between FastMikkTSpace tangents and MikkTSpace tangents.</summary>
	public bool bCompareWithMikkt;
	///<summary>Minimum angle difference in degrees for a FastMikkTSpace tangent to be considered different to a MikkTSpace tangent.</summary>
	public float CompareWithMikktThreshold;
}
