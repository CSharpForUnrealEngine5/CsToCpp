#pragma warning disable CS8618,CS8603,CS1587,CS1591
using CSharpToCpp.Utilities;

namespace GameFramework
{
    [CppIgnoreNew]
    public partial struct FRotator
    {
        public FRotator(double InPitch, double InYaw, double InRoll) {
            Pitch = InPitch;
            Yaw = InYaw;
            Roll = InRoll;
        }

        public FVector RotateVector(FVector rotate) { return new FVector(); }

        public static FRotator ZeroRotator;

    }
}
