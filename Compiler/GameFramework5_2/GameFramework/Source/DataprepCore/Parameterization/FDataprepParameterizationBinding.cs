#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The parameterization binding is a struct that hold an object and the property path to the parameterized property</summary>
[CppInclude("Parameterization/DataprepParameterization.h")]
public partial struct FDataprepParameterizationBinding {
	public UDataprepParameterizableObject ObjectBinded;
	public TArray<FDataprepPropertyLink> PropertyChain;
}
