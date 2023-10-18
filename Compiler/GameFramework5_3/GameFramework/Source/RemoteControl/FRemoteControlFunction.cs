namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a function exposed to remote control.</summary>
[CppInclude("RemoteControlField.h")]
public partial struct FRemoteControlFunction {
	public UFunction Function_DEPRECATED;
	public bool bIsCallableInPackaged;
	public FSoftObjectPath FunctionPath;
}
