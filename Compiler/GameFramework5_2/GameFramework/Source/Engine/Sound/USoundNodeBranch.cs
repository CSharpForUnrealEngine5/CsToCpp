namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects a child node based on the value of a boolean parameter</summary>
[CppInclude("Sound/SoundNodeBranch.h")]
public partial class USoundNodeBranch : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the boolean parameter to use to determine which branch we should take</summary>
	public string BoolParameterName;
}
