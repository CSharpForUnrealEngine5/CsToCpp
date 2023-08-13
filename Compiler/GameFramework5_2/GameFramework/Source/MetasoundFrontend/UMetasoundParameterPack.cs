namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Here is the UObject BlueprintType that can be used in c++ and blueprint code. It holds a FMetasoundParamStorage</summary>
[CppInclude("MetasoundParameterPack.h")]
public partial class UMetasoundParameterPack : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>MakeMetasoundParameterPack</summary>
	public static UMetasoundParameterPack MakeMetasoundParameterPack() { return default; }
	///<summary>SetBool</summary>
	public ESetParamResult SetBool(string ParameterName,bool InValue,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>SetInt</summary>
	public ESetParamResult SetInt(string ParameterName,int InValue,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>SetFloat</summary>
	public ESetParamResult SetFloat(string ParameterName,float InValue,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>SetString</summary>
	public ESetParamResult SetString(string ParameterName,string InValue,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>SetTrigger</summary>
	public ESetParamResult SetTrigger(string ParameterName,bool OnlyIfExists/*=true*/) { return default; }
	///<summary>GetBool</summary>
	public bool GetBool(string ParameterName,ESetParamResult Result) { return default; }
	///<summary>GetInt</summary>
	public int GetInt(string ParameterName,ESetParamResult Result) { return default; }
	///<summary>GetFloat</summary>
	public float GetFloat(string ParameterName,ESetParamResult Result) { return default; }
	///<summary>GetString</summary>
	public string GetString(string ParameterName,ESetParamResult Result) { return default; }
	///<summary>GetTrigger</summary>
	public bool GetTrigger(string ParameterName,ESetParamResult Result) { return default; }
	///<summary>HasBool</summary>
	public bool HasBool(string ParameterName) { return default; }
	///<summary>HasInt</summary>
	public bool HasInt(string ParameterName) { return default; }
	///<summary>HasFloat</summary>
	public bool HasFloat(string ParameterName) { return default; }
	///<summary>HasString</summary>
	public bool HasString(string ParameterName) { return default; }
	///<summary>HasTrigger</summary>
	public bool HasTrigger(string ParameterName) { return default; }
}
