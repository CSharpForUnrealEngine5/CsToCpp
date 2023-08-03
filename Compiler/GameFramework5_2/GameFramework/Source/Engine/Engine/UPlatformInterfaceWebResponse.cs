#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlatformInterfaceWebResponse.h")]
public partial class UPlatformInterfaceWebResponse : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>This holds the original requested URL</summary>
	public string OriginalURL;
	///<summary>Result code from the response (200=OK, 404=Not Found, etc)</summary>
	public int ResponseCode;
	///<summary>A user-specified tag specified with the request</summary>
	public int Tag;
	///<summary>For string results, this is the response</summary>
	public string StringResponse;
	///<summary>For non-string results, this is the response</summary>
	public TArray<byte> BinaryResponse;
	///<summary>@return the number of header/value pairs</summary>
	public  int GetNumHeaders() { return default; }
	///<summary>Retrieve the header and value for the given index of header/value pair</summary>
	public  void GetHeader(int HeaderIndex,string Header,string Value) {}
	///<summary>@return the value for the given header (or &quot;&quot; if no matching header)</summary>
	public  string GetHeaderValue(string HeaderName) { return default; }
}
