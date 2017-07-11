﻿using Android.Support.Media;

namespace Plugin.Media
{
    public static class ExifInterfaceExtension
    {

        public static void Copy(this ExifInterface dest, ExifInterface source)
        {
            var tagNames = new string[] {
                ExifInterface.TagArtist,
                ExifInterface.TagBitsPerSample,
                ExifInterface.TagCompression,
                ExifInterface.TagCopyright,
                ExifInterface.TagDatetime,
                ExifInterface.TagImageDescription,
                ExifInterface.TagImageLength,
                ExifInterface.TagImageWidth,
                ExifInterface.TagJpegInterchangeFormat,
                ExifInterface.TagJpegInterchangeFormatLength,
                ExifInterface.TagMake,
                ExifInterface.TagModel,
                ExifInterface.TagOrientation,
                ExifInterface.TagPhotometricInterpretation,
                ExifInterface.TagPlanarConfiguration,
                ExifInterface.TagPrimaryChromaticities,
                ExifInterface.TagReferenceBlackWhite,
                ExifInterface.TagResolutionUnit,
                ExifInterface.TagRowsPerStrip,
                ExifInterface.TagSamplesPerPixel,
                ExifInterface.TagSoftware,
                ExifInterface.TagStripByteCounts,
                ExifInterface.TagStripOffsets,
                ExifInterface.TagTransferFunction,
                ExifInterface.TagWhitePoint,
                ExifInterface.TagXResolution,
                ExifInterface.TagYCbCrCoefficients,
                ExifInterface.TagYCbCrPositioning,
                ExifInterface.TagYCbCrSubSampling,
                ExifInterface.TagYResolution,
                ExifInterface.TagApertureValue,
                ExifInterface.TagBrightnessValue,
                ExifInterface.TagCfaPattern,
                ExifInterface.TagColorSpace,
                ExifInterface.TagComponentsConfiguration,
                ExifInterface.TagCompressedBitsPerPixel,
                ExifInterface.TagContrast,
                ExifInterface.TagCustomRendered,
                ExifInterface.TagDatetimeDigitized,
                ExifInterface.TagDatetimeOriginal,
                ExifInterface.TagDeviceSettingDescription,
                ExifInterface.TagDigitalZoomRatio,
                ExifInterface.TagExifVersion,
                ExifInterface.TagExposureBiasValue,
                ExifInterface.TagExposureIndex,
                ExifInterface.TagExposureMode,
                ExifInterface.TagExposureProgram,
                ExifInterface.TagExposureTime,
                ExifInterface.TagFNumber,
                ExifInterface.TagFileSource,
                ExifInterface.TagFlash,
                ExifInterface.TagFlashEnergy,
                ExifInterface.TagFlashpixVersion,
                ExifInterface.TagFocalLength,
                ExifInterface.TagFocalLengthIn35mmFilm,
                ExifInterface.TagFocalPlaneResolutionUnit,
                ExifInterface.TagFocalPlaneXResolution,
                ExifInterface.TagFocalPlaneYResolution,
                ExifInterface.TagGainControl,
                ExifInterface.TagIsoSpeedRatings,
                ExifInterface.TagImageUniqueId,
                ExifInterface.TagLightSource,
                ExifInterface.TagMakerNote,
                ExifInterface.TagMaxApertureValue,
                ExifInterface.TagMeteringMode,
                ExifInterface.TagNewSubfileType,
                ExifInterface.TagOecf,
                ExifInterface.TagPixelXDimension,
                ExifInterface.TagPixelYDimension,
                ExifInterface.TagRelatedSoundFile,
                ExifInterface.TagSaturation,
                ExifInterface.TagSceneCaptureType,
                ExifInterface.TagSceneType,
                ExifInterface.TagSensingMethod,
                ExifInterface.TagSharpness,
                ExifInterface.TagShutterSpeedValue,
                ExifInterface.TagSpatialFrequencyResponse,
                ExifInterface.TagSpectralSensitivity,
                ExifInterface.TagSubfileType,
                ExifInterface.TagSubsecTime,
                ExifInterface.TagSubsecTimeDigitized,
                ExifInterface.TagSubsecTimeOriginal,
                ExifInterface.TagSubjectArea,
                ExifInterface.TagSubjectDistance,
                ExifInterface.TagSubjectDistanceRange,
                ExifInterface.TagSubjectLocation,
                ExifInterface.TagUserComment,
                ExifInterface.TagWhiteBalance,
                ExifInterface.TagGpsAltitude,
                ExifInterface.TagGpsAltitudeRef,
                ExifInterface.TagGpsAreaInformation,
                ExifInterface.TagGpsDop,
                ExifInterface.TagGpsDatestamp,
                ExifInterface.TagGpsDestBearing,
                ExifInterface.TagGpsDestBearingRef,
                ExifInterface.TagGpsDestDistance,
                ExifInterface.TagGpsDestDistanceRef,
                ExifInterface.TagGpsDestLatitude,
                ExifInterface.TagGpsDestLatitudeRef,
                ExifInterface.TagGpsDestLongitude,
                ExifInterface.TagGpsDestLongitudeRef,
                ExifInterface.TagGpsDifferential,
                ExifInterface.TagGpsImgDirection,
                ExifInterface.TagGpsImgDirectionRef,
                ExifInterface.TagGpsLatitude,
                ExifInterface.TagGpsLatitudeRef,
                ExifInterface.TagGpsLongitude,
                ExifInterface.TagGpsLongitudeRef,
                ExifInterface.TagGpsMapDatum,
                ExifInterface.TagGpsMeasureMode,
                ExifInterface.TagGpsProcessingMethod,
                ExifInterface.TagGpsSatellites,
                ExifInterface.TagGpsSpeed,
                ExifInterface.TagGpsSpeedRef,
                ExifInterface.TagGpsStatus,
                ExifInterface.TagGpsTimestamp,
                ExifInterface.TagGpsTrack,
                ExifInterface.TagGpsTrackRef,
                ExifInterface.TagGpsVersionId,
                ExifInterface.TagInteroperabilityIndex,
                ExifInterface.TagThumbnailImageLength,
                ExifInterface.TagThumbnailImageWidth,
                ExifInterface.TagDngVersion,
                ExifInterface.TagDefaultCropSize,
                ExifInterface.TagOrfThumbnailImage,
                ExifInterface.TagOrfPreviewImageStart,
                ExifInterface.TagOrfPreviewImageLength,
                ExifInterface.TagOrfAspectFrame,
            };
            foreach(var tagName in tagNames)
            {
                dest.SetAttribute(tagName, source.GetAttribute(tagName));
            }
        }
    }
}
