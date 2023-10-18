namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about editor-side struct property indices.</summary>
[CppInclude("Animation/AnimNodeData.h")]
public partial struct FAnimNodeStructData {
	public TMap<FName,int> NameToIndexMap;
	public int NumProperties;
}
