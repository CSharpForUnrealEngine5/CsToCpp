#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Root component in the components tree</summary>
[CppInclude("Components/DMXPixelMappingRootComponent.h")]
public partial class UDMXPixelMappingRootComponent : UDMXPixelMappingBaseComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Chached Renderer Component names and their actual object pointer. Useful to speed up access (see DMXPixelMappingSubsystem)</summary>
	public TMap<string,UDMXPixelMappingRendererComponent> CachedRendererComponentsByName;
}
