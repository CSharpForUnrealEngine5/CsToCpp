namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceCustomComputeKernel.h")]
public partial class UOptimusCustomComputeKernelDataInterface : UComputeDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>ComponentSourceBinding</summary>
	public TWeakObjectPtr<UOptimusComponentSourceBinding> ComponentSourceBinding;
	///<summary>NumThreadsExpression</summary>
	public string NumThreadsExpression;
}
