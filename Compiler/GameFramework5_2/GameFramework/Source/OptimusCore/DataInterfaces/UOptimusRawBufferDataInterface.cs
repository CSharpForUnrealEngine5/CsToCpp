#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceRawBuffer.h")]
public partial class UOptimusRawBufferDataInterface : UOptimusComputeDataInterface {
// OptimusRawBufferDataInterface
	public FShaderValueTypeHandle ValueType;
	public FOptimusDataDomain DataDomain;
	public TWeakObjectPtr<UOptimusComponentSourceBinding> ComponentSourceBinding;
}
