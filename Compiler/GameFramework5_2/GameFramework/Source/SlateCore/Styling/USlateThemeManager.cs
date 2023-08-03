#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/StyleColors.h")]
public partial class USlateThemeManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CurrentThemeId</summary>
	public FGuid CurrentThemeId;
	///<summary>ActiveColors</summary>
	public FStyleColorList ActiveColors;
}
