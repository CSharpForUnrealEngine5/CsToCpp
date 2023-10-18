namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor used to position a local fog volume in the scene.</summary>
[CppInclude("Engine/LocalHeightFog.h")]
public partial class ALocalHeightFog : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>Object used to visualize the local fog volume</summary>
	public ULocalHeightFogComponent LocalHeightFogVolume;
}
