namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Experimental - Weld edges of input meshes</summary>
[CppInclude("DataprepGeometryOperations.h")]
public partial class UDataprepWeldEdgesOperation : UDataprepEditingOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Merge search tolerance</summary>
	public float Tolerance;
	///<summary>Apply to only unique pairs</summary>
	public bool bOnlyUnique;
}
