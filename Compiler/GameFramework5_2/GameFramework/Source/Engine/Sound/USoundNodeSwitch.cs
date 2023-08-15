namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects a child node based on the value of a integer parameter</summary>
[CppInclude("Sound/SoundNodeSwitch.h")]
public partial class USoundNodeSwitch : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the integer parameter to use to determine which branch we should take</summary>
	public FName IntParameterName;
}
