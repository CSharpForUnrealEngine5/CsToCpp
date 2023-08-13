namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Text3DEngineSubsystem.h")]
public partial class UText3DEngineSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultMaterial</summary>
	public UMaterial DefaultMaterial;
	///<summary>CachedFonts</summary>
	public TMap<uint,FCachedFontData> CachedFonts;
}
