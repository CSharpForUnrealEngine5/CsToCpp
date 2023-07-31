#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remote Control Virtual Property which is stores in container with many properties</summary>
[CppInclude("RCVirtualProperty.h")]
public partial class URCVirtualPropertyInContainer : URCVirtualPropertyBase {
	///<summary>Pointer to container where stores Virtual Properties</summary>
	public TWeakObjectPtr<URCVirtualPropertyContainerBase> ContainerWeakPtr;
}
