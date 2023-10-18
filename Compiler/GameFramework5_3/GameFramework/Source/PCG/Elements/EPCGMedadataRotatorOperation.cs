namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataRotatorOpElement.h")]
public enum EPCGMedadataRotatorOperation {
	RotatorOp=0,
	Combine=1,
	Invert=2,
	Lerp=3,
	Normalize=4,
	TransformOp=100,
	TransformRotation=101,
	InverseTransformRotation=102,
}