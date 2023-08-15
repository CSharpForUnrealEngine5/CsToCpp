namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_BlendListByEnum.h")]
public partial class UAnimGraphNode_BlendListByEnum : UAnimGraphNode_BlendListBase {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_BlendListByEnum Node;
	///<summary>Name of the enum being switched on</summary>
	public UEnum BoundEnum;
	///<summary>VisibleEnumEntries</summary>
	public TArray<FName> VisibleEnumEntries;
}
