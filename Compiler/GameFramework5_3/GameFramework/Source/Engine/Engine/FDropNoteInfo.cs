namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Info about one note dropped in the map during PIE.</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FDropNoteInfo {
	public FVector Location;
	public FRotator Rotation;
	public string Comment;
}
