#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseMediaSource.h")]
///<summary>Base class for concrete media sources.</summary>
public partial class UBaseMediaSource : UMediaSource {
// BaseMediaSource
	public TMap<string,string> PlatformPlayerNames;
	public string PlayerName;
}
