#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloud.h")]
public partial class ALidarClippingVolume : AVolume {
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>Affects how this volume affects points</summary>
	public ELidarClippingVolumeMode Mode;
	///<summary>Determines the processing order of the nodes, in case they overlap.</summary>
	public int Priority;
}
