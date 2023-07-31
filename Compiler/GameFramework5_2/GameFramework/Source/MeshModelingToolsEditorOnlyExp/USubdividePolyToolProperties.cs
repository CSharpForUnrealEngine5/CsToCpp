#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties</summary>
[CppInclude("SubdividePolyTool.h")]
public partial class USubdividePolyToolProperties : UInteractiveToolPropertySet {
	///<summary>Number of iterations/levels of subdivision to perform</summary>
	public int SubdivisionLevel;
	///<summary>Controls whether the user can select Catmull-Clark or is forced to use Loop</summary>
	public bool bCatmullClarkOK;
	///<summary>SubdivisionScheme</summary>
	public ESubdivisionScheme SubdivisionScheme;
	///<summary>NormalComputationMethod</summary>
	public ESubdivisionOutputNormals NormalComputationMethod;
	///<summary>UVComputationMethod</summary>
	public ESubdivisionOutputUVs UVComputationMethod;
	///<summary>Assign a new PolyGroup ID to each newly created face</summary>
	public bool bNewPolyGroups;
	///<summary>Display each PolyGroup with an auto-generated color</summary>
	public bool bRenderGroups;
	///<summary>Display the mesh corresponding to Subdivision Level 0</summary>
	public bool bRenderCage;
}
