#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositeCameraShakePattern.h")]
///<summary>A base class for a simple camera shake.</summary>
public partial class UCompositeCameraShakePattern : UCameraShakePattern {
// CompositeCameraShakePattern
	public TArray<UCameraShakePattern> ChildPatterns;
}
