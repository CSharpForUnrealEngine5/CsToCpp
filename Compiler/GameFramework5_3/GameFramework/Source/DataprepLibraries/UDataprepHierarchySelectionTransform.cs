namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Return immediate children or all the descendants of the selected objects</summary>
[CppInclude("DataprepSelectionTransforms.h")]
public partial class UDataprepHierarchySelectionTransform : UDataprepSelectionTransform {
	public static UClass StaticClass() {return default;}
	///<summary>Specify policy of hierarchical parsing of selected objects</summary>
	public EDataprepHierarchySelectionPolicy SelectionPolicy;
}
