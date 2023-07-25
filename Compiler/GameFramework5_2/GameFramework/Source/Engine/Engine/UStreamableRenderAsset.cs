#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StreamableRenderAsset.h")]
public partial class UStreamableRenderAsset : UObject {
// StreamableRenderAsset
	public void SetForceMipLevelsToBeResident(float Seconds,int CinematicLODGroupMask/*=0*/) {}
	public double ForceMipLevelsToBeResidentTimestamp;
	public int NumCinematicMipLevels;
	public FPerQualityLevelInt NoRefStreamingLODBias;
	public int StreamingIndex;
	public bool NeverStream;
	public bool bGlobalForceMipLevelsToBeResident;
	public bool bHasStreamingUpdatePending;
	public bool bForceMiplevelsToBeResident;
	public bool bIgnoreStreamingMipBias;
	public bool bUseCinematicMipLevels;
}
