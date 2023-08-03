#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudEditorTools.h")]
public partial class ULidarToolActionsMeshing : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Max error around the meshed areas. Leave at 0 for max quality</summary>
	public float MaxMeshingError;
	///<summary>bMergeMeshes</summary>
	public bool bMergeMeshes;
	///<summary>If not merging meshes, this will retain the transform of the original cloud</summary>
	public bool bRetainTransform;
	///<summary>BuildStaticMesh</summary>
	public  void BuildStaticMesh() {}
}
