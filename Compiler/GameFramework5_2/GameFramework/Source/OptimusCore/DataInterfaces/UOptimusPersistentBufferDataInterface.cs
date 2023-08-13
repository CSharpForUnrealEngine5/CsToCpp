namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Interface for a transient buffer.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceRawBuffer.h")]
public partial class UOptimusPersistentBufferDataInterface : UOptimusRawBufferDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>ResourceName</summary>
	public string ResourceName;
}
