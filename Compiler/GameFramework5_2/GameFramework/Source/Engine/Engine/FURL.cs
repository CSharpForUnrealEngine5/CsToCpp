#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>URL structure.</summary>
[CppInclude("Engine/EngineBaseTypes.h")]
public partial struct FURL {
	public string Protocol;
	public string Host;
	public int Port;
	public int Valid;
	public string Map;
	public string RedirectURL;
	public TArray<string> Op;
	public string Portal;
}
