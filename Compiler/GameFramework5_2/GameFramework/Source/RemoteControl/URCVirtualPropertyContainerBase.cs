#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RCVirtualPropertyContainer.h")]
///<summary>Container for more then one Virtual Property</summary>
public partial class URCVirtualPropertyContainerBase : UObject {
// RCVirtualPropertyContainerBase
	public FInstancedPropertyBag Bag;
	public TSet<URCVirtualPropertyBase> VirtualProperties;
	public TWeakObjectPtr<URemoteControlPreset> PresetWeakPtr;
}
