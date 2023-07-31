#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A placeable actor that represents a planet atmosphere material and simulates sky and light scattering within it.</summary>
[CppInclude("Components/SkyAtmosphereComponent.h")]
public partial class ASkyAtmosphere : AInfo {
	///<summary>SkyAtmosphereComponent</summary>
	public USkyAtmosphereComponent SkyAtmosphereComponent;
	///<summary>Arrow component to indicate default sun rotation</summary>
	public UArrowComponent ArrowComponent;
}
