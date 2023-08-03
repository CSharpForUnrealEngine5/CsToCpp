#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomImportOptions.h")]
public partial class UGroomImportOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ConversionSettings</summary>
	public FGroomConversionSettings ConversionSettings;
	///<summary>Interpolation settings per group</summary>
	public TArray<FHairGroupsInterpolation> InterpolationSettings;
}
