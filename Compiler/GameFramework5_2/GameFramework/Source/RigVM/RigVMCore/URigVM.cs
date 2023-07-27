#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVM.h")]
///<summary>The RigVM is the main object for evaluating FRigVMByteCode instructions.</summary>
public partial class URigVM : UObject {
// RigVM
	public  bool Execute(string InEntryName/*=NAME_None*/) { return default; }
	public  int AddRigVMFunction(UScriptStruct InRigVMStruct,string InMethodName) { return default; }
	public  string GetRigVMFunctionName(int InFunctionIndex) { return default; }
	public URigVMMemoryStorage WorkMemoryStorageObject;
	public URigVMMemoryStorage LiteralMemoryStorageObject;
	public URigVMMemoryStorage DebugMemoryStorageObject;
	public FRigVMByteCode ByteCodeStorage;
	public  bool GetParameterValueBool(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  float GetParameterValueFloat(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  double GetParameterValueDouble(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  int GetParameterValueInt(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  string GetParameterValueName(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  string GetParameterValueString(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  FVector2D GetParameterValueVector2D(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  FVector GetParameterValueVector(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  FQuat GetParameterValueQuat(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  FTransform GetParameterValueTransform(string InParameterName,int InArrayIndex/*=0*/) { return default; }
	public  void SetParameterValueBool(string InParameterName,bool InValue,int InArrayIndex/*=0*/) {}
	public  void SetParameterValueFloat(string InParameterName,float InValue,int InArrayIndex/*=0*/) {}
	public  void SetParameterValueDouble(string InParameterName,double InValue,int InArrayIndex/*=0*/) {}
	public  void SetParameterValueInt(string InParameterName,int InValue,int InArrayIndex/*=0*/) {}
	public  void SetParameterValueName(string InParameterName,string InValue,int InArrayIndex/*=0*/) {}
	public  void SetParameterValueString(string InParameterName,string InValue,int InArrayIndex/*=0*/) {}
	public  void SetParameterValueVector2D(string InParameterName,FVector2D InValue,int InArrayIndex/*=0*/) {}
	public  void SetParameterValueVector(string InParameterName,FVector InValue,int InArrayIndex/*=0*/) {}
	public  void SetParameterValueQuat(string InParameterName,FQuat InValue,int InArrayIndex/*=0*/) {}
	public  void SetParameterValueTransform(string InParameterName,FTransform InValue,int InArrayIndex/*=0*/) {}
	public  FRigVMStatistics GetStatistics() { return default; }
	public FRigVMInstructionArray Instructions;
	public FRigVMExtendedExecuteContext Context;
	public uint NumExecutions;
	public TArray<string> FunctionNamesStorage;
	public TArray<FRigVMParameter> Parameters;
	public TMap<string,int> ParametersNameMap;
	public URigVM DeferredVMToCopy;
}
