namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSSettings.h")]
public partial class UMaterialBlendSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Package name for Material Blend instance.</summary>
	public string BlendedMaterialName;
	///<summary>Destination path for Material Blend instance.</summary>
	public FDirectoryPath BlendedMaterialPath;
}
