namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties</summary>
[CppInclude("SubdividePolyTool.h")]
public partial class USubdividePolyToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Number of iterations/levels of subdivision to perform</summary>
	public int SubdivisionLevel;
	///<summary>SubdivisionScheme</summary>
	public ESubdivisionScheme SubdivisionScheme;
	///<summary>How to treat mesh boundaries</summary>
	public ESubdivisionBoundaryScheme BoundaryScheme;
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
	///<summary>When using the group topology for subdivision, whether to add extra corners at sharp group edge bends on mesh boundaries. Note: We cannot add extra corners on non-boundary group edges, as this would create non-manifold geometry on subdivision.</summary>
	public bool bAddExtraCorners;
	///<summary>How acute an angle between two edges needs to be to add an extra corner there when Add Extra Corners is true.</summary>
	public double ExtraCornerAngleThresholdDegrees;
	///<summary>Shows whether the current subdivision scheme is overridden to be &quot;Loop&quot; because the group topology is unsuitable.</summary>
	public bool bOverriddenSubdivisionScheme;
}
