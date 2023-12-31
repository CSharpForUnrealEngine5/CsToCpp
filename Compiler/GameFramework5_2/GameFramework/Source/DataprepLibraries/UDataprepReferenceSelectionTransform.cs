namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Return assets directly used/referenced by the selected objects.</summary>
[CppInclude("DataprepSelectionTransforms.h")]
public partial class UDataprepReferenceSelectionTransform : UDataprepSelectionTransform {
	public static UClass StaticClass() {return default;}
	///<summary>Include assets referenced/used by assets directly referenced/used by selected objects</summary>
	public bool bAllowIndirectReferences;
}
