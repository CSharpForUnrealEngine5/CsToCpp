namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides a way for blueprint to create and store a map of HTTP headers</summary>
[CppInclude("HttpHeader.h")]
public partial struct FHttpHeader {
	public TMap<string,string> Headers;
}
