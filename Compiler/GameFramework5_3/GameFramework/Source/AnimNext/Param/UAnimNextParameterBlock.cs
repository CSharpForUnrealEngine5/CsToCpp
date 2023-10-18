namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset used to define AnimNext parameters and their bindings</summary>
[CppInclude("Param/AnimNextParameterBlock.h")]
public partial class UAnimNextParameterBlock : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>RigVM</summary>
	public URigVM RigVM;
	///<summary>ExtendedExecuteContext</summary>
	public FRigVMExtendedExecuteContext ExtendedExecuteContext;
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>PropertyBag</summary>
	public FInstancedPropertyBag PropertyBag;
	///<summary>EditorData</summary>
	public UObject EditorData;
}
