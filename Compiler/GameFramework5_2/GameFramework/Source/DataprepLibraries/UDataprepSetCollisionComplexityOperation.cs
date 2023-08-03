#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, set its collision complexity</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetCollisionComplexityOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Collision complexity</summary>
	public ECollisionTraceFlag CollisionTraceFlag;
}
