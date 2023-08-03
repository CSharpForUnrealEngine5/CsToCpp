#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all DMX Pixel Mapping components.</summary>
[CppInclude("Components/DMXPixelMappingBaseComponent.h")]
public partial class UDMXPixelMappingBaseComponent : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reset all sending DMX channels to 0 for this component and all children</summary>
	public  void ResetDMX() {}
	///<summary>Send DMX values of this component and all children.</summary>
	public  void SendDMX() {}
	///<summary>Render downsample texture for this component and all children</summary>
	public  void Render() {}
	///<summary>Render downsample texture and send DMX for this component and all children</summary>
	public  void RenderAndSendDMX() {}
	///<summary>Array of children belong to this component</summary>
	public TArray<UDMXPixelMappingBaseComponent> Children;
	///<summary>Parent component</summary>
	public UDMXPixelMappingBaseComponent Parent_DEPRECATED;
	///<summary>Parent component</summary>
	public TWeakObjectPtr<UDMXPixelMappingBaseComponent> WeakParent;
}
