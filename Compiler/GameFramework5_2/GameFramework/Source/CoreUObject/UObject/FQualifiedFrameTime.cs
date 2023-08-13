namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A frame time qualified by a frame rate context.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FQualifiedFrameTime {
	public FFrameTime Time;
	public FFrameRate Rate;
}
