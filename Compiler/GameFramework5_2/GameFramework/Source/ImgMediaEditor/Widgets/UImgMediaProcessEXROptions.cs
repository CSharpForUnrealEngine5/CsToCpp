#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/ImgMediaProcessEXROptions.h")]
public partial class UImgMediaProcessEXROptions : UObject {
// ImgMediaProcessEXROptions
	public FFilePath InputPath;
	public FDirectoryPath OutputPath;
	public bool bEnableMipMapping;
	public bool bEnableTiling;
	public int TileSizeX;
	public int TileSizeY;
	public int NumThreads;
	public bool bUsePlayer;
	public int NumTilesX;
	public int NumTilesY;
	public bool bEnableMipLevelTint;
	public TArray<FLinearColor> MipLevelTints;
}
