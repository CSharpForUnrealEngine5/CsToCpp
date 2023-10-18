namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for more then one Virtual Property</summary>
[CppInclude("RCVirtualPropertyContainer.h")]
public partial class URCVirtualPropertyContainerBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Holds bag of properties.</summary>
	public FInstancedPropertyBag Bag;
	///<summary>Set of the virtual properties</summary>
	public TSet<URCVirtualPropertyBase> VirtualProperties;
	///<summary>Pointer to Remote Control Preset</summary>
	public TWeakObjectPtr<URemoteControlPreset> PresetWeakPtr;
}
