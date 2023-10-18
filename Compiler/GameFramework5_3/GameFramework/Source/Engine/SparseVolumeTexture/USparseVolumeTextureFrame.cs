namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a frame in a SparseVolumeTexture sequence and owns the actual data needed for rendering. Is owned by a UStreamableSparseVolumeTexture object.</summary>
[CppInclude("SparseVolumeTexture/SparseVolumeTexture.h")]
public partial class USparseVolumeTextureFrame : USparseVolumeTexture {
	public static UClass StaticClass() {return default;}
	///<summary>Owner</summary>
	public USparseVolumeTexture Owner;
	///<summary>FrameIndex</summary>
	public int FrameIndex;
}
