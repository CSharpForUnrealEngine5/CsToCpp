namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MapBuildDataRegistry.h")]
public partial class UMapBuildDataRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The lighting quality the level was last built with</summary>
	public ELightingBuildQuality LevelLightingQuality;
}
