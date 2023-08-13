namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for reading groom.</summary>
[CppInclude("Deformer/DeformerDataInterfaceGroom.h")]
public partial class UOptimusGroomDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>Groom</summary>
	public UGroomComponent Groom;
}
