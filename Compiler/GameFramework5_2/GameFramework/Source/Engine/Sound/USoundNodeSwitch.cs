#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects a child node based on the value of a integer parameter</summary>
[CppInclude("Sound/SoundNodeSwitch.h")]
public partial class USoundNodeSwitch : USoundNode {
	///<summary>The name of the integer parameter to use to determine which branch we should take</summary>
	public string IntParameterName;
}
