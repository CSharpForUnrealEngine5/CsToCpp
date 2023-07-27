#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundParameterPack.h")]
///<summary>Here is the UObject BlueprintType that can be used in c++ and blueprint code. It holds a FMetasoundParamStorage</summary>
public partial class UMetasoundParameterPack : UObject {
// MetasoundParameterPack
	public static UMetasoundParameterPack MakeMetasoundParameterPack() { return default; }
	public  ESetParamResult SetBool(string ParameterName,bool InValue,bool OnlyIfExists/*=true*/) { return default; }
	public  ESetParamResult SetInt(string ParameterName,int InValue,bool OnlyIfExists/*=true*/) { return default; }
	public  ESetParamResult SetFloat(string ParameterName,float InValue,bool OnlyIfExists/*=true*/) { return default; }
	public  ESetParamResult SetString(string ParameterName,string InValue,bool OnlyIfExists/*=true*/) { return default; }
	public  ESetParamResult SetTrigger(string ParameterName,bool OnlyIfExists/*=true*/) { return default; }
	public  bool GetBool(string ParameterName,ESetParamResult Result) { return default; }
	public  int GetInt(string ParameterName,ESetParamResult Result) { return default; }
	public  float GetFloat(string ParameterName,ESetParamResult Result) { return default; }
	public  string GetString(string ParameterName,ESetParamResult Result) { return default; }
	public  bool GetTrigger(string ParameterName,ESetParamResult Result) { return default; }
	public  bool HasBool(string ParameterName) { return default; }
	public  bool HasInt(string ParameterName) { return default; }
	public  bool HasFloat(string ParameterName) { return default; }
	public  bool HasString(string ParameterName) { return default; }
	public  bool HasTrigger(string ParameterName) { return default; }
}
