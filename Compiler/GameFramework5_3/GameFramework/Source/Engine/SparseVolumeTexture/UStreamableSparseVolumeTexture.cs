namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a streamable SparseVolumeTexture asset and serves as base class for UStaticSparseVolumeTexture and UAnimatedSparseVolumeTexture. It has an array of USparseVolumeTextureFrame.</summary>
[CppInclude("SparseVolumeTexture/SparseVolumeTexture.h")]
public partial class UStreamableSparseVolumeTexture : USparseVolumeTexture {
	public static UClass StaticClass() {return default;}
	///<summary>VolumeResolution</summary>
	public FIntVector VolumeResolution;
	///<summary>NumMipLevels</summary>
	public int NumMipLevels;
	///<summary>NumFrames</summary>
	public int NumFrames;
	///<summary>FormatA</summary>
	public EPixelFormat FormatA;
	///<summary>FormatB</summary>
	public EPixelFormat FormatB;
	///<summary>FallbackValueA</summary>
	public FVector4f FallbackValueA;
	///<summary>FallbackValueB</summary>
	public FVector4f FallbackValueB;
	///<summary>The addressing mode to use for the X axis.</summary>
	public TextureAddress AddressX;
	///<summary>The addressing mode to use for the Y axis.</summary>
	public TextureAddress AddressY;
	///<summary>The addressing mode to use for the Z axis.</summary>
	public TextureAddress AddressZ;
	///<summary>If enabled, the SparseVolumeTexture is only going to use the local DDC. For certain assets it might be reasonable to also use the remote DDC, but for larger assets this will mean long up- and download times.</summary>
	public bool bLocalDDCOnly;
	///<summary>AssetImportData</summary>
	public UAssetImportData AssetImportData;
	///<summary>Frames</summary>
	public TArray<USparseVolumeTextureFrame> Frames;
	///<summary>VolumeBoundsMin</summary>
	public FIntVector VolumeBoundsMin;
	///<summary>VolumeBoundsMax</summary>
	public FIntVector VolumeBoundsMax;
	///<summary>InitState</summary>
	public byte InitState;
}
