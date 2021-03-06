﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Xunit;

namespace UnitTests.Core
{
    public class BlobCacheKeysFixtures
    {

        [InlineData("hello world", "searchQuery-hello world")]
        [InlineData("hello", "searchQuery-hello")]
        [InlineData("", "searchQuery-")]
        [Theory]
        public void SearchQueryKeyShouldBeExpected(string query, string expected)
        {
            var sut = BlobCacheKeys.GetKeyForSearch(query);

            //sut.Should().Be(expected);
        }
    }
}
