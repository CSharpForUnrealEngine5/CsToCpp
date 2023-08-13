namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Parameterization/DataprepParameterization.h")]
public partial class UDataprepParameterizationInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The parameterization from which this instance was constructed</summary>
	public UDataprepParameterization SourceParameterization;
	///<summary>The actual object on which the parameterization data is stored</summary>
	public UObject ParameterizationInstance;
	///<summary>This is used only to store a serialization of the values of the parameterization since we can&#39;t save the custom class</summary>
	public TArray<byte> ParameterizationInstanceStorage;
}
