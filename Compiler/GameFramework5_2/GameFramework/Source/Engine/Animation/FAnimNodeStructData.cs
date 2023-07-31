#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about editor-side struct property indices.</summary>
[CppInclude("Animation/AnimNodeData.h")]
public partial struct FAnimNodeStructData {
	public TMap<string,int> NameToIndexMap;
	public int NumProperties;
}
