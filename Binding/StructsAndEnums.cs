using System;

namespace MonoTouch.GPUImage
{
    public struct GPUTextureOptions
    {
        public uint MinFilter { get; set; }

        public uint MagFilter { get; set; }

        public uint WrapS { get; set; }

        public uint WrapT { get; set; }

        public uint InternalFormat { get; set; }

        public uint Format { get; set; }

        public uint Type { get; set; }
    }

    public enum GPUImageRotationMode
    {
        NoRotation,
        RotateLeft,
        RotateRight,
        FlipVertical,
        FlipHorizonal,
        RotateRightFlipVertical,
        RotateRightFlipHorizontal,
        Rotate180
    }

    public enum GPUImageFillModeType
    {
        Stretch,
        // Stretch to fill the full view, which may distort the image outside of its normal aspect ratio
        PreserveAspectRatio,
        // Maintains the aspect ratio of the source image, adding bars of the specified background color
        PreserveAspectRatioAndFill
        // Maintains the aspect ratio of the source image, zooming in on its center to fill the view}
    }

    /*
    public enum GPUImageFillModeType
    {
        kGPUImageFillModeStretch,                       // Stretch to fill the full view, which may distort the image outside of its normal aspect ratio
        kGPUImageFillModePreserveAspectRatio,           // Maintains the aspect ratio of the source image, adding bars of the specified background color
        kGPUImageFillModePreserveAspectRatioAndFill     // Maintains the aspect ratio of the source image, zooming in on its center to fill the view
    } 

    public enum GPUImageRotationMode { kGPUImageNoRotation, kGPUImageRotateLeft, kGPUImageRotateRight, kGPUImageFlipVertical, kGPUImageFlipHorizonal, kGPUImageRotateRightFlipVertical, kGPUImageRotate180 };

    */

    public struct GPUVector4
    {
        public float One;
        public float Two;
        public float Three;
        public float Four;
    };

    public struct GPUVector3
    {
        public float One;
        public float Two;
        public float Three;
    };

    public struct GPUMatrix4x4
    {
        public GPUVector4 One;
        public GPUVector4 Two;
        public GPUVector4 Three;
        public GPUVector4 Four;
    };

    public struct GPUMatrix3x3
    {
        public GPUVector3 One;
        public GPUVector3 Two;
        public GPUVector3 Three;
    };

    public enum GPUPixelFormat
    {
        BGRA = 0x80E1,
        RGBA = 0x1908,
        RGB = 0x1907}

    ;

    public enum GPUPixelType
    {
        UByte = 0x1401,
        Float = 0x1406
    }
}

