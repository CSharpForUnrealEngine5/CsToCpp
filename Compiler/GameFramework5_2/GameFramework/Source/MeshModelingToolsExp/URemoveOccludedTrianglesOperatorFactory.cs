namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory with enough info to spawn the background-thread Operator to do a chunk of work for the tool</summary>
[CppInclude("RemoveOccludedTrianglesTool.h")]
public partial class URemoveOccludedTrianglesOperatorFactory : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Tool</summary>
	public URemoveOccludedTrianglesTool Tool;
}
