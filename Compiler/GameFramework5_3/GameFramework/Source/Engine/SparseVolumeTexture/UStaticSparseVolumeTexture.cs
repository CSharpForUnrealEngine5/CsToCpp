namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a streamable SparseVolumeTexture asset with a single frame. Although there is only a single frame, it is still recommended to use USparseVolumeTextureFrame::GetFrameAndIssueStreamingRequest().</summary>
[CppInclude("SparseVolumeTexture/SparseVolumeTexture.h")]
public partial class UStaticSparseVolumeTexture : UStreamableSparseVolumeTexture {
	public static UClass StaticClass() {return default;}
}
