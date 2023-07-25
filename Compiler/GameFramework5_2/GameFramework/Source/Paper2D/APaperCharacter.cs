#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperCharacter.h")]
///<summary>APaperCharacter behaves like ACharacter, but uses a UPaperFlipbookComponent instead of a USkeletalMeshComponent as a visual representation</summary>
public partial class APaperCharacter : ACharacter {
// PaperCharacter
	public UPaperFlipbookComponent Sprite;
}
