namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each actor in the input set, offset its position/rotation/scale with random vector generated from X/Y/Z Min-Max.</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepRandomizeTransformOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Transform component to randomize</summary>
	public ERandomizeTransformType TransformType;
	///<summary>Reference frame to use (relative/world)</summary>
	public ERandomizeTransformReferenceFrame ReferenceFrame;
	///<summary>Min random value</summary>
	public FVector Min;
	///<summary>Max random value</summary>
	public FVector Max;
}
