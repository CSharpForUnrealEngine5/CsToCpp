namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshToVolumeTool.h")]
public partial class UMeshToVolumeToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Method for converting the input mesh to a set of Planar Polygonal Faces in the output Volume.</summary>
	public EMeshToVolumeMode ConversionMode;
	///<summary>Type of new Volume to create on Accept</summary>
	public UClass NewVolumeType;
	///<summary>If set, the target Volume will be updated, rather than creating a new Volume.</summary>
	public TLazyObjectPtr<AVolume> TargetVolume;
}
