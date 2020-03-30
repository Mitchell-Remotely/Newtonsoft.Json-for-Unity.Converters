﻿using System.Collections.Generic;
using UnityEngine;

namespace Newtonsoft.Json.UnityConverters.Tests.ConvertingUnityTypes
{
    public class BoundsTests : TypeTester<Bounds>
    {
        public static readonly IReadOnlyCollection<(Bounds deserialized, string serialized)> representations = new[] {
            (new Bounds(new Vector3(1, 2, 3), new Vector3(4, 5, 6)), @"{""xMin"":1,""yMin"":2,""zMin"":3,""sizeX"":4,""sizeY"":5,""sizeZ"":6}")
        };
    }

    public class BoundsIntTests : TypeTester<BoundsInt>
    {
        public static readonly IReadOnlyCollection<(BoundsInt deserialized, string serialized)> representations = new[] {
            (new BoundsInt(1, 2, 3, 4, 5, 6), @"{""xMin"":1,""yMin"":2,""zMin"":3,""sizeX"":4,""sizeY"":5,""sizeZ"":6}")
        };
    }
}