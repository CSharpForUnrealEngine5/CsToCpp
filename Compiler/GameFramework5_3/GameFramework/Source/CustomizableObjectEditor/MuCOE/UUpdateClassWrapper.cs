namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper UObject class for the UCustomizableObjectInstance::FObjectInstanceUpdatedDelegate dynamic multicast delegate</summary>
[CppInclude("MuCOE/CustomizableObjectEditor.h")]
public partial class UUpdateClassWrapper : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Method to assign for the callback</summary>
	public void DelegatedCallback(UCustomizableObjectInstance Instance) {}
}
