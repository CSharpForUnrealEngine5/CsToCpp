#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CSGMeshesTool.h")]
///<summary>Properties of the trim mode</summary>
public partial class UTrimMeshesToolProperties : UInteractiveToolPropertySet {
// TrimMeshesToolProperties
	public ETrimOperation WhichMesh;
	public ETrimSide TrimSide;
	public float WindingThreshold;
	public bool bShowTrimmingMesh;
	public float OpacityOfTrimmingMesh;
	public FLinearColor ColorOfTrimmingMesh;
}
