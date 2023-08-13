namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The DataprepParameterization contains the data for the parameterization of a pipeline</summary>
[CppInclude("Parameterization/DataprepParameterization.h")]
public partial class UDataprepParameterization : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The containers for the bindings</summary>
	public UDataprepParameterizationBindings BindingsContainer;
	///<summary>CustomContainerClass</summary>
	public UClass CustomContainerClass;
	///<summary>DefaultParameterisation</summary>
	public UDataprepParameterizableObject DefaultParameterisation;
	///<summary>This is used only to store a serialization of the values of the parameterization since we can&#39;t save our custom container class</summary>
	public TArray<byte> ParameterizationStorage;
}
