namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceRawBuffer.h")]
public partial class UOptimusRawBufferDataInterface : UOptimusComputeDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>The value type we should be allocating elements for</summary>
	public FShaderValueTypeHandle ValueType;
	///<summary>The data domain this buffer covers</summary>
	public FOptimusDataDomain DataDomain;
	///<summary>The component source to query component domain validity and sizing</summary>
	public TWeakObjectPtr<UOptimusComponentSourceBinding> ComponentSourceBinding;
}
