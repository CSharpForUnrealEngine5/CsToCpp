namespace GameFramework;

public partial struct EKeys
{
    public static FKey AnyKey;

    public static FKey MouseX;
    public static FKey MouseY;
    public static FKey Mouse2D;
    public static FKey MouseScrollUp;
    public static FKey MouseScrollDown;
    public static FKey MouseWheelAxis;

    public static FKey LeftMouseButton;
    public static FKey RightMouseButton;
    public static FKey MiddleMouseButton;
    public static FKey ThumbMouseButton;
    public static FKey ThumbMouseButton2;

    public static FKey BackSpace;
    public static FKey Tab;
    public static FKey Enter;
    public static FKey Pause;

    public static FKey CapsLock;
    public static FKey Escape;
    public static FKey SpaceBar;
    public static FKey PageUp;
    public static FKey PageDown;
    public static FKey End;
    public static FKey Home;

    public static FKey Left;
    public static FKey Up;
    public static FKey Right;
    public static FKey Down;

    public static FKey Insert;
    public static FKey Delete;

    public static FKey Zero;
    public static FKey One;
    public static FKey Two;
    public static FKey Three;
    public static FKey Four;
    public static FKey Five;
    public static FKey Six;
    public static FKey Seven;
    public static FKey Eight;
    public static FKey Nine;

    public static FKey A;
    public static FKey B;
    public static FKey C;
    public static FKey D;
    public static FKey E;
    public static FKey F;
    public static FKey G;
    public static FKey H;
    public static FKey I;
    public static FKey J;
    public static FKey K;
    public static FKey L;
    public static FKey M;
    public static FKey N;
    public static FKey O;
    public static FKey P;
    public static FKey Q;
    public static FKey R;
    public static FKey S;
    public static FKey T;
    public static FKey U;
    public static FKey V;
    public static FKey W;
    public static FKey X;
    public static FKey Y;
    public static FKey Z;

    public static FKey NumPadZero;
    public static FKey NumPadOne;
    public static FKey NumPadTwo;
    public static FKey NumPadThree;
    public static FKey NumPadFour;
    public static FKey NumPadFive;
    public static FKey NumPadSix;
    public static FKey NumPadSeven;
    public static FKey NumPadEight;
    public static FKey NumPadNine;

    public static FKey Multiply;
    public static FKey Add;
    public static FKey Subtract;
    public static FKey Decimal;
    public static FKey Divide;

    public static FKey F1;
    public static FKey F2;
    public static FKey F3;
    public static FKey F4;
    public static FKey F5;
    public static FKey F6;
    public static FKey F7;
    public static FKey F8;
    public static FKey F9;
    public static FKey F10;
    public static FKey F11;
    public static FKey F12;

    public static FKey NumLock;

    public static FKey ScrollLock;

    public static FKey LeftShift;
    public static FKey RightShift;
    public static FKey LeftControl;
    public static FKey RightControl;
    public static FKey LeftAlt;
    public static FKey RightAlt;
    public static FKey LeftCommand;
    public static FKey RightCommand;

    public static FKey Semicolon;
    public static FKey Equals;
    public static FKey Comma;
    public static FKey Underscore;
    public static FKey Hyphen;
    public static FKey Period;
    public static FKey Slash;
    public static FKey Tilde;
    public static FKey LeftBracket;
    public static FKey Backslash;
    public static FKey RightBracket;
    public static FKey Apostrophe;

    public static FKey Ampersand;
    public static FKey Asterix;
    public static FKey Caret;
    public static FKey Colon;
    public static FKey Dollar;
    public static FKey Exclamation;
    public static FKey LeftParantheses;
    public static FKey RightParantheses;
    public static FKey Quote;

    public static FKey A_AccentGrave;
    public static FKey E_AccentGrave;
    public static FKey E_AccentAigu;
    public static FKey C_Cedille;
    public static FKey Section;

    // Platform Keys
    // These keys platform specific versions of keys that go by different names.
    // The delete key is a good example, on Windows Delete is the virtual key for Delete.
    // On Macs, the Delete key is the virtual key for BackSpace.
    public static FKey Platform_Delete;

    // Gamepad Keys
    public static FKey Gamepad_Left2D;
    public static FKey Gamepad_LeftX;
    public static FKey Gamepad_LeftY;
    public static FKey Gamepad_Right2D;
    public static FKey Gamepad_RightX;
    public static FKey Gamepad_RightY;
    public static FKey Gamepad_LeftTriggerAxis;
    public static FKey Gamepad_RightTriggerAxis;

    public static FKey Gamepad_LeftThumbstick;
    public static FKey Gamepad_RightThumbstick;
    public static FKey Gamepad_Special_Left;
    public static FKey Gamepad_Special_Left_X;
    public static FKey Gamepad_Special_Left_Y;
    public static FKey Gamepad_Special_Right;
    public static FKey Gamepad_FaceButton_Bottom;
    public static FKey Gamepad_FaceButton_Right;
    public static FKey Gamepad_FaceButton_Left;
    public static FKey Gamepad_FaceButton_Top;
    public static FKey Gamepad_LeftShoulder;
    public static FKey Gamepad_RightShoulder;
    public static FKey Gamepad_LeftTrigger;
    public static FKey Gamepad_RightTrigger;
    public static FKey Gamepad_DPad_Up;
    public static FKey Gamepad_DPad_Down;
    public static FKey Gamepad_DPad_Right;
    public static FKey Gamepad_DPad_Left;

    // Virtual key codes used for input axis button press/release emulation
    public static FKey Gamepad_LeftStick_Up;
    public static FKey Gamepad_LeftStick_Down;
    public static FKey Gamepad_LeftStick_Right;
    public static FKey Gamepad_LeftStick_Left;

    public static FKey Gamepad_RightStick_Up;
    public static FKey Gamepad_RightStick_Down;
    public static FKey Gamepad_RightStick_Right;
    public static FKey Gamepad_RightStick_Left;

    // public static FKey Vector axes (FVector; not float)
    public static FKey Tilt;
    public static FKey RotationRate;
    public static FKey Gravity;
    public static FKey Acceleration;

    // Gestures
    public static FKey Gesture_Pinch;
    public static FKey Gesture_Flick;
    public static FKey Gesture_Rotate;

    // PS4-specific

    // Steam Controller Specific
    public static FKey Steam_Touch_0;
    public static FKey Steam_Touch_1;
    public static FKey Steam_Touch_2;
    public static FKey Steam_Touch_3;
    public static FKey Steam_Back_Left;
    public static FKey Steam_Back_Right;

    // Xbox One global speech commands
    public static FKey Global_Menu;
    public static FKey Global_View;
    public static FKey Global_Pause;
    public static FKey Global_Play;
    public static FKey Global_Back;

    // Android-specific
    public static FKey Android_Back;
    public static FKey Android_Volume_Up;
    public static FKey Android_Volume_Down;
    public static FKey Android_Menu;

    // HTC Vive Controller
    public static FKey Vive_Left_Grip_Click;
    public static FKey Vive_Left_Menu_Click;
    public static FKey Vive_Left_Trigger_Click;
    public static FKey Vive_Left_Trigger_Axis;
    public static FKey Vive_Left_Trackpad_2D;
    public static FKey Vive_Left_Trackpad_X;
    public static FKey Vive_Left_Trackpad_Y;
    public static FKey Vive_Left_Trackpad_Click;
    public static FKey Vive_Left_Trackpad_Touch;
    public static FKey Vive_Left_Trackpad_Up;
    public static FKey Vive_Left_Trackpad_Down;
    public static FKey Vive_Left_Trackpad_Left;
    public static FKey Vive_Left_Trackpad_Right;
    public static FKey Vive_Right_Grip_Click;
    public static FKey Vive_Right_Menu_Click;
    public static FKey Vive_Right_Trigger_Click;
    public static FKey Vive_Right_Trigger_Axis;
    public static FKey Vive_Right_Trackpad_2D;
    public static FKey Vive_Right_Trackpad_X;
    public static FKey Vive_Right_Trackpad_Y;
    public static FKey Vive_Right_Trackpad_Click;
    public static FKey Vive_Right_Trackpad_Touch;
    public static FKey Vive_Right_Trackpad_Up;
    public static FKey Vive_Right_Trackpad_Down;
    public static FKey Vive_Right_Trackpad_Left;
    public static FKey Vive_Right_Trackpad_Right;

    // Microsoft Mixed Reality Motion Controller
    public static FKey MixedReality_Left_Menu_Click;
    public static FKey MixedReality_Left_Grip_Click;
    public static FKey MixedReality_Left_Trigger_Click;
    public static FKey MixedReality_Left_Trigger_Axis;
    public static FKey MixedReality_Left_Thumbstick_2D;
    public static FKey MixedReality_Left_Thumbstick_X;
    public static FKey MixedReality_Left_Thumbstick_Y;
    public static FKey MixedReality_Left_Thumbstick_Click;
    public static FKey MixedReality_Left_Thumbstick_Up;
    public static FKey MixedReality_Left_Thumbstick_Down;
    public static FKey MixedReality_Left_Thumbstick_Left;
    public static FKey MixedReality_Left_Thumbstick_Right;
    public static FKey MixedReality_Left_Trackpad_2D;
    public static FKey MixedReality_Left_Trackpad_X;
    public static FKey MixedReality_Left_Trackpad_Y;
    public static FKey MixedReality_Left_Trackpad_Click;
    public static FKey MixedReality_Left_Trackpad_Touch;
    public static FKey MixedReality_Left_Trackpad_Up;
    public static FKey MixedReality_Left_Trackpad_Down;
    public static FKey MixedReality_Left_Trackpad_Left;
    public static FKey MixedReality_Left_Trackpad_Right;
    public static FKey MixedReality_Right_Menu_Click;
    public static FKey MixedReality_Right_Grip_Click;
    public static FKey MixedReality_Right_Trigger_Click;
    public static FKey MixedReality_Right_Trigger_Axis;
    public static FKey MixedReality_Right_Thumbstick_2D;
    public static FKey MixedReality_Right_Thumbstick_X;
    public static FKey MixedReality_Right_Thumbstick_Y;
    public static FKey MixedReality_Right_Thumbstick_Click;
    public static FKey MixedReality_Right_Thumbstick_Up;
    public static FKey MixedReality_Right_Thumbstick_Down;
    public static FKey MixedReality_Right_Thumbstick_Left;
    public static FKey MixedReality_Right_Thumbstick_Right;
    public static FKey MixedReality_Right_Trackpad_2D;
    public static FKey MixedReality_Right_Trackpad_X;
    public static FKey MixedReality_Right_Trackpad_Y;
    public static FKey MixedReality_Right_Trackpad_Click;
    public static FKey MixedReality_Right_Trackpad_Touch;
    public static FKey MixedReality_Right_Trackpad_Up;
    public static FKey MixedReality_Right_Trackpad_Down;
    public static FKey MixedReality_Right_Trackpad_Left;
    public static FKey MixedReality_Right_Trackpad_Right;

    // Oculus Touch Controller
    public static FKey OculusTouch_Left_X_Click;
    public static FKey OculusTouch_Left_Y_Click;
    public static FKey OculusTouch_Left_X_Touch;
    public static FKey OculusTouch_Left_Y_Touch;
    public static FKey OculusTouch_Left_Menu_Click;
    public static FKey OculusTouch_Left_Grip_Click;
    public static FKey OculusTouch_Left_Grip_Axis;
    public static FKey OculusTouch_Left_Trigger_Click;
    public static FKey OculusTouch_Left_Trigger_Axis;
    public static FKey OculusTouch_Left_Trigger_Touch;
    public static FKey OculusTouch_Left_Thumbstick_2D;
    public static FKey OculusTouch_Left_Thumbstick_X;
    public static FKey OculusTouch_Left_Thumbstick_Y;
    public static FKey OculusTouch_Left_Thumbstick_Click;
    public static FKey OculusTouch_Left_Thumbstick_Touch;
    public static FKey OculusTouch_Left_Thumbstick_Up;
    public static FKey OculusTouch_Left_Thumbstick_Down;
    public static FKey OculusTouch_Left_Thumbstick_Left;
    public static FKey OculusTouch_Left_Thumbstick_Right;
    public static FKey OculusTouch_Right_A_Click;
    public static FKey OculusTouch_Right_B_Click;
    public static FKey OculusTouch_Right_A_Touch;
    public static FKey OculusTouch_Right_B_Touch;
    public static FKey OculusTouch_Right_Grip_Click;
    public static FKey OculusTouch_Right_Grip_Axis;
    public static FKey OculusTouch_Right_Trigger_Click;
    public static FKey OculusTouch_Right_Trigger_Axis;
    public static FKey OculusTouch_Right_Trigger_Touch;
    public static FKey OculusTouch_Right_Thumbstick_2D;
    public static FKey OculusTouch_Right_Thumbstick_X;
    public static FKey OculusTouch_Right_Thumbstick_Y;
    public static FKey OculusTouch_Right_Thumbstick_Click;
    public static FKey OculusTouch_Right_Thumbstick_Touch;
    public static FKey OculusTouch_Right_Thumbstick_Up;
    public static FKey OculusTouch_Right_Thumbstick_Down;
    public static FKey OculusTouch_Right_Thumbstick_Left;
    public static FKey OculusTouch_Right_Thumbstick_Right;

    // Valve Index Controller
    public static FKey ValveIndex_Left_A_Click;
    public static FKey ValveIndex_Left_B_Click;
    public static FKey ValveIndex_Left_A_Touch;
    public static FKey ValveIndex_Left_B_Touch;
    public static FKey ValveIndex_Left_Grip_Axis;
    public static FKey ValveIndex_Left_Grip_Force;
    public static FKey ValveIndex_Left_Trigger_Click;
    public static FKey ValveIndex_Left_Trigger_Axis;
    public static FKey ValveIndex_Left_Trigger_Touch;
    public static FKey ValveIndex_Left_Thumbstick_2D;
    public static FKey ValveIndex_Left_Thumbstick_X;
    public static FKey ValveIndex_Left_Thumbstick_Y;
    public static FKey ValveIndex_Left_Thumbstick_Click;
    public static FKey ValveIndex_Left_Thumbstick_Touch;
    public static FKey ValveIndex_Left_Thumbstick_Up;
    public static FKey ValveIndex_Left_Thumbstick_Down;
    public static FKey ValveIndex_Left_Thumbstick_Left;
    public static FKey ValveIndex_Left_Thumbstick_Right;
    public static FKey ValveIndex_Left_Trackpad_2D;
    public static FKey ValveIndex_Left_Trackpad_X;
    public static FKey ValveIndex_Left_Trackpad_Y;
    public static FKey ValveIndex_Left_Trackpad_Force;
    public static FKey ValveIndex_Left_Trackpad_Touch;
    public static FKey ValveIndex_Left_Trackpad_Up;
    public static FKey ValveIndex_Left_Trackpad_Down;
    public static FKey ValveIndex_Left_Trackpad_Left;
    public static FKey ValveIndex_Left_Trackpad_Right;
    public static FKey ValveIndex_Right_A_Click;
    public static FKey ValveIndex_Right_B_Click;
    public static FKey ValveIndex_Right_A_Touch;
    public static FKey ValveIndex_Right_B_Touch;
    public static FKey ValveIndex_Right_Grip_Axis;
    public static FKey ValveIndex_Right_Grip_Force;
    public static FKey ValveIndex_Right_Trigger_Click;
    public static FKey ValveIndex_Right_Trigger_Axis;
    public static FKey ValveIndex_Right_Trigger_Touch;
    public static FKey ValveIndex_Right_Thumbstick_2D;
    public static FKey ValveIndex_Right_Thumbstick_X;
    public static FKey ValveIndex_Right_Thumbstick_Y;
    public static FKey ValveIndex_Right_Thumbstick_Click;
    public static FKey ValveIndex_Right_Thumbstick_Touch;
    public static FKey ValveIndex_Right_Thumbstick_Up;
    public static FKey ValveIndex_Right_Thumbstick_Down;
    public static FKey ValveIndex_Right_Thumbstick_Left;
    public static FKey ValveIndex_Right_Thumbstick_Right;
    public static FKey ValveIndex_Right_Trackpad_2D;
    public static FKey ValveIndex_Right_Trackpad_X;
    public static FKey ValveIndex_Right_Trackpad_Y;
    public static FKey ValveIndex_Right_Trackpad_Force;
    public static FKey ValveIndex_Right_Trackpad_Touch;
    public static FKey ValveIndex_Right_Trackpad_Up;
    public static FKey ValveIndex_Right_Trackpad_Down;
    public static FKey ValveIndex_Right_Trackpad_Left;
    public static FKey ValveIndex_Right_Trackpad_Right;

    // Virtual buttons that use other buttons depending on the platform
    public static FKey Virtual_Accept;
    public static FKey Virtual_Back;

    public static FKey Invalid;

}
