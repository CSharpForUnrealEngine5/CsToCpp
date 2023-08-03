#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An instance of a UNeuralMorphNetwork.</summary>
[CppInclude("NeuralMorphNetwork.h")]
public partial class UNeuralMorphNetworkInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The neural network this is an instance of.</summary>
	public UNeuralMorphNetwork Network;
}
