#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/TrueTypeFontFactory.h")]
public partial class UTrueTypeFontFactory : UTextureFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Import options for the font</summary>
	public UFontImportOptions ImportOptions;
	///<summary>True when the font dialog was shown for this factory during the non-legacy creation process</summary>
	public bool bPropertiesConfigured;
	///<summary>True if a font was selected during the non-legacy creation process</summary>
	public bool bFontSelected;
}
