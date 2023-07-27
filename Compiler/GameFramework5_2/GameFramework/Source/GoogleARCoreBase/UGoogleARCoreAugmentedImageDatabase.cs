#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreAugmentedImageDatabase.h")]
///<summary>A collection of processed images for ARCore to track.</summary>
public partial class UGoogleARCoreAugmentedImageDatabase : UDataAsset {
// GoogleARCoreAugmentedImageDatabase
	public  int AddRuntimeAugmentedImageFromTexture(UTexture2D ImageTexture,string ImageName,float ImageWidthInMeter/*=0f*/) { return default; }
	public TArray<FGoogleARCoreAugmentedImageDatabaseEntry> Entries;
	public TArray<byte> SerializedDatabase;
}
