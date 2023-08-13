namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parent class for DMX sending components</summary>
[CppInclude("Components/DMXPixelMappingOutputDMXComponent.h")]
public partial class UDMXPixelMappingOutputDMXComponent : UDMXPixelMappingOutputComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Render input texture for downsample texture, donwsample and send DMX for this component</summary>
	public virtual void RenderWithInputAndSendDMX() {}
}
