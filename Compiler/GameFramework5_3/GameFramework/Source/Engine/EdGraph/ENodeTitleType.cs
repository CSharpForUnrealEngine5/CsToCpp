namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphNode.h")]
///<summary>Enum to indicate what sort of title we want.</summary>
[CppEnumInNamespace]
public enum ENodeTitleType {
	FullTitle=0,
	ListView=1,
	EditableTitle=2,
	MenuTitle=3,
	MAX_TitleTypes=4,
}
