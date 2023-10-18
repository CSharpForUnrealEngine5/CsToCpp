namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloud.h")]
public partial class ALidarClippingVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>Affects how this volume affects points</summary>
	public ELidarClippingVolumeMode Mode;
	///<summary>Determines the processing order of the nodes, in case they overlap.</summary>
	public int Priority;
}
