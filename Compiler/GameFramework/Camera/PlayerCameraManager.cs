using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Camera/PlayerCameraManager.h")]
    public partial class APlayerCameraManager : AActor {
        [CppConst]
        public FRotator GetCameraRotation() { return default(FRotator); }
    }

}