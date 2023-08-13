namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralEnumClasses.h")]
///<summary>It defines in which device (CPU, GPU) the desired operation (e.g., the neural network inference) is run.</summary>
public enum ENeuralDeviceType {
	CPU=0,
	GPU=1,
}
