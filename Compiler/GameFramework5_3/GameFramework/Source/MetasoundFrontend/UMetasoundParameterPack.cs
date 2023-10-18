namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Here is the UObject BlueprintType that can be used in c++ and blueprint code. It holds a FMetasoundParamStorage</summary>
[CppInclude("MetasoundParameterPack.h")]
public partial class UMetasoundParameterPack : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>MakeMetasoundParameterPack</summary>
	public static UMetasoundParameterPack MakeMetasoundParameterPack() { return default; }
	///<summary>SetBool</summary>
	public ESetParamResult SetBool(FName ParameterName,bool InValue,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>SetInt</summary>
	public ESetParamResult SetInt(FName ParameterName,int InValue,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>SetFloat</summary>
	public ESetParamResult SetFloat(FName ParameterName,float InValue,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>SetString</summary>
	public ESetParamResult SetString(FName ParameterName,string InValue,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>SetTrigger</summary>
	public ESetParamResult SetTrigger(FName ParameterName,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>GetBool</summary>
	public bool GetBool(FName ParameterName,ESetParamResult Result) { return default; }
	///<summary>GetInt</summary>
	public int GetInt(FName ParameterName,ESetParamResult Result) { return default; }
	///<summary>GetFloat</summary>
	public float GetFloat(FName ParameterName,ESetParamResult Result) { return default; }
	///<summary>GetString</summary>
	public string GetString(FName ParameterName,ESetParamResult Result) { return default; }
	///<summary>GetTrigger</summary>
	public bool GetTrigger(FName ParameterName,ESetParamResult Result) { return default; }
	///<summary>HasBool</summary>
	public bool HasBool(FName ParameterName) { return default; }
	///<summary>HasInt</summary>
	public bool HasInt(FName ParameterName) { return default; }
	///<summary>HasFloat</summary>
	public bool HasFloat(FName ParameterName) { return default; }
	///<summary>HasString</summary>
	public bool HasString(FName ParameterName) { return default; }
	///<summary>HasTrigger</summary>
	public bool HasTrigger(FName ParameterName) { return default; }
}
