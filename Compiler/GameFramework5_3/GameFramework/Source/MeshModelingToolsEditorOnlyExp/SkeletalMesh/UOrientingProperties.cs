namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UOrientingProperties</summary>
[CppInclude("SkeletalMesh/SkeletonEditingTool.h")]
public partial class UOrientingProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>bAutoOrient</summary>
	public bool bAutoOrient;
	///<summary>Options</summary>
	public FOrientOptions Options;
}
