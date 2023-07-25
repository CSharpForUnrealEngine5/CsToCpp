#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Fonts/CompositeFont.h")]
///<summary>Payload data describing an individual font in a typeface. Keep this lean as it's also used as a key!</summary>
public partial struct FFontData {
// FontData
	public string FontFilename;
	public EFontHinting Hinting;
	public EFontLoadingPolicy LoadingPolicy;
	public int SubFaceIndex;
	public UObject FontFaceAsset;
	public UFontBulkData BulkDataPtr_DEPRECATED;
	public TArray<byte> FontData_DEPRECATED;
}
