#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for loading and initializing state configuration</summary>
[CppInclude("Net/Core/Connection/StateStruct.h")]
public partial class UStatePerObjectConfig : UObject {
	///<summary>Overrides the config section name, using the CDO</summary>
	public string PerObjectConfigSection;
	///<summary>Whether or not this state configuration instance is enabled (states will not load, if not)</summary>
	public bool bEnabled;
}
