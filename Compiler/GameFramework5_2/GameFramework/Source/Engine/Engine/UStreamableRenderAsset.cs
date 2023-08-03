#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StreamableRenderAsset.h")]
public partial class UStreamableRenderAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Tells the streaming system that it should force all mip-levels to be resident for a number of seconds.</summary>
	public  void SetForceMipLevelsToBeResident(float Seconds,int CinematicLODGroupMask/*=0*/) {}
	///<summary>WorldSettings timestamp that tells the streamer to force all miplevels to be resident up until that time.</summary>
	public double ForceMipLevelsToBeResidentTimestamp;
	///<summary>Number of mip-levels to use for cinematic quality.</summary>
	public int NumCinematicMipLevels;
	///<summary>NoRefStreamingLODBias</summary>
	public FPerQualityLevelInt NoRefStreamingLODBias;
	///<summary>FStreamingRenderAsset index used by the texture streaming system.</summary>
	public int StreamingIndex;
	///<summary>NeverStream</summary>
	public bool NeverStream;
	///<summary>Global and serialized version of ForceMiplevelsToBeResident.</summary>
	public bool bGlobalForceMipLevelsToBeResident;
	///<summary>Whether some mips might be streamed soon. If false, the texture is not planned resolution will be stable.</summary>
	public bool bHasStreamingUpdatePending;
	///<summary>Override whether to fully stream even if texture hasn&#39;t been rendered.</summary>
	public bool bForceMiplevelsToBeResident;
	///<summary>When forced fully resident, ignores the streaming mip bias used to accommodate memory constraints.</summary>
	public bool bIgnoreStreamingMipBias;
	///<summary>Whether to use the extra cinematic quality mip-levels, when we&#39;re forcing mip-levels to be resident.</summary>
	public bool bUseCinematicMipLevels;
}
