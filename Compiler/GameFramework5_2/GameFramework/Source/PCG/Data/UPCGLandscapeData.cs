#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGLandscapeData.h")]
///<summary>Landscape data access abstraction for PCG. Supports multi-landscape access, but it assumes that they are not overlapping.</summary>
public partial class UPCGLandscapeData : UPCGSurfaceData {
// PCGLandscapeData
	public TArray<TSoftObjectPtr<ALandscapeProxy>> Landscapes;
	public FBox Bounds;
	public bool bHeightOnly;
	public bool bUseMetadata;
}
