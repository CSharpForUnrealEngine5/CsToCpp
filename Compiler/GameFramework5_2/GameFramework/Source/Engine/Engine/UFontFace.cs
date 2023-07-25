#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/FontFace.h")]
///<summary>A font face asset contains the raw payload data for a source TTF/OTF file as used by FreeType.</summary>
public partial class UFontFace : UObject {
// FontFace
	public string SourceFilename;
	public EFontHinting Hinting;
	public EFontLoadingPolicy LoadingPolicy;
	public EFontLayoutMethod LayoutMethod;
	public TArray<byte> FontFaceData_DEPRECATED;
	public TArray<string> SubFaces;
}
