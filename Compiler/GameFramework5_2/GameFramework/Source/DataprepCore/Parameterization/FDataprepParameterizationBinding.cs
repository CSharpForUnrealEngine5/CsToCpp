#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Parameterization/DataprepParameterization.h")]
///<summary>The parameterization binding is a struct that hold an object and the property path to the parameterized property</summary>
public partial struct FDataprepParameterizationBinding {
// DataprepParameterizationBinding
	public UDataprepParameterizableObject ObjectBinded;
	public TArray<FDataprepPropertyLink> PropertyChain;
}
