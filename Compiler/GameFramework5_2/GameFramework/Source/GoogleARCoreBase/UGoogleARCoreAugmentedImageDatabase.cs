namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A collection of processed images for ARCore to track.</summary>
[CppInclude("GoogleARCoreAugmentedImageDatabase.h")]
public partial class UGoogleARCoreAugmentedImageDatabase : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>AddRuntimeAugmentedImageFromTexture</summary>
	public int AddRuntimeAugmentedImageFromTexture(UTexture2D ImageTexture,string ImageName,float ImageWidthInMeter/*=0f*/) { return default; }
	///<summary>The individual instances of</summary>
	public TArray<FGoogleARCoreAugmentedImageDatabaseEntry> Entries;
	///<summary>The serialized database, in the ARCore augmented image database</summary>
	public TArray<byte> SerializedDatabase;
}
