// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<144beb4b770282f0015bf14d86ffd1b8>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// An enum that represents the type of media content being shared, which can
    /// be useful for various purposes such as displaying the media content in a
    /// specific way or applying certain filters or effects to it. It can be used
    /// as a type of parameter in
    /// @internal_link(horizon.platform.media.Media#share_to_facebook(String,
    /// String, MediaContentType)).
    [Preserve]
    public enum MediaContentType : int
    {
        /// Represents that the MediaContentType is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        /// Indicates that the media content is a photo. This value can be used to
        /// specify that the media content being shared is a photo.
        [Description("PHOTO")]
        [Preserve]
        Photo,

        
    }

}
