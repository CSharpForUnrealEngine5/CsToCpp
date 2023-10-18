namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the ImagePlate plugin.</summary>
[CppInclude("ImagePlateFileSequence.h")]
public partial class UImagePlateSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Specifies a sub-directory to append to any image plate file sequences</summary>
	public string ProxyName;
}
