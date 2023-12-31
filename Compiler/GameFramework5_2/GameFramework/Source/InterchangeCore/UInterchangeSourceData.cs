namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Helper class to be able to read different source data</summary>
[CppInclude("InterchangeSourceData.h")]
public partial class UInterchangeSourceData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetFilename</summary>
	public string GetFilename() { return default; }
	///<summary>SetFilename</summary>
	public bool SetFilename(string InFilename) { return default; }
	///<summary>Filename</summary>
	public string Filename;
}
