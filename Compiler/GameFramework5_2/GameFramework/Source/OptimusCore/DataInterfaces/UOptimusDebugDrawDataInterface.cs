namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Interface for writing skinned mesh.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceDebugDraw.h")]
public partial class UOptimusDebugDrawDataInterface : UOptimusComputeDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>DebugDrawParameters</summary>
	public FOptimusDebugDrawParameters DebugDrawParameters;
}
