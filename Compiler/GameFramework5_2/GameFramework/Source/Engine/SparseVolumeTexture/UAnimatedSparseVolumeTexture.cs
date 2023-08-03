#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAnimatedSparseVolumeTexture inherit from USparseVolumeTexture to be viewed using the first frame by default.</summary>
[CppInclude("SparseVolumeTexture/SparseVolumeTexture.h")]
public partial class UAnimatedSparseVolumeTexture : USparseVolumeTexture {
	public static UClass StaticClass() {return default;}
	///<summary>The asset frame count.</summary>
	public int FrameCount;
	///<summary>VolumeBounds</summary>
	public FBox VolumeBounds;
}
