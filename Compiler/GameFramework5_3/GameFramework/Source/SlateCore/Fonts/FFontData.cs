namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Payload data describing an individual font in a typeface. Keep this lean as it&#39;s also used as a key!</summary>
[CppInclude("Fonts/CompositeFont.h")]
public partial struct FFontData {
	public string FontFilename;
	public EFontHinting Hinting;
	public EFontLoadingPolicy LoadingPolicy;
	public int SubFaceIndex;
	public UObject FontFaceAsset;
	public UFontBulkData BulkDataPtr_DEPRECATED;
	public TArray<byte> FontData_DEPRECATED;
}
