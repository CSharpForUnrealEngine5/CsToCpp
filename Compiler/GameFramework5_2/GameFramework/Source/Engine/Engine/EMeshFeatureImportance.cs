namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
///<summary>The importance of a mesh feature when automatically generating mesh LODs.</summary>
[CppEnumInNamespace]
public enum EMeshFeatureImportance {
	Off=0,
	Lowest=1,
	Low=2,
	Normal=3,
	High=4,
	Highest=5,
}
