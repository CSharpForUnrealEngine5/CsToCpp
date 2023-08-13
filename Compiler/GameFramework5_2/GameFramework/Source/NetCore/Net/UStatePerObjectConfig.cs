namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for loading and initializing state configuration</summary>
[CppInclude("Net/Core/Connection/StateStruct.h")]
public partial class UStatePerObjectConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Overrides the config section name, using the CDO</summary>
	public string PerObjectConfigSection;
	///<summary>Whether or not this state configuration instance is enabled (states will not load, if not)</summary>
	public bool bEnabled;
}
