namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all DMX Pixel Mapping components.</summary>
[CppInclude("Components/DMXPixelMappingBaseComponent.h")]
public partial class UDMXPixelMappingBaseComponent : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reset all sending DMX channels to 0 for this component and all children</summary>
	public virtual void ResetDMX() {}
	///<summary>Send DMX values of this component and all children.</summary>
	public virtual void SendDMX() {}
	///<summary>Render downsample texture for this component and all children</summary>
	public virtual void Render() {}
	///<summary>Render downsample texture and send DMX for this component and all children</summary>
	public virtual void RenderAndSendDMX() {}
	///<summary>bExpanded</summary>
	public bool bExpanded;
	///<summary>Array of children belong to this component</summary>
	public TArray<UDMXPixelMappingBaseComponent> Children;
	///<summary>Parent component</summary>
	public UDMXPixelMappingBaseComponent Parent_DEPRECATED;
	///<summary>Custom user name for the component. Should be used if set.</summary>
	public string UserName;
	///<summary>Parent component</summary>
	public TWeakObjectPtr<UDMXPixelMappingBaseComponent> WeakParent;
}
