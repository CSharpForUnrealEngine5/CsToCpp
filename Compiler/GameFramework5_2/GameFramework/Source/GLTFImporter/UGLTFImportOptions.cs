#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GLTFImportOptions.h")]
public partial class UGLTFImportOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Generate new UV coordinates for lightmapping instead of using the highest index UV set. </summary>
	public bool bGenerateLightmapUVs;
	///<summary>Scale factor used for importing assets, by default: 100, for conversion from meters(glTF) to centimeters(Unreal default).</summary>
	public float ImportScale;
}
