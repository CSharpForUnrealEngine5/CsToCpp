#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelSnapshotsSettings.h")]
public partial class ULevelSnapshotsSettings : UObject {
	///<summary>Specifies classes and properties that should never be captured nor restored.</summary>
	public FSkippedClassList SkippedClasses;
	///<summary>Used when comparing float properties. Floats that have changes beyond this point do not show up as changed. // Max value is SMALL_NUMBER = 1e-8</summary>
	public float FloatComparisonPrecision;
	///<summary>Used when comparing double properties. Doubles that have changes beyond this point do not show up as changed. // Max value is SMALL_NUMBER = 1e-8</summary>
	public double DoubleComparisonPrecision;
	///<summary>Performance trade-off. Used when filtering a snapshot.</summary>
	public FHashSettings HashSettings;
	///<summary>Specifies the compression settings to use when a snapshot is saved.</summary>
	public FSnapshotCompressionSettings CompressionSettings;
}
