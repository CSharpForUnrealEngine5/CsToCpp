#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperations.h")]
///<summary>For each actor in the input set, offset its position/rotation/scale with random vector generated from X/Y/Z Min-Max.</summary>
public partial class UDataprepRandomizeTransformOperation : UDataprepOperation {
// DataprepRandomizeTransformOperation
	public ERandomizeTransformType TransformType;
	public ERandomizeTransformReferenceFrame ReferenceFrame;
	public FVector Min;
	public FVector Max;
}
