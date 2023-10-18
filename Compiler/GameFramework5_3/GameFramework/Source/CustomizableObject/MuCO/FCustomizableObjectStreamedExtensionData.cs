namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to store extension data that can be streamed in and out from an external package.</summary>
[CppInclude("MuCO/CustomizableObjectStreamedExtensionData.h")]
public partial struct FCustomizableObjectStreamedExtensionData {
	public TSoftObjectPtr<UCustomizableObjectExtensionDataContainer> ContainerPath;
	public UCustomizableObjectExtensionDataContainer Container;
}
