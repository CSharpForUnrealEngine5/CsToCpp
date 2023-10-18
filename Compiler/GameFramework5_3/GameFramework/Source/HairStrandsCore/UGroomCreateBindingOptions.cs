namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCreateBindingOptions.h")]
public partial class UGroomCreateBindingOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Groom asset</summary>
	public TWeakObjectPtr<UGroomAsset> GroomAsset;
	///<summary>Type of mesh to create groom binding for</summary>
	public EGroomBindingMeshType GroomBindingType;
	///<summary>Skeletal mesh on which the groom has been authored. This is optional, and used only if the hair</summary>
	public USkeletalMesh SourceSkeletalMesh;
	///<summary>Skeletal mesh on which the groom is attached to.</summary>
	public USkeletalMesh TargetSkeletalMesh;
	///<summary>GeometryCache on which the groom has been authored</summary>
	public UGeometryCache SourceGeometryCache;
	///<summary>GeometryCache on which the groom is attached to.</summary>
	public UGeometryCache TargetGeometryCache;
	///<summary>Number of points used for the rbf interpolation</summary>
	public int NumInterpolationPoints;
	///<summary>Section to pick to transfer the position</summary>
	public int MatchingSection;
}
