namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectMipDataProvider.h")]
public partial class UMutableTextureMipDataProviderFactory : UTextureMipDataProviderFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Todo: Simplify by replacing the reference to the Instance with some static parametrization or hash with enough info to reconstruct the texture</summary>
	public UCustomizableObjectInstance CustomizableObjectInstance;
}
