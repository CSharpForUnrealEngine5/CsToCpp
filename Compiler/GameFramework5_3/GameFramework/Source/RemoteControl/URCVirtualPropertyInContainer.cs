namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remote Control Virtual Property which is stores in container with many properties</summary>
[CppInclude("RCVirtualProperty.h")]
public partial class URCVirtualPropertyInContainer : URCVirtualPropertyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to container where stores Virtual Properties</summary>
	public TWeakObjectPtr<URCVirtualPropertyContainerBase> ContainerWeakPtr;
}
