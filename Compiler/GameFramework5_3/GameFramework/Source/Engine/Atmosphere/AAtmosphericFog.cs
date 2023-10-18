namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A placeable fog actor that simulates atmospheric light scattering</summary>
[CppInclude("Atmosphere/AtmosphericFog.h")]
public partial class AAtmosphericFog : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>Main fog component</summary>
	public UAtmosphericFogComponent AtmosphericFogComponent;
	///<summary>Arrow component to indicate default sun rotation</summary>
	public UArrowComponent ArrowComponent;
}
