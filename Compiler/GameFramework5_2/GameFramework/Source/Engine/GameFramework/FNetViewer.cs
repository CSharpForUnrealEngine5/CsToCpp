#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>stores information on a viewer that actors need to be checked against for relevancy</summary>
[CppInclude("GameFramework/WorldSettings.h")]
public partial struct FNetViewer {
	public UNetConnection Connection;
	public AActor InViewer;
	public AActor ViewTarget;
	public FVector ViewLocation;
	public FVector ViewDir;
}
