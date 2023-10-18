namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for writing skinned mesh.</summary>
[CppInclude("Deformer/DeformerDataInterfaceGroomWrite.h")]
public partial class UOptimusGroomWriteDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>GroomComponent</summary>
	public UGroomComponent GroomComponent;
}
