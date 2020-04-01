// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> Defines a function that boosts scores based on distance from a geographic location. </summary>
    public partial class DistanceScoringFunction : ScoringFunction
    {
        /// <summary> Initializes a new instance of DistanceScoringFunction. </summary>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="parameters"> Parameter values for the distance scoring function. </param>
        public DistanceScoringFunction(string fieldName, double boost, DistanceScoringParameters parameters) : base(fieldName, boost)
        {
            if (fieldName == null)
            {
                throw new ArgumentNullException(nameof(fieldName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Type = "distance";
        }

        /// <summary> Initializes a new instance of DistanceScoringFunction. </summary>
        /// <param name="type"> Indicates the type of function to use. Valid values include magnitude, freshness, distance, and tag. The function type must be lower case. </param>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="interpolation"> A value indicating how boosting will be interpolated across document scores; defaults to &quot;Linear&quot;. </param>
        /// <param name="parameters"> Parameter values for the distance scoring function. </param>
        internal DistanceScoringFunction(string type, string fieldName, double boost, ScoringFunctionInterpolation? interpolation, DistanceScoringParameters parameters) : base(type, fieldName, boost, interpolation)
        {
            Parameters = parameters;
            Type = type ?? "distance";
        }

        /// <summary> Parameter values for the distance scoring function. </summary>
        public DistanceScoringParameters Parameters { get; }
    }
}