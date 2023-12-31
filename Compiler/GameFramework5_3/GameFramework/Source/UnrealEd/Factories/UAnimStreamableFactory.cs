namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/AnimStreamableFactory.h")]
public partial class UAnimStreamableFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>TargetSkeleton</summary>
	public USkeleton TargetSkeleton;
	///<summary>Used when creating a composite from an AnimSequence, becomes the only AnimSequence contained</summary>
	public UAnimSequence SourceAnimation;
}
