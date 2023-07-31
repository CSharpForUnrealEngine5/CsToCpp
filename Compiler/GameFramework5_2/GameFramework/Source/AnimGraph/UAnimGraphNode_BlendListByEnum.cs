#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_BlendListByEnum.h")]
public partial class UAnimGraphNode_BlendListByEnum : UAnimGraphNode_BlendListBase {
	///<summary>Node</summary>
	public FAnimNode_BlendListByEnum Node;
	///<summary>Name of the enum being switched on</summary>
	public UEnum BoundEnum;
	///<summary>VisibleEnumEntries</summary>
	public TArray<string> VisibleEnumEntries;
}
