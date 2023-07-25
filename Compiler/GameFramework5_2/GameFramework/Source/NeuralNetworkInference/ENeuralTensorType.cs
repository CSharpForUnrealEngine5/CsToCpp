#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralEnumClasses.h")]
///<summary>The type of the neural tensor. E.g., a Weight tensor will be read-only and never modified, an Input tensor will be modified by the user, an</summary>
public enum ENeuralTensorType {
	Generic=0,
	Input=1,
	IntermediateNotInitialized=2,
	IntermediateInitialized=3,
	Output=4,
	Weight=5,
}
