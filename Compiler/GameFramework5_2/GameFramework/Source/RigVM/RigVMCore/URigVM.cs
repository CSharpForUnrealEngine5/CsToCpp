#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The RigVM is the main object for evaluating FRigVMByteCode instructions.</summary>
[CppInclude("RigVMCore/RigVM.h")]
public partial class URigVM : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Executes the VM.</summary>
	public  bool Execute(string InEntryName/*=NAME_None*/) { return default; }
	///<summary>Add a function for execute instructions to this VM.</summary>
	public  int AddRigVMFunction(UScriptStruct InRigVMStruct,string InMethodName) { return default; }
	///<summary>Returns the name of a function given its index</summary>
	public  string GetRigVMFunctionName(int InFunctionIndex) { return default; }
	///<summary>WorkMemoryStorageObject</summary>
	public URigVMMemoryStorage WorkMemoryStorageObject;
	///<summary>LiteralMemoryStorageObject</summary>
	public URigVMMemoryStorage LiteralMemoryStorageObject;
	///<summary>DebugMemoryStorageObject</summary>
	public URigVMMemoryStorage DebugMemoryStorageObject;
	///<summary>The byte code of the VM</summary>
	public FRigVMByteCode ByteCodeStorage;
	///<summary>GetParameterValueBool</summary>
	public  bool GetParameterValueBool(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueFloat</summary>
	public  float GetParameterValueFloat(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueDouble</summary>
	public  double GetParameterValueDouble(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueInt</summary>
	public  int GetParameterValueInt(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueName</summary>
	public  string GetParameterValueName(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueString</summary>
	public  string GetParameterValueString(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueVector2D</summary>
	public  FVector2D GetParameterValueVector2D(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueVector</summary>
	public  FVector GetParameterValueVector(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueQuat</summary>
	public  FQuat GetParameterValueQuat(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>GetParameterValueTransform</summary>
	public  FTransform GetParameterValueTransform(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	///<summary>SetParameterValueBool</summary>
	public  void SetParameterValueBool(string InParameterName,bool InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueFloat</summary>
	public  void SetParameterValueFloat(string InParameterName,float InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueDouble</summary>
	public  void SetParameterValueDouble(string InParameterName,double InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueInt</summary>
	public  void SetParameterValueInt(string InParameterName,int InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueName</summary>
	public  void SetParameterValueName(string InParameterName,string InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueString</summary>
	public  void SetParameterValueString(string InParameterName,string InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueVector2D</summary>
	public  void SetParameterValueVector2D(string InParameterName,FVector2D InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueVector</summary>
	public  void SetParameterValueVector(string InParameterName,FVector InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueQuat</summary>
	public  void SetParameterValueQuat(string InParameterName,FQuat InValue,int InArrayIndex/*=0*/) {}
	///<summary>SetParameterValueTransform</summary>
	public  void SetParameterValueTransform(string InParameterName,FTransform InValue,int InArrayIndex/*=0*/) {}
	///<summary>returns the statistics information</summary>
	public  FRigVMStatistics GetStatistics() { return default; }
	///<summary>Instructions</summary>
	public FRigVMInstructionArray Instructions;
	///<summary>Context</summary>
	public FRigVMExtendedExecuteContext Context;
	///<summary>NumExecutions</summary>
	public uint NumExecutions;
	///<summary>FunctionNamesStorage</summary>
	public TArray<string> FunctionNamesStorage;
	///<summary>Parameters</summary>
	public TArray<FRigVMParameter> Parameters;
	///<summary>ParametersNameMap</summary>
	public TMap<string,int> ParametersNameMap;
	///<summary>DeferredVMToCopy</summary>
	public URigVM DeferredVMToCopy;
}
