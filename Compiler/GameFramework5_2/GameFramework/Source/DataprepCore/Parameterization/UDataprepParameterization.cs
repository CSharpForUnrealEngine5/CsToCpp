#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Parameterization/DataprepParameterization.h")]
///<summary>The DataprepParameterization contains the data for the parameterization of a pipeline</summary>
public partial class UDataprepParameterization : UObject {
// DataprepParameterization
	public UDataprepParameterizationBindings BindingsContainer;
	public UClass CustomContainerClass;
	public UDataprepParameterizableObject DefaultParameterisation;
	public TArray<byte> ParameterizationStorage;
}
