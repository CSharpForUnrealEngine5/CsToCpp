#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DMXPixelMappingBaseComponent.h")]
///<summary>Base class for all DMX Pixel Mapping components.</summary>
public partial class UDMXPixelMappingBaseComponent : UObject {
// DMXPixelMappingBaseComponent
	public  void ResetDMX() {}
	public  void SendDMX() {}
	public  void Render() {}
	public  void RenderAndSendDMX() {}
	public TArray<UDMXPixelMappingBaseComponent> Children;
	public UDMXPixelMappingBaseComponent Parent_DEPRECATED;
	public TWeakObjectPtr<UDMXPixelMappingBaseComponent> WeakParent;
}
