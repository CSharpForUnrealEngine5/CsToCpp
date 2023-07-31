#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A placeable fog actor that simulates atmospheric light scattering</summary>
[CppInclude("Atmosphere/AtmosphericFog.h")]
public partial class AAtmosphericFog : AInfo {
	///<summary>Main fog component</summary>
	public UAtmosphericFogComponent AtmosphericFogComponent;
	///<summary>Arrow component to indicate default sun rotation</summary>
	public UArrowComponent ArrowComponent;
}
