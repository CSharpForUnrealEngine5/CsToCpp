namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudEditorTools.h")]
public partial class ULidarToolActionsSelection : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>ClearSelection</summary>
	public void ClearSelection() {}
	///<summary>InvertSelection</summary>
	public void InvertSelection() {}
	///<summary>DeleteSelected</summary>
	public void DeleteSelected() {}
	///<summary>DeleteHidden</summary>
	public void DeleteHidden() {}
	///<summary>HideSelected</summary>
	public void HideSelected() {}
	///<summary>ResetVisibility</summary>
	public void ResetVisibility() {}
	///<summary>Higher values will generally result in more accurate calculations, at the expense of time</summary>
	public int Quality;
	///<summary>Higher values are less susceptible to noise, but will most likely lose finer details, especially around hard edges.</summary>
	public float NoiseTolerance;
	///<summary>CalculateNormals</summary>
	public void CalculateNormals() {}
	///<summary>Extract</summary>
	public void Extract() {}
	///<summary>ExtractAsCopy</summary>
	public void ExtractAsCopy() {}
	///<summary>Max error around the meshed areas. Leave at 0 for max quality</summary>
	public float MaxMeshingError;
	///<summary>bMergeMeshes</summary>
	public bool bMergeMeshes;
	///<summary>If not merging meshes, this will retain the transform of the original cloud</summary>
	public bool bRetainTransform;
	///<summary>BuildStaticMesh</summary>
	public void BuildStaticMesh() {}
}
