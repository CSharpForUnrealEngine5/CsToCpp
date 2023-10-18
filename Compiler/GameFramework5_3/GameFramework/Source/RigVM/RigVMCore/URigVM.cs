namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The RigVM is the main object for evaluating FRigVMByteCode instructions.</summary>
[CppInclude("RigVMCore/RigVM.h")]
public partial class URigVM : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Executes the VM.</summary>
	public virtual bool Execute(FRigVMExtendedExecuteContext Context,FName InEntryName/*=NAME_None*/) { return default; }
	///<summary>Add a function for execute instructions to this VM.</summary>
	public virtual int AddRigVMFunction(UScriptStruct InRigVMStruct,FName InMethodName) { return default; }
	///<summary>Returns the name of a function given its index</summary>
	public virtual string GetRigVMFunctionName(int InFunctionIndex) { return default; }
	///<summary>WorkMemoryStorageObject</summary>
	public URigVMMemoryStorage WorkMemoryStorageObject;
	///<summary>LiteralMemoryStorageObject</summary>
	public URigVMMemoryStorage LiteralMemoryStorageObject;
	///<summary>DebugMemoryStorageObject</summary>
	public URigVMMemoryStorage DebugMemoryStorageObject;
	///<summary>The byte code of the VM</summary>
	public FRigVMByteCode ByteCodeStorage;
	///<summary>GetParameterValueBool</summary>
	public bool GetParameterValueBool(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueFloat</summary>
	public float GetParameterValueFloat(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueDouble</summary>
	public double GetParameterValueDouble(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueInt</summary>
	public int GetParameterValueInt(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueName</summary>
	public FName GetParameterValueName(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueString</summary>
	public string GetParameterValueString(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueVector2D</summary>
	public FVector2D GetParameterValueVector2D(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueVector</summary>
	public FVector GetParameterValueVector(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueQuat</summary>
	public FQuat GetParameterValueQuat(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueTransform</summary>
	public FTransform GetParameterValueTransform(FName InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>SetParameterValueBool</summary>
	public void SetParameterValueBool(FName InParameterName,bool InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueFloat</summary>
	public void SetParameterValueFloat(FName InParameterName,float InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueDouble</summary>
	public void SetParameterValueDouble(FName InParameterName,double InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueInt</summary>
	public void SetParameterValueInt(FName InParameterName,int InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueName</summary>
	public void SetParameterValueName(FName InParameterName,FName InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueString</summary>
	public void SetParameterValueString(FName InParameterName,string InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueVector2D</summary>
	public void SetParameterValueVector2D(FName InParameterName,FVector2D InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueVector</summary>
	public void SetParameterValueVector(FName InParameterName,FVector InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueQuat</summary>
	public void SetParameterValueQuat(FName InParameterName,FQuat InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueTransform</summary>
	public void SetParameterValueTransform(FName InParameterName,FTransform InValue,int InArrayIndex/*=0*/) {}
	///<summary>returns the statistics information</summary>
	public FRigVMStatistics GetStatistics() { return default; }
	///<summary>Instructions</summary>
	public FRigVMInstructionArray Instructions;
	///<summary>NumExecutions_DEPRECATED</summary>
	public uint NumExecutions_DEPRECATED;
	///<summary>FunctionNamesStorage</summary>
	public TArray<FName> FunctionNamesStorage;
	///<summary>Parameters</summary>
	public TArray<FRigVMParameter> Parameters;
	///<summary>ParametersNameMap</summary>
	public TMap<FName,int> ParametersNameMap;
	///<summary>DeferredVMToCopy</summary>
	public URigVM DeferredVMToCopy;
}
