#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A font face asset contains the raw payload data for a source TTF/OTF file as used by FreeType.</summary>
[CppInclude("Engine/FontFace.h")]
public partial class UFontFace : UObject {
	///<summary>The filename of the font face we were created from. This may not always exist on disk, as we may have previously loaded and cached the font data inside this asset.</summary>
	public string SourceFilename;
	///<summary>The hinting algorithm to use with the font face.</summary>
	public EFontHinting Hinting;
	///<summary>Enum controlling how this font face should be loaded at runtime. See the enum for more explanations of the options.</summary>
	public EFontLoadingPolicy LoadingPolicy;
	///<summary>Which method should we use when laying out the font? Try changing this if you notice clipping or height issues with your font.</summary>
	public EFontLayoutMethod LayoutMethod;
	///<summary>The data associated with the font face. This should always be filled in providing the source filename is valid.</summary>
	public TArray<byte> FontFaceData_DEPRECATED;
	///<summary>Transient cache of the sub-faces available within this face</summary>
	public TArray<string> SubFaces;
}
