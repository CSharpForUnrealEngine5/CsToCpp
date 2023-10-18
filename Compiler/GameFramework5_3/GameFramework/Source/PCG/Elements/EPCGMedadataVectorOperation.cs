namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataVectorOpElement.h")]
public enum EPCGMedadataVectorOperation {
	VectorOp=0,
	Cross=1,
	Dot=2,
	Distance=3,
	Normalize=4,
	Length=5,
	RotateAroundAxis=6,
	TransformOp=100,
	TransformDirection=101,
	TransformLocation=102,
	InverseTransformDirection=103,
	InverseTransformLocation=104,
}
