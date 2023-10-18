namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Framework/Views/ITypedTableView.h")]
///<summary>Lists can exist as regular lists or as backing widgets for a tree.</summary>
[CppEnumInNamespace]
public enum ETableViewMode {
	List=0,
	Tile=1,
	Tree=2,
}
