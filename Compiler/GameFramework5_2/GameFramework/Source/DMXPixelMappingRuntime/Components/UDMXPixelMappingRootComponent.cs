#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DMXPixelMappingRootComponent.h")]
///<summary>Root component in the components tree</summary>
public partial class UDMXPixelMappingRootComponent : UDMXPixelMappingBaseComponent {
// DMXPixelMappingRootComponent
	public TMap<string,UDMXPixelMappingRendererComponent> CachedRendererComponentsByName;
}
