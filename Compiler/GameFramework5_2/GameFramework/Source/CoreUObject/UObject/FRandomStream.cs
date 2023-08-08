#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Thread-safe random number generator that can be manually seeded.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FRandomStream {
    
	public int InitialSeed;
	public int Seed;

    public FRandomStream(int InSeed) { InitialSeed = Seed = 0; }
    public FRandomStream(string InName) { InitialSeed = Seed = 0; }

    public void Initialize(int InSeed) { }
    public void Initialize(string InName) { }
    /// <summary>
    /// Resets this random stream to the initial seed value.
    /// </summary>
    public void Reset() { }

    public int GetInitialSeed() { return 0; }

    public void GenerateNewSeed() { }
    /// <summary>
    /// Returns a random float number in the range [0, 1).
    /// </summary>
    /// <returns></returns>
    public float GetFraction() { return 0.0f; }

    public int GetUnsignedInt() { return 0; }

    public FVector GetUnitVector() { return default; }

    public int GetCurrentSeed() { return Seed; }
    /// <summary>
    /// Mirrors the random number API in FMath
    /// </summary>
    /// <returns></returns>
    public float FRand() { return 0.0f; }
    
    public int RandHelper(int A) { return 0; }
    
    /// <summary>
    /// Returns a random vector of unit size.
    /// </summary>
    /// <returns></returns>
    public FVector VRand() { return default;  }

    public FVector RandPointInBox(FBox Box) { return default; }
    /// <summary>
    /// Returns a random unit vector, uniformly distributed, within the specified cone.
    /// </summary>
    /// <param name="Dir"></param>
    /// <param name="ConeHalfAngleRad"></param>
    /// <returns></returns>
    public FVector VRandCone(FVector Dir, float ConeHalfAngleRad ) { return default; }

    public override string ToString()
    {
        return base.ToString();
    }
}
