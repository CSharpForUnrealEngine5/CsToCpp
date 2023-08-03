#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an asset that can be used to store binding information between a groom and a skeletal mesh</summary>
[CppInclude("GroomBindingAsset.h")]
public partial class UGroomBindingAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Type of mesh to create groom binding for</summary>
	public EGroomBindingMeshType GroomBindingType;
	///<summary>Groom to bind.</summary>
	public UGroomAsset Groom;
	///<summary>Skeletal mesh on which the groom has been authored. This is optional, and used only if the hair</summary>
	public USkeletalMesh SourceSkeletalMesh;
	///<summary>Skeletal mesh on which the groom is attached to.</summary>
	public USkeletalMesh TargetSkeletalMesh;
	///<summary>SourceGeometryCache</summary>
	public UGeometryCache SourceGeometryCache;
	///<summary>TargetGeometryCache</summary>
	public UGeometryCache TargetGeometryCache;
	///<summary>Number of points used for the rbf interpolation</summary>
	public int NumInterpolationPoints;
	///<summary>Number of points used for the rbf interpolation</summary>
	public int MatchingSection;
	///<summary>GroupInfos</summary>
	public TArray<FGoomBindingGroupInfo> GroupInfos;
}
