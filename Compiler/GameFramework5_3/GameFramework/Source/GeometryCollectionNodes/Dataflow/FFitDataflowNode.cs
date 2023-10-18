namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fits a value from one range to another</summary>
[CppInclude("Dataflow/GeometryCollectionMathNodes.h")]
public partial struct FFitDataflowNode {
	public float Float;
	public float OldMin;
	public float OldMax;
	public float NewMin;
	public float NewMax;
	public float ReturnValue;
}
