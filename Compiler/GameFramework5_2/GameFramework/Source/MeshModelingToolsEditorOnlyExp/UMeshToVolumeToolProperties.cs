#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshToVolumeTool.h")]
public partial class UMeshToVolumeToolProperties : UInteractiveToolPropertySet {
// MeshToVolumeToolProperties
	public EMeshToVolumeMode ConversionMode;
	public UClass NewVolumeType;
	public TLazyObjectPtr<AVolume> TargetVolume;
}
