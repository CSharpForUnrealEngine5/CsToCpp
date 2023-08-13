namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCControllerModifiedDescription {
	public TArray<FRCControllerDescription> Controllers;
	public TArray<string> ChangedValues;
}
