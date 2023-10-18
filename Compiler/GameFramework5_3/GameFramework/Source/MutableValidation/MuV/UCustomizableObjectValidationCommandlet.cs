namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuV/CustomizableObjectValidationCommandlet.h")]
public partial class UCustomizableObjectValidationCommandlet : UCommandlet {
	public static UClass StaticClass() {return default;}
	///<summary>Customizable Object to be tested</summary>
	public UCustomizableObject ToTestCustomizableObject;
	///<summary>Customizable Object Instance currently being updated</summary>
	public UCustomizableObjectInstance InstanceBeingUpdated;
	///<summary>Array of COI to be generated with randomized parameter values</summary>
	public TArray<UCustomizableObjectInstance> InstancesToProcess;
	///<summary>Callback invoked once the currently updating instance has done the update.</summary>
	public void OnInstanceUpdate(FUpdateContext Result) {}
}
