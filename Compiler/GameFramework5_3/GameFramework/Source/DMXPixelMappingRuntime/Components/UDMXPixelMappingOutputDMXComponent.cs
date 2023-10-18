namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for components that contain a fixture patch to send DMX.</summary>
[CppInclude("Components/DMXPixelMappingOutputDMXComponent.h")]
public partial class UDMXPixelMappingOutputDMXComponent : UDMXPixelMappingOutputComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The quality level to use when averaging colors during downsampling.</summary>
	public EDMXPixelBlendingQuality CellBlendingQuality;
	///<summary>FixturePatchRef</summary>
	public FDMXEntityFixturePatchRef FixturePatchRef;
	///<summary>Sets which color space Pixel Mapping sends</summary>
	public UClass ColorSpaceClass;
	///<summary>The Color Space currently in use</summary>
	public UDMXPixelMappingColorSpace ColorSpace;
	///<summary>Modulators applied to the output before sending DMX</summary>
	public TArray<UClass> ModulatorClasses;
	///<summary>The actual modulator instances</summary>
	public TArray<UDMXModulator> Modulators;
	///<summary>RenderWithInputAndSendDMX</summary>
	public virtual void RenderWithInputAndSendDMX() {}
}
