#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlatformInterfaceWebResponse.h")]
public partial class UPlatformInterfaceWebResponse : UObject {
// PlatformInterfaceWebResponse
	public string OriginalURL;
	public int ResponseCode;
	public int Tag;
	public string StringResponse;
	public TArray<byte> BinaryResponse;
	public int GetNumHeaders() { return default; }
	public void GetHeader(int HeaderIndex,string Header,string Value) {}
	public string GetHeaderValue(string HeaderName) { return default; }
}
