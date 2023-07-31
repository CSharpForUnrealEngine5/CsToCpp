#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Text3DEngineSubsystem.h")]
public partial class UText3DEngineSubsystem : UEngineSubsystem {
	///<summary>DefaultMaterial</summary>
	public UMaterial DefaultMaterial;
	///<summary>CachedFonts</summary>
	public TMap<uint,FCachedFontData> CachedFonts;
}
