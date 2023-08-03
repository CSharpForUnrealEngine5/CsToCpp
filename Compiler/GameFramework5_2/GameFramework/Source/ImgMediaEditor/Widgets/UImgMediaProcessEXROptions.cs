#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/ImgMediaProcessEXROptions.h")]
public partial class UImgMediaProcessEXROptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The directory that contains the image sequence files.</summary>
	public FFilePath InputPath;
	///<summary>The directory to output the processed image sequence files to.</summary>
	public FDirectoryPath OutputPath;
	///<summary>If checked, then enable mip mapping.</summary>
	public bool bEnableMipMapping;
	///<summary>If checked, then enable tiling.</summary>
	public bool bEnableTiling;
	///<summary>Width of a tile in pixels. If 0, then do not make tiles.</summary>
	public int TileSizeX;
	///<summary>Height of a tile in pixels. If 0, then do not make tiles.</summary>
	public int TileSizeY;
	///<summary>Number of threads to use when processing. If 0 then this number is set automatically.</summary>
	public int NumThreads;
	///<summary>Use a player to read in the image.</summary>
	public bool bUsePlayer;
	///<summary>Number of tiles in the X direction. If 0, then there are no tiles.</summary>
	public int NumTilesX;
	///<summary>Number of tiles in the Y direction. If 0, then there are no tiles.</summary>
	public int NumTilesY;
	///<summary>Tint each mip level a different colour to help with debugging.</summary>
	public bool bEnableMipLevelTint;
	///<summary>Colour to tint each mip level.</summary>
	public TArray<FLinearColor> MipLevelTints;
}
