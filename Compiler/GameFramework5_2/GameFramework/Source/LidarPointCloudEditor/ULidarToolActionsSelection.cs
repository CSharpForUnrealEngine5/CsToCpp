#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudEditorTools.h")]
public partial class ULidarToolActionsSelection : UInteractiveToolPropertySet {
// LidarToolActionsSelection
	public void ClearSelection() {}
	public void InvertSelection() {}
	public void DeleteSelected() {}
	public void DeleteHidden() {}
	public void HideSelected() {}
	public void ResetVisibility() {}
	public int Quality;
	public float NoiseTolerance;
	public void CalculateNormals() {}
	public void Extract() {}
	public void ExtractAsCopy() {}
	public float MaxMeshingError;
	public bool bMergeMeshes;
	public bool bRetainTransform;
	public void BuildStaticMesh() {}
}
