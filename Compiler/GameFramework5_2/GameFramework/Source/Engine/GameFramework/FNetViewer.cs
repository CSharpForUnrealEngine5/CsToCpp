#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/WorldSettings.h")]
///<summary>stores information on a viewer that actors need to be checked against for relevancy</summary>
public partial struct FNetViewer {
// NetViewer
	public UNetConnection Connection;
	public AActor InViewer;
	public AActor ViewTarget;
	public FVector ViewLocation;
	public FVector ViewDir;
}
