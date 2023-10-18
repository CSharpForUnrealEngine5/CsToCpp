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
