#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/BookMark.h")]
///<summary>A camera position the current level.</summary>
public partial class UBookMark : UBookmarkBase {
// BookMark
	public FVector Location;
	public FRotator Rotation;
	public TArray<string> HiddenLevels;
}
