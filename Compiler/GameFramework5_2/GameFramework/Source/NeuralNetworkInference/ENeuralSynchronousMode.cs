#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralEnumClasses.h")]
///<summary>Whether the operation (e.g., UNeuralNetwork::Run()) will run in the calling thread (Synchronous) or in a background thread (Asynchronous).</summary>
public enum ENeuralSynchronousMode {
	Synchronous=0,
	Asynchronous=1,
}
