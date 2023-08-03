#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Config class for Remote Control Logic related settings.</summary>
[CppInclude("RemoteControlLogicConfig.h")]
public partial class URemoteControlLogicConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>PropertyBag types that are supported for use as Controllers</summary>
	public TArray<EPropertyBagPropertyType> SupportedControllerTypes;
	///<summary>Certain types such as FVector / FRotator / FColor are specializations of UStructProperty</summary>
	public TArray<string> SupportedControllerStructTypes;
}
