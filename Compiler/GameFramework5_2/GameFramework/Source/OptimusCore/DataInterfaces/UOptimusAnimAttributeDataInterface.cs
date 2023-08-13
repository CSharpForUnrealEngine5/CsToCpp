namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Interface for reading animation attributes on skeletal mesh.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceAnimAttribute.h")]
public partial class UOptimusAnimAttributeDataInterface : UOptimusComputeDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>AttributeArray</summary>
	public FOptimusAnimAttributeArray AttributeArray;
}
