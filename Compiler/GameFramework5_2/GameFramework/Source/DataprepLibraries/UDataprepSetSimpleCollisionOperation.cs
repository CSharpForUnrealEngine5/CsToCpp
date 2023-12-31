namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, replace the existing static mesh&#39;s collision setup with a simple one based on selected shape</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetSimpleCollisionOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Shape&#39;s of the collision geometry encompassing the static mesh</summary>
	public EScriptCollisionShapeType ShapeType;
}
