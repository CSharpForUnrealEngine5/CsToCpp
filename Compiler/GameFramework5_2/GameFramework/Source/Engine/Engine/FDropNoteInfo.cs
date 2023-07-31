#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Info about one note dropped in the map during PIE.</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FDropNoteInfo {
	public FVector Location;
	public FRotator Rotation;
	public string Comment;
}
