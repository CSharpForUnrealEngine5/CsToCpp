namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node which can get a specific console variable&#39;s value.</summary>
[CppInclude("Graph/Nodes/MovieGraphGetCVarValueNode.h")]
public partial class UMovieGraphGetCVarValueNode : UMovieGraphSettingNode {
	public static UClass StaticClass() {return default;}
	///<summary>bOverride_Name</summary>
	public bool bOverride_Name;
	///<summary>The name of the CVar that will have its value fetched.</summary>
	public string Name;
}
