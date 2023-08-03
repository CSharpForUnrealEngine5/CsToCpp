#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines level bounds</summary>
[CppInclude("Engine/LevelBounds.h")]
public partial class ALevelBounds : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Bounding box for the level bounds.</summary>
	public UBoxComponent BoxComponent;
	///<summary>Whether to automatically update actor bounds based on all relevant actors bounds belonging to the same level</summary>
	public bool bAutoUpdateBounds;
}
