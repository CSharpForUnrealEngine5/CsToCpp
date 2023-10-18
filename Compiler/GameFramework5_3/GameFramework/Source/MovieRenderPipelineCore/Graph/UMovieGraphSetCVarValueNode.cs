namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node which can set a specific console variable&#39;s value.</summary>
[CppInclude("Graph/Nodes/MovieGraphSetCVarValueNode.h")]
public partial class UMovieGraphSetCVarValueNode : UMovieGraphSettingNode {
	public static UClass StaticClass() {return default;}
	///<summary>bOverride_Name</summary>
	public bool bOverride_Name;
	///<summary>bOverride_Value</summary>
	public bool bOverride_Value;
	///<summary>The name of the CVar having its value set.</summary>
	public string Name;
	///<summary>The new value of the CVar.</summary>
	public string Value;
}
