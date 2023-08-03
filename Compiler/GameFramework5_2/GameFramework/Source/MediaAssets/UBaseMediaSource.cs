#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for concrete media sources.</summary>
[CppInclude("BaseMediaSource.h")]
public partial class UBaseMediaSource : UMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>Override native media player plug-ins per platform (Empty = find one automatically).</summary>
	public TMap<string,string> PlatformPlayerNames;
	///<summary>Name of the desired native media player (Empty = find one automatically).</summary>
	public string PlayerName;
}
