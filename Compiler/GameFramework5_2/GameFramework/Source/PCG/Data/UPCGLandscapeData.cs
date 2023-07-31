#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Landscape data access abstraction for PCG. Supports multi-landscape access, but it assumes that they are not overlapping.</summary>
[CppInclude("Data/PCGLandscapeData.h")]
public partial class UPCGLandscapeData : UPCGSurfaceData {
	///<summary>TODO: add on property changed to clear cached data. This is used to populate the LandscapeInfos array.</summary>
	public TArray<TSoftObjectPtr<ALandscapeProxy>> Landscapes;
	///<summary>Bounds</summary>
	public FBox Bounds;
	///<summary>bHeightOnly</summary>
	public bool bHeightOnly;
	///<summary>bUseMetadata</summary>
	public bool bUseMetadata;
}
