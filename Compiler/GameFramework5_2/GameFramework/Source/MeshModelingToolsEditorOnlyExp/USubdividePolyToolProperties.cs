#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubdividePolyTool.h")]
///<summary>Properties</summary>
public partial class USubdividePolyToolProperties : UInteractiveToolPropertySet {
// SubdividePolyToolProperties
	public int SubdivisionLevel;
	public bool bCatmullClarkOK;
	public ESubdivisionScheme SubdivisionScheme;
	public ESubdivisionOutputNormals NormalComputationMethod;
	public ESubdivisionOutputUVs UVComputationMethod;
	public bool bNewPolyGroups;
	public bool bRenderGroups;
	public bool bRenderCage;
}
