namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Enumerates available options for the translucency sort policy.</summary>
[CppEnumInNamespace]
public enum ETranslucentSortPolicy {
	SortByDistance=0,
	SortByProjectedZ=1,
	SortAlongAxis=2,
}
