using CSharpToCpp.Utilities;

namespace GameFramework
{
    [CppIgnoreNew]
    public struct FRotator
    {
        public double Pitch;
        public double Yaw;
        public double Row;

        public FRotator(double InPitch, double InYaw, double InRoll) {
            Pitch = InPitch;
            Yaw = InYaw;
            Row = InRoll;
        }

        public FVector RotateVector(FVector rotate) { return new FVector(); }

        public static FRotator ZeroRotator;

    }
}
