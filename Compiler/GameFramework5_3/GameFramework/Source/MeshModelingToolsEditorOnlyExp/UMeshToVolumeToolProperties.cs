namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshToVolumeTool.h")]
public partial class UMeshToVolumeToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Method for converting the input mesh to a set of Planar Polygonal Faces in the output Volume.</summary>
	public EMeshToVolumeMode ConversionMode;
	///<summary>When true, adjacent coplanar groups will not be merged together into single faces. Not relevant if</summary>
	public bool bPreserveGroupBoundaries;
	///<summary>Determines whether mesh gets auto simplified when its triangle count is too high.</summary>
	public bool bAutoSimplify;
	///<summary>Target triangle count for auto simplification when Auto Simplify is true.</summary>
	public int SimplifyMaxTriangles;
	///<summary>Type of new Volume to create on Accept</summary>
	public UClass NewVolumeType;
	///<summary>If set, the target Volume will be updated, rather than creating a new Volume.</summary>
	public TLazyObjectPtr<AVolume> TargetVolume;
}
