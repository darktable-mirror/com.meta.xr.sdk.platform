// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<86ac523089d2888f34bcc0e720df05c8>>
 */

using System;
using System.Collections;
using Oculus.Platform.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;
using UnityEngine.Scripting;

namespace Oculus.Platform
{
    /// FIXME: Add doc comment for this option!
    [Serializable]
    [Preserve]
    public class TestUnreleasedOptions {
        /// Tests that unreleased options objects do not appear in the public SDK
        [JsonProperty("test_property")]
        [Preserve]
        public uint TestProperty = 0;
        
        public string Json => JsonUtility.ToJson(this);

        [Preserve]
        public TestUnreleasedOptions()
        {
        }
        
        [Preserve]
        public void SetTestProperty(uint value)
        {
            TestProperty = value;
        }
        
        ~TestUnreleasedOptions()
        {
        }
    }
}
