#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceGraph.h")]
public partial struct FOptimusGraphVariableDescription {
// OptimusGraphVariableDescription
	public string Name;
	public FShaderValueTypeHandle ValueType;
	public TArray<byte> Value;
	public int Offset;
}
