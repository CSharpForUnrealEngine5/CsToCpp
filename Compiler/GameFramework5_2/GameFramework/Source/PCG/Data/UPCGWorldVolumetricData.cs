#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGWorldData.h")]
///<summary>Queries volume for presence of world collision or not. Can be used to voxelize environment.</summary>
public partial class UPCGWorldVolumetricData : UPCGVolumeData {
// PCGWorldVolumetricData
	public TWeakObjectPtr<UWorld> World;
	public TWeakObjectPtr<UPCGComponent> OriginatingComponent;
	public FPCGWorldVolumetricQueryParams QueryParams;
}
