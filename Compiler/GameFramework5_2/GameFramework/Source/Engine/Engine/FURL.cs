#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineBaseTypes.h")]
///<summary>URL structure.</summary>
public partial struct FURL {
// URL
	public string Protocol;
	public string Host;
	public int Port;
	public int Valid;
	public string Map;
	public string RedirectURL;
	public TArray<string> Op;
	public string Portal;
}
