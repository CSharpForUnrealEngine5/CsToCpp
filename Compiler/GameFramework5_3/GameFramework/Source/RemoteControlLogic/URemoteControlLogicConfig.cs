namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Config class for Remote Control Logic related settings.</summary>
[CppInclude("RemoteControlLogicConfig.h")]
public partial class URemoteControlLogicConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>PropertyBag types that are supported for use as Controllers</summary>
	public TArray<EPropertyBagPropertyType> SupportedControllerTypes;
	///<summary>Certain types such as FVector / FRotator / FColor are specializations of UStructProperty</summary>
	public TArray<FName> SupportedControllerStructTypes;
	///<summary>Add specific Object types Class Paths to this list in order to provide support for them</summary>
	public TArray<FName> SupportedControllerObjectClassPaths;
	///<summary>Custom Controllers list. The elements in this list are used to generate customized versions of available controllers</summary>
	public TArray<FName> SupportedControllerCustomTypes;
}
