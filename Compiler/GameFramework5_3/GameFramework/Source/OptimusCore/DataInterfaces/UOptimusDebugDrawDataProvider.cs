namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for writing skinned mesh.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceDebugDraw.h")]
public partial class UOptimusDebugDrawDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>PrimitiveComponent</summary>
	public UPrimitiveComponent PrimitiveComponent;
	///<summary>DebugDrawParameters</summary>
	public FOptimusDebugDrawParameters DebugDrawParameters;
}
